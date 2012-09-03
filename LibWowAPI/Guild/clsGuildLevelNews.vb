' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a guild leveling up for the guild news.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a guild leveling up for the guild news.  Inherits from <see cref="NewsItem" />.</remarks>
    Public Class GuildLevelNews
        Inherits NewsItem

        ''' <summary>
        ''' The new level of the guild.
        ''' </summary>
        ''' <value>This property gets or sets the LevelUp field.</value>
        ''' <returns>Returns the new level of the guild.</returns>
        ''' <remarks>This represents the new level of the guild.</remarks>
        Public Property LevelUp As Integer

        Friend Sub New(dtDate As Date, intLevelUp As Integer)
            [Date] = dtDate
            LevelUp = intLevelUp
        End Sub

    End Class

End Namespace
