' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Data.GuildAchievements

    ''' <summary>
    ''' A class containing information about a guild achievement.
    ''' </summary>
    ''' <remarks>This class provides detailed information about a guild achievement.</remarks>
    Public Class Achievement

        ''' <summary>
        ''' The ID number of the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the guild achievement.</returns>
        ''' <remarks>Each guild achievement has a unique ID number to identify it.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The title of the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Title field.</value>
        ''' <returns>Returns the title of the guild achievement.</returns>
        ''' <remarks>This is the localized title of the guild achievement.</remarks>
        Public Property Title As String

        ''' <summary>
        ''' The number of guild achievement points obtained for successfully completing the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Points field.</value>
        ''' <returns>Returns the number of guild achievement points obtained for successfully completing the guild achievement.</returns>
        ''' <remarks>Each successfully completed guild achievement earns a set number of guild achievement points for the guild.</remarks>
        Public Property Points As Integer

        ''' <summary>
        ''' The description of the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Description field.</value>
        ''' <returns>Returns the description of the guild achievement.</returns>
        ''' <remarks>This is the localized description of the guild achievement.</remarks>
        Public Property Description As String

        ''' <summary>
        ''' The reward obtained for completing the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Reward field.</value>
        ''' <returns>Returns the reward obtained for completing the guild achievement.</returns>
        ''' <remarks>This is the reward received for completing the guild achievement.  This is not localized.</remarks>
        Public Property Reward As String

        ''' <summary>
        ''' The item obtained as a reward for completing the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the RewardItem field.</value>
        ''' <returns>Returns the item obtained as a reward for completing the guild achievement.</returns>
        ''' <remarks>This is a <see cref="RewardItem" /> object that contains details about the item received for completing the guild achievement.</remarks>
        Public Property RewardItem As RewardItem

        Friend Sub New(intID As Integer, strTitle As String, intPoints As Integer, strDescription As String, strReward As String, riRewardItem As RewardItem)
            ID = intID
            Title = strTitle
            Points = intPoints
            Description = strDescription
            Reward = strReward
            RewardItem = riRewardItem
        End Sub

    End Class

End Namespace
