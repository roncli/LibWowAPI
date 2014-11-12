' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Drawing
Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Item

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class ItemLookupTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_Basic()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 105239
            ilLookup.Load()

            Dim iItem = ilLookup.Item
            Dim isStat = iItem.BonusStats.Where(Function(s) s.Stat = ItemStatType.Strength).First()
            Dim isSource = iItem.ItemSource
            Dim icClass = iItem.ItemClass
            Dim isSubclass = iItem.ItemSubClass

            Assert.AreEqual(iItem.BaseArmor, 141)
            Assert.AreEqual(iItem.BonusStats.Count, 4)
            Assert.AreEqual(isStat.Stat, ItemStatType.Strength)
            Assert.AreEqual(isStat.Amount, 74)
            Assert.AreEqual(iItem.BuyPrice, 1402603)
            Assert.AreEqual(iItem.Description, "")
            Assert.AreEqual(iItem.DisenchantingSkillRank, 575)
            Assert.AreEqual(iItem.DisplayInfoID, 127315)
            Assert.AreEqual(iItem.Equippable, True)
            Assert.AreEqual(iItem.HasSockets, True)
            Assert.AreEqual(iItem.HeroicTooltip, False)
            Assert.AreEqual(iItem.Icon, "inv_helmet_plate_raidwarrior_n_01")
            Assert.AreEqual(iItem.InventoryType, InventoryType.Head)
            Assert.AreEqual(iItem.IsAuctionable, False)
            Assert.AreEqual(iItem.ItemBind, Binding.BindOnPickup)
            Assert.AreEqual(icClass.ClassID, 4)
            Assert.AreEqual(icClass.Name, "Armor")
            Assert.AreEqual(iItem.ItemID, 105239)
            Assert.AreEqual(iItem.ItemLevel, 559)
            Assert.AreEqual(isSource.SourceID, 0)
            Assert.AreEqual(isSource.SourceType, "NONE")
            Assert.AreEqual(isSubclass.Name, "Plate")
            Assert.AreEqual(isSubclass.SubclassID, 4)
            Assert.AreEqual(iItem.MaxCount, 0)
            Assert.AreEqual(iItem.MaxDurability, 100)
            Assert.AreEqual(iItem.MinStanding, Standing.Hated)
            Assert.AreEqual(iItem.Name, "Thranok's Shattering Helm")
            Assert.AreEqual(iItem.NameDescription, "Heroic Warforged")
            Assert.AreEqual(iItem.NameDescriptionColor, Color.FromArgb(255, 0, 255, 0))
            Assert.AreEqual(iItem.Quality, Quality.Epic)
            Assert.AreEqual(iItem.RequiredFactionID, 0)
            Assert.AreEqual(iItem.RequiredLevel, 90)
            Assert.AreEqual(iItem.RequiredSkill, Profession.None)
            Assert.AreEqual(iItem.RequiredSkillRank, 0)
            Assert.AreEqual(iItem.SellPrice, 280520)
            Assert.AreEqual(iItem.SocketBonus, "+11 Strength")
            Assert.AreEqual(iItem.Sockets.Count, 2)
            Assert.AreEqual(iItem.StackSize, 1)
            Assert.AreEqual(iItem.TotalArmor, 141)
            Assert.AreEqual(iItem.Upgradable, True)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_AllowableClassesAndRaces()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 28236
            ilLookup.Load()

            Dim iItem = ilLookup.Item

            Assert.AreEqual(iItem.AllowableClasses.Count, 1)
            Assert.IsTrue(iItem.AllowableRaces.Count > 1)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_ContextRequired()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 110050
            ilLookup.Load()

            Dim iItem = ilLookup.Item

            Assert.AreEqual(iItem.ItemID, 110050)
            Assert.IsTrue(iItem.AvailableContexts.Count > 1)
            Assert.AreEqual(iItem.Name, Nothing)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_ContextsAndBonuses()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 110050
            ilLookup.Options.Context = "dungeon-heroic"
            ilLookup.Options.Bonuses.Add(524)
            ilLookup.Options.Bonuses.Add(499)
            ilLookup.Load()

            Dim iItem = ilLookup.Item
            Dim bsSummary = iItem.BonusSummary
            Dim bcChances = bsSummary.BonusChances
            Dim bcChance = bcChances.Where(Function(c) c.ChanceType = "UPGRADE").First()
            Dim bcuUpgrade = bcChance.Upgrade
            Dim bcsStat = bcChance.Stats.Where(Function(s) s.Stat = ItemStatType.ILevel).First()

            Assert.AreEqual(iItem.Context, "dungeon-heroic")
            Assert.AreEqual(iItem.Bonuses.Count, 2)
            Assert.AreEqual(bsSummary.DefaultBonuses.Count, 1)
            Assert.AreEqual(bsSummary.ChanceBonuses.Count, 6)
            Assert.AreEqual(bcChances.Count, 3)
            Assert.AreEqual(bcChance.ChanceType, "UPGRADE")
            Assert.AreEqual(bcChance.Sockets.Count, 0)
            Assert.AreEqual(bcChance.Stats.Count, 6)
            Assert.AreEqual(bcuUpgrade.Name, "Warforged")
            Assert.AreEqual(bcuUpgrade.UpgradeID, 11428)
            Assert.AreEqual(bcuUpgrade.UpgradeType, "NAME_DESCRIPTION")
            Assert.AreEqual(bcsStat.Delta, 6)
            Assert.AreEqual(bcsStat.Stat, ItemStatType.ILevel)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_BoundZone()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 30311
            ilLookup.Load()

            Dim bzZone = ilLookup.Item.BoundZone

            Assert.AreEqual(bzZone.Name, "Tempest Keep")
            Assert.AreEqual(bzZone.ZoneID, 3845)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_Container()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 51809
            ilLookup.Load()

            Dim iItem = ilLookup.Item

            Assert.AreEqual(iItem.ContainerSlots, 24)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_Gem()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 41440
            ilLookup.Load()

            Dim giInfo = ilLookup.Item.GemInfo
            Dim bBonus = giInfo.Bonus

            Assert.AreEqual(bBonus.MinLevel, 0)
            Assert.AreEqual(bBonus.Name, "+14 Spirit")
            Assert.AreEqual(bBonus.RequiredItemLevel, 60)
            Assert.AreEqual(bBonus.RequiredSkill, Profession.None)
            Assert.AreEqual(bBonus.RequiredSkillRank, 0)
            Assert.AreEqual(bBonus.SourceItemID, 41440)
            Assert.AreEqual(giInfo.MinItemLevel, 0)
            Assert.AreEqual(giInfo.Type, "BLUE")
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_ItemSet()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 99558
            ilLookup.Load()

            Dim isSet = ilLookup.Item.ItemSet
            Dim sbBonus = isSet.SetBonuses.Where(Function(b) b.Threshold = 2).First()

            Assert.AreEqual(isSet.Items.Count, 5)
            Assert.AreEqual(isSet.ItemSetID, 1179)
            Assert.AreEqual(isSet.Name, "Plate of the Prehistoric Marauder")
            Assert.AreEqual(sbBonus.Description, "You heal for 30% of all damage blocked with a shield and 30% of all damage absorbed by Shield Barrier.")
            Assert.AreEqual(sbBonus.Threshold, 2)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_ItemSpell()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 104691
            ilLookup.Load()

            Dim isSpell = ilLookup.Item.ItemSpells.First()
            Dim sSpell = isSpell.Spell

            Assert.AreEqual(isSpell.CategoryID, 0)
            Assert.AreEqual(isSpell.Charges, 0)
            Assert.AreEqual(isSpell.Consumable, False)
            Assert.AreEqual(isSpell.SpellID, 146343)
            Assert.AreEqual(isSpell.Trigger, ItemSpellTrigger.OnUse)
            Assert.AreEqual(sSpell.CastTime, "Instant")
            Assert.AreEqual(sSpell.Cooldown, Nothing)
            Assert.AreEqual(sSpell.Description, "Reduces damage taken from creature area of effect attacks by 8% for 15 sec.")
            Assert.AreEqual(sSpell.Icon, "ability_rogue_quickrecovery")
            Assert.AreEqual(sSpell.Name, "Avoidance")
            Assert.AreEqual(sSpell.PowerCost, Nothing)
            Assert.AreEqual(sSpell.Range, Nothing)
            Assert.AreEqual(sSpell.SpellID, 146343)
            Assert.AreEqual(sSpell.Subtext, Nothing)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_RequiredAbility()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 77067
            ilLookup.Load()

            Dim raAbility = ilLookup.Item.RequiredAbility

            Assert.AreEqual(raAbility.Description, "You can now learn to ride fast flying mounts from your riding trainer.")
            Assert.AreEqual(raAbility.Name, "Artisan Riding")
            Assert.AreEqual(raAbility.SpellID, 34091)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Properties_Weapon()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 49623
            ilLookup.Load()

            Dim wiInfo = ilLookup.Item.WeaponInfo
            Dim dDamage = wiInfo.Damage

            Assert.AreEqual(wiInfo.WeaponSpeed, 3.7)
            Assert.AreEqual(wiInfo.DPS, 52.43243)
            Assert.AreEqual(dDamage.ExactMax, 243.0#)
            Assert.AreEqual(dDamage.ExactMin, 145.0#)
            Assert.AreEqual(dDamage.Max, 243)
            Assert.AreEqual(dDamage.Min, 145)
        End Sub

        <TestMethod()> Public Sub ItemLookup_Constructor_Default()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 49624
            ilLookup.Load()

            Assert.AreEqual(ilLookup.Item.Name, "Tiny Scaly Tail")
        End Sub

        <TestMethod()> Public Sub ItemLookup_Constructor_ByItemID()
            Dim ilLookup = New ItemLookup(49625)

            Assert.AreEqual(ilLookup.Item.Name, "Polished Shell Fragment")
        End Sub

        <TestMethod()> Public Sub ItemLookup_Constructor_WithContext()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 110050
            ilLookup.Options.Context = "dungeon-normal"
            ilLookup.Load()

            Assert.AreEqual(ilLookup.Item.Name, "Dagger of the Sanguine Emeralds")
        End Sub

        <TestMethod()> Public Sub ItemLookup_Constructor_WithContextAndBonuses()
            Dim ilLookup = New ItemLookup()
            ilLookup.Options.ItemID = 110050
            ilLookup.Options.Context = "dungeon-normal"
            ilLookup.Options.Bonuses.Add(522)
            ilLookup.Options.Bonuses.Add(40)
            ilLookup.Load()

            Assert.AreEqual(ilLookup.Item.Name, "Dagger of the Sanguine Emeralds")
        End Sub

    End Class

End Namespace
