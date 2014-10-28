' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Realm

Namespace roncliProductions.LibWowAPI.Auction

    ''' <summary>
    ''' A class containing information about the auctions available on a realm.
    ''' </summary>
    ''' <remarks>This class contains a snapshot of auctions for all auctions on a single realm.</remarks>
    Public Class Auctions

        ''' <summary>
        ''' The realm the auctions are on.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm the auctions are on.</returns>
        ''' <remarks>This is a <see cref="RealmName" /> object that defines the realm the auctions are on.</remarks>
        Public Property Realm As RealmName

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

        Friend Sub New(rnRealm As RealmName, dtLastUpdated As Date, ahAuctions As AuctionHouse)
            Realm = rnRealm
            LastUpdated = dtLastUpdated
            Auctions = ahAuctions
        End Sub

    End Class

End Namespace
