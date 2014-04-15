' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.BattlePet

    ''' <summary>
    ''' A class containing information about a battle pet ability.
    ''' </summary>
    ''' <remarks>This class contains information about a battle pet ability.</remarks>
    Public Class Ability

        ''' <summary>
        ''' The ID number of the ability.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the ability.</returns>
        ''' <remarks>Each ability has a unique ID number that is used to identify the ability.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The name of the ability.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the ability.</returns>
        ''' <remarks>This is the localized name of the ability.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' A path leading to the ability's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the ability's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The number of rounds the skill will be on cooldown for once used.
        ''' </summary>
        ''' <value>This property gets or sets the Cooldown field.</value>
        ''' <returns>Returns the number of rounds the skill will be on cooldown for once used.</returns>
        ''' <remarks>This represents the number of rounds the skill will be on cooldown for once used.</remarks>
        Public Property Cooldown As Integer

        ''' <summary>
        ''' The number of rounds the skill remains active.
        ''' </summary>
        ''' <value>This property gets or sets the Rounds field.</value>
        ''' <returns>Returns the number of rounds the skill remains active.</returns>
        ''' <remarks>This represents the number of rounds the skill remains active.</remarks>
        Public Property Rounds As Integer

        ''' <summary>
        ''' The ID number of the pet type.
        ''' </summary>
        ''' <value>This property gets or sets the PetTypeID field.</value>
        ''' <returns>Returns the ID number of the pet type.</returns>
        ''' <remarks>The pet type can be determined by matching this field to the <see cref="Data.PetTypes.PetType.ID" /> field of the <see cref="Data.PetTypes.PetType" /> class.</remarks>
        Public Property PetTypeID As Integer

        ''' <summary>
        ''' Determines whether the ability is passive.
        ''' </summary>
        ''' <value>This property gets or sets the IsPassive field.</value>
        ''' <returns>Returns whether the ability is passive.</returns>
        ''' <remarks>This determines whether the ability is passive.</remarks>
        Public Property IsPassive As Boolean

        ''' <summary>
        ''' Determines whether to show the damage types a pet is strong or weak against in the tooltip.
        ''' </summary>
        ''' <value>This property gets or sets the HideHints field.</value>
        ''' <returns>Returns whether to show the damage types a pet is strong or weak against in the tooltip.</returns>
        ''' <remarks>This determines whether to show the damage types a pet is strong or weak against in the tooltip.</remarks>
        Public Property HideHints As Boolean

        Friend Sub New(intID As Integer, strName As String, strIcon As String, intCooldown As Integer, intRounds As Integer, intPetTypeID As Integer, blnIsPassive As Boolean, blnHideHints As Boolean)
            ID = intID
            Name = strName
            Icon = strIcon
            Cooldown = intCooldown
            Rounds = intRounds
            PetTypeID = intPetTypeID
            IsPassive = blnIsPassive
            HideHints = blnHideHints
        End Sub

    End Class

End Namespace