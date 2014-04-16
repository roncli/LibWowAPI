' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character audit.
    ''' </summary>
    ''' <remarks>Character audits contain information about a character's gear, providing suggestions on how to improve.</remarks>
    Public Class Audit

        ''' <summary>
        ''' The number of issue types found with the character's gear.
        ''' </summary>
        ''' <value>This property gets or sets the NumberOfIssues field.</value>
        ''' <returns>Returns the number of issue types found with the character's gear.</returns>
        ''' <remarks>This represents the number of issue types found with the character's gear.</remarks>
        Public Property NumberOfIssues As Integer

        Private colSlots As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The number of issues found on each equipment slot.
        ''' </summary>
        ''' <value>This property gets the Slots field.</value>
        ''' <returns>Returns the number of issues found on each equipment slot.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the number of issues found on each equipment slot.</remarks>
        Public ReadOnly Property Slots As Collection(Of EquipmentCount)
            Get
                Return colSlots
            End Get
        End Property

        ''' <summary>
        ''' The number of empty glyph slots.
        ''' </summary>
        ''' <value>This property gets or sets the EmptyGlyphSlots field.</value>
        ''' <returns>Returns the number of empty glyph slots.</returns>
        ''' <remarks>This represents the number of empty glyph slots.</remarks>
        Public Property EmptyGlyphSlots As Integer

        ''' <summary>
        ''' The number of unspent talent points.
        ''' </summary>
        ''' <value>This property gets or sets the UnspentTalentPoints field.</value>
        ''' <returns>Returns the number of unspent talent points.</returns>
        ''' <remarks>This represents the number of unspent talent points.</remarks>
        Public Property UnspentTalentPoints As Integer

        ''' <summary>
        ''' Determines if the character does not have a spec.
        ''' </summary>
        ''' <value>This property gets or sets the NoSpec field.</value>
        ''' <returns>Returns whether the character does not have a spec.</returns>
        ''' <remarks>This determines if the character does not have a spec.</remarks>
        Public Property NoSpec As Boolean

        Private colUnenchantedItems As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's unenchanted items by equipment slot.
        ''' </summary>
        ''' <value>This property gets the UnenchantedItems field.</value>
        ''' <returns>Returns the character's unenchanted items by equipment slot.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's unenchanted items by equipment slot.</remarks>
        Public ReadOnly Property UnenchantedItems As Collection(Of EquipmentCount)
            Get
                Return colUnenchantedItems
            End Get
        End Property

        ''' <summary>
        ''' The number of empty sockets.
        ''' </summary>
        ''' <value>This property gets or sets the EmptySockets field.</value>
        ''' <returns>Returns the number of empty sockets.</returns>
        ''' <remarks>This represents the number of empty sockets.</remarks>
        Public Property EmptySockets As Integer

        Private colItemsWithEmptySockets As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's empty sockets by equipment slot.
        ''' </summary>
        ''' <value>This property gets the ItemsWithEmptySockets field.</value>
        ''' <returns>Returns the character's empty sockets by equipment slot.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's empty sockets by equipment slot.</remarks>
        Public ReadOnly Property ItemsWithEmptySockets As Collection(Of EquipmentCount)
            Get
                Return colItemsWithEmptySockets
            End Get
        End Property

        ''' <summary>
        ''' The appropriate armor type for the character.
        ''' </summary>
        ''' <value>This property gets or sets the AppropriateArmorType field.</value>
        ''' <returns>Returns the appropriate armor type for the character.</returns>
        ''' <remarks>This represents the appropriate armor type for the character.</remarks>
        Public Property AppropriateArmorType As ArmorType

        Private colInappropriateArmorType As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's inappropriate armor types by equipment slot.
        ''' </summary>
        ''' <value>This property gets the InappropriateArmorType field.</value>
        ''' <returns>Returns the character's inappropriate armor types by equipment slot.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's inappropriate armor types by equipment slot.</remarks>
        Public ReadOnly Property InappropriateArmorType As Collection(Of EquipmentCount)
            Get
                Return colInappropriateArmorType
            End Get
        End Property

        ''' <summary>
        ''' The character's low level items.
        ''' </summary>
        ''' <value>This property gets or sets the LowLevelItems field.</value>
        ''' <returns>Returns the character's low level items.</returns>
        ''' <remarks>This represents the character's low level items.</remarks>
        Public Property LowLevelItems As LowLevelItems

        ''' <summary>
        ''' The item level threshold to determine what items are low level.
        ''' </summary>
        ''' <value>This property gets or sets the LowLevelThreshold field.</value>
        ''' <returns>Returns the item level threshold to determine what items are low level.</returns>
        ''' <remarks>This represents the item level threshold to determine what items are low level.</remarks>
        Public Property LowLevelThreshold As Integer

        Private colMissingExtraSockets As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's missing sockets by equipment type.
        ''' </summary>
        ''' <value>This property gets the MissingExtraSockets field.</value>
        ''' <returns>Returns the character's missing sockets by equipment type.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's missing sockets by equipemnt type.</remarks>
        Public ReadOnly Property MissingExtraSockets As Collection(Of EquipmentCount)
            Get
                Return colMissingExtraSockets
            End Get
        End Property

        ''' <summary>
        ''' A recommendation for a belt buckle.
        ''' </summary>
        ''' <value>This property gets or sets the RecommendedBeltBuckle field.</value>
        ''' <returns>Returns a recommendation for a belt buckle.</returns>
        ''' <remarks>This represents a recommendation for a belt buckle.</remarks>
        Public Property RecommendedBeltBuckle As LibWowAPI.Item.Item

        Private colMissingBlacksmithSockets As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's missing blacksmith sockets by equipment type.
        ''' </summary>
        ''' <value>This property gets the MissingBlacksmithSockets by equipment type.</value>
        ''' <returns>Returns the character's missing blacksmith sockets by equipment type.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's missing blacksmith sockets by equipment type.</remarks>
        Public ReadOnly Property MissingBlacksmithSockets As Collection(Of EquipmentCount)
            Get
                Return colMissingBlacksmithSockets
            End Get
        End Property

        Private colMissingEnchanterEnchants As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's missing enchanter enchantments by equipment type.
        ''' </summary>
        ''' <value>This property gets the MissingEnchanterEnchants by equipment type.</value>
        ''' <returns>Returns the character's missing enchanter enchantments by equipment type.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's missing enchanter enchantments by equipment type.</remarks>
        Public ReadOnly Property MissingEnchanterEnchants As Collection(Of EquipmentCount)
            Get
                Return colMissingEnchanterEnchants
            End Get
        End Property

        Private colMissingEngineerEnchants As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's missing engineer enchantments by equipment type.
        ''' </summary>
        ''' <value>This property gets the MissingEngineerEnchants by equipment type.</value>
        ''' <returns>Returns the character's missing engineer enchantments by equipment type.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's missing engineer enchantments by equipment type.</remarks>
        Public ReadOnly Property MissingEngineerEnchants As Collection(Of EquipmentCount)
            Get
                Return colMissingEngineerEnchants
            End Get
        End Property

        Private colMissingScribeEnchants As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's missing scribe enchantments by equipment type.
        ''' </summary>
        ''' <value>This property gets the MissingScribeEnchants by equipment type.</value>
        ''' <returns>Returns the character's missing scribe enchantments by equipment type.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's missing scribe enchantments by equipment type.</remarks>
        Public ReadOnly Property MissingScribeEnchants As Collection(Of EquipmentCount)
            Get
                Return colMissingScribeEnchants
            End Get
        End Property

        ''' <summary>
        ''' The number of missing jewelcrafter gems.
        ''' </summary>
        ''' <value>This property gets or sets the MissingJewelcrafterGems field.</value>
        ''' <returns>Returns the number of missing jewelcrafter gems.</returns>
        ''' <remarks>This represents the number of missing jewelcrafter gems.</remarks>
        Public Property MissingJewelcrafterGems As Integer

        ''' <summary>
        ''' A recommendation for a jewelcrafter gem.
        ''' </summary>
        ''' <value>This property gets or sets the RecommendedJewelcrafterGem field.</value>
        ''' <returns>Returns a recommendation for a jewelcrafter gem.</returns>
        ''' <remarks>This represents a recommendation for a jewelcrafter gem.</remarks>
        Public Property RecommendedJewelcrafterGem As LibWowAPI.Item.Item

        Private colMissingLeatherworkerEnchants As Collection(Of EquipmentCount)
        ''' <summary>
        ''' The character's missing leatherworker enchantments by equipment type.
        ''' </summary>
        ''' <value>This property gets the MissingLeatherworkerEnchants by equipment type.</value>
        ''' <returns>Returns the character's missing leatherworker enchantments by equipment type.</returns>
        ''' <remarks>This is a <see cref="Collection(Of EquipmentCount)" /> of <see cref="EquipmentCount" /> that represents the character's missing leatherworker enchantments by equipment type.</remarks>
        Public ReadOnly Property MissingLeatherworkerEnchants As Collection(Of EquipmentCount)
            Get
                Return colMissingLeatherworkerEnchants
            End Get
        End Property

        Friend Sub New(intNumberOfIssues As Integer, ecSlots As Collection(Of EquipmentCount), intEmptyGlyphSlots As Integer, intUnspentTalentPoints As Integer, blnNoSpec As Boolean, ecUnenchantedItems As Collection(Of EquipmentCount), intEmptySockets As Integer, ecItemsWithEmptySockets As Collection(Of EquipmentCount), atAppropriateArmorType As ArmorType, ecInappropriateArmorType As Collection(Of EquipmentCount), lliLowLevelItems As LowLevelItems, ecMissingExtraSockets As Collection(Of EquipmentCount), iRecommendedBeltBuckle As LibWowAPI.Item.Item, ecMissingBlacksmithSockets As Collection(Of EquipmentCount), ecMissingEnchanterEnchants As Collection(Of EquipmentCount), ecMissingEngineerEnchants As Collection(Of EquipmentCount), ecMissingScribeEnchants As Collection(Of EquipmentCount), intMissingJewelcrafterGems As Integer, iRecommendedJewelcrafterGem As LibWowAPI.Item.Item, ecMissingLeatherworkerEnchants As Collection(Of EquipmentCount))
            NumberOfIssues = intNumberOfIssues
            colSlots = ecSlots
            EmptyGlyphSlots = intEmptyGlyphSlots
            UnspentTalentPoints = intUnspentTalentPoints
            NoSpec = blnNoSpec
            colUnenchantedItems = ecUnenchantedItems
            EmptySockets = intEmptySockets
            colItemsWithEmptySockets = ecItemsWithEmptySockets
            AppropriateArmorType = atAppropriateArmorType
            colInappropriateArmorType = ecInappropriateArmorType
            LowLevelItems = lliLowLevelItems
            colMissingExtraSockets = ecMissingExtraSockets
            RecommendedBeltBuckle = iRecommendedBeltBuckle
            colMissingBlacksmithSockets = ecMissingBlacksmithSockets
            colMissingEnchanterEnchants = ecMissingEnchanterEnchants
            colMissingEngineerEnchants = ecMissingEngineerEnchants
            colMissingScribeEnchants = ecMissingScribeEnchants
            MissingJewelcrafterGems = intMissingJewelcrafterGems
            RecommendedJewelcrafterGem = iRecommendedJewelcrafterGem
            colMissingLeatherworkerEnchants = ecMissingLeatherworkerEnchants
        End Sub

    End Class

End Namespace
