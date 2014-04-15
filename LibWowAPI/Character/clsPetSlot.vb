' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's battle pet slot.
    ''' </summary>
    ''' <remarks>The data contained within this class contains information about a character's battle pet slot.</remarks>
    Public Class PetSlot

        ''' <summary>
        ''' The slot the battle pet is in.
        ''' </summary>
        ''' <value>This property gets or sets the Slot field.</value>
        ''' <returns>Returns the slot the battle pet is in.</returns>
        ''' <remarks>This represents the slot the battle pet is in.</remarks>
        Public Property Slot As Integer

        ''' <summary>
        ''' The pet's GUID.
        ''' </summary>
        ''' <value>This property gets or sets the BattlePetGuid field.</value>
        ''' <returns>Returns the pet's GUID.</returns>
        ''' <remarks>This is an internal identifier used by Blizzard to identify a pet.</remarks>
        Public Property BattlePetGuid As String

        ''' <summary>
        ''' Determines if the slot is empty.
        ''' </summary>
        ''' <value>This property gets or sets the IsEmpty field.</value>
        ''' <returns>Returns whether the slot if empty.</returns>
        ''' <remarks>This determines if the slot is empty.</remarks>
        Public Property IsEmpty As Boolean

        ''' <summary>
        ''' Determines if the slot is locked.
        ''' </summary>
        ''' <value>This property gets or sets the IsLocked field.</value>
        ''' <returns>Returns whether the slot if locked.</returns>
        ''' <remarks>This determines if the slot is locked.</remarks>
        Public Property IsLocked As Boolean

        Private colAbilities As Collection(Of Integer)
        ''' <summary>
        ''' The ability IDs the pet has.
        ''' </summary>
        ''' <value>This property gets or sets the Abilities field.</value>
        ''' <returns>Returns the ability IDs the pet has.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Integer)" /> of ability IDs the pet has.</remarks>
        Public ReadOnly Property Abilites As Collection(Of Integer)
            Get
                Return colAbilities
            End Get
        End Property

        Friend Sub New(intSlot As Integer, strBattlePetGuid As String, blnIsEmpty As Boolean, blnIsLocked As Boolean, intAbilities As Collection(Of Integer))
            Slot = intSlot
            BattlePetGuid = strBattlePetGuid
            IsEmpty = blnIsEmpty
            IsLocked = blnIsLocked
            colAbilities = intAbilities
        End Sub

    End Class

End Namespace
