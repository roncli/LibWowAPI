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
            'TODO: This fails! Determine if Level is ever used in GuildBasicInfo Assert.AreEqual(gbiGuild.Level, 25)
            Assert.IsTrue(gbiGuild.Members > 100)
            Assert.AreEqual(gbiGuild.Name, "Six Minutes To Release")
            Assert.AreEqual(gbiGuild.Realm, "Lightbringer")
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_HunterPets()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Ahderi"
            cpProfile.Options.HunterPets = True
            cpProfile.Load()

            Dim hpPets = cpProfile.Character.HunterPets
            Dim hpPet = hpPets.Where(Function(p) p.Name = "DoubleDown").First()
            Dim sSpec = hpPet.Spec

            Assert.IsTrue(hpPets.Count > 0)
            Assert.AreEqual(hpPet.CalcSpec, "a")
            Assert.AreEqual(hpPet.Creature, 20748)
            Assert.AreEqual(hpPet.FamilyID, 1)
            Assert.AreEqual(hpPet.FamilyName, "Wolf")
            Assert.AreEqual(hpPet.Name, "DoubleDown")
            Assert.AreEqual(hpPet.Slot, 4)
            Assert.AreEqual(sSpec.BackgroundImage, "bg-deathknight-blood")
            Assert.AreEqual(sSpec.Description, "Driven by a frenzied persistence to pursue prey, these beasts stop at nothing to achieve victory; even death is temporary for these predators.")
            Assert.AreEqual(sSpec.Icon, "ability_druid_kingofthejungle")
            Assert.AreEqual(sSpec.Name, "Ferocity")
            Assert.AreEqual(sSpec.Order, 0)
            Assert.AreEqual(sSpec.Role, "DPS")
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Items()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Items = True
            cpProfile.Load()

            Dim iItems = cpProfile.Character.Items

            Assert.IsTrue(iItems.AverageItemLevel >= 500)
            Assert.IsTrue(iItems.AverageItemLevelEquipped >= 500)
            Assert.IsTrue(iItems.Head.ItemID > 0)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Mounts()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Mounts = True
            cpProfile.Load()

            Dim mMounts = cpProfile.Character.Mounts
            Dim mMount = mMounts.Collected.Where(Function(m) m.Name = "Albino Drake").First()

            Assert.IsTrue(mMounts.NumCollected >= 100)
            Assert.IsTrue(mMounts.NumNotCollected > 0)
            Assert.AreEqual(mMount.CreatureID, 32158)
            Assert.AreEqual(mMount.Icon, "ability_mount_drake_blue")
            Assert.AreEqual(mMount.IsAquatic, True)
            Assert.AreEqual(mMount.IsFlying, True)
            Assert.AreEqual(mMount.IsGround, True)
            Assert.AreEqual(mMount.IsJumping, False)
            Assert.AreEqual(mMount.ItemID, 44178)
            Assert.AreEqual(mMount.Name, "Albino Drake")
            Assert.AreEqual(mMount.Quality, Quality.Epic)
            Assert.AreEqual(mMount.SpellID, 60025)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Pets()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Pets = True
            cpProfile.Load()

            Dim pPets = cpProfile.Character.Pets
            Dim pPet = pPets.Collected.Where(Function(p) p.Name = "Cinder Kitten").First()
            Dim bpsStats = pPet.Stats

            Assert.IsTrue(pPets.NumCollected >= 150)
            Assert.IsTrue(pPets.NumNotCollected > 0)
            Assert.AreEqual(pPet.BattlePetGuid, "00000000020853D1")
            Assert.AreEqual(pPet.CanBattle, True)
            Assert.AreEqual(pPet.CreatureID, 68267)
            Assert.AreEqual(pPet.CreatureName, "Cinder Kitten")
            Assert.AreEqual(pPet.Icon, "inv_misc_firekitty")
            Assert.AreEqual(pPet.IsFavorite, False)
            Assert.AreEqual(pPet.IsFirstAbilitySlotSelected, False)
            Assert.AreEqual(pPet.IsSecondAbilitySlotSelected, False)
            Assert.AreEqual(pPet.IsThirdAbilitySlotSelected, False)
            Assert.AreEqual(pPet.ItemID, 92707)
            Assert.AreEqual(pPet.Name, "Cinder Kitten")
            Assert.AreEqual(pPet.Quality, Quality.Rare)
            Assert.AreEqual(pPet.SpellID, 134538)
            Assert.AreEqual(bpsStats.Breed, BattlePetBreed.MaleBalanced)
            Assert.AreEqual(bpsStats.Gender, Gender.Male)
            Assert.AreEqual(bpsStats.Health, 464)
            Assert.AreEqual(bpsStats.Level, 7)
            Assert.AreEqual(bpsStats.PetQuality, Quality.Rare)
            Assert.AreEqual(bpsStats.Power, 82)
            Assert.AreEqual(bpsStats.SpeciesID, 1117)
            Assert.AreEqual(bpsStats.Speed, 82)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_PetSlots()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.PetSlots = True
            cpProfile.Load()

            Dim psSlot = cpProfile.Character.PetSlots.First()

            Assert.AreEqual(psSlot.Abilites.Count, 0)
            Assert.AreEqual(psSlot.BattlePetGuid, Nothing)
            Assert.AreEqual(psSlot.IsEmpty, True)
            Assert.AreEqual(psSlot.IsLocked, False)
            Assert.AreEqual(psSlot.Slot, 1)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Professions()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Professions = True
            cpProfile.Load()

            Dim pProfessions = cpProfile.Character.Professions
            Dim pPrimary = pProfessions.Primary.First()
            Dim pSecondary = pProfessions.Secondary.First()

            Assert.AreEqual(pPrimary.Icon, "trade_blacksmithing")
            Assert.IsTrue(pPrimary.Max >= 600)
            Assert.AreEqual(pPrimary.Name, "Blacksmithing")
            Assert.AreEqual(pPrimary.Profession, LibWowAPI.Enums.Profession.Blacksmithing)
            Assert.IsTrue(pPrimary.Rank >= 600)
            Assert.IsTrue(pPrimary.Recipes.Count > 0)
            Assert.AreEqual(pSecondary.Icon, "spell_holy_sealofsacrifice")
            Assert.IsTrue(pSecondary.Max >= 600)
            Assert.AreEqual(pSecondary.Name, "First Aid")
            Assert.AreEqual(pSecondary.Profession, LibWowAPI.Enums.Profession.FirstAid)
            Assert.IsTrue(pSecondary.Rank >= 600)
            Assert.IsTrue(pSecondary.Recipes.Count > 0)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Progession()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Progression = True
            cpProfile.Load()

            Dim iRaid = cpProfile.Character.Progression.Raids.Where(Function(i) i.Name = "Siege of Orgrimmar").First()
            Dim bBoss = iRaid.Bosses.First()

            Assert.AreEqual(bBoss.EncounterID, 71543)
            Assert.IsTrue(bBoss.FlexKills >= 19)
            Assert.IsTrue(bBoss.FlexTimestamp >= New Date(2014, 4, 2, 1, 33, 57))
            Assert.IsTrue(bBoss.HeroicKills >= 0)
            Assert.IsTrue(bBoss.HeroicTimestamp >= New Date(1970, 1, 1))
            Assert.IsTrue(bBoss.LFRKills >= 3)
            Assert.IsTrue(bBoss.LFRTimestamp >= New Date(2014, 2, 19, 23, 17, 26))
            Assert.AreEqual(bBoss.Name, "Immerseus")
            Assert.IsTrue(bBoss.NormalKills >= 36)
            Assert.IsTrue(bBoss.NormalTimestamp >= New Date(2014, 10, 29, 1, 22, 46))
            Assert.AreEqual(iRaid.Heroic, Progress.None)
            Assert.AreEqual(iRaid.InstanceID, 6738)
            Assert.AreEqual(iRaid.Name, "Siege of Orgrimmar")
            Assert.AreEqual(iRaid.Normal, Progress.Cleared)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_PvP()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.PvP = True
            cpProfile.Load()

            Dim abBracket = cpProfile.Character.PvP.Brackets.ArenaBracket2v2

            Assert.IsTrue(abBracket.Rating >= 0)
            Assert.IsTrue(abBracket.SeasonLost >= 0)
            Assert.IsTrue(abBracket.SeasonPlayed >= 0)
            Assert.IsTrue(abBracket.SeasonWon >= 0)
            Assert.AreEqual(abBracket.Slug, "2v2")
            Assert.IsTrue(abBracket.WeeklyLost >= 0)
            Assert.IsTrue(abBracket.WeeklyPlayed >= 0)
            Assert.IsTrue(abBracket.WeeklyWon >= 0)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Quests()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Quests = True
            cpProfile.Load()

            Assert.IsTrue(cpProfile.Character.Quests.Count > 0)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Reputation()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Reputation = True
            cpProfile.Load()

            Dim rReputation = cpProfile.Character.Reputation.Where(Function(r) r.Name = "Stormwind").First()

            Assert.AreEqual(rReputation.FactionID, 72)
            Assert.AreEqual(rReputation.Max, 999)
            Assert.AreEqual(rReputation.Name, "Stormwind")
            Assert.AreEqual(rReputation.Standing, Standing.Exalted)
            Assert.AreEqual(rReputation.Value, 999)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Stats()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Stats = True
            cpProfile.Load()

            Dim csStats = cpProfile.Character.Stats

            Assert.IsTrue(csStats.Agi > 0)
            Assert.IsTrue(csStats.Armor > 0)
            Assert.IsTrue(csStats.AttackPower > 0)
            Assert.IsTrue(csStats.Block >= 0)
            Assert.IsTrue(csStats.BlockRating >= 0)
            Assert.IsTrue(csStats.Crit > 0)
            Assert.IsTrue(csStats.CritRating >= 0)
            Assert.IsTrue(csStats.Dodge >= 0)
            Assert.IsTrue(csStats.DodgeRating >= 0)
            Assert.IsTrue(csStats.ExpertiseRating >= 0)
            Assert.IsTrue(csStats.Haste >= 0)
            Assert.IsTrue(csStats.HasteRating >= 0)
            Assert.IsTrue(csStats.HasteRatingPercent >= 0)
            Assert.IsTrue(csStats.Health > 0)
            Assert.IsTrue(csStats.Int > 0)
            Assert.IsTrue(csStats.MainHandDmgMax >= 0)
            Assert.IsTrue(csStats.MainHandDmgMin >= 0)
            Assert.IsTrue(csStats.MainHandDps >= 0)
            Assert.IsTrue(csStats.MainHandSpeed >= 0)
            Assert.IsTrue(csStats.Mana5 >= 0)
            Assert.IsTrue(csStats.Mana5Combat >= 0)
            Assert.IsTrue(csStats.Mastery >= 0)
            Assert.IsTrue(csStats.MasteryRating >= 0)
            Assert.IsTrue(csStats.OffHandDmgMax >= -1)
            Assert.IsTrue(csStats.OffHandDmgMin >= -1)
            Assert.IsTrue(csStats.OffHandDps >= -1)
            Assert.IsTrue(csStats.OffHandSpeed >= -1)
            Assert.IsTrue(csStats.Parry >= 0)
            Assert.IsTrue(csStats.ParryRating >= 0)
            Assert.IsTrue(csStats.Power > 0)
            Assert.AreEqual(csStats.PowerType, PowerType.Mana)
            Assert.IsTrue(csStats.PvpPower >= 0)
            Assert.IsTrue(csStats.PvpPowerDamage >= 0)
            Assert.IsTrue(csStats.PvpPowerHealing >= 0)
            Assert.IsTrue(csStats.PvpPowerRating >= 0)
            Assert.IsTrue(csStats.PvpResilience >= 0)
            Assert.IsTrue(csStats.PvpResilienceBonus >= 0)
            Assert.IsTrue(csStats.PvpResilienceRating >= 0)
            Assert.IsTrue(csStats.RangedAttackPower >= 0)
            Assert.IsTrue(csStats.RangedCrit >= 0)
            Assert.IsTrue(csStats.RangedCritRating >= 0)
            Assert.AreEqual(csStats.RangedDmgMax, -1.0#)
            Assert.AreEqual(csStats.RangedDmgMin, -1.0#)
            Assert.AreEqual(csStats.RangedDps, -1.0#)
            Assert.IsTrue(csStats.RangedHaste >= 0)
            Assert.IsTrue(csStats.RangedHasteRating >= 0)
            Assert.IsTrue(csStats.RangedHasteRatingPercent >= 0)
            Assert.AreEqual(csStats.RangedSpeed, -1.0#)
            Assert.IsTrue(csStats.SpellCrit >= 0)
            Assert.IsTrue(csStats.SpellCritRating >= 0)
            Assert.IsTrue(csStats.SpellHaste >= 0)
            Assert.IsTrue(csStats.SpellHasteRating >= 0)
            Assert.IsTrue(csStats.SpellHasteRatingPercent >= 0)
            Assert.IsTrue(csStats.SpellPen >= 0)
            Assert.IsTrue(csStats.SpellPower >= 0)
            Assert.IsTrue(csStats.Spr > 0)
            Assert.IsTrue(csStats.Sta > 0)
            Assert.IsTrue(csStats.Str > 0)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Talents()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Talents = True
            cpProfile.Load()

            Dim tsSpec = cpProfile.Character.Talents.First()
            Dim tTalent = tsSpec.Talents.First()
            Dim sSpell = tTalent.Spell
            Dim gMajorGlyph = tsSpec.Glyphs.Major.First()
            Dim gMinorGlyph = tsSpec.Glyphs.Minor.First()
            Dim sSpec = tsSpec.Spec

            Assert.AreEqual(tsSpec.CalcGlyph, "LQNPiq")
            Assert.AreEqual(tsSpec.CalcSpec, "a")
            Assert.AreEqual(tsSpec.CalcTalent, "212221.")
            Assert.AreEqual(gMajorGlyph.Glyph, 930)
            Assert.AreEqual(gMajorGlyph.GlyphType, GlyphType.Major)
            Assert.AreEqual(gMajorGlyph.Icon, "ability_paladin_protectoroftheinnocent")
            Assert.AreEqual(gMajorGlyph.Item, 66918)
            Assert.AreEqual(gMajorGlyph.Name, "Glyph of Protector of the Innocent")
            Assert.AreEqual(gMinorGlyph.Glyph, 457)
            Assert.AreEqual(gMinorGlyph.GlyphType, GlyphType.Minor)
            Assert.AreEqual(gMinorGlyph.Icon, "ability_mage_firestarter")
            Assert.AreEqual(gMinorGlyph.Item, 43369)
            Assert.AreEqual(gMinorGlyph.Name, "Glyph of Fire From the Heavens")
            Assert.AreEqual(sSpec.BackgroundImage, "bg-paladin-holy")
            Assert.AreEqual(sSpec.Description, "Invokes the power of the Light to protect and to heal.")
            Assert.AreEqual(sSpec.Icon, "spell_holy_holybolt")
            Assert.AreEqual(sSpec.Name, "Holy")
            Assert.AreEqual(sSpec.Order, 0)
            Assert.AreEqual(sSpec.Role, "HEALING")
            Assert.AreEqual(tTalent.Column, 2)
            Assert.AreEqual(sSpell.CastTime, "Passive")
            Assert.AreEqual(sSpell.Cooldown, Nothing)
            Assert.AreEqual(sSpell.Description, "Increases your movement speed by 15%, plus an additional 5% for each charge of Holy Power up to 3.")
            Assert.AreEqual(sSpell.Icon, "ability_paladin_veneration")
            Assert.AreEqual(sSpell.Name, "Pursuit of Justice")
            Assert.AreEqual(sSpell.PowerCost, Nothing)
            Assert.AreEqual(sSpell.Range, Nothing)
            Assert.AreEqual(sSpell.SpellID, 26023)
            Assert.AreEqual(sSpell.Subtext, Nothing)
            Assert.AreEqual(tTalent.Tier, 0)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Properties_Titles()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Options.Titles = True
            cpProfile.Load()

            Dim tTitle = cpProfile.Character.Titles.Where(Function(t) t.TitleID = 53).First()

            Assert.AreEqual(tTitle.Name, "%s, Champion of the Naaru")
            Assert.AreEqual(tTitle.TitleID, 53)
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Constructor_Default()
            Dim cpProfile As New CharacterProfile()
            cpProfile.Options.Realm = "Lightbringer"
            cpProfile.Options.Name = "Roncli"
            cpProfile.Load()

            Assert.AreEqual(cpProfile.Character.Battlegroup, "Cyclone")
        End Sub

        <TestMethod()> Public Sub CharacterProfile_Constructor_ByRealmAndName()
            Dim cpProfile As New CharacterProfile("Lightbringer", "Opshae")

            Assert.AreEqual(cpProfile.Character.Battlegroup, "Cyclone")
        End Sub

    End Class

End Namespace
