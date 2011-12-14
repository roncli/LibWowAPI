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

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class that retrieves arena team information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about an arena team.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve an arena team.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.PvP;
    ''' 
    ''' namespace ArenaTeamExample {
    '''
    '''     public class ArenaTeamClass {
    ''' 
    '''         public Team GetTeam(string realm, int size, string name) {
    '''             ArenaTeam team = new ArenaTeam();
    '''             team.Options.Realm = realm;
    '''             team.Options.TeamSize = size;
    '''             team.Options.Name = name;
    '''             team.Load();
    '''             return team.Team;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.PvP
    ''' 
    ''' Namespace ArenaTeamExample
    ''' 
    '''     Public Class ArenaTeamClass
    ''' 
    '''         Public Function GetTeam(realm As String, size As Integer, name as String) As Team
    '''             Dim team As New ArenaLadder()
    '''             team.Options.Realm = realm
    '''             team.Options.TeamSize = size
    '''             team.Options.Name = name
    '''             team.Load()
    '''             Return team.Team
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class ArenaTeam
        Inherits WowAPIData

        Private atTeam As New Schema.arenateam

#Region "WowAPIData Overrides"

#Region "Properties"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/arena/{0}/{1}v{1}/{2}", Options.Realm, Options.TeamSize, Options.Name), UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.ArenaTeam.{0}.{1}.{2}", Options.Realm, Options.TeamSize, Options.Name)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the arena team.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Team" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    atTeam = CType(New DataContractJsonSerializer(GetType(Schema.arenateam)).ReadObject(msJSON), Schema.arenateam)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            tTeam = New Team(
                atTeam.realm,
                atTeam.ranking,
                atTeam.rating,
                atTeam.teamsize,
                Date.Parse(atTeam.created, CultureInfo.InvariantCulture),
                atTeam.name,
                atTeam.gamesPlayed,
                atTeam.gamesWon,
                atTeam.gamesLost,
                atTeam.sessionGamesPlayed,
                atTeam.sessionGamesWon,
                atTeam.sessionGamesLost,
                atTeam.lastSessionRanking,
                atTeam.side.GetSide(),
                atTeam.currentWeekRanking,
                If(atTeam.members Is Nothing, Nothing, (
                   From m In atTeam.members
                   Select New Member(
                       If(m.character Is Nothing, Nothing,
                           New Character(
                               m.character.name,
                               m.character.realm,
                               m.character.class.GetClass(),
                               m.character.race.GetRace(),
                               CType(m.character.gender, Gender),
                               m.character.level,
                               m.character.achievementPoints,
                               m.character.thumbnail
                               )
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
           )
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up arena team information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up arena team information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New ArenaTeamOptions

        Private tTeam As Team
        ''' <summary>
        ''' Arena team information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets or sets the Team field.</value>
        ''' <returns>Returns arena team information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Team" /> object that represents the team specified in the <see cref="ArenaTeam.Options" />.</remarks>
        Public ReadOnly Property Team As Team
            Get
                Return tTeam
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve arena team information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="ArenaTeam" /> class.  You must set the <see cref="ArenaTeamOptions.Realm" />, <see cref="ArenaTeamOptions.TeamSize" />, and <see cref="ArenaTeamOptions.Name" /> properties of the <see cref="ArenaTeam.Options" /> property and then call the <see cref="ArenaTeam.Load" /> method to load the arena team.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve an arena team.
        ''' </summary>
        ''' <param name="strRealm">The realm of the team to lookup.</param>
        ''' <param name="intTeamSize">The size of the team to lookup.</param>
        ''' <param name="strName">The name of the team to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="ArenaTeam" /> class and automatically loads the data for the specified realm, team size, and name.</remarks>
        Public Sub New(strRealm As String, intTeamSize As Integer, strName As String)
            Options.Realm = strRealm
            Options.TeamSize = intTeamSize
            Options.Name = strName
            Load()
        End Sub

#End Region

    End Class

End Namespace
