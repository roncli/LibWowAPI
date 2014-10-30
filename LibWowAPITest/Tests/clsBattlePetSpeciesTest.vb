' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.BattlePet

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class BattlePetSpeciesTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub BattlePetSpecies_Properties()
            Dim bpsSpecies = New BattlePetSpecies()
            bpsSpecies.Options.SpeciesID = 258
            bpsSpecies.Load()

            Dim sSpecies = bpsSpecies.Species
            Dim saAbilities = sSpecies.Abilities
            Dim saAbility = saAbilities.First()
            Dim ptAbilityPetType = saAbility.PetType
            Dim ptSpeciesPetType = sSpecies.PetType

            Assert.AreEqual(saAbilities.Count, 6)
            Assert.AreEqual(saAbility.AbilityID, 777)
            Assert.AreEqual(saAbility.Cooldown, 0)
            Assert.AreEqual(saAbility.HideHints, False)
            Assert.AreEqual(saAbility.Icon, "ability_racial_rocketbarrage")
            Assert.AreEqual(saAbility.IsPassive, False)
            Assert.AreEqual(saAbility.Name, "Missile")
            Assert.AreEqual(saAbility.Order, 0)
            Assert.AreEqual(ptAbilityPetType.Key, "mechanical")
            Assert.AreEqual(ptAbilityPetType.Name, "Mechanical")
            Assert.AreEqual(ptAbilityPetType.PetTypeID, 9)
            Assert.AreEqual(ptAbilityPetType.StrongAgainstID, 7)
            Assert.AreEqual(ptAbilityPetType.TypeAbilityID, 244)
            Assert.AreEqual(ptAbilityPetType.WeakAgainstID, 6)
            Assert.AreEqual(saAbility.RequiredLevel, 1)
            Assert.AreEqual(saAbility.Rounds, 1)
            Assert.AreEqual(saAbility.Slot, 0)
            Assert.AreEqual(sSpecies.CanBattle, True)
            Assert.AreEqual(sSpecies.CreatureID, 42078)
            Assert.AreEqual(sSpecies.Description, "Powerful artillery of the terran army. The Thor is always the first one in and the last one out!")
            Assert.AreEqual(sSpecies.Icon, "t_roboticon")
            Assert.AreEqual(sSpecies.Name, "Mini Thor")
            Assert.AreEqual(ptSpeciesPetType.Key, "mechanical")
            Assert.AreEqual(ptSpeciesPetType.Name, "Mechanical")
            Assert.AreEqual(ptSpeciesPetType.PetTypeID, 9)
            Assert.AreEqual(ptSpeciesPetType.StrongAgainstID, 7)
            Assert.AreEqual(ptSpeciesPetType.TypeAbilityID, 244)
            Assert.AreEqual(ptSpeciesPetType.WeakAgainstID, 6)
            Assert.AreEqual(sSpecies.Source, "Promotion: StarCraft II: Wings of Liberty Collector's Edition")
            Assert.AreEqual(sSpecies.SpeciesID, 258)
        End Sub

        <TestMethod()> Public Sub BattlePetSpecies_Constructor_Default()
            Dim bpsSpecies = New BattlePetSpecies()
            bpsSpecies.Options.SpeciesID = 259
            bpsSpecies.Load()

            Assert.AreEqual(bpsSpecies.Species.Name, "Blue Mini Jouster")
        End Sub

        <TestMethod()> Public Sub BattlePetSpecies_Constructor_BySpeciesID()
            Dim bpsSpecies = New BattlePetSpecies(260)

            Assert.AreEqual(bpsSpecies.Species.Name, "Gold Mini Jouster")
        End Sub

    End Class

End Namespace
