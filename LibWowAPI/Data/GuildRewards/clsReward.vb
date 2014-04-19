' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Achievement
Imports roncliProductions.LibWowAPI.Data.CharacterRaces
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Item

Namespace roncliProductions.LibWowAPI.Data.GuildRewards

    ''' <summary>
    ''' A class containing information about a guild reward.
    ''' </summary>
    ''' <remarks>This class represents a guild reward.</remarks>
    Public Class Reward

        ''' <summary>
        ''' The required guild level to receive the reward.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredGuildLevel field.</value>
        ''' <returns>Returns the required guild level to receive the reward.</returns>
        ''' <remarks>This will be set to 0 if there is no required guild level.</remarks>
        Public Property RequiredGuildLevel As Integer

        ''' <summary>
        ''' The required guild reputation standing to receive the reward.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredGuildStanding field.</value>
        ''' <returns>Returns the required guild standing to receive the reward.</returns>
        ''' <remarks>This is a <see cref="Enums.Standing" /> enumeration that indicates the standing required with the guild to receive the reward.</remarks>
        Public Property RequiredGuildStanding As Standing

        Private colRaces As Collection(Of Race)
        ''' <summary>
        ''' The races allowed to receive the reward.
        ''' </summary>
        ''' <value>This property gets the Races field.</value>
        ''' <returns>Returns the races allowed to receive the reward.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Race)" /> of <see cref="Race" /> that indicates the races that can use the reward.</remarks>
        Public ReadOnly Property Races As Collection(Of Race)
            Get
                Return colRaces
            End Get
        End Property

        ''' <summary>
        ''' The guild achievement that unlocks the reward.
        ''' </summary>
        ''' <value>This property gets or sets the Achievement.</value>
        ''' <returns>Returns the guild achievement that unlocks the reward.</returns>
        ''' <remarks>This is a <see cref="Achievement" /> object that details the achievement required to unlock the reward.</remarks>
        Public Property Achievement As Achievement.Achievement

        ''' <summary>
        ''' The guild reward item.
        ''' </summary>
        ''' <value>This property gets or sets the RewardItem.</value>
        ''' <returns>Returns the guild reward item.</returns>
        ''' <remarks>This is a <see cref="ItemBasicInfo" /> object that contains details about the rewarded item.</remarks>
        Public Property RewardItem As ItemBasicInfo

        Friend Sub New(intRequiredGuildLevel As Integer, sRequiredGuildStanding As Standing, rRaces As Collection(Of Race), aAchievement As Achievement.Achievement, ibiRewardItem As ItemBasicInfo)
            RequiredGuildLevel = intRequiredGuildLevel
            RequiredGuildStanding = sRequiredGuildStanding
            colRaces = rRaces
            Achievement = aAchievement
            RewardItem = ibiRewardItem
        End Sub

    End Class

End Namespace
