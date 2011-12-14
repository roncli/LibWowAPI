' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System

<Assembly: CLSCompliant(True)> 

Namespace roncliProductions.LibWowAPI.Enums

    ''' <summary>
    ''' An enumeration to describe an item's quality.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Item.ItemLookup" /> class, among others, to identify the quality of the item.</remarks>
    Public Enum Quality
        Unknown = -1

        ''' <summary>
        ''' This is a grey item.
        ''' </summary>
        ''' <remarks></remarks>
        Poor = 0

        ''' <summary>
        ''' This is a white item.
        ''' </summary>
        ''' <remarks></remarks>
        Common = 1

        ''' <summary>
        ''' This is a green item.
        ''' </summary>
        ''' <remarks></remarks>
        Uncommon = 2

        ''' <summary>
        ''' This is a blue item.
        ''' </summary>
        ''' <remarks></remarks>
        Rare = 3

        ''' <summary>
        ''' This is a purple item.
        ''' </summary>
        ''' <remarks></remarks>
        Epic = 4

        ''' <summary>
        ''' This is an orange item.
        ''' </summary>
        ''' <remarks></remarks>
        Legendary = 5

        ''' <summary>
        ''' This is an orange item.
        ''' </summary>
        ''' <remarks></remarks>
        OtherLegendary = 6

        ''' <summary>
        ''' This is a gold item.
        ''' </summary>
        ''' <remarks></remarks>
        Heirloom = 7
    End Enum

    ''' <summary>
    ''' An enumeration to describe a side.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Data.CharacterRaces" /> class, among others, to identify which faction the character belongs to.</remarks>
    Public Enum Side
        Unknown = -1
        Alliance = 0
        Horde = 1
    End Enum

    ''' <summary>
    ''' An enumeration to describe a gender.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Character.CharacterProfile" /> class, among others, to identify the gender of the character.</remarks>
    Public Enum Gender
        Unknown = -1
        Male = 0
        Female = 1
    End Enum

    ''' <summary>
    ''' An enumeration to describe a character's reputation standing.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Character.CharacterProfile" /> class, among others, to determine a character's standing with a faction.</remarks>
    Public Enum Standing
        Unknown = -1
        Hated = 0
        Hostile = 1
        Unfriendly = 2
        Neutral = 3
        Friendly = 4
        Honored = 5
        Revered = 6
        Exalted = 7
    End Enum

    ''' <summary>
    ''' An enumeration to describe a realm's type.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Realm.RealmStatus" /> class to determine a realm's type.</remarks>
    Public Enum RealmType
        Unknown = 0

        ''' <summary>
        ''' This is a Player Vs. Environment realm.
        ''' </summary>
        ''' <remarks></remarks>
        PvE = 1

        ''' <summary>
        ''' This is a Player Vs. Player realm.
        ''' </summary>
        ''' <remarks></remarks>
        PvP = 2

        ''' <summary>
        ''' This is a Roleplaying Player Vs. Environment realm.
        ''' </summary>
        ''' <remarks></remarks>
        RP = 3

        ''' <summary>
        ''' This is a Roleplaying Player Vs. Player realm.
        ''' </summary>
        ''' <remarks></remarks>
        RPPvP = 4
    End Enum

    ''' <summary>
    ''' An enumeration to describe a character's power type.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Data.CharacterClasses" /> class, among others, to determine what type of power bar the character uses.</remarks>
    Public Enum PowerType
        Unknown = 0

        ''' <summary>
        ''' This character uses energy.
        ''' </summary>
        ''' <remarks></remarks>
        Energy = 1

        ''' <summary>
        ''' This character uses focus.
        ''' </summary>
        ''' <remarks></remarks>
        Focus = 2

        ''' <summary>
        ''' This character uses mana.
        ''' </summary>
        ''' <remarks></remarks>
        Mana = 3

        ''' <summary>
        ''' This character uses rage.
        ''' </summary>
        ''' <remarks></remarks>
        Rage = 4

        ''' <summary>
        ''' This character uses runic power.
        ''' </summary>
        ''' <remarks></remarks>
        RunicPower = 5
    End Enum

    ''' <summary>
    ''' An enumeration to describe a character's progression in an instance.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Character.CharacterProfile" /> class, which returns character data that includes a character's progression in an instance.</remarks>
    Public Enum Progress
        Unknown = -1

        ''' <summary>
        ''' The character has killed no bosses in this instance.
        ''' </summary>
        ''' <remarks></remarks>
        None = 0

        ''' <summary>
        ''' The character has killed some bosses in this instance.
        ''' </summary>
        ''' <remarks></remarks>
        [Partial] = 1

        ''' <summary>
        ''' The character has killed all of the bosses in this instance.
        ''' </summary>
        ''' <remarks></remarks>
        Cleared = 2
    End Enum

    ''' <summary>
    ''' An enumeration to describe an item's binding.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Item.ItemLookup" /> class, which returns item data that includes the binding type.</remarks>
    Public Enum Binding
        ''' <summary>
        ''' This item can be freely traded between characters.
        ''' </summary>
        ''' <remarks></remarks>
        NoBinding = 0

        ''' <summary>
        ''' The item becomes soulbound to the character when it is obtained.  This also encompasses Bind on Battle.Net account.
        ''' </summary>
        ''' <remarks></remarks>
        BindOnPickup = 1

        ''' <summary>
        ''' The item only becomes soulbound to the character when it is equipped.
        ''' </summary>
        ''' <remarks></remarks>
        BindOnEquip = 2

        ''' <summary>
        ''' The item only becomes soulbound to the character when it is used.
        ''' </summary>
        ''' <remarks></remarks>
        BindOnUse = 3

        ''' <summary>
        ''' This is a quest item, which cannot be traded.
        ''' </summary>
        ''' <remarks></remarks>
        QuestItem = 4

        ''' <summary>
        ''' Carryover from the Armory which defined both types 4 and 5 as a quest item, but type 5 was never used.
        ''' </summary>
        ''' <remarks></remarks>
        OtherQuestItem = 5
    End Enum

    ''' <summary>
    ''' An enumeration to describe an item's subclass.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Item.ItemLookup" /> class, which returns item data that includes the item's subclass.  The value of the enumeration is 100 * <see cref="LibWowAPI.Item.Item.ItemClass" /> + <i>Subclass</i>, where Subclass is the value of the subclass returned by the API.</remarks>
    Public Enum ItemSubClass
        None = -1

        ''' <summary>
        ''' This item is a general consumable.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable = 0

        ''' <summary>
        ''' This item is a potion.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable_Potion = 1

        ''' <summary>
        ''' This item is an elixir.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable_Elixir = 2

        ''' <summary>
        ''' This item is a flask.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable_Flask = 3

        ''' <summary>
        ''' This item is a scroll.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable_Scroll = 4

        ''' <summary>
        ''' This item is food or drink.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable_FoodAndDrink = 5

        ''' <summary>
        ''' This item is an item enhancement.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable_ItemEnhancement = 6

        ''' <summary>
        ''' This item is a bandage.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable_Bandage = 7

        ''' <summary>
        ''' This item is a miscellaneous consumable item.
        ''' </summary>
        ''' <remarks></remarks>
        Consumable_Other = 8

        ''' <summary>
        ''' This item is a container.
        ''' </summary>
        ''' <remarks></remarks>
        Container = 100

        ''' <summary>
        ''' This item is a soul bag.
        ''' </summary>
        ''' <remarks></remarks>
        Container_SoulBag = 101

        ''' <summary>
        ''' This item is an herb bag.
        ''' </summary>
        ''' <remarks></remarks>
        Container_HerbBag = 102

        ''' <summary>
        ''' This item is an enchanting bag.
        ''' </summary>
        ''' <remarks></remarks>
        Container_EnchantingBag = 103

        ''' <summary>
        ''' This item is an engineering bag.
        ''' </summary>
        ''' <remarks></remarks>
        Container_EngineeringBag = 104

        ''' <summary>
        ''' This item is a gem bag.
        ''' </summary>
        ''' <remarks></remarks>
        Container_GemBag = 105

        ''' <summary>
        ''' This item is a mining bag.
        ''' </summary>
        ''' <remarks></remarks>
        Container_MiningBag = 106

        ''' <summary>
        ''' This item is a leatherworking bag.
        ''' </summary>
        ''' <remarks></remarks>
        Container_LeatherworkingBag = 107

        ''' <summary>
        ''' This item is an inscription bag.
        ''' </summary>
        ''' <remarks></remarks>
        Container_InscriptionBag = 108

        ''' <summary>
        ''' This item is a tackle box.
        ''' </summary>
        ''' <remarks></remarks>
        Container_TackleBox = 109

        ''' <summary>
        ''' This item is a one-handed axe.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_OneHandedAxe = 200

        ''' <summary>
        ''' This item is a two-handed axe.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_TwoHandedAxe = 201

        ''' <summary>
        ''' This item is a bow.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Bow = 202

        ''' <summary>
        ''' This item is a gun.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Gun = 203

        ''' <summary>
        ''' This item is a one-handed mace.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_OneHandedMace = 204

        ''' <summary>
        ''' This item is a two-handed mace.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_TwoHandedMace = 205

        ''' <summary>
        ''' This item is a polearm.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Polearm = 206

        ''' <summary>
        ''' This item is a one-handed sword.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_OneHandedSword = 207

        ''' <summary>
        ''' This item is a two-handed sword.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_TwoHandedSword = 208

        ''' <summary>
        ''' This item is an obsolete weapon.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Weapon_Obsolete = 209

        ''' <summary>
        ''' This item is a staff.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Staff = 210

        ''' <summary>
        ''' This item is a one-handed exotic weapon.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_OneHandedExotic = 211

        ''' <summary>
        ''' This item is a two-handed exotic weapon.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_TwoHandedExotic = 212

        ''' <summary>
        ''' This item is a fist weapon.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_FistWeapon = 213

        ''' <summary>
        ''' This item is a miscellaneous weapon.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Miscellaneous = 214

        ''' <summary>
        ''' This item is a dagger.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Dagger = 215

        ''' <summary>
        ''' This item is a thrown weapon.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Thrown = 216

        ''' <summary>
        ''' This item is a spear.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Spear = 217

        ''' <summary>
        ''' This item is a crossbow.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Crossbow = 218

        ''' <summary>
        ''' This item is a wand.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_Wand = 219

        ''' <summary>
        ''' This item is a fishing pole.
        ''' </summary>
        ''' <remarks></remarks>
        Weapon_FishingPole = 220

        ''' <summary>
        ''' This item is a red gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Red = 300

        ''' <summary>
        ''' This item is a blue gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Blue = 301

        ''' <summary>
        ''' This item is a yellow gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Yellow = 302

        ''' <summary>
        ''' This item is a purple gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Purple = 303

        ''' <summary>
        ''' This item is a green gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Green = 304

        ''' <summary>
        ''' This item is an orange gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Orange = 305

        ''' <summary>
        ''' This item is a meta gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Meta = 306

        ''' <summary>
        ''' This item is a simple gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Simple = 307

        ''' <summary>
        ''' This item is a prismatic gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Prismatic = 308

        ''' <summary>
        ''' This item is an engineer's hydraulic gem.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Hydraulic = 309

        ''' <summary>
        ''' This item is an engineer's cogwheel.
        ''' </summary>
        ''' <remarks></remarks>
        Gem_Cogwheel = 310

        ''' <summary>
        ''' This item is a miscellaneous piece of armor.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Miscellaneous = 400

        ''' <summary>
        ''' This item is cloth armor.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Cloth = 401

        ''' <summary>
        ''' This item is leather armor.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Leather = 402

        ''' <summary>
        ''' This item is mail armor.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Mail = 403

        ''' <summary>
        ''' This item is plate armor.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Plate = 404

        ''' <summary>
        ''' This item is a buckler.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Armor_Buckler = 405

        ''' <summary>
        ''' This item is a shield.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Shield = 406

        ''' <summary>
        ''' This item is a libram.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Libram = 407

        ''' <summary>
        ''' This item is an idol.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Idol = 408

        ''' <summary>
        ''' This item is a totem.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Totem = 409

        ''' <summary>
        ''' This item is a sigil.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Sigil = 410

        ''' <summary>
        ''' This item is a relic.
        ''' </summary>
        ''' <remarks></remarks>
        Armor_Relic = 411

        ''' <summary>
        ''' This item is a reagent.
        ''' </summary>
        ''' <remarks></remarks>
        Reagent = 500

        ''' <summary>
        ''' This item is a wand projectile.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Projectile_Wand = 600

        ''' <summary>
        ''' This item is a bolt projectile.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Projectile_Bolt = 601

        ''' <summary>
        ''' This item is an arrow.
        ''' </summary>
        ''' <remarks></remarks>
        Projectile_Arrow = 602

        ''' <summary>
        ''' This item is a bullet.
        ''' </summary>
        ''' <remarks></remarks>
        Projectile_Bullet = 603

        ''' <summary>
        ''' This item is a thrown projectile.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Projectile_Thrown = 604

        ''' <summary>
        ''' This item is a miscellaneous trade good.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods = 700

        ''' <summary>
        ''' This item is a part.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Parts = 701

        ''' <summary>
        ''' This item is an explosive.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Explosives = 702

        ''' <summary>
        ''' This item is a device.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Devices = 703

        ''' <summary>
        ''' This item is used for jewelcrafting.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Jewelcrafting = 704

        ''' <summary>
        ''' This item is a piece of cloth.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Cloth = 705

        ''' <summary>
        ''' This item is a piece of leather.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Leather = 706

        ''' <summary>
        ''' This item is metal or stone.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_MetalAndStone = 707

        ''' <summary>
        ''' This item is meat.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Meat = 708

        ''' <summary>
        ''' This item is an herb.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Herb = 709

        ''' <summary>
        ''' This item is an elemental item.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Elemental = 710

        ''' <summary>
        ''' This item is a miscellaneous trade good.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Other = 711

        ''' <summary>
        ''' This item is an enchanting material.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Enchanting = 712

        ''' <summary>
        ''' This item is a trade good material.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_Materials = 713

        ''' <summary>
        ''' This item is an item enchantment.
        ''' </summary>
        ''' <remarks></remarks>
        TradeGoods_ItemEnchantment = 714

        ''' <summary>
        ''' This item is a weapon enchantment.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> TradeGoods_WeaponEnchantment = 715

        ''' <summary>
        ''' This item is a generic item.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Generic = 800

        ''' <summary>
        ''' This item is a book.
        ''' </summary>
        ''' <remarks></remarks>
        Book = 900

        ''' <summary>
        ''' This item is a leatherworking book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Leatherworking = 901

        ''' <summary>
        ''' This item is a tailoring book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Tailoring = 902

        ''' <summary>
        ''' This item is an engineering book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Engineering = 903

        ''' <summary>
        ''' This item is a blacksmithing book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Blacksmithing = 904

        ''' <summary>
        ''' This item is a cooking book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Cooking = 905

        ''' <summary>
        ''' This item is an alchemy book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Alchemy = 906

        ''' <summary>
        ''' This item is a first aid book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_FirstAid = 907

        ''' <summary>
        ''' This item is an enchanting book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Enchanting = 908

        ''' <summary>
        ''' This item is a fishing book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Fishing = 909

        ''' <summary>
        ''' This item is a jewelcrafting book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Jewelcrafting = 910

        ''' <summary>
        ''' This item is an inscription book.
        ''' </summary>
        ''' <remarks></remarks>
        Book_Inscription = 911

        ''' <summary>
        ''' This item is currency.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Money = 1000

        ''' <summary>
        ''' This item is a miscellaneous quiver.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Quiver = 1100

        ''' <summary>
        ''' This item is an obsolete quiver.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This subclass is obsolete.")> Quiver_Obsolete = 1101

        ''' <summary>
        ''' This item is a quiver.
        ''' </summary>
        ''' <remarks></remarks>
        Quiver_Quiver = 1102

        ''' <summary>
        ''' This item is an ammo pouch.
        ''' </summary>
        ''' <remarks></remarks>
        Quiver_AmmoPouch = 1103

        ''' <summary>
        ''' This item is a quest item.
        ''' </summary>
        ''' <remarks></remarks>
        Quest = 1200

        ''' <summary>
        ''' This item is a key.
        ''' </summary>
        ''' <remarks></remarks>
        Key = 1300

        ''' <summary>
        ''' This item is a lock pick.
        ''' </summary>
        ''' <remarks></remarks>
        Key_Lockpick = 1301

        ''' <summary>
        ''' This item is a permanent item.
        ''' </summary>
        ''' <remarks></remarks>
        Permanent = 1400

        ''' <summary>
        ''' This item is junk.
        ''' </summary>
        ''' <remarks></remarks>
        Junk = 1500

        ''' <summary>
        ''' This item is a reagent.
        ''' </summary>
        ''' <remarks></remarks>
        Junk_Reagent = 1501

        ''' <summary>
        ''' This item is a companion pet.
        ''' </summary>
        ''' <remarks></remarks>
        Junk_Pet = 1502

        ''' <summary>
        ''' This item is a holiday item.
        ''' </summary>
        ''' <remarks></remarks>
        Junk_Holiday = 1503

        ''' <summary>
        ''' This item is miscellaneous junk.
        ''' </summary>
        ''' <remarks></remarks>
        Junk_Other = 1504

        ''' <summary>
        ''' This item is a mount.
        ''' </summary>
        ''' <remarks></remarks>
        Junk_Mount = 1505

        ''' <summary>
        ''' This item is a glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph = 1600

        ''' <summary>
        ''' This item is a warrior's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Warrior = 1601

        ''' <summary>
        ''' This item is a paladin's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Paladin = 1602

        ''' <summary>
        ''' This item is a hunter's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Hunter = 1603

        ''' <summary>
        ''' This item is a rogue's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Rogue = 1604

        ''' <summary>
        ''' This item is a priest's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Priest = 1605

        ''' <summary>
        ''' This item is a death knight's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_DeathKnight = 1606

        ''' <summary>
        ''' This item is a shaman's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Shaman = 1607

        ''' <summary>
        ''' This item is a mage's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Mage = 1608

        ''' <summary>
        ''' This item is a warlock's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Warlock = 1609

        ''' <summary>
        ''' This item is a druid's glyph.
        ''' </summary>
        ''' <remarks></remarks>
        Glyph_Druid = 1611
    End Enum

    ''' <summary>
    ''' An enumeration to describe an item's equippable type.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Item.ItemLookup" /> class, which returns item data that includes the item's euqippable type.</remarks>
    Public Enum InventoryType
        ''' <summary>
        ''' This item is not equippable.
        ''' </summary>
        ''' <remarks></remarks>
        NonEquipType = 0

        ''' <summary>
        ''' This item is worn on the head.
        ''' </summary>
        ''' <remarks></remarks>
        Head = 1

        ''' <summary>
        ''' This item is worn around the neck.
        ''' </summary>
        ''' <remarks></remarks>
        Neck = 2

        ''' <summary>
        ''' This item is worn on the shoulders.
        ''' </summary>
        ''' <remarks></remarks>
        Shoulders = 3

        ''' <summary>
        ''' This item is a shirt.
        ''' </summary>
        ''' <remarks></remarks>
        Shirt = 4

        ''' <summary>
        ''' This item is worn on the chest.  Does not include robes, see <see cref="InventoryType.ChestRobe" /> for robes.
        ''' </summary>
        ''' <remarks></remarks>
        Chest = 5

        ''' <summary>
        ''' This item is worn around the waist.
        ''' </summary>
        ''' <remarks></remarks>
        Waist = 6

        ''' <summary>
        ''' This item is worn on the legs.
        ''' </summary>
        ''' <remarks></remarks>
        Legs = 7

        ''' <summary>
        ''' This item is worn on the feet.
        ''' </summary>
        ''' <remarks></remarks>
        Feet = 8

        ''' <summary>
        ''' This item is worn on the wrists.
        ''' </summary>
        ''' <remarks></remarks>
        Wrist = 9

        ''' <summary>
        ''' This item is worn on the hands.
        ''' </summary>
        ''' <remarks></remarks>
        Hands = 10

        ''' <summary>
        ''' This item is a ring.
        ''' </summary>
        ''' <remarks></remarks>
        Finger = 11

        ''' <summary>
        ''' This item is a trinket.
        ''' </summary>
        ''' <remarks></remarks>
        Trinket = 12

        ''' <summary>
        ''' This item is equippable in either the main hand or the off hand.
        ''' </summary>
        ''' <remarks></remarks>
        OneHand = 13

        ''' <summary>
        ''' This item is equippable in the off hand.  Exclusively for shields, see <see cref="InventoryType.OffHand" /> for other off hand items.
        ''' </summary>
        ''' <remarks></remarks>
        OffHandShield = 14

        ''' <summary>
        ''' This item is a ranged weapon.  Exclusively for bows, see <see cref="InventoryType.Ranged" /> for other ranged items.
        ''' </summary>
        ''' <remarks></remarks>
        RangedBow = 15

        ''' <summary>
        ''' This item is worn on the back.
        ''' </summary>
        ''' <remarks></remarks>
        Back = 16

        ''' <summary>
        ''' This item is equippable in both hands.
        ''' </summary>
        ''' <remarks></remarks>
        TwoHand = 17

        ''' <summary>
        ''' This item is a bag.
        ''' </summary>
        ''' <remarks></remarks>
        Bag = 18

        ''' <summary>
        ''' This item is a tabard.
        ''' </summary>
        ''' <remarks></remarks>
        Tabard = 19

        ''' <summary>
        ''' This item is worn on the chest.  Exclusively for robes, see <see cref="InventoryType.Chest" /> for other chest items.
        ''' </summary>
        ''' <remarks></remarks>
        ChestRobe = 20

        ''' <summary>
        ''' This item is equippable in the main hand.
        ''' </summary>
        ''' <remarks></remarks>
        MainHand = 21

        ''' <summary>
        ''' This item is equippable in the off hand.  Does not include shields or frills, see <see cref="InventoryType.OffHandShield" /> for shields and <see cref="InventoryType.OffHandFrill" /> for frills.
        ''' </summary>
        ''' <remarks></remarks>
        OffHand = 22

        ''' <summary>
        ''' This item is equippable in the off hand.  Exclusively for frills, see <see cref="InventoryType.OffHand" /> for other off hand items.
        ''' </summary>
        ''' <remarks></remarks>
        OffHandFrill = 23

        ''' <summary>
        ''' This item is a projectile.
        ''' </summary>
        ''' <remarks></remarks>
        Projectile = 24

        ''' <summary>
        ''' This item is a thrown weapon.
        ''' </summary>
        ''' <remarks></remarks>
        Thrown = 25

        ''' <summary>
        ''' This item is a ranged weapon.  Does not include bows, see <see cref="InventoryType.RangedBow" /> for bows.
        ''' </summary>
        ''' <remarks></remarks>
        Ranged = 26

        ''' <summary>
        ''' This item is a quiver.
        ''' </summary>
        ''' <remarks></remarks>
        <Obsolete("This inventory type is obsolete.")> Quiver = 27

        ''' <summary>
        ''' This item is a relic.  Includes totems, idols, librams and relics.
        ''' </summary>
        ''' <remarks></remarks>
        Relic = 28
    End Enum

    ''' <summary>
    ''' An enumeration to describe a profession.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Character.CharacterProfile" /> class, among others, which returns character data including their professions.  The value of the enumeration is the profession ID.</remarks>
    Public Enum Profession
        None = 0
        Alchemy = 171
        Archaeology = 794
        Blacksmithing = 164
        Cooking = 185
        Enchanting = 333
        Engineering = 202
        FirstAid = 129
        Fishing = 356
        Herbalism = 182
        Inscription = 773
        Jewelcrafting = 755
        Leatherworking = 165
        Mining = 186
        Riding = 762
        Skinning = 393
        Tailoring = 197
    End Enum

    ''' <summary>
    ''' An enumeration to describe a combat statistic type.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Item.ItemLookup" /> class to determine a type of combat statistic.</remarks>
    Public Enum Stat
        None = 0
        Health = 1
        Mana = 2
        Agility = 3
        Strength = 4
        Intellect = 5
        Spirit = 6
        Stamina = 7
        DefenseSkillRating = 12
        DodgeRating = 13
        ParryRating = 14
        BlockRating = 15
        HitMeleeRating = 16
        HitRangedRating = 17
        HitSpellRating = 18
        CritMeleeRating = 19
        CritRangedRating = 20
        CritSpellRating = 21
        HitMeleeTakenRating = 22
        HitRangedTakenRating = 23
        HitSpellTakenRating = 24
        CritMeleeTakenRating = 25
        CritRangedTakenRating = 26
        CritSpellTakenRating = 27
        HasteMeleeRating = 28
        HasteRangedRating = 29
        HasteSpellRating = 30
        HitRating = 31
        CritRating = 32
        HitTakenRating = 33
        CritTakenRating = 34
        ResilienceRating = 35
        HasteRating = 36
        ExpertiseRating = 37
        AttackPower = 38
        RangedAttackPower = 39
        FeralAttackPower = 40
        SpellHealingDone = 41
        SpellDamageDone = 42
        ManaRegeneration = 43
        ArmorPenetrationRating = 44
        SpellPower = 45
        HealthRegeneration = 46
        SpellPenetration = 47
        BlockValue = 48
        MasteryRating = 49
        ExtraArmor = 50
        FireResistance = 51
        FrostResistance = 52
        ShadowResistance = 54
        NatureResistance = 55
        ArcaneResistance = 56
    End Enum

    ''' <summary>
    ''' An enumeration to describe the estimated amount of time left in an auction.
    ''' </summary>
    ''' <remarks>This enumeration is used in the <see cref="LibWowAPI.Auction.AuctionData" /> class, which returns auction data that includes the estimated amount of time left in each auction.</remarks>
    Public Enum AuctionTimeLeft
        Unknown = 0

        ''' <summary>
        ''' The auction has 30 minutes or less remaining.
        ''' </summary>
        ''' <remarks></remarks>
        [Short] = 1

        ''' <summary>
        ''' The auction has 30 minutes to 2 hours remaining.
        ''' </summary>
        ''' <remarks></remarks>
        Medium = 2

        ''' <summary>
        ''' The auction has 2 hours to 12 hours remaining.
        ''' </summary>
        ''' <remarks></remarks>
        [Long] = 3

        ''' <summary>
        ''' The auction has 12 hours or more remaining.
        ''' </summary>
        ''' <remarks></remarks>
        VeryLong = 4
    End Enum

End Namespace
