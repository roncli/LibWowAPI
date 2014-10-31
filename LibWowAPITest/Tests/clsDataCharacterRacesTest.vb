' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.CharacterRaces
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataCharacterRacesTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataCharacterRaces_Properties()
            Dim crRaces = New CharacterRaces()
            crRaces.Load()

            Dim rRace = crRaces.Races.Where(Function(r) r.RaceID = 1).First()

            Assert.AreEqual(rRace.Faction, Faction.Alliance)
            Assert.AreEqual(rRace.Mask, 1)
            Assert.AreEqual(rRace.Name, "Human")
            Assert.AreEqual(rRace.RaceID, 1)
        End Sub

        <TestMethod()> Public Sub DataCharacterRaces_Constructor_Default()
            Dim crRaces = New CharacterRaces()
            crRaces.Load()

            Assert.IsTrue(crRaces.Races.Count > 0)
        End Sub

    End Class

End Namespace
