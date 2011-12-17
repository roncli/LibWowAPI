' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Auction

    ''' <summary>
    ''' A class containing information about an auction house.
    ''' </summary>
    ''' <remarks>This class contains a snapshot of auctions for a single auction house on a single realm.  Each realm has three auction houses, including Alliance, Horde, and Neutral.</remarks>
    Public Class AuctionHouse

        Private colAuctions As Collection(Of Auction)
        ''' <summary>
        ''' The auctions available on the auction house.
        ''' </summary>
        ''' <value>This property gets the Auctions field.</value>
        ''' <returns>Returns the auctions available on the auction house.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Auction)" /> of <see cref="Auction" /> which represents a snapshot of the auctions available on the auction house.</remarks>
        Public ReadOnly Property Auctions As Collection(Of Auction)
            Get
                Return colAuctions
            End Get
        End Property

        Friend Sub New(aAuctions As Collection(Of Auction))
            colAuctions = aAuctions
        End Sub

    End Class

End Namespace
