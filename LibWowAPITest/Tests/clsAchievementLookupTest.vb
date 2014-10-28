' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Achievement
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class AchievementLookupTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub Achievement_Properties_Basic()
            Dim alLookup = New AchievementLookup(5845)
            Dim achievement = alLookup.Achievement
            Dim criteria = achievement.Criteria.FirstOrDefault()

            Assert.AreEqual(achievement.AccountWide, True)
            Assert.AreEqual(achievement.AchievementID, 5845)
            Assert.AreEqual(achievement.Criteria.Count, 6)
            Assert.AreEqual(criteria.CriteriaID, 17743)
            Assert.AreEqual(criteria.Description, "Let's Do Lunch: Darnassus")
            Assert.AreEqual(criteria.Max, 1L)
            Assert.AreEqual(criteria.OrderIndex, 0)
            Assert.AreEqual(achievement.Description, "Complete each Let's Do Lunch achievement.")
            Assert.AreEqual(achievement.Faction, Faction.Neutral)
            Assert.AreEqual(achievement.Icon, "inv_misc_food_dimsum")
            Assert.AreEqual(achievement.Points, 10)
            Assert.AreEqual(achievement.Title, "A Bunch of Lunch")
        End Sub

        <TestMethod()> Public Sub Achievement_Properties_Reward_Mount()
            Dim alLookup = New AchievementLookup(4156)
            Dim achievement = alLookup.Achievement
            Dim item = achievement.RewardItems.FirstOrDefault()

            Assert.AreEqual(achievement.Reward, "Reward: Crusader's White Warhorse")
            Assert.AreEqual(achievement.RewardItems.Count, 1)
            Assert.AreEqual(item.Armor, 0)
            Assert.AreEqual(item.Icon, "ability_mount_ridinghorse")
            Assert.AreEqual(item.ItemID, 49096)
            Assert.AreEqual(item.ItemLevel, 40)
            Assert.AreEqual(item.Name, "Crusader's White Warhorse")
            Assert.AreEqual(item.Quality, Quality.Epic)
        End Sub

        <TestMethod()> Public Sub Constructor_Default()
            Dim alLookup = New AchievementLookup()
            alLookup.Options.AchievementID = 3496
            alLookup.Load()

            Assert.AreEqual(alLookup.Achievement.Title, "A Brew-FAST Mount")
        End Sub

        <TestMethod()> Public Sub Constructor_ByAchievementID()
            Dim alLookup = New AchievementLookup(7252)

            Assert.AreEqual(alLookup.Achievement.Title, "A Brewing Storm")
        End Sub

    End Class

End Namespace
