' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Recipe

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class RecipeLookupTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub RecipeLookup_Properties()
            Dim rlLookup = New RecipeLookup()
            rlLookup.Options.RecipeID = 7421
            rlLookup.Load()

            Dim rRecipe = rlLookup.Recipe

            Assert.AreEqual(rRecipe.Icon, "inv_staff_goldfeathered_01")
            Assert.AreEqual(rRecipe.Name, "Runed Copper Rod")
            Assert.AreEqual(rRecipe.Profession, "Enchanting")
            Assert.AreEqual(rRecipe.RecipeID, 7421)
        End Sub

        <TestMethod()> Public Sub RecipeLookup_Constructor_Default()
            Dim rlLookup = New RecipeLookup()
            rlLookup.Options.RecipeID = 7420
            rlLookup.Load()

            Assert.AreEqual(rlLookup.Recipe.Name, "Minor Health")
        End Sub

        <TestMethod()> Public Sub RecipeLookup_Constructor_ByRecipeID()
            Dim rlLookup = New RecipeLookup(7418)

            Assert.AreEqual(rlLookup.Recipe.Name, "Minor Health")
        End Sub

    End Class

End Namespace
