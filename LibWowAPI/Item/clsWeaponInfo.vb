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

        ''' <summary>
        ''' The amounts of damage this weapon can do.
        ''' </summary>
        ''' <value>This property gets the Damage field.</value>
        ''' <returns>Returns the amounts of damage this weapon can do.</returns>
        ''' <remarks>This represents the amounts of damage that this weapon can do.</remarks>
        Public Property Damage As Damage

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

        Friend Sub New(dDamage As Damage, dblWeaponSpeed As Double, dblDPS As Double)
            Damage = dDamage
            WeaponSpeed = dblWeaponSpeed
            DPS = dblDPS
        End Sub

    End Class

End Namespace
