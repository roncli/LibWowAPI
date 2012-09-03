' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a completed achievement for the character feed.
    ''' </summary>
    ''' <remarks>This class provides detailed information about a completed achievement for the character feed.  Inherits from <see cref="FeedItem" />.</remarks>
    Public Class AchievementFeed
        Inherits FeedItem

        ''' <summary>
        ''' The completed achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Achievement field.</value>
        ''' <returns>Returns the completed achievement.</returns>
        ''' <remarks>This is a <see cref="FeedAchievement" /> object that represents the completed achievement.</remarks>
        Public Property Achievement As FeedAchievement

        ''' <summary>
        ''' Determines whether the related achievement is a feat of strength.
        ''' </summary>
        ''' <value>This property gets or sets the FeatOfStrength field.</value>
        ''' <returns>Returns whether the related achievement is a feat of strength.</returns>
        ''' <remarks>This determines whether the related achievement is a feat of strength.</remarks>
        Public Property FeatOfStrength As Boolean

        Friend Sub New(dtDate As Date, aAchievement As FeedAchievement, blnFeatOfStrength As Boolean)
            [Date] = dtDate
            Achievement = aAchievement
            FeatOfStrength = blnFeatOfStrength
        End Sub

    End Class

End Namespace
