' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Quest

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class QuestLookupTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub QuestLookup_Properties()
            Dim qlLookup = New QuestLookup()
            qlLookup.Options.QuestID = 123
            qlLookup.Load()

            Dim qQuest = qlLookup.Quest

            Assert.AreEqual(qQuest.Category, "Elwynn Forest")
            Assert.AreEqual(qQuest.Level, 10)
            Assert.AreEqual(qQuest.QuestID, 123)
            Assert.AreEqual(qQuest.RequiredLevel, 7)
            Assert.AreEqual(qQuest.SuggestedPartyMembers, 0)
            Assert.AreEqual(qQuest.Title, "The Collector")
        End Sub

        <TestMethod()> Public Sub QuestLookup_Constructor_Default()
            Dim qlLookup = New QuestLookup()
            qlLookup.Options.QuestID = 12345
            qlLookup.Load()

            Assert.AreEqual(qlLookup.Quest.Title, "Candy Bucket")
        End Sub

        <TestMethod()> Public Sub QuestLookup_Constructor_ByQuestID()
            Dim qlLookup = New QuestLookup(12344)

            Assert.AreEqual(qlLookup.Quest.Title, "Candy Bucket")
        End Sub

    End Class

End Namespace
