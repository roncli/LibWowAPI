' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Item

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
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Head As ItemBasicInfo

        ''' <summary>
        ''' The item around the character's neck.
        ''' </summary>
        ''' <value>This property gets or sets the Neck field.</value>
        ''' <returns>Returns the item on the character's neck.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Neck As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's shoulders.
        ''' </summary>
        ''' <value>This property gets or sets the Shoulder field.</value>
        ''' <returns>Returns the item on the character's shoulders.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Shoulder As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's back.
        ''' </summary>
        ''' <value>This property gets or sets the Back field.</value>
        ''' <returns>Returns the item on the character's back.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Back As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's chest.
        ''' </summary>
        ''' <value>This property gets or sets the Chest field.</value>
        ''' <returns>Returns the item on the character's chest.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Chest As ItemBasicInfo

        ''' <summary>
        ''' The shirt the character is wearing.
        ''' </summary>
        ''' <value>This property gets or sets the Shirt field.</value>
        ''' <returns>Returns the shirt the character is wearing.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Shirt As ItemBasicInfo

        ''' <summary>
        ''' The tabard the character is wearing.
        ''' </summary>
        ''' <value>This property gets or sets the Tabard field.</value>
        ''' <returns>Returns the tabard the character is wearing.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Tabard As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's wrists.
        ''' </summary>
        ''' <value>This property gets or sets the Wrist field.</value>
        ''' <returns>Returns the item on the character's wrists.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Wrist As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's hands.
        ''' </summary>
        ''' <value>This property gets or sets the Hands field.</value>
        ''' <returns>Returns the item on the character's hands.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Hands As ItemBasicInfo

        ''' <summary>
        ''' The item around the character's waist.
        ''' </summary>
        ''' <value>This property gets or sets the Waist field.</value>
        ''' <returns>Returns the item on the character's waist.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Waist As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's legs.
        ''' </summary>
        ''' <value>This property gets or sets the Legs field.</value>
        ''' <returns>Returns the item on the character's legs.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Legs As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's feet.
        ''' </summary>
        ''' <value>This property gets or sets the Feet field.</value>
        ''' <returns>Returns the item on the character's feet.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Feet As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's first finger.
        ''' </summary>
        ''' <value>This property gets or sets the Finger1 field.</value>
        ''' <returns>Returns the item on the character's first finger.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Finger1 As ItemBasicInfo

        ''' <summary>
        ''' The item on the character's second finger.
        ''' </summary>
        ''' <value>This property gets or sets the Finger2 field.</value>
        ''' <returns>Returns the item on the character's second finger.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Finger2 As ItemBasicInfo

        ''' <summary>
        ''' The character's first equipped trinket.
        ''' </summary>
        ''' <value>This property gets or sets the Trinket1 field.</value>
        ''' <returns>Returns the character's first equipped trinket.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Trinket1 As ItemBasicInfo

        ''' <summary>
        ''' The character's second equipped trinket.
        ''' </summary>
        ''' <value>This property gets or sets the Trinket2 field.</value>
        ''' <returns>Returns the character's second equipped trinket.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property Trinket2 As ItemBasicInfo

        ''' <summary>
        ''' The item equipped in the character's main hand.
        ''' </summary>
        ''' <value>This property gets or sets the MainHand field.</value>
        ''' <returns>Returns the item equipped in the character's main hand.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property MainHand As ItemBasicInfo

        ''' <summary>
        ''' The item equipped in the character's off hand.
        ''' </summary>
        ''' <value>This property gets or sets the OffHand field.</value>
        ''' <returns>Returns the item equipped in the character's off hand.</returns>
        ''' <remarks>This is an <see cref="ItemBasicInfo" /> object that contains details about the item.</remarks>
        Public Property OffHand As ItemBasicInfo

        Friend Sub New(intAverageItemLevel As Integer, intAverageItemLevelEquipped As Integer, ibiHead As ItemBasicInfo, ibiNeck As ItemBasicInfo, ibiShoulder As ItemBasicInfo, ibiBack As ItemBasicInfo, ibiChest As ItemBasicInfo, ibiShirt As ItemBasicInfo, ibiTabard As ItemBasicInfo, ibiWrist As ItemBasicInfo, ibiHands As ItemBasicInfo, ibiWaist As ItemBasicInfo, ibiLegs As ItemBasicInfo, ibiFeet As ItemBasicInfo, ibiFinger1 As ItemBasicInfo, ibiFinger2 As ItemBasicInfo, ibiTrinket1 As ItemBasicInfo, ibiTrinket2 As ItemBasicInfo, ibiMainHand As ItemBasicInfo, ibiOffHand As ItemBasicInfo)
            AverageItemLevel = intAverageItemLevel
            AverageItemLevelEquipped = intAverageItemLevelEquipped
            Head = ibiHead
            Neck = ibiNeck
            Shoulder = ibiShoulder
            Back = ibiBack
            Chest = ibiChest
            Shirt = ibiShirt
            Tabard = ibiTabard
            Wrist = ibiWrist
            Hands = ibiHands
            Waist = ibiWaist
            Legs = ibiLegs
            Feet = ibiFeet
            Finger1 = ibiFinger1
            Finger2 = ibiFinger2
            Trinket1 = ibiTrinket1
            Trinket2 = ibiTrinket2
            MainHand = ibiMainHand
            OffHand = ibiOffHand
        End Sub

    End Class

End Namespace
