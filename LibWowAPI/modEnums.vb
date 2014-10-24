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
    ''' An enumeration to describe a faction.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Data.CharacterRaces" /> class, among others, to identify which faction the character belongs to.</remarks>
    Public Enum Faction
        Unknown = -1
        Alliance = 0
        Horde = 1
        Neutral = 2
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
        <Obsolete("This inventory type is obsolete.")> Relic = 28
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
    Public Enum ItemStat
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
        PvpPowerRating = 57
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

    ''' <summary>
    ''' An enumeration to describe the current status of a PvP zone.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Realm.RealmStatus" /> class to indicate the status of a world PvP zone.</remarks>
    Public Enum PvpZoneStatus
        Unknown = -1

        ''' <summary>
        ''' The zone is currently idle.
        ''' </summary>
        ''' <remarks></remarks>
        Idle = 0

        ''' <summary>
        ''' The zone is currently populating, accepting players for the next battle.
        ''' </summary>
        ''' <remarks></remarks>
        Populating = 1

        ''' <summary>
        ''' The zone is currently undergoing an active battle.
        ''' </summary>
        ''' <remarks></remarks>
        Active = 2

        ''' <summary>
        ''' The zone just recently concluded a battle.
        ''' </summary>
        ''' <remarks></remarks>
        Concluding = 3
    End Enum

    ''' <summary>
    ''' An enumeration to describe how an item spell is proced.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Item.ItemLookup" /> class to identify how to proc an item's effect.</remarks>
    Public Enum ItemSpellTrigger
        Unknown = -1

        ''' <summary>
        ''' The item spell is proced passively.
        ''' </summary>
        ''' <remarks></remarks>
        OnEquip = 0

        ''' <summary>
        ''' The item spell is proced on use.
        ''' </summary>
        ''' <remarks></remarks>
        OnUse = 1
    End Enum

    ''' <summary>
    ''' An enumeration to describe a battle pet's breed.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Auction.AuctionData" /> class and other battle pet related classes, to identify the breed of a battle pet.</remarks>
    Public Enum BattlePetBreed
        Unknown = 0

        ''' <summary>
        ''' Adds 2.5 base health, 0.5 base power, and 0.5 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleBalanced = 3

        ''' <summary>
        ''' Adds 2 base power per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleDoublePower = 4

        ''' <summary>
        ''' Adds 2 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleDoubleSpeed = 5

        ''' <summary>
        ''' Adds 10 base health per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleDoubleHealth = 6

        ''' <summary>
        ''' Adds 4.5 base health and 0.9 base power per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleHealthPower = 7

        ''' <summary>
        ''' Adds 0.9 base power and 0.9 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        MalePowerSpeed = 8

        ''' <summary>
        ''' Adds 4.5 base health and 0.9 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleHealthSpeed = 9

        ''' <summary>
        ''' Adds 2 base health, 0.9 base power, and 0.4 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleBalancedPower = 10

        ''' <summary>
        ''' Adds 2 base health, 0.4 base power, and 0.9 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleBalancedSpeed = 11

        ''' <summary>
        ''' Adds 4.5 base health, 0.4 base power, and 0.4 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        MaleBalancedHealth = 12

        ''' <summary>
        ''' Adds 2.5 base health, 0.5 base power, and 0.5 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleBalanced = 13

        ''' <summary>
        ''' Adds 2 base power per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleDoublePower = 14

        ''' <summary>
        ''' Adds 2 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleDoubleSpeed = 15

        ''' <summary>
        ''' Adds 10 base health per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleDoubleHealth = 16

        ''' <summary>
        ''' Adds 4.5 base health and 0.9 base power per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleHealthPower = 17

        ''' <summary>
        ''' Adds 0.9 base power and 0.9 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemalePowerSpeed = 18

        ''' <summary>
        ''' Adds 4.5 base health and 0.9 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleHealthSpeed = 19

        ''' <summary>
        ''' Adds 2 base health, 0.9 base power, and 0.4 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleBalancedPower = 20

        ''' <summary>
        ''' Adds 2 base health, 0.4 base power, and 0.9 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleBalancedSpeed = 21

        ''' <summary>
        ''' Adds 4.5 base health, 0.4 base power, and 0.4 base speed per level.
        ''' </summary>
        ''' <remarks></remarks>
        FemaleBalancedHealth = 22
    End Enum

    ''' <summary>
    ''' An enumeration to describe a character's equipment slot.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Character.CharacterProfile" /> class to identify the slot an item is being worn on.</remarks>
    Public Enum EquipmentSlot
        Unknwon = -1
        Head = 0
        Shoulders = 2
        Shirt = 3
        Chest = 4
        Waist = 5
        Legs = 6
        Feet = 7
        Wrist = 8
        Hands = 9
        Finger1 = 10
        Finger2 = 11
        Trinket1 = 12
        Trinket2 = 13
        Back = 14
        MainHand = 15
        OffHand = 16
        Tabard = 18
    End Enum

    ''' <summary>
    ''' An enumeration that describes a leaderboard type.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Leaderboard.LeaderboardLookup" /> class to identify which bracket the leaderboard is for.</remarks>
    Public Enum LeaderboardType
        Unknown = 0
        Arena2v2 = 1
        Arena3v3 = 2
        Arena5v5 = 3
        RatedBattlegrounds = 4
    End Enum

    ''' <summary>
    ''' An enumeration that describes an armor type.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Character.CharacterProfile" /> class to identify the type of armor the character wears.</remarks>
    Public Enum ArmorType
        Unknown = -1
        None = 0
        Cloth = 1
        Leather = 2
        Mail = 3
        Plate = 4
    End Enum

    ''' <summary>
    ''' An enumeration that describes a glyph type.
    ''' </summary>
    ''' <remarks>This enumeration is used by the <see cref="LibWowAPI.Data.Talents" /> class to identify the type of glyph.</remarks>
    Public Enum GlyphType
        Major = 0
        Minor = 1
    End Enum

End Namespace
