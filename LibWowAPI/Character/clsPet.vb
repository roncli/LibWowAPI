' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a combat pet.
    ''' </summary>
    ''' <remarks>Combat pets will only be returned for hunters.</remarks>
    Public Class Pet

        ''' <summary>
        ''' The name of the combat pet.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the combat pet.</returns>
        ''' <remarks>This property is the name given to the pet by the owner.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The ID number of the NPC.
        ''' </summary>
        ''' <value>This property gets or sets the Creature field.</value>
        ''' <returns>Returns the ID number of the NPC.</returns>
        ''' <remarks>Pets are tamed from NPCs in the game world.  This number represents the ID number of the NPC that was tamed.</remarks>
        Public Property Creature As Integer

        ''' <summary>
        ''' Determines if the current combat pet is the character's active pet.
        ''' </summary>
        ''' <value>This property gets or sets the Selected field.</value>
        ''' <returns>Returns a boolean that determins if the current combat pet is the character's active pet.</returns>
        ''' <remarks>This determines if the current combat pet is the character's active pet.</remarks>
        Public Property Selected As Boolean

        ''' <summary>
        ''' The ID number of the slot the combat pet is using.
        ''' </summary>
        ''' <value>This property gets or sets the Slot field.</value>
        ''' <returns>Returns the ID number of the slot the combat pet is using.</returns>
        ''' <remarks>Hunters have a fixed number of slots in which to store pets.  This field represents which slot this pet uses.</remarks>
        Public Property Slot As Integer

        ''' <summary>
        ''' The pet's talent spec.
        ''' </summary>
        ''' <value>This property gets or sets the Talents field.</value>
        ''' <returns>Returns the pet's talent spec.</returns>
        ''' <remarks>This represents the pet's talent spec.  This is only available if the <see cref="Selected" /> property is true.</remarks>
        Public Property Talents As Talent

        Friend Sub New(strName As String, intCreature As Integer, blnSelected As Boolean, intSlot As Integer, tTalents As Talent)
            Name = strName
            Creature = intCreature
            Selected = blnSelected
            Slot = intSlot
            Talents = tTalents
        End Sub

    End Class

End Namespace
