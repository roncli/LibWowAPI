' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.BattlePet

    ''' <summary>
    ''' A class containing information about a battle pet's stats.
    ''' </summary>
    ''' <remarks>This class contains information about a battle pet's stats.</remarks>
    Public Class Stats

        ''' <summary>
        ''' The ID number of the species.
        ''' </summary>
        ''' <value>This property gets or sets the SpeeciesID field.</value>
        ''' <returns>Returns the ID number of the species.</returns>
        ''' <remarks>Each species has a unique ID number that is used to identify the species.</remarks>
        Public Property SpeciesID As Integer

        ''' <summary>
        ''' The breed of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the Breed field.</value>
        ''' <returns>Returns the breed of the pet.</returns>
        ''' <remarks>This represents the breed of the pet.</remarks>
        Public Property Breed As BattlePetBreed

        ''' <summary>
        ''' The gender of the pet.
        ''' </summary>
        ''' <value>This property gets the Gender field.</value>
        ''' <returns>Returns the gender of the pet.</returns>
        ''' <remarks>This represents the gender of the pet.</remarks>
        Public ReadOnly Property Gender As Gender
            Get
                If Breed >= 3 And Breed <= 12 Then
                    Return Gender.Male
                ElseIf Breed >= 13 And Breed <= 22 Then
                    Return Gender.Female
                Else
                    Return Gender.Unknown
                End If
            End Get
        End Property

        ''' <summary>
        ''' The quality of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the PetQuality field.</value>
        ''' <returns>Returns the quality of the pet.</returns>
        ''' <remarks>This represents the quality of the pet.</remarks>
        Public Property PetQuality As Quality

        ''' <summary>
        ''' The level of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the Level field.</value>
        ''' <returns>Returns the level of the pet.</returns>
        ''' <remarks>This represents the level of the pet.</remarks>
        Public Property Level As Integer

        ''' <summary>
        ''' The health of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the Health field.</value>
        ''' <returns>Returns the health of the pet.</returns>
        ''' <remarks>This represents the health of the pet.</remarks>
        Public Property Health As Integer

        ''' <summary>
        ''' The power of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the Power field.</value>
        ''' <returns>Returns the power of the pet.</returns>
        ''' <remarks>This represents the power of the pet.</remarks>
        Public Property Power As Integer

        ''' <summary>
        ''' The speed of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the Speed field.</value>
        ''' <returns>Returns the speed of the pet.</returns>
        ''' <remarks>This represents the speed of the pet.</remarks>
        Public Property Speed As Integer

        Public Sub New(intSpeciesID As Integer, bpbBreed As BattlePetBreed, qPetQuality As Quality, intLevel As Integer, intHealth As Integer, intPower As Integer, intSpeed As Integer)
            SpeciesID = intSpeciesID
            Breed = bpbBreed
            PetQuality = qPetQuality
            Level = intLevel
            Health = intHealth
            Power = intPower
            Speed = intSpeed
        End Sub

    End Class

End Namespace
