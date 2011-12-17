' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System

Namespace roncliProductions.LibWowAPI.Auction

    ''' <summary>
    ''' A class that defines options for the auction data lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the realm to look up auction data for.  There is no need to create an instance of this class, as the <see cref="AuctionData.Options" /> property automatically does so for you.</remarks>
    Public Class AuctionDataOptions

        ''' <summary>
        ''' The realm to lookup auction data for.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm to lookup auction data for.</returns>
        ''' <remarks>This property allows you to set the realm to look up auction data for.  You may use either the <see cref="LibWowAPI.Realm.Realm.Name" /> or the <see cref="LibWowAPI.Realm.Realm.Slug" />.</remarks>
        Public Property Realm As String

        Friend Property URI As Uri
        Friend Property LastModified As Date

        Friend Sub New()
        End Sub

    End Class

End Namespace
