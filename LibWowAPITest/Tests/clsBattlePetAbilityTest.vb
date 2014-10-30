' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.BattlePet

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class BattlePetAbilityTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub BattlePetAbility_Properties()
            Dim bpaAbility = New BattlePetAbility()
            bpaAbility.Options.AbilityID = 640
            bpaAbility.Load()

            Dim aAbility = bpaAbility.Ability
            Dim ptPetType = aAbility.PetType

            Assert.AreEqual(aAbility.AbilityID, 640)
            Assert.AreEqual(aAbility.Cooldown, 0)
            Assert.AreEqual(aAbility.HideHints, False)
            Assert.AreEqual(aAbility.Icon, "spell_shadow_plaguecloud")
            Assert.AreEqual(aAbility.IsPassive, False)
            Assert.AreEqual(aAbility.Name, "Toxic Smoke")
            Assert.AreEqual(ptPetType.Key, "mechanical")
            Assert.AreEqual(ptPetType.Name, "Mechanical")
            Assert.AreEqual(ptPetType.PetTypeID, 9)
            Assert.AreEqual(ptPetType.StrongAgainstID, 7)
            Assert.AreEqual(ptPetType.TypeAbilityID, 244)
            Assert.AreEqual(ptPetType.WeakAgainstID, 6)
            Assert.AreEqual(aAbility.Rounds, 1)
        End Sub

        <TestMethod()> Public Sub BattlePetAbility_Constructor_Default()
            Dim bpaAbility = New BattlePetAbility()
            bpaAbility.Options.AbilityID = 641
            bpaAbility.Load()

            Assert.AreEqual(bpaAbility.Ability.Name, "Egg Barrage")
        End Sub

        <TestMethod()> Public Sub BattlePetAbility_Constructor_ByAbilityID()
            Dim bpaAbility = New BattlePetAbility(642)

            Assert.AreEqual(bpaAbility.Ability.Name, "Egg Barrage")
        End Sub

    End Class

End Namespace
