' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Auction.Schema

    <DataContract()> Friend Class auctions

        <DataMember()> Public Property realm As realm
        <DataMember()> Public Property alliance As auctionHouse
        <DataMember()> Public Property horde As auctionHouse
        <DataMember()> Public Property neutral As auctionHouse

    End Class

End Namespace
