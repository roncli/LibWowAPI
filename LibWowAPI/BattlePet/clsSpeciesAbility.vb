' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Data.PetTypes

Namespace roncliProductions.LibWowAPI.BattlePet

    ''' <summary>
    ''' A class containing information about a specific battle pet species's ability.
    ''' </summary>
    ''' <remarks>This class contains information about a specific battle pet species's ability.</remarks>
    Public Class SpeciesAbility
        Inherits Ability

        ''' <summary>
        ''' Gets the slot that the ability can be used in.
        ''' </summary>
        ''' <value>This property gets or sets the Slot field.</value>
        ''' <returns>Returns the slot that the ability can be used in.</returns>
        ''' <remarks>Each battle pet can only use one ability per availble slot, and each ability can only be used in only one specific slot.  This represents which slot the ability can be used in.</remarks>
        Public Property Slot As Integer

        ''' <summary>
        ''' Gets the order in which the ability is displayed.
        ''' </summary>
        ''' <value>This property gets or sets the Order field.</value>
        ''' <returns>Returns the order in which the ability is displayed.</returns>
        ''' <remarks>This represents the order in which the ability is displayed.</remarks>
        Public Property Order As Integer

        ''' <summary>
        ''' The level required for the species to use this ability.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredLevel field.</value>
        ''' <returns>Returns the level required for the species to use this ability.</returns>
        ''' <remarks>This represents the level required for the species to use this ability.</remarks>
        Public Property RequiredLevel As Integer

        Friend Sub New(intSlot As Integer, intOrder As Integer, intRequiredLevel As Integer, intID As Integer, strName As String, strIcon As String, intCooldown As Integer, intRounds As Integer, ptPetType As PetType, blnIsPassive As Boolean, blnHideHints As Boolean)
            MyBase.New(intID, strName, strIcon, intCooldown, intRounds, ptPetType, blnIsPassive, blnHideHints)
            Slot = intSlot
            Order = intOrder
            RequiredLevel = intRequiredLevel
        End Sub

    End Class

End Namespace
