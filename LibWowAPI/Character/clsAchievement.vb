﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a completed achievement.
    ''' </summary>
    ''' <remarks>This class contains the achievement <see cref="Achievement.ID" /> number and the <see cref="Achievement.Timestamp" /> the achievement was completed.  Use the <see cref="Data.CharacterAchievements.CharacterAchievements" /> class to get more detailed information about the achievement.</remarks>
    Public Class Achievement

        ''' <summary>
        ''' The ID number of the achievement.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the achievement.</returns>
        ''' <remarks>This represents the achievement ID number which can be used with the <see cref="Data.CharacterAchievements.CharacterAchievements" /> class to get more information about the achievement.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The date the achievement was completed.
        ''' </summary>
        ''' <value>This property gets or sets the Timestamp field.</value>
        ''' <returns>Returns the date the achievement was completed.</returns>
        ''' <remarks>The date returned is the time in UTC that the achievement was fully completed.</remarks>
        Public Property Timestamp As Date

        Friend Sub New(intID As Integer, dtTimestamp As Date)
            ID = intID
            Timestamp = dtTimestamp
        End Sub

    End Class

End Namespace