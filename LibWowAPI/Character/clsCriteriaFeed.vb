' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a completed criteria of an achievement for the character feed.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a completed criteria of an achievement for the character feed.  Inherits from <see cref="FeedItem" />.</remarks>
    Public Class CriteriaFeed
        Inherits FeedItem

        ''' <summary>
        ''' The achievement in progress.
        ''' </summary>
        ''' <value>This property gets or sets the Achievement field.</value>
        ''' <returns>Returns the achievement in progress.</returns>
        ''' <remarks>This is a <see cref="FeedAchievement" /> object that represents the achievement in progress.</remarks>
        Public Property Achievement As FeedAchievement

        ''' <summary>
        ''' Determines whether the related achievement is a feat of strength.
        ''' </summary>
        ''' <value>This property gets or sets the FeatOfStrength field.</value>
        ''' <returns>Returns whether the related achievement is a feat of strength.</returns>
        ''' <remarks>This determines whether the related achievement is a feat of strength.</remarks>
        Public Property FeatOfStrength As Boolean

        ''' <summary>
        ''' The completed criteria.
        ''' </summary>
        ''' <value>This property gets or sets the Criteria field.</value>
        ''' <returns>Returns the completed criteria.</returns>
        ''' <remarks>This is a <see cref="FeedCriteria" /> object that represents the completed criteria.</remarks>
        Public Property Criteria As FeedCriteria

        Friend Sub New(dtDate As Date, aAchievement As FeedAchievement, blnFeatOfStrength As Boolean, cCriteria As FeedCriteria)
            [Date] = dtDate
            Achievement = aAchievement
            FeatOfStrength = blnFeatOfStrength
            Criteria = cCriteria
        End Sub

    End Class

End Namespace
