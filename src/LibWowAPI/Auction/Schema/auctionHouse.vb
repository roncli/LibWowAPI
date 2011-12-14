' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Auction.Schema

    <DataContract()> Friend Class auctionHouse

        <DataMember()> Public Property auctions As auction()

    End Class

End Namespace
