' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Auction

    ''' <summary>
    ''' A class that retrieves auction data from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>
    ''' <para>
    ''' The Blizzard WoW API provides snapshots of auction house data for each server approximately once per hour.  This class can be used to retrieve that data.
    ''' <h5>Caching</h5>
    ''' Because this class has to make two calls to the API to retrieve the necessary data, caching works a little differently.  The call that retreives the auction files is cached for 15 minutes, but the actual auction data itself is cached for 3 hours.  The <see cref="AuctionData.CacheLength" /> property represents the former time, defaulting to 15 minutes.  The latter time is not changable, nor can it be cleared since an auction snapshot for that particular point in time will never change.
    ''' </para>
    ''' </remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve auction data.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Auction;
    ''' 
    ''' namespace AuctionExample {
    '''
    '''     public class AuctionClass {
    ''' 
    '''         public Collection&lt;Auctions&gt; GetAuctionsForRealm(string realm) {
    '''             AuctionData auctions = new AuctionData();
    '''             auctions.Options.Realm = realm;
    '''             auctions.Load();
    '''             return auctions.Auctions;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Auction
    ''' 
    ''' Namespace AuctionExample
    ''' 
    '''     Public Class AuctionClass
    ''' 
    '''         Public Function GetAuctionsForRealm(realm As String) As Collection(Of Auctions)
    '''             Dim auctions As New AuctionData()
    '''             auctions.Options.Realm = realm
    '''             auctions.Load()
    '''             Return auctions.Auctions
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class AuctionData
        Inherits WowAPIData

        Private aAuctions As New Schema.auctions

#Region "WowAPIData Overrides"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 15 minutes for auction data.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 15 minutes for auction data.</returns>
        ''' <remarks>The CacheLength is a <see cref="System.TimeSpan" /> that determines how long an API request should be stored in the cache.  The default can be changed at any time before the <see cref="AuctionData.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(0, 15, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.AuctionData.{0}.{1:yyyyMMddHHmmss}", Options.Realm, Options.LastModified)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return Options.URI
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' Loads the auction data.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of LibWowAPI.Auction.Auctions)" /> of <see cref="LibWowAPI.Auction.Auctions" />.  Each item in the collection represents data received from one auction data file from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            Dim afFiles As New AuctionFiles()
            afFiles.CacheLength = CacheLength
            afFiles.IfModifiedSince = IfModifiedSince
            afFiles.Options.Realm = Options.Realm
            afFiles.Load()

            colAuctions = New Collection(Of Auctions)
            For Each fFile In afFiles.Files
                Options.URI = fFile.URI
                Options.LastModified = fFile.LastModified

                Dim tsCacheLength As TimeSpan = CacheLength
                CacheLength = New TimeSpan(3, 0, 0)
                MyBase.Retrieve()
                If Modified.HasValue AndAlso Not Modified Then
                    Return
                End If
                Try
                    Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                        aAuctions = CType(New DataContractJsonSerializer(GetType(Schema.auctions)).ReadObject(msJSON), Schema.auctions)
                    End Using
                Catch sex As SerializationException
                    Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
                End Try

                CacheLength = tsCacheLength

                colAuctions.Add(
                    New Auctions(
                        New Realm(aAuctions.realm.name, aAuctions.realm.slug),
                        fFile.LastModified,
                        New AuctionHouse(
                            (
                                From a In aAuctions.alliance.auctions
                                Select New Auction(a.auc, a.item, a.owner, a.bid, a.buyout, a.quantity, a.timeLeft.GetAuctionTimeLeft())
                                ).ToCollection()
                            ),
                        New AuctionHouse(
                            (
                                From a In aAuctions.horde.auctions
                                Select New Auction(a.auc, a.item, a.owner, a.bid, a.buyout, a.quantity, a.timeLeft.GetAuctionTimeLeft())
                                ).ToCollection()
                            ),
                        New AuctionHouse(
                            (
                                From a In aAuctions.neutral.auctions
                                Select New Auction(a.auc, a.item, a.owner, a.bid, a.buyout, a.quantity, a.timeLeft.GetAuctionTimeLeft())
                                ).ToCollection()
                            )
                        )
                    )
            Next
        End Sub

#End Region

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up auction data.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up auction data.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New AuctionDataOptions()

        Private colAuctions As Collection(Of Auctions)
        ''' <summary>
        ''' A list of sets of auction data as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Auctions field.</value>
        ''' <returns>Returns a list of sets of auction data as returned from the BLizzard WoW API.</returns>
        ''' <remarks>Each member of the collection represents a single <see cref="Auction" /> object.  Each object represents data received from a single file from the API.</remarks>
        Public ReadOnly Property Auctions As Collection(Of Auctions)
            Get
                Return colAuctions
            End Get
        End Property

#End Region

#Region "Constructors"

        ''' <summary>
        ''' A default constructor to retrieve auction information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="AuctionData" /> class.  You must set the <see cref="AuctionDataOptions.Realm" /> property of the <see cref="AuctionData.Options" /> property, and then call the <see cref="AuctionData.Load" /> method to load the auction data.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve auction information for a realm from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="strRealm">The realm to load auction data for.</param>
        ''' <remarks>This method creates a new instance of the <see cref="AuctionData" /> class and automatically loads the data for the specified realm.</remarks>
        Public Sub New(strRealm As String)
            Options.Realm = strRealm
            Load()
        End Sub

#End Region

    End Class

End Namespace
