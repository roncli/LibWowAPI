' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about a weapon.
    ''' </summary>
    ''' <remarks>This contains details about the damage that a weapon can do.</remarks>
    Public Class WeaponInfo

        Private colDamage As Collection(Of Damage)
        ''' <summary>
        ''' The amounts of damage this weapon can do.
        ''' </summary>
        ''' <value>This property gets the Damage field.</value>
        ''' <returns>Returns the amounts of damage this weapon can do.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Damage)" /> of <see cref="Damage" /> that contains a list of damages that this weapon can do.</remarks>
        Public ReadOnly Property Damage As Collection(Of Damage)
            Get
                Return colDamage
            End Get
        End Property

        ''' <summary>
        ''' The weapon's swing time in seconds.
        ''' </summary>
        ''' <value>This property gets or sets the WeaponSpeed field.</value>
        ''' <returns>Returns the weapon's swing time in seconds.</returns>
        ''' <remarks>This represents the weapon's swing time in seconds.</remarks>
        Public Property WeaponSpeed As Double

        ''' <summary>
        ''' The weapon's base damage per second.
        ''' </summary>
        ''' <value>This property gets or sets the DPS field.</value>
        ''' <returns>Returns the weapon's base damage per second.</returns>
        ''' <remarks>This represents the weapon's base damage per second.</remarks>
        Public Property DPS As Double

        Friend Sub New(dDamage As Collection(Of Damage), dblWeaponSpeed As Double, dblDPS As Double)
            colDamage = dDamage
            WeaponSpeed = dblWeaponSpeed
            DPS = dblDPS
        End Sub

    End Class

End Namespace
