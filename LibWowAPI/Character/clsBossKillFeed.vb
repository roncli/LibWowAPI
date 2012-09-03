' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a boss kill for the character feed.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a boss kill for the character feed.  Inherits from <see cref="FeedItem" />.</remarks>
    Public Class BossKillFeed
        Inherits FeedItem

        ''' <summary>
        ''' The achievement used to track the boss kill.
        ''' </summary>
        ''' <value>This property gets or sets the Achievement field.</value>
        ''' <returns>Returns the achievement used to track the boss kill.</returns>
        ''' <remarks>This is a <see cref="FeedAchievement" /> object that represents the achievement used to track the boss kill.  This is actually the achievement for the statistic that is incremented once the boss is killed.</remarks>
        Public Property Achievement As FeedAchievement

        ''' <summary>
        ''' Determines whether the related achievement is a feat of strength.
        ''' </summary>
        ''' <value>This property gets or sets the FeatOfStrength field.</value>
        ''' <returns>Returns whether the related achievement is a feat of strength.</returns>
        ''' <remarks>This determines whether the related achievement is a feat of strength.</remarks>
        Public Property FeatOfStrength As Boolean

        ''' <summary>
        ''' The criteria used to determine that this was a boss kill.
        ''' </summary>
        ''' <value>This property gets or sets the Criteria field.</value>
        ''' <returns>Returns the criteria used to determine that this was a boss kill.</returns>
        ''' <remarks>This is a <see cref="FeedCriteria" /> object that represents the criteria used to determine that this was a boss kill.</remarks>
        Public Property Criteria As FeedCriteria

        ''' <summary>
        ''' The number of times the character has killed this boss.
        ''' </summary>
        ''' <value>This property gets or sets the Quantity field.</value>
        ''' <returns>Returns the number of times the character has killed this boss.</returns>
        ''' <remarks>This represents the number of times the character has killed this boss.</remarks>
        Public Property Quantity As Integer

        ''' <summary>
        ''' The name of the boss.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the boss.</returns>
        ''' <remarks>This is the localized name of the boss.</remarks>
        Public Property Name As String

        Friend Sub New(dtDate As Date, aAchievement As FeedAchievement, blnFeatOfStrength As Boolean, cCriteria As FeedCriteria, intQuantity As Integer, strName As String)
            [Date] = dtDate
            Achievement = aAchievement
            FeatOfStrength = blnFeatOfStrength
            Criteria = cCriteria
            Quantity = intQuantity
            Name = strName
        End Sub

    End Class

End Namespace
