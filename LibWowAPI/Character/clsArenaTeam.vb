' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about one of the character's arena teams.
    ''' </summary>
    ''' <remarks>Characters belonging to arena teams can have information about their teams provided by the API.</remarks>
    Public Class ArenaTeam

        ''' <summary>
        ''' The name of the team.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the team.</returns>
        ''' <remarks>Characters can choose the name of their arena team.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The character's personal rating within the team.
        ''' </summary>
        ''' <value>This property gets or sets the PersonalRating field.</value>
        ''' <returns>Returns the character's personal rating within the team.</returns>
        ''' <remarks>To determine a character's performance within the arena team, the characters are given a personal rating.</remarks>
        Public Property PersonalRating As Integer

        ''' <summary>
        ''' The team's rating.
        ''' </summary>
        ''' <value>This property gets or sets the TeamRating field.</value>
        ''' <returns>Returns the team's rating.</returns>
        ''' <remarks>A team rating is used to determine performance compared to other teams.</remarks>
        Public Property TeamRating As Integer

        ''' <summary>
        ''' The size of the team.
        ''' </summary>
        ''' <value>This property gets or sets the Size field.</value>
        ''' <returns>Returns the size of the team.</returns>
        ''' <remarks>Arena teams can consist of 2, 3, or 5 players.</remarks>
        Public Property Size As Integer

        Friend Sub New(strName As String, intPersonalRating As Integer, intTeamRating As Integer, intSize As Integer)
            Name = strName
            PersonalRating = intPersonalRating
            TeamRating = intTeamRating
            Size = intSize
        End Sub

    End Class

End Namespace
