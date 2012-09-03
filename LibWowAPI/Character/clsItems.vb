' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's equipped items.
    ''' </summary>
    ''' <remarks>This class includes average item levels as well as each item equipped by the character.</remarks>
    Public Class Items

        ''' <summary>
        ''' The average item level of the character's top gear.
        ''' </summary>
        ''' <value>This property gets or sets the AverageItemLevel field.</value>
        ''' <returns>Returns the average item level of the character's top gear.</returns>
        ''' <remarks>The average item level includes all of the character's gear, including gear in the inventory of the bank.</remarks>
        Public Property AverageItemLevel As Integer

        ''' <summary>
        ''' The average item level of the character's currently equipped gear.
        ''' </summary>
        ''' <value>This property gets or sets the AverageItemLevelEquipped field.</value>
        ''' <returns>Returns the average item level of the character's currently equipped gear.</returns>
        ''' <remarks>This property only considers the currently equipped gear when calculating the average item level.</remarks>
        Public Property AverageItemLevelEquipped As Integer

        ''' <summary>
        ''' The item on the character's head.
        ''' </summary>
        ''' <value>This property gets or sets the Head field.</value>
        ''' <returns>Returns the item on the character's head.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Head As Item

        ''' <summary>
        ''' The item around the character's neck.
        ''' </summary>
        ''' <value>This property gets or sets the Neck field.</value>
        ''' <returns>Returns the item on the character's neck.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Neck As Item

        ''' <summary>
        ''' The item on the character's shoulders.
        ''' </summary>
        ''' <value>This property gets or sets the Shoulder field.</value>
        ''' <returns>Returns the item on the character's shoulders.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Shoulder As Item

        ''' <summary>
        ''' The item on the character's back.
        ''' </summary>
        ''' <value>This property gets or sets the Back field.</value>
        ''' <returns>Returns the item on the character's back.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Back As Item

        ''' <summary>
        ''' The item on the character's chest.
        ''' </summary>
        ''' <value>This property gets or sets the Chest field.</value>
        ''' <returns>Returns the item on the character's chest.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Chest As Item

        ''' <summary>
        ''' The shirt the character is wearing.
        ''' </summary>
        ''' <value>This property gets or sets the Shirt field.</value>
        ''' <returns>Returns the shirt the character is wearing.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Shirt As Item

        ''' <summary>
        ''' The tabard the character is wearing.
        ''' </summary>
        ''' <value>This property gets or sets the Tabard field.</value>
        ''' <returns>Returns the tabard the character is wearing.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Tabard As Item

        ''' <summary>
        ''' The item on the character's wrists.
        ''' </summary>
        ''' <value>This property gets or sets the Wrist field.</value>
        ''' <returns>Returns the item on the character's wrists.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Wrist As Item

        ''' <summary>
        ''' The item on the character's hands.
        ''' </summary>
        ''' <value>This property gets or sets the Hands field.</value>
        ''' <returns>Returns the item on the character's hands.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Hands As Item

        ''' <summary>
        ''' The item around the character's waist.
        ''' </summary>
        ''' <value>This property gets or sets the Waist field.</value>
        ''' <returns>Returns the item on the character's waist.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Waist As Item

        ''' <summary>
        ''' The item on the character's legs.
        ''' </summary>
        ''' <value>This property gets or sets the Legs field.</value>
        ''' <returns>Returns the item on the character's legs.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Legs As Item

        ''' <summary>
        ''' The item on the character's feet.
        ''' </summary>
        ''' <value>This property gets or sets the Feet field.</value>
        ''' <returns>Returns the item on the character's feet.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Feet As Item

        ''' <summary>
        ''' The item on the character's first finger.
        ''' </summary>
        ''' <value>This property gets or sets the Finger1 field.</value>
        ''' <returns>Returns the item on the character's first finger.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Finger1 As Item

        ''' <summary>
        ''' The item on the character's second finger.
        ''' </summary>
        ''' <value>This property gets or sets the Finger2 field.</value>
        ''' <returns>Returns the item on the character's second finger.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Finger2 As Item

        ''' <summary>
        ''' The character's first equipped trinket.
        ''' </summary>
        ''' <value>This property gets or sets the Trinket1 field.</value>
        ''' <returns>Returns the character's first equipped trinket.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Trinket1 As Item

        ''' <summary>
        ''' The character's second equipped trinket.
        ''' </summary>
        ''' <value>This property gets or sets the Trinket2 field.</value>
        ''' <returns>Returns the character's second equipped trinket.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property Trinket2 As Item

        ''' <summary>
        ''' The item equipped in the character's main hand.
        ''' </summary>
        ''' <value>This property gets or sets the MainHand field.</value>
        ''' <returns>Returns the item equipped in the character's main hand.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property MainHand As Item

        ''' <summary>
        ''' The item equipped in the character's off hand.
        ''' </summary>
        ''' <value>This property gets or sets the OffHand field.</value>
        ''' <returns>Returns the item equipped in the character's off hand.</returns>
        ''' <remarks>This is an <see cref="Item" /> object that contains details about the item.</remarks>
        Public Property OffHand As Item

        Friend Sub New(intAverageItemLevel As Integer, intAverageItemLevelEquipped As Integer, iHead As Item, iNeck As Item, iShoulder As Item, iBack As Item, iChest As Item, iShirt As Item, iTabard As Item, iWrist As Item, iHands As Item, iWaist As Item, iLegs As Item, iFeet As Item, iFinger1 As Item, iFinger2 As Item, iTrinket1 As Item, iTrinket2 As Item, iMainHand As Item, iOffHand As Item)
            AverageItemLevel = intAverageItemLevel
            AverageItemLevelEquipped = intAverageItemLevelEquipped
            Head = iHead
            Neck = iNeck
            Shoulder = iShoulder
            Back = iBack
            Chest = iChest
            Shirt = iShirt
            Tabard = iTabard
            Wrist = iWrist
            Hands = iHands
            Waist = iWaist
            Legs = iLegs
            Feet = iFeet
            Finger1 = iFinger1
            Finger2 = iFinger2
            Trinket1 = iTrinket1
            Trinket2 = iTrinket2
            MainHand = iMainHand
            OffHand = iOffHand
        End Sub

    End Class

End Namespace
