' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.CharacterClasses
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataCharacterClassesTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataCharacterClasses_Properties()
            Dim ccClasses As New CharacterClasses()
            ccClasses.Load()

            Dim cClass = ccClasses.Classes.Where(Function(c) c.ClassID = 1).First()

            Assert.AreEqual(cClass.ClassID, 1)
            Assert.AreEqual(cClass.Mask, 1)
            Assert.AreEqual(cClass.Name, "Warrior")
            Assert.AreEqual(cClass.PowerType, PowerType.Rage)
        End Sub

        <TestMethod()> Public Sub DataCharacterClasses_Constructor_Default()
            Dim ccClasses As New CharacterClasses()
            ccClasses.Load()

            Assert.IsTrue(ccClasses.Classes.Count > 0)
        End Sub

    End Class

End Namespace
