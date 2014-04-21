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

        Public Property Slot As Integer

        Public Property Order As Integer

        Public Property RequiredLevel As Integer

        Public Sub New(intSlot As Integer, intOrder As Integer, intRequiredLevel As Integer, intID As Integer, strName As String, strIcon As String, intCooldown As Integer, intRounds As Integer, ptPetType As PetType, blnIsPassive As Boolean, blnHideHints As Boolean)
            MyBase.New(intID, strName, strIcon, intCooldown, intRounds, ptPetType, blnIsPassive, blnHideHints)
            Slot = intSlot
            Order = intOrder
            RequiredLevel = intRequiredLevel
        End Sub

    End Class

End Namespace
