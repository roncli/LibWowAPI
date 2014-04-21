' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.BattlePet
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a pet.
    ''' </summary>
    ''' <remarks>The data contained within this class contains information about a single pet.</remarks>
    Public Class Collected

        ''' <summary>
        ''' The given name of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the given name of the pet.</returns>
        ''' <remarks>Pet owners are allowed to name their pets.  This field returns the given name.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The spell ID of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the SpellID field.</value>
        ''' <returns>Returns the spell ID of the pet.</returns>
        ''' <remarks>This represents the spell ID of the pet.</remarks>
        Public Property SpellID As Integer

        ''' <summary>
        ''' The creature ID of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the CreatureID field.</value>
        ''' <returns>Returns the creature ID of the pet.</returns>
        ''' <remarks>This represents the creature ID of the pet.</remarks>
        Public Property CreatureID As Integer

        ''' <summary>
        ''' The item ID of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the ItemID field.</value>
        ''' <returns>Returns the item ID of the pet.</returns>
        ''' <remarks>This represents the item ID of the pet.</remarks>
        Public Property ItemID As Integer

        ''' <summary>
        ''' The quality of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the Quality field.</value>
        ''' <returns>Returns the quality of the pet.</returns>
        ''' <remarks>This is a <see cref="Enums.Quality" /> enumeration that represents the quality of the pet.</remarks>
        Public Property Quality As Quality

        ''' <summary>
        ''' A path leading to the pet's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the pet's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The pet's battle stats.
        ''' </summary>
        ''' <value>This property gets or sets the Stats field.</value>
        ''' <returns>Returns the pet's battle stats.</returns>
        ''' <remarks>This is a <see cref="BattlePetStats" /> object that represents the pet's battle stats.</remarks>
        Public Property Stats As BattlePetStats

        ''' <summary>
        ''' The pet's GUID.
        ''' </summary>
        ''' <value>This property gets or sets the BattlePetGuid field.</value>
        ''' <returns>Returns the pet's GUID.</returns>
        ''' <remarks>This is an internal identifier used by Blizzard to identify a pet.</remarks>
        Public Property BattlePetGuid As String

        ''' <summary>
        ''' Determines if the owning character has marked this pet as a favorite.
        ''' </summary>
        ''' <value>This property gets or sets the IsFavorite field.</value>
        ''' <returns>Returns whether the owning character has marked this pet as a favorite.</returns>
        ''' <remarks>This determines if the owning character has marked this pet as a favorite.</remarks>
        Public Property IsFavorite As Boolean

        ''' <summary>
        ''' Determines if the pet's first ability slot is selected.
        ''' </summary>
        ''' <value>This property gets or sets the IsFirstAbilitySlotSelected field.</value>
        ''' <returns>Returns whether the pet's first ability slot is selected.</returns>
        ''' <remarks>This determines if the pet's first ability slot is selected.</remarks>
        Public Property IsFirstAbilitySlotSelected As Boolean

        ''' <summary>
        ''' Determines if the pet's second ability slot is selected.
        ''' </summary>
        ''' <value>This property gets or sets the IsSecondAbilitySlotSelected field.</value>
        ''' <returns>Returns whether the pet's second ability slot is selected.</returns>
        ''' <remarks>This determines if the pet's second ability slot is selected.</remarks>
        Public Property IsSecondAbilitySlotSelected As Boolean

        ''' <summary>
        ''' Determines if the pet's third ability slot is selected.
        ''' </summary>
        ''' <value>This property gets or sets the IsThirdAbilitySlotSelected field.</value>
        ''' <returns>Returns whether the pet's third ability slot is selected.</returns>
        ''' <remarks>This determines if the pet's third ability slot is selected.</remarks>
        Public Property IsThirdAbilitySlotSelected As Boolean

        ''' <summary>
        ''' The original name of the pet.
        ''' </summary>
        ''' <value>This property gets or sets the CreatureName field.</value>
        ''' <returns>Returns the original name of the pet.</returns>
        ''' <remarks>This represents the original, localized name of the pet.</remarks>
        Public Property CreatureName As String

        ''' <summary>
        ''' Determines if the pet can battle.
        ''' </summary>
        ''' <value>This property gets or sets the CanBattle field.</value>
        ''' <returns>Returns whether the pet can battle.</returns>
        ''' <remarks>This determines if the pet can battle.</remarks>
        Public Property CanBattle As Boolean

        Friend Sub New(strName As String, intSpellID As Integer, intCreatureID As Integer, intItemID As Integer, qQuality As Quality, strIcon As String, bpsStats As BattlePetStats, strBattlePetGuid As String, blnIsFavorite As Boolean, blnIsFirstAbilitySlotSelected As Boolean, blnIsSecondAbilitySlotSelected As Boolean, blnIsThirdAbilitySlotSelected As Boolean, strCreatureName As String, blnCanBattle As Boolean)
            Name = strName
            SpellID = intSpellID
            CreatureID = intCreatureID
            ItemID = intItemID
            Quality = qQuality
            Icon = strIcon
            Stats = bpsStats
            BattlePetGuid = strBattlePetGuid
            IsFavorite = blnIsFavorite
            IsFirstAbilitySlotSelected = blnIsFirstAbilitySlotSelected
            IsSecondAbilitySlotSelected = blnIsSecondAbilitySlotSelected
            IsThirdAbilitySlotSelected = blnIsThirdAbilitySlotSelected
            CreatureName = strCreatureName
            CanBattle = blnCanBattle
        End Sub

    End Class

End Namespace
