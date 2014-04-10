' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Achievements

    ''' <summary>
    ''' A class that looks up achievement information for a single achievement from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve information for a single achievement from the API.  This works for both character achievements and guild achievements, since their achievement IDs are unique.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve an achievement.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Achievements;
    '''
    ''' namespace AchievementExample {
    '''
    '''     public class AchievementClass {
    '''
    '''         public Achievement GetAchievement(int achievementID) {
    '''             AchievementLookup achievement = new AchievementLookup();
    '''             achievement.Options.AchievementID = achievementID;
    '''             achievement.Load();
    '''             return achievement.Achievement;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Achievements
    ''' 
    ''' Namespace AchievementExample
    ''' 
    '''     Public Class AchievementClass
    ''' 
    '''         Public Function GetAchievement(achievementID As Integer) As Achievement
    '''             Dim achievement As New AchievementLookup()
    '''             achievement.Options.AchievementID = achievementID
    '''             achievement.Load()
    '''             Return achievement.Achievement
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class AchievementLookup
        Inherits WowAPIData

        Private alAchievement As New Schema.achievement

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for achievement information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for achievement information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="AchievementLookup.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.Achievement.{0}", Options.AchievementID)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/achievement/{0}", Options.AchievementID), UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the achievement.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into an <see cref="Achievement" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    alAchievement = CType(New DataContractJsonSerializer(GetType(Schema.achievement)).ReadObject(msJSON), Schema.achievement)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            aAchievement = New Achievement(
                alAchievement.id,
                alAchievement.title,
                alAchievement.points,
                alAchievement.description,
                alAchievement.reward,
                If(
                    alAchievement.rewardItems Is Nothing, Nothing, (
                        From ri In alAchievement.rewardItems
                        Select New RewardItem(
                            ri.id,
                            ri.name,
                            ri.icon,
                            CType(ri.quality, Quality),
                            ri.itemLevel,
                            ri.armor
                            )
                        ).ToCollection()
                    ),
                alAchievement.icon,
                If(
                    alAchievement.criteria Is Nothing, Nothing, (
                        From cr In alAchievement.criteria
                        Order By cr.orderIndex
                        Select New Criteria(
                            cr.id,
                            cr.description,
                            cr.orderIndex,
                            cr.max
                            )
                        ).ToCollection()
                    ),
                alAchievement.accountWide,
                CType(alAchievement.factionId, Side)
                )
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up an achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up an achievement.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New AchievementLookupOptions

        Private aAchievement As Achievement
        ''' <summary>
        ''' The achievement returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Achievement field.</value>
        ''' <returns>Returns achievement information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is an <see cref="Achievement" /> object that contains information about the achievement specified in the <see cref="AchievementLookup.Options" />.</remarks>
        Public ReadOnly Property Achievement As Achievement
            Get
                Return aAchievement
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve information for a single achievement from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="AchievementLookup" /> class.  You must call the <see cref="AchievementLookup.Load" /> method to load an achievement.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve information for a single achievement from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="intAchievementID">The achievement ID to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="AchievementLookup" /> class and automatically loads the data for the specified achievement ID.</remarks>
        Public Sub New(intAchievementID As Integer)
            Options.AchievementID = intAchievementID
            Load()
        End Sub

#End Region

    End Class

End Namespace
