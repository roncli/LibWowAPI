' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class containing information about an arena team.
    ''' </summary>
    ''' <remarks>This class contains detailed information about an arena team.</remarks>
    Public Class Team

        ''' <summary>
        ''' The realm the team plays on.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm the team plays on.</returns>
        ''' <remarks>This represents the realm the team plays on.</remarks>
        Public Property Realm As String

        ''' <summary>
        ''' The team's ranking.
        ''' </summary>
        ''' <value>This property gets or sets the Ranking field.</value>
        ''' <returns>Returns the team's ranking.</returns>
        ''' <remarks>A 0 indicates that the team is unranked.  Only the top 2000 teams per battlegroup are ranked.</remarks>
        Public Property Ranking As Integer

        ''' <summary>
        ''' The team's rating.
        ''' </summary>
        ''' <value>This property gets or sets the Rating field.</value>
        ''' <returns>Returns the team's rating.</returns>
        ''' <remarks>This represents the team's rating.</remarks>
        Public Property Rating As Integer

        ''' <summary>
        ''' The team size.
        ''' </summary>
        ''' <value>This property gets or sets the TeamSize field.</value>
        ''' <returns>Returns the team size.</returns>
        ''' <remarks>This represents the team size.</remarks>
        Public Property TeamSize As Integer

        ''' <summary>
        ''' The date the team was created.
        ''' </summary>
        ''' <value>This property gets or sets the Created field.</value>
        ''' <returns>Returns the date the team was created.</returns>
        ''' <remarks>This represents the date the team was created.</remarks>
        Public Property Created As Date

        ''' <summary>
        ''' The name of the team.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the team.</returns>
        ''' <remarks>This represents the name of the team.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The number of games played this week.
        ''' </summary>
        ''' <value>This property gets or sets the GamesPlayed field.</value>
        ''' <returns>Returns the number of games played this week.</returns>
        ''' <remarks>This represents the number of games played this week.</remarks>
        Public Property GamesPlayed As Integer

        ''' <summary>
        ''' The number of games won this week.
        ''' </summary>
        ''' <value>This property gets or sets the GamesWon field.</value>
        ''' <returns>Returns the number of games won this week.</returns>
        ''' <remarks>This represents the number of games won this week.</remarks>
        Public Property GamesWon As Integer

        ''' <summary>
        ''' The number of games lost this week.
        ''' </summary>
        ''' <value>This property gets or sets the GamesLost field.</value>
        ''' <returns>Returns the number of games lost this week.</returns>
        ''' <remarks>This represents the number of games lost this week.</remarks>
        Public Property GamesLost As Integer

        ''' <summary>
        ''' The number of games played this season.
        ''' </summary>
        ''' <value>This property gets or sets the SessionGamesPlayed field.</value>
        ''' <returns>Returns the number of games played this season.</returns>
        ''' <remarks>This represents the number of games played this season.</remarks>
        Public Property SessionGamesPlayed As Integer

        ''' <summary>
        ''' The number of games won this season.
        ''' </summary>
        ''' <value>This property gets or sets the SessionGamesWon field.</value>
        ''' <returns>Returns the number of games won this season.</returns>
        ''' <remarks>This represents the number of games won this season.</remarks>
        Public Property SessionGamesWon As Integer

        ''' <summary>
        ''' The number of games lost this season.
        ''' </summary>
        ''' <value>This property gets or sets the SessionGamesLost field.</value>
        ''' <returns>Returns the number of games lost this season.</returns>
        ''' <remarks>This represents the number of games lost this season.</remarks>
        Public Property SessionGamesLost As Integer

        ''' <summary>
        ''' The team's ranking last season.
        ''' </summary>
        ''' <value>This property gets or sets the LastSessionRanking field.</value>
        ''' <returns>Returns the team's ranking last season.</returns>
        ''' <remarks>This represents the team's ranking last season.  Only the top 2000 teams per battlegroup are ranked.</remarks>
        Public Property LastSessionRanking As Integer

        ''' <summary>
        ''' The side the team is on.
        ''' </summary>
        ''' <value>This property gets or sets the Side field.</value>
        ''' <returns>Returns the side the team is on.</returns>
        ''' <remarks>This is a <see cref="Enums.Side" /> enumeration that tells what side the team is on.</remarks>
        Public Property Side As Side

        ''' <summary>
        ''' The team's ranking as of the previous Tuesday.
        ''' </summary>
        ''' <value>This property gets or sets the CurrentWeekRanking field.</value>
        ''' <returns>Returns the team's ranking as of the previous Tuesday.</returns>
        ''' <remarks>This represents the team's ranking as of the previous Tuesday.  Only the top 2000 teams per battlegroup are ranked.</remarks>
        Public Property CurrentWeekRanking As Integer

        Private colMembers As Collection(Of Member)
        ''' <summary>
        ''' A list of members on the team.
        ''' </summary>
        ''' <value>This property gets the Members field.</value>
        ''' <returns>Returns a list of members on the team.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Member)" /> of <see cref="Member" /> that is a list of all of the members on the team.</remarks>
        Public ReadOnly Property Members As Collection(Of Member)
            Get
                Return colMembers
            End Get
        End Property

        Friend Sub New(strRealm As String, intRanking As Integer, intRating As Integer, intTeamSize As Integer, dtCreated As Date, strName As String, intGamesPlayed As Integer, intGamesWon As Integer, intGamesLost As Integer, intSessionGamesPlayed As Integer, intSessionGamesWon As Integer, intSessionGamesLost As Integer, intLastSessionRanking As Integer, sSide As Side, intCurrentWeekRanking As Integer, mMembers As Collection(Of Member))
            Realm = strRealm
            Ranking = intRanking
            Rating = intRating
            TeamSize = intTeamSize
            Created = dtCreated
            Name = strName
            GamesPlayed = intGamesPlayed
            GamesWon = intGamesWon
            GamesLost = intGamesLost
            SessionGamesPlayed = intSessionGamesPlayed
            SessionGamesWon = intSessionGamesWon
            SessionGamesLost = intSessionGamesLost
            LastSessionRanking = intLastSessionRanking
            Side = sSide
            CurrentWeekRanking = intCurrentWeekRanking
            colMembers = mMembers
        End Sub

    End Class

End Namespace
