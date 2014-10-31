' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.Talents
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataClassTalentsTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataClassTalents_Properties()
            Dim ctTalents = New ClassTalents()
            ctTalents.Load()

            Dim tTalents = ctTalents.Talents.Where(Function(t) t.Class.Name = "Hunter").First()
            Dim sPetSpec = tTalents.PetSpecs.Where(Function(s) s.Name = "Ferocity").First()
            Dim gGlyph = tTalents.Glyphs.Where(Function(g) g.Item = 42897).First()
            Dim ttTalentTier = tTalents.TalentTiers.First()
            Dim tTalent = ttTalentTier.TalentSlots.Where(Function(t) t.Column = 0).First().Talents.First()
            Dim sSpell = tTalent.Spell
            Dim sSpec = tTalents.Specs.Where(Function(s) s.Name = "Beast Mastery").First()

            Assert.AreEqual(sPetSpec.BackgroundImage, "bg-deathknight-blood")
            Assert.AreEqual(sPetSpec.Description, "Driven by a frenzied persistence to pursue prey, these beasts stop at nothing to achieve victory; even death is temporary for these predators.")
            Assert.AreEqual(sPetSpec.Icon, "ability_druid_kingofthejungle")
            Assert.AreEqual(sPetSpec.Name, "Ferocity")
            Assert.AreEqual(sPetSpec.Order, 0)
            Assert.AreEqual(sPetSpec.Role, "DPS")
            Assert.AreEqual(gGlyph.Glyph, 351)
            Assert.AreEqual(gGlyph.GlyphType, GlyphType.Minor)
            Assert.AreEqual(gGlyph.Icon, "ability_hunter_aspectmastery")
            Assert.AreEqual(gGlyph.Item, 42897)
            Assert.AreEqual(gGlyph.Name, "Glyph of Aspects")
            Assert.AreEqual(ttTalentTier.Tier, 0)
            Assert.AreEqual(tTalent.Column, 0)
            Assert.AreEqual(tTalent.Tier, 0)
            Assert.AreEqual(sSpell.CastTime, "Passive")
            Assert.AreEqual(sSpell.Cooldown, Nothing)
            Assert.AreEqual(sSpell.Description, "Disengage also frees you from all movement impairing effects and increases your movement speed by 60% for 8 sec.")
            Assert.AreEqual(sSpell.Icon, "ability_hunter_posthaste")
            Assert.AreEqual(sSpell.Name, "Posthaste")
            Assert.AreEqual(sSpell.PowerCost, Nothing)
            Assert.AreEqual(sSpell.Range, Nothing)
            Assert.AreEqual(sSpell.SpellID, 109215)
            Assert.AreEqual(sSpell.Subtext, Nothing)
            Assert.AreEqual(sSpec.BackgroundImage, "bg-hunter-beastmaster")
            Assert.IsTrue(sSpec.Description.StartsWith("A master of the wild who can tame a wide variety of beasts to assist "))
            Assert.IsTrue(sSpec.Description.EndsWith(" in combat."))
            Assert.AreEqual(sSpec.Icon, "ability_hunter_bestialdiscipline")
            Assert.AreEqual(sSpec.Name, "Beast Mastery")
            Assert.AreEqual(sSpec.Order, 0)
            Assert.AreEqual(sSpec.Role, "DPS")
        End Sub

        <TestMethod()> Public Sub DataClassTalents_Constructor_Default()
            Dim ctTalents = New ClassTalents()
            ctTalents.Load()

            Assert.IsTrue(ctTalents.Talents.Count > 0)
        End Sub

    End Class

End Namespace
