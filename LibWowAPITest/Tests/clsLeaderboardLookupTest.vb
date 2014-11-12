' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Leaderboard

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class LeaderboardLookupTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod()> Public Sub LeaderboardLookup_Constructor_Default()
            Dim llLookup = New LeaderboardLookup()
            llLookup.Options.Type = LeaderboardType.Arena2v2
            llLookup.Load()

            Assert.IsTrue(llLookup.Leaderboard.Count >= 0)
        End Sub

        <TestMethod()> Public Sub LeaderboardLookup_Constructor_ByBracket()
            Dim llLookup = New LeaderboardLookup(LeaderboardType.Arena3v3)

            Assert.IsTrue(llLookup.Leaderboard.Count > 0)
        End Sub

    End Class

End Namespace
