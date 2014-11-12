' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Data.ItemClasses

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class DataItemClassesTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub DataItemClasses_Properties()
            Dim icClasses = New ItemClasses()
            icClasses.Load()

            Dim cClass = icClasses.Classes.Where(Function(c) c.ClassID = 0).First()
            Dim scSubClass = cClass.Subclasses.Where(Function(s) s.SubclassID = 0).First()

            Assert.AreEqual(cClass.ClassID, 0)
            Assert.AreEqual(cClass.Name, "Consumable")
            Assert.AreEqual(scSubClass.Name, "Consumable")
            Assert.AreEqual(scSubClass.SubclassID, 0)
        End Sub

        <TestMethod()> Public Sub DataItemClasses_Constructor_Default()
            Dim icClasses = New ItemClasses()
            icClasses.Load()

            Assert.IsTrue(icClasses.Classes.Count > 0)
        End Sub

    End Class

End Namespace
