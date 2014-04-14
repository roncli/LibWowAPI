' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about one of a character's arena brackets.
    ''' </summary>
    ''' <remarks>PvP statistics include rating, wins, losses, and number of matches played.</remarks>
    Public Class ArenaBracket

        ''' <summary>
        ''' Blizzard's internal name for the bracket.
        ''' </summary>
        ''' <value>This property gets or sets the Slug field.</value>
        ''' <returns>Returns Blizzard's internal name for the bracket.</returns>
        ''' <remarks>This represents Blizzard's internal name for the bracket.</remarks>
        Public Property Slug As String

        ''' <summary>
        ''' The character's rating for the bracket.
        ''' </summary>
        ''' <value>This property gets or sets the Rating field.</value>
        ''' <returns>Returns the character's rating for the bracket.</returns>
        ''' <remarks>This represents the character's rating for the bracket.</remarks>
        Public Property Rating As Integer

        ''' <summary>
        ''' The number of matches the character has played this week.
        ''' </summary>
        ''' <value>This property gets or sets the WeeklyPlayed field.</value>
        ''' <returns>Returns the number of matches the character has played this week.</returns>
        ''' <remarks>This represents the number of matches the character has played this week.</remarks>
        Public Property WeeklyPlayed As Integer

        ''' <summary>
        ''' The number of matches the character has won this week.
        ''' </summary>
        ''' <value>This property gets or sets the WeeklyWon field.</value>
        ''' <returns>Returns the number of matches the character has won this week.</returns>
        ''' <remarks>This represents the number of matches the character has won this week.</remarks>
        Public Property WeeklyWon As Integer

        ''' <summary>
        ''' The number of matches the character has lost this week.
        ''' </summary>
        ''' <value>This property gets or sets the WeeklyLost field.</value>
        ''' <returns>Returns the number of matches the character has lost this week.</returns>
        ''' <remarks>This represents the number of matches the character has lost this week.</remarks>
        Public Property WeeklyLost As Integer

        ''' <summary>
        ''' The number of matches the character has played this season.
        ''' </summary>
        ''' <value>This property gets or sets the SeasonPlayed field.</value>
        ''' <returns>Returns the number of matches the character has played this season.</returns>
        ''' <remarks>This represents the number of matches the character has played this season.</remarks>
        Public Property SeasonPlayed As Integer

        ''' <summary>
        ''' The number of matches the character has won this season.
        ''' </summary>
        ''' <value>This property gets or sets the SeasonWon field.</value>
        ''' <returns>Returns the number of matches the character has won this season.</returns>
        ''' <remarks>This represents the number of matches the character has won this season.</remarks>
        Public Property SeasonWon As Integer

        ''' <summary>
        ''' The number of matches the character has lost this season.
        ''' </summary>
        ''' <value>This property gets or sets the SeasonLost field.</value>
        ''' <returns>Returns the number of matches the character has lost this season.</returns>
        ''' <remarks>This represents the number of matches the character has lost this season.</remarks>
        Public Property SeasonLost As Integer

        Friend Sub New(strSlug As String, intRating As Integer, intWeeklyPlayed As Integer, intWeeklyWon As Integer, intWeeklyLost As Integer, intSeasonPlayed As Integer, intSeasonWon As Integer, intSeasonLost As Integer)
            Slug = strSlug
            Rating = intRating
            WeeklyPlayed = intWeeklyPlayed
            WeeklyWon = intWeeklyWon
            WeeklyLost = intWeeklyLost
            SeasonPlayed = intSeasonPlayed
            SeasonWon = intSeasonWon
            SeasonLost = intSeasonLost
        End Sub

    End Class

End Namespace
