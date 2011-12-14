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
    ''' A class that retrieves arena ladder information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides the list of top teams on a battlegroup's arena ladder.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve an arena ladder.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.PvP;
    ''' 
    ''' namespace ArenaLadderExample {
    '''
    '''     public class ArenaLadderClass {
    ''' 
    '''         public Collection(Of Team) GetTeams(string battlegroup, int size, int teams) {
    '''             ArenaLadder ladder = new ArenaLadder();
    '''             ladder.Options.Battlegroup = battlegroup;
    '''             ladder.Options.TeamSize = size;
    '''             ladder.Options.Teams = teams;
    '''             ladder.Load();
    '''             return ladder.Teams;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.PvP
    ''' 
    ''' Namespace ArenaLadderExample
    ''' 
    '''     Public Class ArenaLadderClass
    ''' 
    '''         Public Function GetTeams(battlegroup As String, size As Integer, teams as Integer) As Collection(Of Team)
    '''             Dim ladder As New ArenaLadder()
    '''             ladder.Options.Battlegroup = battlegroup
    '''             ladder.Options.TeamSize = size
    '''             ladder.Options.Teams = teams
    '''             ladder.Load()
    '''             Return ladder.Teams
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class ArenaLadder
        Inherits WowAPIData

        Private lLadder As New Schema.ladder

#Region "WowAPIData Overrides"

#Region "Properties"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                QueryString.Clear()
                If Options.Teams > 0 Then
                    QueryString.Add("size", Options.Teams.ToString(CultureInfo.InvariantCulture))
                End If
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/pvp/arena/{0}/{1}v{1}", Options.Battlegroup, Options.TeamSize), UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.ArenaLadder.{0}.{1}.{2}", Options.Battlegroup, Options.TeamSize, Options.Teams)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the arena ladder.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Team)" /> of <see cref="Team" />.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    lLadder = CType(New DataContractJsonSerializer(GetType(Schema.ladder)).ReadObject(msJSON), Schema.ladder)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colTeams = (
                From t In lLadder.arenateam
                Select New Team(
                    t.realm,
                    t.ranking,
                    t.rating,
                    t.teamsize,
                    Date.Parse(t.created, CultureInfo.InvariantCulture),
                    t.name,
                    t.gamesPlayed,
                    t.gamesWon,
                    t.gamesLost,
                    t.sessionGamesPlayed,
                    t.sessionGamesWon,
                    t.sessionGamesLost,
                    t.lastSessionRanking,
                    t.side.GetSide(),
                    t.currentWeekRanking,
                    (From m In t.members
                     Select New Member(
                         New Character(
                             m.character.name,
                             m.character.realm,
                             m.character.class.GetClass(),
                             m.character.race.GetRace(),
                             CType(m.character.gender, Gender),
                             m.character.level,
                             m.character.achievementPoints,
                             m.character.thumbnail
                             ),
                         m.rank,
                         m.gamesPlayed,
                         m.gamesWon,
                         m.gamesLost,
                         m.sessionGamesPlayed,
                         m.sessionGamesWon,
                         m.sessionGamesLost,
                         m.personalRating
                         )
                     ).ToCollection()
                 )
             ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up arena ladder information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up arena ladder information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New ArenaLadderOptions

        Private colTeams As Collection(Of Team)
        ''' <summary>
        ''' Arena ladder information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Teams field.</value>
        ''' <returns>Returns arena ladder information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Team)" /> of <see cref="Team" /> that represents the list of top arena teams for the battlegroup specified in the <see cref="ArenaLadder.Options" />.</remarks>
        Public ReadOnly Property Teams As Collection(Of Team)
            Get
                Return colTeams
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve arena ladder information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="ArenaLadder" /> class.  You must set the <see cref="ArenaLadderOptions.Battlegroup" /> and <see cref="ArenaLadderOptions.TeamSize" /> properties of the <see cref="ArenaLadder.Options" /> property and then call the <see cref="ArenaLadder.Load" /> method to load the arena teams.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve an arena ladder.
        ''' </summary>
        ''' <param name="strBattlegroup">The battlegroup to lookup the arena ladder for.</param>
        ''' <param name="intTeamSize">This size of the teams to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="ArenaLadder" /> class and automatically loads the data for the specified battlegroup and team size.</remarks>
        Public Sub New(strBattlegroup As String, intTeamSize As Integer)
            Options.Battlegroup = strBattlegroup
            Options.TeamSize = intTeamSize
            Load()
        End Sub

#End Region

    End Class

End Namespace
