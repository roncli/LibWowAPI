' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Data.PetTypes

    ''' <summary>
    ''' A class containing information about a pet type.
    ''' </summary>
    ''' <remarks>This contains basic information about a pet type.</remarks>
    Public Class PetType

        ''' <summary>
        ''' The ID number of the pet type.
        ''' </summary>
        ''' <value>This property gets or sets the PetTypeID field.</value>
        ''' <returns>Returns the ID number of the pet type.</returns>
        ''' <remarks>This represents the ID number of the pet type.</remarks>
        Public Property PetTypeID As Integer

        ''' <summary>
        ''' The pet type's key.
        ''' </summary>
        ''' <value>This property gets or sets the Key field.</value>
        ''' <returns>Returns the pet type's key.</returns>
        ''' <remarks>This is Blizzard's internal representation of the pet type.</remarks>
        Public Property Key As String

        ''' <summary>
        ''' The pet type's name.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the pet type's name.</returns>
        ''' <remarks>This represents the localized name of the pet type.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The pet type's ability.
        ''' </summary>
        ''' <value>This property gets or sets the TypeAbilityID field.</value>
        ''' <returns>Returns the pet type's ability.</returns>
        ''' <remarks>You may get more information about this ability by using this ID number as a parameter to the <see cref="BattlePet.BattlePetAbility" /> class.</remarks>
        Public Property TypeAbilityID As Integer

        ''' <summary>
        ''' The pet type this pet type is strong against.
        ''' </summary>
        ''' <value>This property gets or sets the StrongAgainstID field.</value>
        ''' <returns>Returns the pet type this pet type is strong against.</returns>
        ''' <remarks>This represents the pet type this pet type is strong against.</remarks>
        Public Property StrongAgainstID As Integer

        ''' <summary>
        ''' The pet type this pet type is weak against.
        ''' </summary>
        ''' <value>This property gets or sets the WeakAgainstID field.</value>
        ''' <returns>Returns the pet type this pet type is weak against.</returns>
        ''' <remarks>This represents the pet type this pet type is weak against.</remarks>
        Public Property WeakAgainstID As Integer

        Friend Sub New(intPetTypeID As Integer, strKey As String, strName As String, intTypeAbilityID As Integer, intStrongAgainstID As Integer, intWeakAgainstID As Integer)
            PetTypeID = intPetTypeID
            Key = strKey
            Name = strName
            TypeAbilityID = intTypeAbilityID
            StrongAgainstID = intStrongAgainstID
            WeakAgainstID = intWeakAgainstID
        End Sub

    End Class

End Namespace
