' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class that retrieves rated battleground ladder information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides the list of top characters on a region's rated battleground ladder.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve a rated battleground ladder.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.PvP;
    ''' 
    ''' namespace RatedBattlegroundLadderExample {
    '''
    '''     public class RatedBattlegroundLadderClass {
    ''' 
    '''         public Collection&lt;BattlegroundRecord&gt; GetLadder() {
    '''             RatedBattlegroundLadder ladder = new RatedBattlegroundLadder();
    '''             ladder.Load();
    '''             return ladder.Characters;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.PvP
    ''' 
    ''' Namespace RatedBattlegroundLadderExample
    ''' 
    '''     Public Class RatedBattlegroundLadderClass
    ''' 
    '''         Public Function GetLadder() As Collection(Of BattlegroundRecord)
    '''             Dim ladder As New RatedBattlegroundLadder()
    '''             ladder.Load()
    '''             Return ladder.Characters;
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class RatedBattlegroundLadder
        Inherits WowAPIData

        Private rblLadder As New Schema.ratedBattlegroundLadder

#Region "WowAPIData Overrides"

#Region "Properties"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                QueryString.Clear()
                If Options.Characters > 0 Then
                    QueryString.Add("size", Options.Characters.ToString(CultureInfo.InvariantCulture))
                End If
                If Options.Page > 0 Then
                    QueryString.Add("page", Options.Page.ToString(CultureInfo.InvariantCulture))
                End If
                If Options.Ascending.HasValue Then
                    QueryString.Add("asc", If(Options.Ascending.Value, "true", "false"))
                End If
                Return New Uri("/api/wow/pvp/ratedbg/ladder", UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.RatedBattlegroundLadder.{0}.{1}.{2}", Options.Characters, Options.Page, If(Options.Ascending.HasValue, Options.Ascending.Value, True))
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the rated battleground ladder.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of BattlegroundRecord)" /> of <see cref="BattlegroundRecord" />.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    rblLadder = CType(New DataContractJsonSerializer(GetType(Schema.ratedBattlegroundLadder)).ReadObject(msJSON), Schema.ratedBattlegroundLadder)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colCharacters = (
                From r In rblLadder.bgRecord
                Select New BattlegroundRecord(
                    r.rank,
                    r.bgRating,
                    r.wins,
                    r.losses,
                    r.played,
                    New Realm(
                        r.realm.name,
                        r.realm.slug,
                        r.realm.battlegroup,
                        r.realm.locale
                        ),
                    New Battlegroup(
                        r.battlegroup.name,
                        r.battlegroup.slug),
                    New Character(
                        r.character.name,
                        r.character.realm,
                        r.character.battlegroup,
                        r.character.class.GetClass(),
                        r.character.race.GetRace(),
                        CType(r.character.gender, Gender),
                        r.character.level,
                        r.character.achievementPoints,
                        r.character.thumbnail,
                        If(
                            r.character.spec Is Nothing, Nothing, (
                                New Spec(
                                    r.character.spec.name,
                                    r.character.spec.role,
                                    r.character.spec.backgroundImage,
                                    r.character.spec.icon,
                                    r.character.spec.description,
                                    r.character.spec.order
                                    )
                                )
                            )
                        ),
                    r.lastModified.BlizzardTimestampToUTC()
                    )
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up rated battleground ladder information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up rated battleground ladder information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New RatedBattlegroundLadderOptions

        Private colCharacters As Collection(Of BattlegroundRecord)
        ''' <summary>
        ''' Rated battleground ladder information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Characters field.</value>
        ''' <returns>Returns rated battleground ladder information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of BattlegroundRecord)" /> of <see cref="BattlegroundRecord" /> that represents the list of top characters for the region.</remarks>
        Public ReadOnly Property Characters As Collection(Of BattlegroundRecord)
            Get
                Return colCharacters
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve rated battleground ladder information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="RatedBattlegroundLadder" /> class.  You must call the <see cref="RatedBattlegroundLadder.Load" /> method to load the characters.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
