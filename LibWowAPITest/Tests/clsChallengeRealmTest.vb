' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Challenge

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class ChallengeRealmTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub ChallengeRealm_Properties()
            Dim crRealm = New ChallengeRealm()
            crRealm.Options.Realm = "Lightbringer"
            crRealm.Load()

            Dim cChallenges = crRealm.Challenge
            Dim cChallenge = cChallenges.Where(Function(c) c.Map.Name = "Gate of the Setting Sun").First()
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

        <TestMethod()> Public Sub ChallengeRealm_Constructor_Default()
            Dim crRealm = New ChallengeRealm()
            crRealm.Options.Realm = "Korialstrasz"
            crRealm.Load()

            Assert.IsTrue(crRealm.Challenge.Count > 0)
        End Sub

        <TestMethod()> Public Sub ChallengeRealm_Constructor_ByRealm()
            Dim crRealm = New ChallengeRealm("Blackhand")

            Assert.IsTrue(crRealm.Challenge.Count > 0)
        End Sub

    End Class

End Namespace
