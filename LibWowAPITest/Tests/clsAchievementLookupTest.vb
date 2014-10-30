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

        <TestMethod()> Public Sub AchievementLookup_Properties_Basic()
            Dim alLookup = New AchievementLookup(5845)
            Dim aAchievement = alLookup.Achievement
            Dim cCriteria = aAchievement.Criteria.FirstOrDefault()

            Assert.AreEqual(aAchievement.AccountWide, True)
            Assert.AreEqual(aAchievement.AchievementID, 5845)
            Assert.AreEqual(aAchievement.Criteria.Count, 6)
            Assert.AreEqual(cCriteria.CriteriaID, 17743)
            Assert.AreEqual(cCriteria.Description, "Let's Do Lunch: Darnassus")
            Assert.AreEqual(cCriteria.Max, 1L)
            Assert.AreEqual(cCriteria.OrderIndex, 0)
            Assert.AreEqual(aAchievement.Description, "Complete each Let's Do Lunch achievement.")
            Assert.AreEqual(aAchievement.Faction, Faction.Neutral)
            Assert.AreEqual(aAchievement.Icon, "inv_misc_food_dimsum")
            Assert.AreEqual(aAchievement.Points, 10)
            Assert.AreEqual(aAchievement.Title, "A Bunch of Lunch")
        End Sub

        <TestMethod()> Public Sub AchievementLookup_Properties_Reward_Mount()
            Dim alLookup = New AchievementLookup(4156)
            Dim aAchievement = alLookup.Achievement
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

        <TestMethod()> Public Sub AchievementLookup_Constructor_Default()
            Dim alLookup = New AchievementLookup()
            alLookup.Options.AchievementID = 3496
            alLookup.Load()

            Assert.AreEqual(alLookup.Achievement.Title, "A Brew-FAST Mount")
        End Sub

        <TestMethod()> Public Sub AchievementLookup_Constructor_ByAchievementID()
            Dim alLookup = New AchievementLookup(7252)

            Assert.AreEqual(alLookup.Achievement.Title, "A Brewing Storm")
        End Sub

    End Class

End Namespace
