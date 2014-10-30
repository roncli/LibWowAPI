' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Drawing
Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Character
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions
Imports System.Runtime.CompilerServices

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class CharacterProfileTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Basic()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Load()

            Dim cCharacter = cpProfile.Character
            Dim ccClass = cCharacter.Class
            Dim rRace = cCharacter.Race

            Assert.IsTrue(cCharacter.AchievementPoints > 10000)
            Assert.AreEqual(cCharacter.Battlegroup, "Cyclone")
            Assert.AreEqual(cCharacter.CalcClass, "b")
            Assert.AreEqual(ccClass.ClassID, 2)
            Assert.AreEqual(ccClass.Mask, 2)
            Assert.AreEqual(ccClass.Name, "Paladin")
            Assert.AreEqual(ccClass.PowerType, PowerType.Mana)
            Assert.AreEqual(cCharacter.Gender, Gender.Male)
            Assert.IsTrue(cCharacter.LastModified > New Date(2014, 10, 1))
            Assert.IsTrue(cCharacter.Level >= 90)
            Assert.AreEqual(cCharacter.Name, "Roncli")
            Assert.AreEqual(rRace.Faction, Faction.Alliance)
            Assert.AreEqual(rRace.Mask, 1)
            Assert.AreEqual(rRace.Name, "Human")
            Assert.AreEqual(rRace.RaceID, 1)
            Assert.AreEqual(cCharacter.Realm, "Lightbringer")
            Assert.AreEqual(cCharacter.Thumbnail, "internal-record-3694/156/113391004-avatar.jpg")
            Assert.IsTrue(cCharacter.TotalHonorableKills >= 8398)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Achievements()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Achievements = True
            cpProfile.Load()

            Dim caAchievements = cpProfile.Character.Achievements
            Dim caAchievement = caAchievements.Achievements.First()
            Dim ccCriteria = caAchievements.Criteria.First()

            Assert.IsTrue(caAchievements.Achievements.Count > 1000)
            Assert.AreEqual(caAchievement.AchievementID, 6)
            Assert.AreEqual(caAchievement.Timestamp, New Date(2008, 10, 15, 3, 37, 0))
            Assert.IsTrue(caAchievements.Criteria.Count > 1000)
            Assert.AreEqual(ccCriteria.Created, New Date(1970, 1, 1))
            Assert.AreEqual(ccCriteria.CriteriaID, 72)
            Assert.IsTrue(ccCriteria.Quantity >= 428)
            Assert.IsTrue(ccCriteria.Timestamp > New Date(2014, 10, 29))
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Appearance()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Appearance = True
            cpProfile.Load()

            Dim aAppearance = cpProfile.Character.Appearance

            Assert.AreEqual(aAppearance.FaceVariation, 4)
            Assert.AreEqual(aAppearance.FeatureVariation, 1)
            Assert.AreEqual(aAppearance.HairColor, 0)
            Assert.AreEqual(aAppearance.HairVariation, 1)
            Assert.AreEqual(aAppearance.ShowCloak, False)
            Assert.AreEqual(aAppearance.ShowHelm, True)
            Assert.AreEqual(aAppearance.SkinColor, 4)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Audit()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Audit = True
            cpProfile.Load()

            Dim aAudit = cpProfile.Character.Audit

            Assert.AreEqual(aAudit.AppropriateArmorType, ArmorType.Plate)
            Assert.AreEqual(aAudit.EmptyGlyphSlots, 0)
            Assert.AreEqual(aAudit.EmptySockets, 0)
            Assert.AreEqual(aAudit.InappropriateArmorType.Count, 0)
            Assert.AreEqual(aAudit.ItemsWithEmptySockets.Count, 0)
            'TODO: Assert.AreEqual(aAudit.LowLevelItems, ??)
            Assert.AreEqual(aAudit.LowLevelThreshold, 0)
            Assert.AreEqual(aAudit.MissingBlacksmithSockets.Count, 0)
            Assert.AreEqual(aAudit.MissingEnchanterEnchants.Count, 0)
            Assert.AreEqual(aAudit.MissingEngineerEnchants.Count, 0)
            Assert.AreEqual(aAudit.MissingExtraSockets.Count, 0)
            Assert.AreEqual(aAudit.MissingJewelcrafterGems, 0)
            Assert.AreEqual(aAudit.MissingLeatherworkerEnchants.Count, 0)
            Assert.AreEqual(aAudit.MissingScribeEnchants.Count, 0)
            Assert.AreEqual(aAudit.NoSpec, False)
            Assert.AreEqual(aAudit.NumberOfIssues, 0)
            Assert.AreEqual(aAudit.RecommendedBeltBuckle, Nothing)
            Assert.AreEqual(aAudit.RecommendedJewelcrafterGem, Nothing)
            Assert.AreEqual(aAudit.Slots.Count, 0)
            Assert.AreEqual(aAudit.UnenchantedItems.Count, 0)
            Assert.AreEqual(aAudit.UnspentTalentPoints, 0)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Feed()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Feed = True
            cpProfile.Load()

            Dim cfFeed = cpProfile.Character.Feed

            Assert.IsTrue(cfFeed.Count > 0)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Guild()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Guild = True
            cpProfile.Load()

            Dim gbiGuild = cpProfile.Character.Guild
            Dim eEmblem = gbiGuild.Emblem

            Assert.IsTrue(gbiGuild.AchievementPoints >= 2000)
            Assert.AreEqual(gbiGuild.Battlegroup, "Cyclone")
            Assert.AreEqual(eEmblem.BackgroundColor, Color.FromArgb(&HFF, &H21, &HDC, &HFF))
            Assert.AreEqual(eEmblem.Border, 3)
            Assert.AreEqual(eEmblem.BorderColor, Color.FromArgb(&HFF, &HF, &H14, &H15))
            Assert.AreEqual(eEmblem.Icon, 49)
            Assert.AreEqual(eEmblem.IconColor, Color.FromArgb(&HFF, &H10, &H15, &H17))
            ' TODO: This fails! Determine if Level is ever used in GuildBasicInfo Assert.AreEqual(gbiGuild.Level, 25)
            Assert.IsTrue(gbiGuild.Members > 100)
            Assert.AreEqual(gbiGuild.Name, "Six Minutes To Release")
            Assert.AreEqual(gbiGuild.Realm, "Lightbringer")
        End Sub

    End Class

End Namespace
