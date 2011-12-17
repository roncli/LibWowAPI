' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about a spell used by an item.
    ''' </summary>
    ''' <remarks>This class contains details about the spell used by an item.</remarks>
    Public Class ItemSpell

        ''' <summary>
        ''' The spell ID number.
        ''' </summary>
        ''' <value>This property gets or sets the SpellID field.</value>
        ''' <returns>Returns the spell ID number.</returns>
        ''' <remarks>Each spell has a unique ID number that is used to identify it.</remarks>
        Public Property SpellID As Integer

        ''' <summary>
        ''' The spell details.
        ''' </summary>
        ''' <value>This property gets or sets the Spell field.</value>
        ''' <returns>Returns the spell details.</returns>
        ''' <remarks>This is a <see cref="Spell" /> object that contains further details about the spell.</remarks>
        Public Property Spell As Spell

        ''' <summary>
        ''' The number of charges available.
        ''' </summary>
        ''' <value>This property gets or sets the Charges field.</value>
        ''' <returns>Returns the number of charges available.</returns>
        ''' <remarks>Returns 0 if the item doesn't use charges.</remarks>
        Public Property Charges As Integer

        ''' <summary>
        ''' Determines whether the spell is consumed on cast.
        ''' </summary>
        ''' <value>This property gets or sets the Consumable field.</value>
        ''' <returns>Returns a boolean that determines whether the spell is consumed on cast.</returns>
        ''' <remarks>This determines whether the spell is consumed on cast.</remarks>
        Public Property Consumable As Boolean

        ''' <summary>
        ''' The spell category ID number.
        ''' </summary>
        ''' <value>This property gets or sets the CategoryID field.</value>
        ''' <returns>Returns the spell category ID number.</returns>
        ''' <remarks>This represents the spell category ID number.</remarks>
        Public Property CategoryID As Integer

        Friend Sub New(intSpellID As Integer, sSpell As Spell, intCharges As Integer, blnConsumable As Boolean, intCategoryID As Integer)
            SpellID = intSpellID
            Spell = sSpell
            Charges = intCharges
            Consumable = blnConsumable
            CategoryID = intCategoryID
        End Sub

    End Class

End Namespace
