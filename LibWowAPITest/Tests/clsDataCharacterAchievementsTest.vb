' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.CharacterAchievements
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataCharacterAchievementsTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataCharacterAchievements_Properties()
            Dim caAchievements As New CharacterAchievements()
            caAchievements.Load()

            Dim cCategory = caAchievements.Categories.Where(Function(c) c.Name = "Quests").First()
            Dim cSubcategory = cCategory.Categories.Where(Function(c) c.Name = "Eastern Kingdoms").First()
            Dim aAchievement = cSubcategory.Achievements.Where(Function(a) a.Title = "Arathi Highlands Quests").First()
            Dim cCriteria = aAchievement.Criteria.First()

            Assert.AreEqual(cCategory.CategoryID, 96)
            Assert.AreEqual(cCategory.Name, "Quests")
            Assert.AreEqual(cSubcategory.CategoryID, 14861)
            Assert.AreEqual(cSubcategory.Name, "Eastern Kingdoms")
            Assert.AreEqual(aAchievement.AccountWide, False)
            Assert.AreEqual(aAchievement.AchievementID, 4896)
            Assert.AreEqual(cCriteria.CriteriaID, 13706)
            Assert.AreEqual(cCriteria.Description, "Arathi Highlands")
            Assert.AreEqual(cCriteria.Max, 18L)
            Assert.AreEqual(cCriteria.OrderIndex, 1)
            Assert.AreEqual(aAchievement.Description, "Complete 18 quests in Arathi Highlands.")
            Assert.AreEqual(aAchievement.Faction, Faction.Neutral)
            Assert.AreEqual(aAchievement.Icon, "achievement_zone_arathihighlands_01")
            Assert.AreEqual(aAchievement.Points, 10)
            Assert.AreEqual(aAchievement.Reward, Nothing)
            Assert.AreEqual(aAchievement.RewardItems.Count, 0)
            Assert.AreEqual(aAchievement.Title, "Arathi Highlands Quests")

            aAchievement = caAchievements.Categories.Where(Function(c) c.CategoryID = 81).First().Achievements.Where(Function(a) a.AchievementID = 4156).First()
            Dim ibiItem = aAchievement.RewardItems.FirstOrDefault()

            Assert.AreEqual(aAchievement.Reward, "Reward: Crusader's White Warhorse")
            Assert.AreEqual(aAchievement.RewardItems.Count, 1)
            Assert.AreEqual(ibiItem.Armor, 0)
            Assert.AreEqual(ibiItem.Icon, "ability_mount_ridinghorse")
            Assert.AreEqual(ibiItem.ItemID, 49096)
            Assert.AreEqual(ibiItem.ItemLevel, 40)
            Assert.AreEqual(ibiItem.Name, "Crusader's White Warhorse")
            Assert.AreEqual(ibiItem.Quality, Quality.Epic)
        End Sub

        <TestMethod()> Public Sub DataCharacterAchievements_Constructor_Default()
            Dim caAchievements As New CharacterAchievements()
            caAchievements.Load()

            Assert.IsTrue(caAchievements.Categories.Count > 0)
        End Sub

    End Class

End Namespace
