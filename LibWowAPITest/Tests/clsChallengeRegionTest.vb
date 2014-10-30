' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Challenge

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class ChallengeRegionTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub ChallengeRegion_Properties()
            Dim crRegion = New ChallengeRegion()
            crRegion.Load()

            Dim cChallenges = crRegion.Challenge
            Dim cChallenge = cChallenges.Where(Function(c) c.Map.Name = "Gate of the Setting Sun").First()
            Dim mMap = cChallenge.Map
            Dim gGroups = cChallenge.Groups

            Assert.AreEqual(mMap.BronzeCriteria.TotalMinutes, 45.0#)
            Assert.AreEqual(mMap.GoldCriteria.TotalMinutes, 13.0#)
            Assert.AreEqual(mMap.HasChallengeMode, True)
            Assert.AreEqual(mMap.MapID, 962)
            Assert.AreEqual(mMap.Name, "Gate of the Setting Sun")
            Assert.AreEqual(mMap.SilverCriteria.TotalMinutes, 22.0#)
            Assert.AreEqual(mMap.Slug, "gate-of-the-setting-sun")
            Assert.IsTrue(gGroups.Count > 0)
        End Sub

        <TestMethod()> Public Sub ChallengeRegion_Constructor_Default()
            Dim crRegion = New ChallengeRegion()
            crRegion.Load()

            Assert.IsTrue(crRegion.Challenge.Count > 0)
        End Sub

    End Class

End Namespace
