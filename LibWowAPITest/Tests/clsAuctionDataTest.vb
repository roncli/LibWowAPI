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

        <TestMethod(), Timeout(60000)> Public Sub Constructor_Default()
            Dim auctions As New AuctionData()
            auctions.Options.Realm = "Lightbringer"
            auctions.Load()

            Assert.IsTrue(auctions.Auctions.Count > 0)
            Assert.IsTrue(auctions.Auctions.First().Auctions.Auctions.Count > 0)
        End Sub

    End Class

End Namespace
