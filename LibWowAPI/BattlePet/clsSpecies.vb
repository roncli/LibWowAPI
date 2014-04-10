' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.BattlePet

    Public Class Species

        ''' <summary>
        ''' The ID number of the species.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the species.</returns>
        ''' <remarks>Each species has a unique ID number that is used to identify the species.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The ID number of the pet type.
        ''' </summary>
        ''' <value>This property gets or sets the PetTypeID field.</value>
        ''' <returns>Returns the ID number of the pet type.</returns>
        ''' <remarks>The pet type can be determined by matching this field to the <see="" /> field of the <see="" /> class.</remarks>
        Public Property PetTypeID As Integer

        ''' <summary>
        ''' The ID number of the creature.
        ''' </summary>
        ''' <value>This property gets or sets the CreatureID field.</value>
        ''' <returns>Returns the ID number of the creature.</returns>
        ''' <remarks>This represents the ID number of the creature.</remarks>
        Public Property CreatureID As Integer

        ''' <summary>
        ''' The name of the species.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the species.</returns>
        ''' <remarks>This is the localized name of the species.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Determines whether this species can do battle.
        ''' </summary>
        ''' <value>This property gets or sets the CanBattle field.</value>
        ''' <returns>Returns whether this species can do battle.</returns>
        ''' <remarks>This determins whether this species can do battle.</remarks>
        Public Property CanBattle As Boolean

        ''' <summary>
        ''' A path leading to the species's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the species's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The description of the species.
        ''' </summary>
        ''' <value>This property gets or sets the Description field.</value>
        ''' <returns>Returns the description of the species.</returns>
        ''' <remarks>This represents the description of the species.</remarks>
        Public Property Description As String

        ''' <summary>
        ''' The source of the species.
        ''' </summary>
        ''' <value>This property gets or sets the Source field.</value>
        ''' <returns>Returns the source of the species.</returns>
        ''' <remarks>This represents the source of the species.</remarks>
        Public Property Source As String

        Private colAbilities As New Collection(Of SpeciesAbility)
        ''' <summary>
        ''' The abilities this species can use.
        ''' </summary>
        ''' <value>This property gets the Abilities field.</value>
        ''' <returns>Returns the abilities this species can use.</returns>
        ''' <remarks>This is a <see cref="Collection(Of SpeciesAbility)" /> of <see cref="SpeciesAbility" /> that represents the abilities this species can use.</remarks>
        Public ReadOnly Property Abilities As Collection(Of SpeciesAbility)
            Get
                Return colAbilities
            End Get
        End Property

        Public Sub New(intID As Integer, intPetTypeID As Integer, intCreatureID As Integer, strName As String, blnCanBattle As Boolean, strIcon As String, strDescription As String, strSource As String, saAbilities As Collection(Of SpeciesAbility))
            ID = intID
            PetTypeID = intPetTypeID
            CreatureID = intCreatureID
            Name = strName
            CanBattle = blnCanBattle
            Icon = strIcon
            Description = strDescription
            Source = strSource
            colAbilities = saAbilities
        End Sub

    End Class

End Namespace
