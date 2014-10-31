' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.GuildPerks

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataGuildPerksTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataGuildPerks_Properties()
            Dim gpPerks = New GuildPerks()
            gpPerks.Load()

            Dim pPerk = gpPerks.Perks.Where(Function(s) s.Spell.SpellID = 83968).First()
            Dim sSpell = pPerk.Spell

            Assert.AreEqual(pPerk.GuildLevel, 1)
            Assert.AreEqual(sSpell.CastTime, "10 sec cast")
            Assert.AreEqual(sSpell.Cooldown, Nothing)
            Assert.AreEqual(sSpell.Description, "Brings all dead party and raid members back to life with 35% health and 35% mana.  A player may only be resurrected by this spell once every 10 minutes.  Cannot be cast in combat or while in a battleground or arena.")
            Assert.AreEqual(sSpell.Icon, "achievement_guildperk_massresurrection")
            Assert.AreEqual(sSpell.Name, "Mass Resurrection")
            Assert.AreEqual(sSpell.PowerCost, Nothing)
            Assert.AreEqual(sSpell.Range, "100 yd range")
            Assert.AreEqual(sSpell.SpellID, 83968)
            Assert.AreEqual(sSpell.Subtext, "Guild Perk")
        End Sub

        <TestMethod()> Public Sub DataGuildPerks_Constructor_Default()
            Dim gpPerks = New GuildPerks()
            gpPerks.Load()

            Assert.IsTrue(gpPerks.Perks.Count > 0)
        End Sub

    End Class

End Namespace
