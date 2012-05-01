' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Data.CharacterAchievements

    ''' <summary>
    ''' A class that retrieves character achievement information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve the list of possible character achievements from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of possible character achievements.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.CharacterAchievements;
    '''
    ''' namespace CharacterAchievementsExample {
    '''
    '''     public class CharacterAchievementsClass {
    '''
    '''         public Collection&lt;Category&gt; GetAchievementCategories() {
    '''             CharacterAchievements achievements = new CharacterAchievements();
    '''             achievements.Load();
    '''             return achievements.Categories;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.CharacterAchievements
    ''' 
    ''' Namespace CharacterAchievementsExample
    ''' 
    '''     Public Class CharacterAchievementsClass
    ''' 
    '''         Public Function GetAchievementCategories() As Collection(Of Category)
    '''             Dim achievements As New CharacterAchievements()
    '''             achievements.Load()
    '''             Return achievements.Categories
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class CharacterAchievements
        Inherits WowAPIData

        Private aAchievements As New Schema.achievements

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for character achievement information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for character achievement information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="CharacterAchievements.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.CharacterAchievements"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/api/wow/data/character/achievements", UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the character achievements.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Category)" /> of <see cref="Category" />.  Each item in the collection represents a category of achievements received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    aAchievements = CType(New DataContractJsonSerializer(GetType(Schema.achievements)).ReadObject(msJSON), Schema.achievements)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colCategories = (
                From c In aAchievements.achievements
                Select New Category(
                    c.id,
                    If(c.categories Is Nothing, Nothing,
                        (
                            From sc In c.categories
                            Select New Category(
                                sc.id,
                                Nothing,
                                sc.name,
                                (
                                    From a In sc.achievements
                                    Select New Achievement(
                                        a.id,
                                        a.title,
                                        a.points,
                                        a.description,
                                        a.reward,
                                        If(a.rewardItem Is Nothing, Nothing,
                                            New RewardItem(
                                                a.rewardItem.id,
                                                a.rewardItem.name,
                                                a.rewardItem.icon,
                                                CType(a.rewardItem.quality, Quality)
                                                )
                                            ),
                                        a.icon,
                                        If(a.criteria Is Nothing, Nothing,
                                            (
                                                From cr In a.criteria
                                                Select New Criteria(
                                                    cr.id,
                                                    cr.description
                                                   )
                                               ).ToCollection()
                                           )
                                        )
                                    ).ToCollection()
                                )
                            ).ToCollection()
                        ),
                    c.name,
                    (
                        From a In c.achievements
                        Select New Achievement(
                            a.id,
                            a.title,
                            a.points,
                            a.description,
                            a.reward,
                            If(a.rewardItem Is Nothing, Nothing,
                                New RewardItem(
                                    a.rewardItem.id,
                                    a.rewardItem.name,
                                    a.rewardItem.icon,
                                    CType(a.rewardItem.quality, Quality)
                                    )
                                ),
                            a.icon,
                            If(a.criteria Is Nothing, Nothing,
                                (
                                    From cr In a.criteria
                                    Select New Criteria(
                                        cr.id,
                                        cr.description
                                        )
                                    ).ToCollection()
                                )
                            )
                        ).ToCollection()
                    )
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colCategories As Collection(Of Category)
        ''' <summary>
        ''' A list of achievements, grouped by categories, as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Categories field.</value>
        ''' <returns>Returns a list of achievements, grouped by categories, as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Category)" /> of <see cref="Category" />, which is a list of all current achievement categories, each of which contain achievements.</remarks>
        Public ReadOnly Property Categories As Collection(Of Category)
            Get
                Return colCategories
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve character achievement information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="CharacterAchievements" /> class.  You must call the <see cref="CharacterAchievements.Load" /> method to load the achievements.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
