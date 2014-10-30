' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Linq
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports roncliProductions.LibWowAPI.Auction

Namespace roncliProductions.LibWowAPITest.Tests

    <TestClass()> Public Class AuctionDataTest

        Public Sub New()
            clsCommon.LoadApiKey()
        End Sub

        <TestMethod(), Timeout(60000)> Public Sub AuctionData_Constructor_Default()
            Dim adData As New AuctionData()
            adData.Options.Realm = "Lightbringer"
            adData.Load()

            Dim aAuctions = adData.Auctions

            Assert.IsTrue(aAuctions.Count > 0)
            Assert.IsTrue(aAuctions.First().Auctions.Auctions.Count > 0)
        End Sub

        <TestMethod(), Timeout(60000)> Public Sub AuctionData_Constructor_ByRealm()
            Dim adData As New AuctionData("Korialstrasz")

            Dim aAuctions = adData.Auctions

            Assert.IsTrue(aAuctions.Count > 0)
            Assert.IsTrue(aAuctions.First().Auctions.Auctions.Count > 0)
        End Sub

    End Class

End Namespace
