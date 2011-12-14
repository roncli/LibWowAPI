' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a specific instance of an item.
    ''' </summary>
    ''' <remarks>Individual items can have unique gemmings, enchantments, reforgings, and random enchantments.  This class contains this information.</remarks>
    Public Class TooltipParams

        Private colGems As Collection(Of Integer)
        ''' <summary>
        ''' A list of item IDs representing the item's socketed gems.
        ''' </summary>
        ''' <value>This property gets the Gems field.</value>
        ''' <returns>Returns a list of item IDs representing the item's socketed gems.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Integer)" /> of item IDs that represent the gem that is socketed.  Use the ID with the <see cref="LibWowAPI.Item.ItemLookup" /> class to learn more details about the gem.</remarks>
        Public ReadOnly Property Gems As Collection(Of Integer)
            Get
                Return colGems
            End Get
        End Property

        ''' <summary>
        ''' The ID number of the item's random enchantment.
        ''' </summary>
        ''' <value>This property gets or sets the Suffix field.</value>
        ''' <returns>Returns the ID number of the item's random enchantment.</returns>
        ''' <remarks>Each random enchantment has an ID number.  However, there is currently no method of figuring out what the random enchantment is from the ID number.</remarks>
        Public Property Suffix As Integer

        ''' <summary>
        ''' The random seed.
        ''' </summary>
        ''' <value>This property gets or sets the Seed field.</value>
        ''' <returns>Returns the random seed.</returns>
        ''' <remarks>Likely used internally by Blizzard to determine what the suffix should be.</remarks>
        Public Property Seed As Integer

        ''' <summary>
        ''' The ID number of the effect of the item enchantment.
        ''' </summary>
        ''' <value>This property gets or sets the Enchant field.</value>
        ''' <returns>Returns the ID number of the effect of the item enchantment.</returns>
        ''' <remarks>Each item enchantment has an ID number.  However, there is currently no method of figuring out what the item enchantment is from the ID number.</remarks>
        Public Property Enchant As Integer

        ''' <summary>
        ''' Indicates whether the item has an extra gem socket.
        ''' </summary>
        ''' <value>This property gets or sets the ExtraSocket field.</value>
        ''' <returns>Returns a boolean that indicates whether the item has an extra gem socket.</returns>
        ''' <remarks>Blacksmiths can make belt buckles that can give belts an extra gem socket.  Additionally, blacksmiths can modify bracers and gloves to include an extra gem socket as well.</remarks>
        Public Property ExtraSocket As Boolean

        Private colSet As Collection(Of Integer)
        ''' <summary>
        ''' A list containing the ID numbers of the other items in the same set as this item that the character has equipped.
        ''' </summary>
        ''' <value>This property gets the Set field.</value>
        ''' <returns>Returns a list containing the ID numbers of the other items in the same set as this item that the character has equipped.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Integer)" /> of item IDs that indicate what other items the character has equipped that are part of the same item set.</remarks>
        Public ReadOnly Property [Set] As Collection(Of Integer)
            Get
                Return colSet
            End Get
        End Property

        ''' <summary>
        ''' The ID number of the reforging done on this item.
        ''' </summary>
        ''' <value>This property gets or sets the Reforge field.</value>
        ''' <returns>Returns the ID number of the reforging done on this item.</returns>
        ''' <remarks>Each reforging has an ID number.  However, there is currently no method of figuring out what the reforging is from the ID number.</remarks>
        Public Property Reforge As Integer

        ''' <summary>
        ''' The ID number of the item this item is transmogrified into.
        ''' </summary>
        ''' <value>This property gets or sets the TransmogItem field.</value>
        ''' <returns>Returns the ID number of the item this item is transmogrified into.</returns>
        ''' <remarks>This is the ID number of the item this item is transmogrified into.</remarks>
        Public Property TransmogItem As Integer

        Friend Sub New(intGems As Collection(Of Integer), intSuffix As Integer, intSeed As Integer, intEnchant As Integer, blnExtraSocket As Boolean, intSet As Collection(Of Integer), intReforge As Integer, intTransmogItem As Integer)
            colGems = intGems
            Suffix = intSuffix
            Seed = intSeed
            Enchant = intEnchant
            ExtraSocket = blnExtraSocket
            colSet = intSet
            Reforge = intReforge
            TransmogItem = intTransmogItem
        End Sub

    End Class

End Namespace
