' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Spell

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class SpellLookupTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub SpellLookup_Properties()
            Dim slLookup = New SpellLookup()
            slLookup.Options.SpellID = 7421
            slLookup.Load()

            Dim sSpell = slLookup.Spell

            Assert.AreEqual(sSpell.CastTime, "1.5 sec cast")
            Assert.AreEqual(sSpell.Cooldown, Nothing)
            Assert.AreEqual(sSpell.Description, "")
            Assert.AreEqual(sSpell.Icon, "inv_staff_goldfeathered_01")
            Assert.AreEqual(sSpell.Name, "Runed Copper Rod")
            Assert.AreEqual(sSpell.PowerCost, Nothing)
            Assert.AreEqual(sSpell.Range, Nothing)
            Assert.AreEqual(sSpell.SpellID, 7421)
            Assert.AreEqual(sSpell.Subtext, Nothing)
        End Sub

        <TestMethod()> Public Sub SpellLookup_Constructor_Default()
            Dim slLookup = New SpellLookup()
            slLookup.Options.SpellID = 7420
            slLookup.Load()

            Assert.AreEqual(slLookup.Spell.Name, "Minor Health")
        End Sub

        <TestMethod()> Public Sub SpellLookup_Constructor_BySpellID()
            Dim slLookup = New SpellLookup(7418)

            Assert.AreEqual(slLookup.Spell.Name, "Minor Health")
        End Sub

    End Class

End Namespace
