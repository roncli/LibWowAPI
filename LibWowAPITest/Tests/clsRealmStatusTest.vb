' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Realm

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class RealmStatusTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub RealmStatus_Properties()
            Dim rsStatus = New RealmStatus()
            rsStatus.Options.Realms.Add("Lightbringer")
            rsStatus.Load()

            Dim rRealm = rsStatus.Realms.First()

            Assert.AreEqual(rRealm.Battlegroup, "Cyclone")
            Assert.AreEqual(rRealm.ConnectedRealms.Count, 2)
            Assert.AreEqual(rRealm.Locale, "en_US")
            Assert.AreEqual(rRealm.Name, "Lightbringer")
            Assert.IsFalse(String.IsNullOrEmpty(rRealm.Population))
            Assert.AreEqual(rRealm.Slug, "lightbringer")
            Assert.AreEqual(rRealm.TimeZone, "America/Los_Angeles")
            Assert.AreEqual(rRealm.TolBarad.Area, 21)
            Assert.AreEqual(rRealm.Type, RealmType.PvE)
            Assert.AreEqual(rRealm.Wintergrasp.Area, 1)
        End Sub

        <TestMethod()> Public Sub RealmStatus_Constructor_Default()
            Dim rsStatus = New RealmStatus()
            rsStatus.Load()

            Assert.IsTrue(rsStatus.Realms.Count > 0)
        End Sub

        <TestMethod()> Public Sub RealmStatus_Constructor_ByRealm()
            Dim rsStatus = New RealmStatus("Korialstrasz")

            Assert.AreEqual(rsStatus.Realms.First().Battlegroup, "Reckoning")
        End Sub

        <TestMethod()> Public Sub RealmStatus_Constructor_ByRealms()
            Dim rsStatus = New RealmStatus(New Collection(Of String)() From {"Korialstrasz", "Lightbringer"})

            Assert.AreEqual(rsStatus.Realms.Count, 2)
        End Sub

        <TestMethod()> Public Sub RealmStatus_Constructor_ByAddingRealms()
            Dim rsStatus = New RealmStatus()
            rsStatus.Options.Realms.Add("Korialstrasz")
            rsStatus.Options.Realms.Add("Lightbringer")
            rsStatus.Options.Realms.Add("Blackhand")
            rsStatus.Load()

            Assert.AreEqual(rsStatus.Realms.Count, 3)
        End Sub

    End Class

End Namespace
