' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about completed achievements and criteria.
    ''' </summary>
    ''' <remarks>Achievements are collections of tasks that characters must complete for achievement points or other rewards.  Criteria represent the individual tasks.  Currently, there is no way to tell what criteria are required for an achievement.</remarks>
    Public Class Achievements

        Private colAchievements As Collection(Of Achievement)
        ''' <summary>
        ''' A list of completed achievements.
        ''' </summary>
        ''' <value>This property gets the Achievements field.</value>
        ''' <returns>Returns a list of completed achievements.</returns>
        ''' <remarks>This <see cref="Collection(Of Achievement)" /> of <see cref="Achievement" /> represents all of the achievements the character has completed.</remarks>
        Public ReadOnly Property Achievements As Collection(Of Achievement)
            Get
                Return colAchievements
            End Get
        End Property

        Private colCriteria As Collection(Of Criteria)
        ''' <summary>
        ''' A list of completed achievement criteria.
        ''' </summary>
        ''' <value>This property gets the Criteria field.</value>
        ''' <returns>Returns a list of completed achievement criteria.</returns>
        ''' <remarks>This <see cref="Collection(Of Criteria)" /> of <see cref="Criteria" /> represents all of the achievement criteria the character has completed.</remarks>
        Public ReadOnly Property Criteria As Collection(Of Criteria)
            Get
                Return colCriteria
            End Get
        End Property

        Friend Sub New(aAchievements As Collection(Of Achievement), cCriteria As Collection(Of Criteria))
            colAchievements = aAchievements
            colCriteria = cCriteria
        End Sub

    End Class

End Namespace
