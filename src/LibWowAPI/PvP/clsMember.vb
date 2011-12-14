' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class containing information about a member of an arena team.
    ''' </summary>
    ''' <remarks>This class contains detailed information about an arena team member.</remarks>
    Public Class Member

        ''' <summary>
        ''' Information about the character.
        ''' </summary>
        ''' <value>This property gets or sets the Character field.</value>
        ''' <returns>Returns information about the character.</returns>
        ''' <remarks>This is a <see cref="Character" /> object that contains further information about the guild member.</remarks>
        Public Property Character As Character

        ''' <summary>
        ''' The rank of the member within the team.
        ''' </summary>
        ''' <value>This property gets or sets the Rank field.</value>
        ''' <returns>Returns the rank of the member within the team.</returns>
        ''' <remarks>This is a 1 if they own the team.</remarks>
        Public Property Rank As Integer

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
        ''' The member's personal team rating.
        ''' </summary>
        ''' <value>This property gets or sets the PersonalRating field.</value>
        ''' <returns>Returns the member's personal team rating.</returns>
        ''' <remarks>This represents the member's personal team rating.</remarks>
        Public Property PersonalRating As Integer

        Friend Sub New(cCharacter As Character, intRank As Integer, intGamesPlayed As Integer, intGamesWon As Integer, intGamesLost As Integer, intSessionGamesPlayed As Integer, intSessionGamesWon As Integer, intSessionGamesLost As Integer, intPersonalRating As Integer)
            Character = cCharacter
            Rank = intRank
            GamesPlayed = intGamesPlayed
            GamesWon = intGamesWon
            GamesLost = intGamesLost
            SessionGamesPlayed = intSessionGamesPlayed
            SessionGamesWon = intSessionGamesWon
            SessionGamesLost = intSessionGamesLost
            PersonalRating = intPersonalRating
        End Sub

    End Class

End Namespace
