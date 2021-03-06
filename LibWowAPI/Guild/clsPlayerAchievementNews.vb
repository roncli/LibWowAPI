﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a completed player achievement for the guild news.
    ''' </summary>
    ''' <remarks>This class provides detailed information about a completed player achievement for the guild news.  Inherits from <see cref="NewsItem" />.</remarks>
    Public Class PlayerAchievementNews
        Inherits NewsItem

        ''' <summary>
        ''' The name of the guild member obtaining the player achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Character field.</value>
        ''' <returns>Returns the name of the guild member obtaining the player achievement.</returns>
        ''' <remarks>This represents the name of the guild member obtaining the player achievement.</remarks>
        Public Property Character As String

        ''' <summary>
        ''' The completed player achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Achievement field.</value>
        ''' <returns>Returns the completed player achievement.</returns>
        ''' <remarks>This is a <see cref="NewsAchievement" /> object that represents the completed player achievement.</remarks>
        Public Property Achievement As NewsAchievement

        Friend Sub New(dtDate As Date, strCharacter As String, aAchievement As NewsAchievement)
            [Date] = dtDate
            Character = strCharacter
            Achievement = aAchievement
        End Sub

    End Class

End Namespace
