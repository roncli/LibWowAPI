' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Realm.Schema

Namespace roncliProductions.LibWowAPI.Auction.Schema

    <DataContract()> Friend Class auctions

        <DataMember()> Public Property realm As realmName
        <DataMember()> Public Property auctions As auctionHouse

    End Class

End Namespace
