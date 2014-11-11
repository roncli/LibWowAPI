' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Drawing
Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Guild

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class GuildProfileTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub GuildProfile_Properties_Basic()
            Dim gpProfile As New GuildProfile()
            gpProfile.Options.Realm = "Lightbringer"
            gpProfile.Options.Name = "Six Minutes To Release"
            gpProfile.Load()

            Dim gGuild = gpProfile.Guild
            Dim eEmblem = gGuild.Emblem

            Assert.IsTrue(gGuild.AchievementPoints >= 2000)
            Assert.AreEqual(gGuild.Battlegroup, "Cyclone")
            Assert.AreEqual(eEmblem.BackgroundColor, Color.FromArgb(&HFF, &H21, &HDC, &HFF))
            Assert.AreEqual(eEmblem.Border, 3)
            Assert.AreEqual(eEmblem.BorderColor, Color.FromArgb(&HFF, &HF, &H14, &H15))
            Assert.AreEqual(eEmblem.Icon, 49)
            Assert.AreEqual(eEmblem.IconColor, Color.FromArgb(&HFF, &H10, &H15, &H17))
            Assert.AreEqual(gGuild.Faction, Faction.Alliance)
            Assert.IsTrue(gGuild.LastModified > New Date(2014, 11, 11))
            Assert.AreEqual(gGuild.Level, 25)
            Assert.AreEqual(gGuild.Name, "Six Minutes To Release")
            Assert.AreEqual(gGuild.Realm, "Lightbringer")
        End Sub

        <TestMethod()> Public Sub GuildProfile_Properties_Achievements()
            Dim gpProfile As New GuildProfile()
            gpProfile.Options.Realm = "Lightbringer"
            gpProfile.Options.Name = "Six Minutes To Release"
            gpProfile.Options.Achievements = True
            gpProfile.Load()

            Dim caAchievements = gpProfile.Guild.Achievements
            Dim caAchievement = caAchievements.Achievements.First()
            Dim ccCriteria = caAchievements.Criteria.First()

            Assert.IsTrue(caAchievements.Achievements.Count > 100)
            Assert.AreEqual(caAchievement.AchievementID, 4860)
            Assert.AreEqual(caAchievement.Timestamp, New Date(2011, 2, 19, 4, 57, 42))
            Assert.IsTrue(caAchievements.Criteria.Count > 100)
            Assert.AreEqual(ccCriteria.Created, New Date(2012, 8, 28, 21, 47, 58))
            Assert.AreEqual(ccCriteria.CriteriaID, 2020)
            Assert.IsTrue(ccCriteria.Quantity = 42999)
            Assert.AreEqual(ccCriteria.Timestamp, New Date(2012, 8, 28, 21, 47, 58))
        End Sub

        <TestMethod()> Public Sub GuildProfile_Properties_Challenge()
            Dim gpProfile As New GuildProfile()
            gpProfile.Options.Realm = "Lightbringer"
            gpProfile.Options.Name = "Six Minutes To Release"
            gpProfile.Options.Challenge = True
            gpProfile.Load()

            Dim cChallenge = gpProfile.Guild.Challenge.Where(Function(c) c.Map.MapID = 962).First()
            Dim mMap = cChallenge.Map
            Dim gGroups = cChallenge.Groups
            Dim rbiRealm = cChallenge.Realm

            Assert.AreEqual(rbiRealm.Battlegroup, "Cyclone")
            Assert.IsTrue(rbiRealm.ConnectedRealms.Count > 0)
            Assert.AreEqual(rbiRealm.Locale, "en_US")
            Assert.AreEqual(rbiRealm.Name, "Internal Record 3694")
            Assert.AreEqual(rbiRealm.Slug, "internal-record-3694")
            Assert.AreEqual(rbiRealm.TimeZone, "America/Los_Angeles")
            Assert.AreEqual(mMap.BronzeCriteria.TotalMinutes, 45.0#)
            Assert.AreEqual(mMap.GoldCriteria.TotalMinutes, 13.0#)
            Assert.AreEqual(mMap.HasChallengeMode, True)
            Assert.AreEqual(mMap.MapID, 962)
            Assert.AreEqual(mMap.Name, "Gate of the Setting Sun")
            Assert.AreEqual(mMap.SilverCriteria.TotalMinutes, 22.0#)
            Assert.AreEqual(mMap.Slug, "gate-of-the-setting-sun")
            Assert.IsTrue(gGroups.Count > 0)
        End Sub

        <TestMethod()> Public Sub GuildProfile_Properties_Members()
            Dim gpProfile As New GuildProfile()
            gpProfile.Options.Realm = "Lightbringer"
            gpProfile.Options.Name = "Six Minutes To Release"
            gpProfile.Options.Members = True
            gpProfile.Load()

            Dim gmMember = gpProfile.Guild.Members.Where(Function(m) m.Character.Name = "Roncli").First()
            Dim cbiCharacter = gmMember.Character
            Dim ccClass = cbiCharacter.Class
            Dim rRace = cbiCharacter.Race
            Dim sSpec = cbiCharacter.Spec

            Assert.AreEqual(gmMember.Rank, 0)
            Assert.IsTrue(cbiCharacter.AchievementPoints >= 10000)
            Assert.AreEqual(cbiCharacter.Battlegroup, "Cyclone")
            Assert.AreEqual(ccClass.ClassID, 2)
            Assert.AreEqual(ccClass.Mask, 2)
            Assert.AreEqual(ccClass.Name, "Paladin")
            Assert.AreEqual(ccClass.PowerType, PowerType.Mana)
            Assert.AreEqual(cbiCharacter.Gender, Gender.Male)
            Assert.AreEqual(cbiCharacter.Guild, "Six Minutes To Release")
            Assert.AreEqual(cbiCharacter.GuildRealm, "Lightbringer")
            Assert.IsTrue(cbiCharacter.Level >= 90)
            Assert.AreEqual(cbiCharacter.Name, "Roncli")
            Assert.AreEqual(rRace.Faction, Faction.Alliance)
            Assert.AreEqual(rRace.Mask, 1)
            Assert.AreEqual(rRace.Name, "Human")
            Assert.AreEqual(rRace.RaceID, 1)
            Assert.AreEqual(cbiCharacter.Realm, "Lightbringer")
            Assert.AreEqual(cbiCharacter.Thumbnail, "internal-record-3694/156/113391004-avatar.jpg")
            Assert.AreEqual(sSpec.BackgroundImage, "bg-paladin-holy")
            Assert.AreEqual(sSpec.Description, "Invokes the power of the Light to protect and to heal.")
            Assert.AreEqual(sSpec.Icon, "spell_holy_holybolt")
            Assert.AreEqual(sSpec.Name, "Holy")
            Assert.AreEqual(sSpec.Order, 0)
            Assert.AreEqual(sSpec.Role, "HEALING")
        End Sub

        <TestMethod()> Public Sub GuildProfile_Properties_News()
            Dim gpProfile As New GuildProfile()
            gpProfile.Options.Realm = "Lightbringer"
            gpProfile.Options.Name = "Six Minutes To Release"
            gpProfile.Options.News = True
            gpProfile.Load()

            Assert.IsTrue(gpProfile.Guild.News.Count > 0)
        End Sub

        <TestMethod()> Public Sub GuildProfile_Constructor_Default()
            Dim gpProfile As New GuildProfile()
            gpProfile.Options.Realm = "Lightbringer"
            gpProfile.Options.Name = "Six Minutes To Release"
            gpProfile.Load()

            Assert.AreEqual(gpProfile.Guild.Battlegroup, "Cyclone")
        End Sub

        <TestMethod()> Public Sub GuildProfile_Constructor_ByRealmAndName()
            Dim gpProfile As New GuildProfile("Lightbringer", "Six Minutes To Release")

            Assert.AreEqual(gpProfile.Guild.Battlegroup, "Cyclone")
        End Sub

    End Class

End Namespace
