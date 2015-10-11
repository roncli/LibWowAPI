' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Realm

Namespace roncliProductions.LibWowAPI.Auction

    ''' <summary>
    ''' A class containing information about the auctions available on a realm.
    ''' </summary>
    ''' <remarks>This class contains a snapshot of auctions for all auctions on a single realm.</remarks>
    Public Class Auctions

        Private colRealms As Collection(Of RealmName)
        ''' <summary>
        ''' The realms the auctions are on.
        ''' </summary>
        ''' <value>This property gets or sets the Realms field.</value>
        ''' <returns>Returns the realms the auctions are on.</returns>
        ''' <remarks>This is a <see cref="Collection(Of RealmName)" /> of <see cref="RealmName" /> objects that defines the realm the auctions are on.</remarks>
        Public ReadOnly Property Realms As Collection(Of RealmName)
            Get
                Return colRealms
            End Get
        End Property

        ''' <summary>
        ''' The date the auctions were last updated.
        ''' </summary>
        ''' <value>This property gets or sets the LastUpdated field.</value>
        ''' <returns>Returns the date the auctions were last updated.</returns>
        ''' <remarks>Auctions are updated on an hourly basis.  This date represents the time in UTC that the auctions were last updated on the server.  You can use this value for the <see cref="WowAPIData.IfModifiedSince" /> property of the <see cref="WowAPIData" /> class.</remarks>
        Public Property LastUpdated As Date

        ''' <summary>
        ''' The auctions available on the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Auctions field.</value>
        ''' <returns>Returns the auctions available on the realm.</returns>
        ''' <remarks>This is an <see cref="AuctionHouse" /> object that lists all of the auctions currently available on the auction house for this realm.</remarks>
        Public Property Auctions As AuctionHouse

        Friend Sub New(rnRealms As Collection(Of RealmName), dtLastUpdated As Date, ahAuctions As AuctionHouse)
            colRealms = rnRealms
            LastUpdated = dtLastUpdated
            Auctions = ahAuctions
        End Sub

    End Class

End Namespace
