' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about completed guild achievements and criteria.
    ''' </summary>
    ''' <remarks>Guild achievements are collections of tasks that guilds must complete for guild achievement points or other rewards.  Criteria represent the individual tasks.  Currently, there is no way to tell what criteria are required for a guild achievement.</remarks>
    Public Class Achievements

        Private colAchievements As Collection(Of CompletedAchievement)
        ''' <summary>
        ''' A list of completed guild achievements.
        ''' </summary>
        ''' <value>This property gets the Achievements field.</value>
        ''' <returns>Returns a list of completed guild achievements.</returns>
        ''' <remarks>This <see cref="Collection(Of CompletedAchievement)" /> of <see cref="CompletedAchievement" /> represents all of the guild achievements the guild has completed.</remarks>
        Public ReadOnly Property Achievements As Collection(Of CompletedAchievement)
            Get
                Return colAchievements
            End Get
        End Property

        Private colCriteria As Collection(Of CompletedCriteria)
        ''' <summary>
        ''' A list of completed guild achievement criteria.
        ''' </summary>
        ''' <value>This property gets the Criteria field.</value>
        ''' <returns>Returns a list of completed guild achievement criteria.</returns>
        ''' <remarks>This <see cref="Collection(Of CompletedCriteria)" /> of <see cref="CompletedCriteria" /> represents all of the guild achievement criteria the guild has completed.</remarks>
        Public ReadOnly Property Criteria As Collection(Of CompletedCriteria)
            Get
                Return colCriteria
            End Get
        End Property

        Friend Sub New(caAchievements As Collection(Of CompletedAchievement), ccCriteria As Collection(Of CompletedCriteria))
            colAchievements = caAchievements
            colCriteria = ccCriteria
        End Sub

    End Class

End Namespace
