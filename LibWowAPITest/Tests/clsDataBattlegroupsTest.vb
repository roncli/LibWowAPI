' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.Battlegroups

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataBattlegroupsTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataBattlegroups_Properties()
            Dim bgBattlegroups As New Battlegroups()
            bgBattlegroups.Load()

            Dim bgBattlegroup = bgBattlegroups.Battlegroups.Where(Function(b) b.Name = "Cyclone").First()

            Assert.IsTrue(bgBattlegroups.Battlegroups.Count > 0)
            Assert.AreEqual(bgBattlegroup.Name, "Cyclone")
            Assert.AreEqual(bgBattlegroup.Slug, "cyclone")
        End Sub

        <TestMethod()> Public Sub DataBattlegroups_Constructor_Default()
            Dim bgBattlegroups As New Battlegroups()
            bgBattlegroups.Load()

            Assert.IsTrue(bgBattlegroups.Battlegroups.Count > 0)
        End Sub

    End Class

End Namespace
