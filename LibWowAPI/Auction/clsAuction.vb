' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Auction

    ''' <summary>
    ''' A class containing information about a single auction.
    ''' </summary>
    ''' <remarks>The information contained in this class defines a single auction on the auction house at the time the data was collected.</remarks>
    Public Class Auction

        ''' <summary>
        ''' The ID number of the auction.
        ''' </summary>
        ''' <value>This property gets or sets the AuctionID field.</value>
        ''' <returns>Returns the ID number of the auction.</returns>
        ''' <remarks>This number remains constant over the course of the auction, and it is believed to be unique per realm.  This makes it easy to track an auction over time.</remarks>
        Public Property AuctionID As Long

        ''' <summary>
        ''' The ID number of the item being auctioned.
        ''' </summary>
        ''' <value>This property gets or sets the ItemID field.</value>
        ''' <returns>Returns the ID number of the item being auctioned.</returns>
        ''' <remarks>The item ID represents the item that is being auctioned.  To find out more information about the item, pass it as an option to the <see cref="Item.ItemLookup" /> class.</remarks>
        Public Property ItemID As Integer

        ''' <summary>
        ''' The name of the character who created the auction.
        ''' </summary>
        ''' <value>This property gets or sets the Owner field.</value>
        ''' <returns>Returns the name of the character who created the auction.</returns>
        ''' <remarks>If for whatever reason the owner is unknown, this will return a string of 3 question marks "???".</remarks>
        Public Property Owner As String

        ''' <summary>
        ''' The realm of the character who created the auction.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm of the character who created the auction.</returns>
        ''' <remarks>If for whatever reason the owner is unknown, this will return a string of 3 question marks "???".</remarks>
        Public Property OwnerRealm As String

        ''' <summary>
        ''' The auction's current bid in copper.
        ''' </summary>
        ''' <value>This property gets or sets the Bid field.</value>
        ''' <returns>Returns the auction's current bid in copper.</returns>
        ''' <remarks>The bid amount is returned in copper.  The amount represents the bid for the entire lot.  This will reflect either the minimum bid if the auction has not had a bid yet, or the current bid if the auction does have a bid.  There is no way to tell which is the case by looking at a single record, but if you track the auction over time and see the bid amount increase, you will know that there are bids on the item.</remarks>
        Public Property Bid As Long

        ''' <summary>
        ''' The auction's buyout value in copper.
        ''' </summary>
        ''' <value>This property gets or sets the Buyout field.</value>
        ''' <returns>Returns the auction's buyout value in copper.</returns>
        ''' <remarks>The buyout amount is returned in copper.  The amount represents the buyout for the entire lot.</remarks>
        Public Property Buyout As Long

        ''' <summary>
        ''' The amount of the item in the auction.
        ''' </summary>
        ''' <value>This property gets or sets the Quantity field.</value>
        ''' <returns>Returns the amount of the item in the auction.</returns>
        ''' <remarks>This value represents how many of an item are in the auction lot.</remarks>
        Public Property Quantity As Integer

        ''' <summary>
        ''' The auction's estimated time left.
        ''' </summary>
        ''' <value>This property gets or sets the TimeLeft field.</value>
        ''' <returns>Returns the auction's estimated time left.</returns>
        ''' <remarks>This property is an <see cref="Enums.AuctionTimeLeft" /> enumeration that represents the estimated amount of time left before the auction expires.</remarks>
        Public Property TimeLeft As AuctionTimeLeft

        ''' <summary>
        ''' The item's Suffix ID.
        ''' </summary>
        ''' <value>This property gets or sets the SuffixID field.</value>
        ''' <returns>Returns the item's Suffix ID.</returns>
        ''' <remarks>This value represents the random enchantment on the item, or 0 if there is no random enchantment.</remarks>
        Public Property SuffixID As Integer

        ''' <summary>
        ''' The item's Unique ID.
        ''' </summary>
        ''' <value>This property gets or sets the UniqueID field.</value>
        ''' <returns>Returns the item's Unique ID.</returns>
        ''' <remarks>This value contains information about the specific instance of the item.  Note that despite the name of the field, this field is not truly unique, and can have repeated values.</remarks>
        Public Property UniqueID As Long

        ''' <summary>
        ''' The item's pet species ID.
        ''' </summary>
        ''' <value>This property gets or sets the PetSpeciesID field.</value>
        ''' <returns>Returns the item's pet species ID.</returns>
        ''' <remarks>If the item being auctioned is not a pet, this will return 0.</remarks>
        Public Property PetSpeciesID As Integer

        ''' <summary>
        ''' The item's pet breed.
        ''' </summary>
        ''' <value>This property gets or sets the PetBreed field.</value>
        ''' <returns>Returns the item's pet breed.</returns>
        ''' <remarks>If the item being auctioned is not a pet, this will return <see cref="BattlePetBreed.Unknown" />.</remarks>
        Public Property PetBreed As BattlePetBreed

        ''' <summary>
        ''' The item's pet level.
        ''' </summary>
        ''' <value>This property gets or sets the PetLevel field.</value>
        ''' <returns>Returns the item's pet level.</returns>
        ''' <remarks>If the item being auctioned is not a pet, this will return 0.</remarks>
        Public Property PetLevel As Integer

        ''' <summary>
        ''' The item's pet quality.
        ''' </summary>
        ''' <value>This property gets or sets the PetQuality field.</value>
        ''' <returns>Returns the item's pet quality.</returns>
        ''' <remarks>If the item being auctioned is not a pet, this will return <see cref="Quality.Unknown" />.</remarks>
        Public Property PetQuality As Quality

        Friend Sub New(lngAuctionID As Long, intItemID As Integer, strOwner As String, strOwnerRealm As String, lngBid As Long, lngBuyout As Long, intQuantity As Integer, atlTimeLeft As AuctionTimeLeft, intSuffixID As Integer, intUniqueID As Long, intPetSpeciesID As Integer, bpbPetBreed As BattlePetBreed, intPetLevel As Integer, qPetQuality As Quality)
            AuctionID = lngAuctionID
            ItemID = intItemID
            Owner = strOwner
            OwnerRealm = strOwnerRealm
            Bid = lngBid
            Buyout = lngBuyout
            Quantity = intQuantity
            TimeLeft = atlTimeLeft
            SuffixID = intSuffixID
            UniqueID = intUniqueID
            PetSpeciesID = intPetSpeciesID
            PetBreed = bpbPetBreed
            PetLevel = intPetLevel
            PetQuality = qPetQuality
        End Sub

    End Class

End Namespace
