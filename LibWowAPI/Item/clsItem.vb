' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.Drawing
Imports roncliProductions.LibWowAPI.Data
Imports roncliProductions.LibWowAPI.Data.CharacterClasses
Imports roncliProductions.LibWowAPI.Data.CharacterRaces
Imports roncliProductions.LibWowAPI.Data.ItemClasses
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about an item.
    ''' </summary>
    ''' <remarks>This class contains detailed information about the item.</remarks>
    Public Class Item

        ''' <summary>
        ''' The ID number of the item.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ItemID number of the item.</returns>
        ''' <remarks>Each item has a unique ID number that is used to identify the item.</remarks>
        Public Property ItemID As Integer

        ''' <summary>
        ''' The rank at which enchanters can disenchant the item.
        ''' </summary>
        ''' <value>This property gets or sets the DisenchantingSkillRank field.</value>
        ''' <returns>Returns the rank at which enchanters can disenchant the item.</returns>
        ''' <remarks>This returns 0 if the item is not disenchantable.</remarks>
        Public Property DisenchantingSkillRank As Integer

        ''' <summary>
        ''' The flavor text on the item.
        ''' </summary>
        ''' <value>This property gets or sets the Description field.</value>
        ''' <returns>Returns the flavor text on the item.</returns>
        ''' <remarks>This is the localized flavor text on the item.</remarks>
        Public Property Description As String

        ''' <summary>
        ''' The name of the item.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the item.</returns>
        ''' <remarks>This is the localized name of the item.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' A path leading to the item's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the item's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The number of items that may be put in a single stack.
        ''' </summary>
        ''' <value>This property gets or sets the StackSize field.</value>
        ''' <returns>Returns the number of items that may be put in a single stack.</returns>
        ''' <remarks>This represents the number of items that may be put in a single stack.</remarks>
        Public Property StackSize As Integer

        Private colAllowableClasses As Collection(Of CharacterClass)
        ''' <summary>
        ''' The classes that are allowed to use this item.
        ''' </summary>
        ''' <value>This property gets the AllowableClasses field.</value>
        ''' <returns>Returns the classes that are allowed to use this item.</returns>
        ''' <remarks>This is a <see cref="Collection(Of CharacterClass)" /> of <see cref="CharacterClass" /> that represents the classes that are allowed to use this item.</remarks>
        Public ReadOnly Property AllowableClasses As Collection(Of CharacterClass)
            Get
                Return colAllowableClasses
            End Get
        End Property

        ''' <summary>
        ''' Information about the zone the item is bound to.
        ''' </summary>
        ''' <value>This property gets or sets the BoundZone field.</value>
        ''' <returns>Returns information about the zone the item is bound to.</returns>
        ''' <remarks>This is a <see cref="BoundZone" /> object that represents the zone the item is bound to.</remarks>
        Public Property BoundZone As BoundZone

        Private colAllowableRaces As Collection(Of Race)
        ''' <summary>
        ''' The races that are allowed to use this item.
        ''' </summary>
        ''' <value>This property gets the AlloweableRaces field.</value>
        ''' <returns>Returns the races that are allowed to use this item.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Race)" /> of <see cref="Race" /> that represents the races that are allowed to use this item.</remarks>
        Public ReadOnly Property AllowableRaces As Collection(Of Race)
            Get
                Return colAllowableRaces
            End Get
        End Property

        ''' <summary>
        ''' The item's binding type.
        ''' </summary>
        ''' <value>This property gets or sets the ItemBind field.</value>
        ''' <returns>Returns the item's binding type.</returns>
        ''' <remarks>This is a <see cref="Enums.Binding" /> enumeration that describes the item's binding type.</remarks>
        Public Property ItemBind As Binding

        Private colBonusStats As Collection(Of ItemStat)
        ''' <summary>
        ''' The bonus stats on an item.
        ''' </summary>
        ''' <value>This property gets the BonusStats field.</value>
        ''' <returns>Returns the bonus stats on an item.</returns>
        ''' <remarks>This is a <see cref="Collection(Of ItemStat)" /> of <see cref="ItemStat" /> that contains a list of the bonus stats on the item.</remarks>
        Public ReadOnly Property BonusStats As Collection(Of ItemStat)
            Get
                Return colBonusStats
            End Get
        End Property

        Private colItemSpells As Collection(Of ItemSpell)
        ''' <summary>
        ''' The various spells provided by this item.
        ''' </summary>
        ''' <value>This property gets the ItemSpells field.</value>
        ''' <returns>Returns the various spells provided by this item.</returns>
        ''' <remarks>This is a <see cref="Collection(Of ItemSpell)" /> of <see cref="ItemSpell" /> that contains a list of the spells provided by this item.</remarks>
        Public ReadOnly Property ItemSpells As Collection(Of ItemSpell)
            Get
                Return colItemSpells
            End Get
        End Property

        ''' <summary>
        ''' The price in copper to buy this item, if it's available from a vendor.
        ''' </summary>
        ''' <value>This property gets or sets the BuyPrice field.</value>
        ''' <returns>Returns the price in copper to buy this item, if it's available from a vendor.</returns>
        ''' <remarks>Some items are not purchasable, but still have this property set.</remarks>
        Public Property BuyPrice As Integer

        ''' <summary>
        ''' The class of the item.
        ''' </summary>
        ''' <value>This property gets or sets the ItemClass field.</value>
        ''' <returns>Returns the class of the item.</returns>
        ''' <remarks>This is a <see cref="ItemClass" /> object that describes the item class.</remarks>
        Public Property ItemClass As ItemClass

        ''' <summary>
        ''' The subclass of the item.
        ''' </summary>
        ''' <value>This property gets the ItemSubClass field.</value>
        ''' <returns>Returns the subclass of the item.</returns>
        ''' <remarks>This is a <see cref="ItemSubclass" /> object that describes the item subclass.</remarks>
        Public Property ItemSubClass As ItemSubclass

        ''' <summary>
        ''' The number of container slots on the item, if this is a container.
        ''' </summary>
        ''' <value>This property gets or sets the ContainerSlots field.</value>
        ''' <returns>Returns the number of container slots on the item, if this is a container.</returns>
        ''' <remarks>This represents the number of container slots on the item, if this is a container.</remarks>
        Public Property ContainerSlots As Integer

        ''' <summary>
        ''' Information about the weapon, if this is a weapon.
        ''' </summary>
        ''' <value>This property gets or sets the WeaponInfo field.</value>
        ''' <returns>Returns information about the weapon, if this is a weapon.</returns>
        ''' <remarks>This is a <see cref="LibWowAPI.Item.WeaponInfo" /> object that contains information about the weapon.</remarks>
        Public Property WeaponInfo As WeaponInfo

        ''' <summary>
        ''' Information about the gem, if this is a gem.
        ''' </summary>
        ''' <value>This property gets or sets the GemInfo field.</value>
        ''' <returns>Returns information about the gem, if this is a gem.</returns>
        ''' <remarks>This is a <see cref="LibWowAPI.Item.GemInfo" /> object that contains information about the gem.</remarks>
        Public Property GemInfo As GemInfo

        ''' <summary>
        ''' The inventory slot this is equipped on, if this is equippable.
        ''' </summary>
        ''' <value>This property gets or sets the InventoryType field.</value>
        ''' <returns>Returns the inventory slot this is equipped on, if this is equippable.</returns>
        ''' <remarks>This is a <see cref="Enums.InventoryType" /> enumeration that represents the inventory slot this item is equipped on.</remarks>
        Public Property InventoryType As InventoryType

        ''' <summary>
        ''' Determines whether this item is equippable.
        ''' </summary>
        ''' <value>This property gets or sets the Equippable field.</value>
        ''' <returns>Returns a boolean that determines whether this item is equippable.</returns>
        ''' <remarks>This determines whether this item is equippable.</remarks>
        Public Property Equippable As Boolean

        ''' <summary>
        ''' The iLevel of the item.
        ''' </summary>
        ''' <value>This property gets or sets the ItemLevel field.</value>
        ''' <returns>Returns the iLevel of the item.</returns>
        ''' <remarks>This represents the iLevel of the item.</remarks>
        Public Property ItemLevel As Integer

        ''' <summary>
        ''' Information about the item set.
        ''' </summary>
        ''' <value>This property gets or sets the ItemSet field.</value>
        ''' <returns>Returns information about the item set.</returns>
        ''' <remarks>This is a <see cref="ItemSet.ItemSet" /> object that represents information about the item set.  This returns null if this item is not part of a set.</remarks>
        Public Property ItemSet As ItemSet.ItemSet

        ''' <summary>
        ''' The maximum number of these items you may have at one time.
        ''' </summary>
        ''' <value>This property gets or sets the MaxCount property.</value>
        ''' <returns>Returns the maximum number of these items you may have at one time.</returns>
        ''' <remarks>This returns 0 if the max count is unlimiated.</remarks>
        Public Property MaxCount As Integer

        ''' <summary>
        ''' The maximum durability of the item, if it has durability.
        ''' </summary>
        ''' <value>This property gets or sets the MaxDurability field.</value>
        ''' <returns>Returns the maximum durability of the item, if it has durability.</returns>
        ''' <remarks>This represents the maximum durability of the item, if it has durability.</remarks>
        Public Property MaxDurability As Integer

        ''' <summary>
        ''' The faction ID that this item requires reputation for in order to buy.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredFactionID field.</value>
        ''' <returns>Returns the faction ID that this item requires repuration for in order to buy.</returns>
        ''' <remarks>Use with <see cref="MinStanding" /> to determine how much reputation you need.</remarks>
        Public Property RequiredFactionID As Integer

        ''' <summary>
        ''' The required standing in order to buy this item.
        ''' </summary>
        ''' <value>This property gets or sets the MinStanding field.</value>
        ''' <returns>Returns the required standing in order to buy this item.</returns>
        ''' <remarks>This is a <see cref="Enums.Standing" /> enumeration that describes the required standing in order to buy this item.  Use with <see cref="RequiredFactionID" /> to determine which faction you need reputation for.</remarks>
        Public Property MinStanding As Standing

        ''' <summary>
        ''' The quality of the item.
        ''' </summary>
        ''' <value>This property gets or sets the Quality field.</value>
        ''' <returns>Returns the quality of the item.</returns>
        ''' <remarks>This is a <see cref="Enums.Quality" /> enumeration that describes the quality of the item.</remarks>
        Public Property Quality As Quality

        ''' <summary>
        ''' The sell price of the item in copper.
        ''' </summary>
        ''' <value>This property gets or sets the SellPrice field.</value>
        ''' <returns>Returns the sell price of the item in copper.</returns>
        ''' <remarks>This represents the sell price of the item in copper.</remarks>
        Public Property SellPrice As Integer

        ''' <summary>
        ''' The profession required to use the item.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredSkill field.</value>
        ''' <returns>Returns the profession required to use the item.</returns>
        ''' <remarks>This is a <see cref="Enums.Profession" /> enumeration that tells what profession is required to use the item.  Use with <see cref="RequiredSkillRank" /> to determine the skill rank needed to use this item.</remarks>
        Public Property RequiredSkill As Profession

        ''' <summary>
        ''' The ability required to use the item.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredAbility field.</value>
        ''' <returns>Returns the ability required to use the item.</returns>
        ''' <remarks>This is a <see cref="LibWowAPI.Item.RequiredAbility" /> object that contains information about the ability required to use this item.</remarks>
        Public Property RequiredAbility As RequiredAbility

        ''' <summary>
        ''' The level required to use the item.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredLevel field.</value>
        ''' <returns>Returns the level required to use the item.</returns>
        ''' <remarks>This represents the level required to use the item.</remarks>
        Public Property RequiredLevel As Integer

        ''' <summary>
        ''' The required profession skill level to use the item.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredSkillRank field.</value>
        ''' <returns>Returns the required profession skill level to use the item.</returns>
        ''' <remarks>Use with <see cref="RequiredSkill" /> to determine the profession required to use this item.</remarks>
        Public Property RequiredSkillRank As Integer

        Private colSockets As Collection(Of String)
        ''' <summary>
        ''' The sockets available on this item.
        ''' </summary>
        ''' <value>This property gets the Sockets field.</value>
        ''' <returns>Returns the sockets available on this item.</returns>
        ''' <remarks>This is a <see cref="Collection(Of String)" /> of sockets that are avialable on the item.</remarks>
        Public ReadOnly Property Sockets As Collection(Of String)
            Get
                Return colSockets
            End Get
        End Property

        ''' <summary>
        ''' The socket bonus given for matching the item's socket colors.
        ''' </summary>
        ''' <value>This property gets or sets the SocketBonus field.</value>
        ''' <returns>Returns the socket bonus given for matching the item's socket colors.</returns>
        ''' <remarks>This represents the socket bonus given for matching the item's socket colors.</remarks>
        Public Property SocketBonus As String

        ''' <summary>
        ''' Information on how the item can be obtained.
        ''' </summary>
        ''' <value>This property gets or sets the ItemSource field.</value>
        ''' <returns>Returns information on how the item can be obtained.</returns>
        ''' <remarks>This is a <see cref="LibWowAPI.Item.ItemSource" /> object that contains information about how to obtain the item.</remarks>
        Public Property ItemSource As ItemSource

        ''' <summary>
        ''' The amount of base armor provided, if the item is equippable.
        ''' </summary>
        ''' <value>This property gets or sets the BaseArmor field.</value>
        ''' <returns>Returns the amount of base armor provided, if the item is equippable.</returns>
        ''' <remarks>This represents the amount of base armor provided, if the item is equippable.</remarks>
        Public Property BaseArmor As Integer

        ''' <summary>
        ''' Determines if the item has sockets.
        ''' </summary>
        ''' <value>This property gets or sets the HasSockets field.</value>
        ''' <returns>Returns a boolean that determines if the item has sockets.</returns>
        ''' <remarks>This determines if the item has sockets.</remarks>
        Public Property HasSockets As Boolean

        ''' <summary>
        ''' Determines if the item is auctionable.
        ''' </summary>
        ''' <value>This property gets or sets the IsAuctionable field.</value>
        ''' <returns>Returns a boolean that determines if the item is auctionable.</returns>
        ''' <remarks>This determines if the item is auctionable.</remarks>
        Public Property IsAuctionable As Boolean

        ''' <summary>
        ''' The total amount of armor on the item from both base armor and bonus armor.
        ''' </summary>
        ''' <value>This property gets or sets the TotalArmor field.</value>
        ''' <returns>Returns the total amount of armor on the item from both base armor and bonus armor.</returns>
        ''' <remarks>This represents the total amount of armor on the item from both base armor and bonus armor.</remarks>
        Public Property TotalArmor As Integer

        ''' <summary>
        ''' The ID number for the display information of this item.
        ''' </summary>
        ''' <value>This property gets or sets the DisplayInfoID field.</value>
        ''' <returns>Returns the ID number for the display information of this item.</returns>
        ''' <remarks>This is an internal identification number used by Blizzard to retrieve the information required to display the item.</remarks>
        Public Property DisplayInfoID As Integer

        ''' <summary>
        ''' The name description of the item.
        ''' </summary>
        ''' <value>This property gets or sets the NameDescription field.</value>
        ''' <returns>Returns the name description of the item.</returns>
        ''' <remarks>The name description is for items from the Mists of Panderia expansion or later that have a description under their name, such as "Heroic" or "Warforged".  See the <see cref="HeroicTooltip" /> property for heroic items from Cataclysm or earlier.</remarks>
        Public Property NameDescription As String

        ''' <summary>
        ''' The color the name description should be displayed in.
        ''' </summary>
        ''' <value>This property gets or sets the NameDescriptionColor field.</value>
        ''' <returns>Returns the color the name description should be displayed in.</returns>
        ''' <remarks>This represents the color the name description should be displayed in.</remarks>
        Public Property NameDescriptionColor As Color

        ''' <summary>
        ''' Determines if the item is upgradable.
        ''' </summary>
        ''' <value>This property gets or sets the Upgradable field.</value>
        ''' <returns>Returns whether the item is upgradable.</returns>
        ''' <remarks>This determins if the item is upgradable.</remarks>
        Public Property Upgradable As Boolean

        ''' <summary>
        ''' Determins if this item is heroic.
        ''' </summary>
        ''' <value>This property gets or sets the HeroicTooltip field.</value>
        ''' <returns>Returns whether the item is heroic.</returns>
        ''' <remarks>This property is only set for items from the Cataclysm expansion or earlier.  See the <see cref="NameDescription" /> property for heroic items from Mists of Pandaria or later.</remarks>
        Public Property HeroicTooltip As Boolean

        ''' <summary>
        ''' The context the item is obtained through.
        ''' </summary>
        ''' <value>This property gets or sets the Context field.</value>
        ''' <returns>Returns the context the item is obtained through.</returns>
        ''' <remarks>This represents the context the item is obtained through.</remarks>
        Public Property Context As String

        Private Property colBonuses As Collection(Of Integer)
        ''' <summary>
        ''' The list of bonus IDs that can be applied to this item.
        ''' </summary>
        ''' <value>This property gets the Bonuses field.</value>
        ''' <returns>Returns the list of bonus IDs that can be applied to this item.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Integer)" /> of bonus IDs that can be applied to this item.</remarks>
        Public ReadOnly Property Bonuses As Collection(Of Integer)
            Get
                Return colBonuses
            End Get
        End Property

        Private Property colAvailableContexts As Collection(Of String)
        ''' <summary>
        ''' The list of available contexts the item can be obtained through.
        ''' </summary>
        ''' <value>This property gets the AvailableContexts field.</value>
        ''' <returns>Returns the list of available contexts the item can be obtained through.</returns>
        ''' <remarks>This is a <see cref="Collection(Of String)" /> of contexts through which this item can be obtained.  To view this item under a different context, pass the context through the <see cref="ItemLookupOptions.Context" /> property of <see cref="ItemLookup.Options" />.</remarks>
        Public ReadOnly Property AvailableContexts As Collection(Of String)
            Get
                Return colAvailableContexts
            End Get
        End Property

        ''' <summary>
        ''' A summary of potential bonuses that can be applied to the item.
        ''' </summary>
        ''' <value>This property gets or sets the BonusSummary field.</value>
        ''' <returns>Returns a summary of potential bonuses that can be applied to the item.</returns>
        ''' <remarks>This is a <see cref="BonusSummary" /> object that represents a summary of potential bonuses that can be applied to the item.</remarks>
        Public Property BonusSummary As BonusSummary

        Friend Sub New(intItemID As Integer, intDisenchantingSkillRank As Integer, strDescription As String, strName As String, strIcon As String, intStackSize As Integer, ccAllowableClasses As Collection(Of CharacterClass), bzBoundZone As BoundZone, rAllowableRaces As Collection(Of Race), bItemBind As Binding, isBonusStats As Collection(Of ItemStat), isItemSpells As Collection(Of ItemSpell), intBuyPrice As Integer, icItemClass As ItemClass, isItemSubClass As ItemSubclass, intContainerSlots As Integer, wiWeaponInfo As WeaponInfo, giGemInfo As GemInfo, itInventoryType As InventoryType, blnEquippable As Boolean, intItemLevel As Integer, isItemSet As ItemSet.ItemSet, intMaxCount As Integer, intMaxDurability As Integer, intRequiredFactionID As Integer, sMinStanding As Standing, qQuality As Quality, intSellPrice As Integer, pRequiredSkill As Profession, raRequiredAbility As RequiredAbility, intRequiredLevel As Integer, intRequiredSkillRank As Integer, strSockets As Collection(Of String), strSocketBonus As String, isItemSource As ItemSource, intBaseArmor As Integer, blnHasSockets As Boolean, blnIsAuctionable As Boolean, intTotalArmor As Integer, intDisplayInfoID As Integer, strNameDescription As String, cNameDescriptionColor As Color, blnUpgradable As Boolean, blnHeroicTooltip As Boolean, strContext As String, intBonuses As Collection(Of Integer), strAvailableContexts As Collection(Of String), bsBonusSummary As BonusSummary)
            ItemID = intItemID
            DisenchantingSkillRank = intDisenchantingSkillRank
            Description = strDescription
            Name = strName
            Icon = strIcon
            StackSize = intStackSize
            colAllowableClasses = ccAllowableClasses
            BoundZone = bzBoundZone
            colAllowableRaces = rAllowableRaces
            ItemBind = bItemBind
            colBonusStats = isBonusStats
            colItemSpells = isItemSpells
            BuyPrice = intBuyPrice
            ItemClass = icItemClass
            ItemSubClass = isItemSubClass
            ContainerSlots = intContainerSlots
            WeaponInfo = wiWeaponInfo
            GemInfo = giGemInfo
            InventoryType = itInventoryType
            Equippable = blnEquippable
            ItemLevel = intItemLevel
            ItemSet = isItemSet
            MaxCount = intMaxCount
            MaxDurability = intMaxDurability
            RequiredFactionID = intRequiredFactionID
            MinStanding = sMinStanding
            Quality = qQuality
            SellPrice = intSellPrice
            RequiredSkill = pRequiredSkill
            RequiredAbility = raRequiredAbility
            RequiredLevel = intRequiredLevel
            RequiredSkillRank = intRequiredSkillRank
            colSockets = strSockets
            SocketBonus = strSocketBonus
            ItemSource = isItemSource
            BaseArmor = intBaseArmor
            HasSockets = blnHasSockets
            IsAuctionable = blnIsAuctionable
            TotalArmor = intTotalArmor
            DisplayInfoID = intDisplayInfoID
            NameDescription = strNameDescription
            NameDescriptionColor = cNameDescriptionColor
            Upgradable = blnUpgradable
            HeroicTooltip = blnHeroicTooltip
            Context = strContext
            colBonuses = intBonuses
            colAvailableContexts = strAvailableContexts
            BonusSummary = bsBonusSummary
        End Sub

    End Class

End Namespace
