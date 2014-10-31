' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.GuildRewards
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataGuildRewardsTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataGuildRewards_Properties()
            Dim grRewards = New GuildRewards()
            grRewards.Load()

            Dim rReward = grRewards.Rewards.Where(Function(r) r.Achievement.AchievementID = 5035 And r.RewardItem.ItemID = 65274).First()
            Dim aAchievement = rReward.Achievement
            Dim riAchievementItem = aAchievement.RewardItems.Where(Function(r) r.ItemID = 65274).First()
            Dim cCriteria = aAchievement.Criteria.First()
            Dim riRewardItem = rReward.RewardItem

            Assert.IsTrue(rReward.Races.Count > 0)
            Assert.AreEqual(rReward.RequiredGuildLevel, 0)
            Assert.AreEqual(rReward.RequiredGuildStanding, Standing.Revered)
            Assert.AreEqual(aAchievement.AccountWide, False)
            Assert.AreEqual(aAchievement.AchievementID, 5035)
            Assert.AreEqual(aAchievement.Description, "Craft 500 Epic items with an item level of at least 359.")
            Assert.AreEqual(aAchievement.Faction, Faction.Neutral)
            Assert.AreEqual(aAchievement.Icon, "ability_repair")
            Assert.AreEqual(aAchievement.Points, 10)
            Assert.AreEqual(aAchievement.Reward, "Reward: Cloak of Coordination")
            Assert.AreEqual(aAchievement.Title, "Master Crafter")
            Assert.AreEqual(riAchievementItem.Armor, 7)
            Assert.AreEqual(riAchievementItem.Icon, "inv_guild_cloak_horde_c")
            Assert.AreEqual(riAchievementItem.ItemID, 65274)
            Assert.AreEqual(riAchievementItem.ItemLevel, 60)
            Assert.AreEqual(riAchievementItem.Name, "Cloak of Coordination")
            Assert.AreEqual(riAchievementItem.Quality, Quality.Epic)
            Assert.AreEqual(riAchievementItem.Stats.Count, 0)
            Assert.AreEqual(cCriteria.CriteriaID, 14811)
            Assert.AreEqual(cCriteria.Description, "")
            Assert.AreEqual(cCriteria.Max, 500L)
            Assert.AreEqual(cCriteria.OrderIndex, 0)
            Assert.AreEqual(riRewardItem.Armor, riAchievementItem.Armor)
            Assert.AreEqual(riRewardItem.Icon, riAchievementItem.Icon)
            Assert.AreEqual(riRewardItem.ItemID, riAchievementItem.ItemID)
            Assert.AreEqual(riRewardItem.ItemLevel, riAchievementItem.ItemLevel)
            Assert.AreEqual(riRewardItem.Name, riAchievementItem.Name)
            Assert.AreEqual(riRewardItem.Quality, riAchievementItem.Quality)
            Assert.AreEqual(riRewardItem.Stats.Count, riAchievementItem.Stats.Count)
        End Sub

        <TestMethod()> Public Sub DataGuildRewards_Constructor_Default()
            Dim grRewards = New GuildRewards()
            grRewards.Load()

            Assert.IsTrue(grRewards.Rewards.Count > 0)
        End Sub

    End Class

End Namespace
