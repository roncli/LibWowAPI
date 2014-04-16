' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about equipment counts by equipment slot.
    ''' </summary>
    ''' <remarks>This is a general class that contains counts for each of a character's equipment slots.</remarks>
    Public Class EquipmentCount

        ''' <summary>
        ''' The equipment slot the count is for.
        ''' </summary>
        ''' <value>This property gets or sets the EquipmentSlot field.</value>
        ''' <returns>Returns the equipment slot the count is for.</returns>
        ''' <remarks>This is a <see cref="EquipmentSlot" /> enumeration that represents the equipment slot the count is for.</remarks>
        Public Property EquipmentSlot As EquipmentSlot

        ''' <summary>
        ''' The count on the equipment slot.
        ''' </summary>
        ''' <value>This property gets or sets the Count field.</value>
        ''' <returns>Returns the count on the equipment slot.</returns>
        ''' <remarks>This represents the count on the equipment slot.</remarks>
        Public Property Count As Integer

        Friend Sub New(esEquipmentSlot As EquipmentSlot, intCount As Integer)
            EquipmentSlot = esEquipmentSlot
            Count = intCount
        End Sub

    End Class

End Namespace
