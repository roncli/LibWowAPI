' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.BattlePet
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class BattlePetStatsLookupTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub BattlePetStatsLookup_Properties()
            Dim bpslLookup = New BattlePetStatsLookup()
            bpslLookup.Options.SpeciesID = 258
            bpslLookup.Options.Level = 25
            bpslLookup.Options.Breed = BattlePetBreed.MaleDoubleSpeed
            bpslLookup.Options.Quality = Quality.Epic
            bpslLookup.Load()

            Dim bpsStats = bpslLookup.Stats

            Assert.AreEqual(bpsStats.Breed, BattlePetBreed.MaleDoubleSpeed)
            Assert.AreEqual(bpsStats.Gender, Gender.Male)
            Assert.AreEqual(bpsStats.Health, 1587)
            Assert.AreEqual(bpsStats.Level, 25)
            Assert.AreEqual(bpsStats.PetQuality, Quality.Epic)
            Assert.AreEqual(bpsStats.Power, 315)
            Assert.AreEqual(bpsStats.SpeciesID, 258)
            Assert.AreEqual(bpsStats.Speed, 297)
        End Sub

        <TestMethod()> Public Sub BattlePetStatsLookup_Constructor_Default()
            Dim bpslLookup = New BattlePetStatsLookup()
            bpslLookup.Options.SpeciesID = 259
            bpslLookup.Load()

            Dim bpsStats = bpslLookup.Stats

            Assert.AreEqual(bpsStats.Breed, BattlePetBreed.MaleBalanced)
            Assert.AreEqual(bpsStats.Gender, Gender.Male)
            Assert.AreEqual(bpsStats.Health, 150)
            Assert.AreEqual(bpsStats.Level, 1)
            Assert.AreEqual(bpsStats.PetQuality, Quality.Common)
            Assert.AreEqual(bpsStats.Power, 9)
            Assert.AreEqual(bpsStats.SpeciesID, 259)
            Assert.AreEqual(bpsStats.Speed, 9)
        End Sub

        <TestMethod()> Public Sub BattlePetStatsLookup_Constructor_BySpeciesID()
            Dim bpslLookup = New BattlePetStatsLookup(260)

            Dim bpsStats = bpslLookup.Stats

            Assert.AreEqual(bpsStats.Breed, BattlePetBreed.MaleBalanced)
            Assert.AreEqual(bpsStats.Gender, Gender.Male)
            Assert.AreEqual(bpsStats.Health, 147)
            Assert.AreEqual(bpsStats.Level, 1)
            Assert.AreEqual(bpsStats.PetQuality, Quality.Common)
            Assert.AreEqual(bpsStats.Power, 10)
            Assert.AreEqual(bpsStats.SpeciesID, 260)
            Assert.AreEqual(bpsStats.Speed, 9)
        End Sub

        <TestMethod()> Public Sub BattlePetStatsLookup_Constructor_ByAllParameters()
            Dim bpslLookup = New BattlePetStatsLookup(261, 5, BattlePetBreed.FemaleBalancedSpeed, Quality.Rare)

            Dim bpsStats = bpslLookup.Stats

            Assert.AreEqual(bpsStats.Breed, BattlePetBreed.FemaleBalancedSpeed)
            Assert.AreEqual(bpsStats.Gender, Gender.Female)
            Assert.AreEqual(bpsStats.Health, 389)
            Assert.AreEqual(bpsStats.Level, 5)
            Assert.AreEqual(bpsStats.PetQuality, Quality.Rare)
            Assert.AreEqual(bpsStats.Power, 51)
            Assert.AreEqual(bpsStats.SpeciesID, 261)
            Assert.AreEqual(bpsStats.Speed, 58)
        End Sub

    End Class

End Namespace
