' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.GuildAchievements
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataGuildAchievementsTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataGuildAchievements_Properties()
            Dim gaAchievements As New GuildAchievements()
            gaAchievements.Load()

            Dim cCategory = gaAchievements.Categories.Where(Function(c) c.Name = "Player vs. Player").First()
            Dim cSubcategory = cCategory.Categories.Where(Function(c) c.Name = "Battlegrounds").First()
            Dim aAchievement = cSubcategory.Achievements.Where(Function(a) a.Title = "5-Cap Crew").First()
            Dim cCriteria = aAchievement.Criteria.First()

            Assert.AreEqual(cCategory.CategoryID, 15078)
            Assert.AreEqual(cCategory.Name, "Player vs. Player")
            Assert.AreEqual(cSubcategory.CategoryID, 15090)
            Assert.AreEqual(cSubcategory.Name, "Battlegrounds")
            Assert.AreEqual(aAchievement.AccountWide, False)
            Assert.AreEqual(aAchievement.AchievementID, 5166)
            Assert.AreEqual(cCriteria.CriteriaID, 14654)
            Assert.AreEqual(cCriteria.Description, "")
            Assert.AreEqual(cCriteria.Max, 100L)
            Assert.AreEqual(cCriteria.OrderIndex, 0)
            Assert.AreEqual(aAchievement.Description, "Win 100 rated Arathi Basin matches while controlling all 5 flags in a guild group.")
            Assert.AreEqual(aAchievement.Faction, Faction.Neutral)
            Assert.AreEqual(aAchievement.Icon, "achievement_bg_winab_5cap")
            Assert.AreEqual(aAchievement.Points, 10)
            Assert.AreEqual(aAchievement.Reward, Nothing)
            Assert.AreEqual(aAchievement.RewardItems.Count, 0)
            Assert.AreEqual(aAchievement.Title, "5-Cap Crew")

            aAchievement = gaAchievements.Categories.Where(Function(c) c.CategoryID = 15088).First().Achievements.Where(Function(a) a.AchievementID = 5201).First()
            Dim ibiItem = aAchievement.RewardItems.FirstOrDefault()

            Assert.AreEqual(aAchievement.Reward, "Reward: Guild Herald")
            Assert.AreEqual(aAchievement.RewardItems.Count, 2)
            Assert.AreEqual(ibiItem.Armor, 0)
            Assert.AreEqual(ibiItem.Icon, "achievement_guildperk_honorablemention_rank2")
            Assert.AreEqual(ibiItem.ItemID, 65364)
            Assert.AreEqual(ibiItem.ItemLevel, 1)
            Assert.AreEqual(ibiItem.Name, "Guild Herald")
            Assert.AreEqual(ibiItem.Quality, Quality.Rare)
        End Sub

        <TestMethod()> Public Sub DataGuildAchievements_Constructor_Default()
            Dim gaAchievements As New GuildAchievements()
            gaAchievements.Load()

            Assert.IsTrue(gaAchievements.Categories.Count > 0)
        End Sub

    End Class

End Namespace
