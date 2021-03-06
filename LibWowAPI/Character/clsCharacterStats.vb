﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's combat statistics.
    ''' </summary>
    ''' <remarks>Most of a character's combat statistics are available in this class.</remarks>
    Public Class CharacterStats

        ''' <summary>
        ''' The amount of health the character has.
        ''' </summary>
        ''' <value>This property gets or sets the Health field.</value>
        ''' <returns>Returns the amount of health the character has.</returns>
        ''' <remarks>This represents the amount of health the character has unbuffed.</remarks>
        Public Property Health As Integer

        ''' <summary>
        ''' The power type the character uses.
        ''' </summary>
        ''' <value>This property gets or sets the PowerType field.</value>
        ''' <returns>Returns the power type the character uses.</returns>
        ''' <remarks>This is a <see cref="Enums.PowerType" /> enumeration that indicates the type of power the character uses.</remarks>
        Public Property PowerType As PowerType

        ''' <summary>
        ''' The amount of power the character has.
        ''' </summary>
        ''' <value>This property gets or sets the Power field.</value>
        ''' <returns>Returns the amount of power the character has.</returns>
        ''' <remarks>This is the maximum amount of power available to the character.</remarks>
        Public Property Power As Integer

        ''' <summary>
        ''' The character's strength.
        ''' </summary>
        ''' <value>This property gets or sets the Str field.</value>
        ''' <returns>Returns the character's strength.</returns>
        ''' <remarks>This represents the character's strength.</remarks>
        Public Property Str As Integer

        ''' <summary>
        ''' The character's agility.
        ''' </summary>
        ''' <value>This property gets or sets the Agi field.</value>
        ''' <returns>Returns the character's agility.</returns>
        ''' <remarks>This represents the character's agility.</remarks>
        Public Property Agi As Integer

        ''' <summary>
        ''' The character's stamina.
        ''' </summary>
        ''' <value>This property gets or sets the Sta field.</value>
        ''' <returns>Returns the character's stamina.</returns>
        ''' <remarks>This represents the character's stamina.</remarks>
        Public Property Sta As Integer

        ''' <summary>
        ''' The character's intellect.
        ''' </summary>
        ''' <value>This property gets or sets the Int field.</value>
        ''' <returns>Returns the character's intellect.</returns>
        ''' <remarks>This represents the character's intellect.</remarks>
        Public Property Int As Integer

        ''' <summary>
        ''' The character's spirit.
        ''' </summary>
        ''' <value>This property gets or sets the Spr field.</value>
        ''' <returns>Returns the character's spirit.</returns>
        ''' <remarks>This represents the character's spirit.</remarks>
        Public Property Spr As Integer

        ''' <summary>
        ''' The character's attack power.
        ''' </summary>
        ''' <value>This property gets or sets the AttackPower field.</value>
        ''' <returns>Returns the character's attack power.</returns>
        ''' <remarks>This represents the amount of attack power the character has.</remarks>
        Public Property AttackPower As Integer

        ''' <summary>
        ''' The character's ranged attack power.
        ''' </summary>
        ''' <value>This property gets or sets the RangedAttackPower field.</value>
        ''' <returns>Returns the character's ranged attack power.</returns>
        ''' <remarks>This represents the amount of ranged attack power the character has.</remarks>
        Public Property RangedAttackPower As Integer

        ''' <summary>
        ''' The character's bonus to PvP resilience.
        ''' </summary>
        ''' <value>This property gets or sets the PvpResilienceBonus field.</value>
        ''' <returns>Returns the character's bonus to PvP resilience.</returns>
        ''' <remarks>This represents the character's bonus to PvP resilience.</remarks>
        Public Property PvpResilienceBonus As Double

        ''' <summary>
        ''' The character's mastery.
        ''' </summary>
        ''' <value>This property gets or sets the Mastery field.</value>
        ''' <returns>Returns the character's mastery.</returns>
        ''' <remarks>This represents the amount of mastery the character has.</remarks>
        Public Property Mastery As Double

        ''' <summary>
        ''' The character's mastery rating.
        ''' </summary>
        ''' <value>This property gets or sets the MasteryRating field.</value>
        ''' <returns>Returns the character's mastery rating.</returns>
        ''' <remarks>This represents the character's mastery rating.</remarks>
        Public Property MasteryRating As Integer

        ''' <summary>
        ''' The character's percentage chance to critically strike.
        ''' </summary>
        ''' <value>This property gets or sets the Crit field.</value>
        ''' <returns>Returns the character's percentage chance to critically strike.</returns>
        ''' <remarks>This represents the character's percentage chance to critically strike.</remarks>
        Public Property Crit As Double

        ''' <summary>
        ''' The character's critical strike rating.
        ''' </summary>
        ''' <value>This property gets or sets the CritRating field.</value>
        ''' <returns>Returns the character's critical strike rating.</returns>
        ''' <remarks>This represents the amount of critical strike rating the character has.</remarks>
        Public Property CritRating As Integer

        ''' <summary>
        ''' The character's percentage increase in haste.
        ''' </summary>
        ''' <value>This property gets or sets the Haste field.</value>
        ''' <returns>Returns the character's percentage increase in haste.</returns>
        ''' <remarks>This represents the character's increase in haste.  Use the <see cref="HasteRatingPercent" /> property for a slightly more precise percentage.</remarks>
        Public Property Haste As Double

        ''' <summary>
        ''' The character's haste rating.
        ''' </summary>
        ''' <value>This property gets or sets the HasteRating field.</value>
        ''' <returns>Returns the character's haste rating.</returns>
        ''' <remarks>This represents the amount of haste rating the character has.</remarks>
        Public Property HasteRating As Integer

        ''' <summary>
        ''' The character's percentage increase in haste.
        ''' </summary>
        ''' <value>This property gets or sets the HasteRatingPercent field.</value>
        ''' <returns>Returns the character's percentage increase in haste.</returns>
        ''' <remarks>This represents the character's increase in haste.  This is slightly more precise than the <see cref="Haste" /> property.</remarks>
        Public Property HasteRatingPercent As Double

        ''' <summary>
        ''' The character's expertise rating.
        ''' </summary>
        ''' <value>This property gets or sets the ExpertiseRating field.</value>
        ''' <returns>Returns the character's expertise rating.</returns>
        ''' <remarks>This represents the amount of expertise rating the character has.</remarks>
        Public Property ExpertiseRating As Integer

        ''' <summary>
        ''' The character's spell power.
        ''' </summary>
        ''' <value>This property gets or sets the SpellPower field.</value>
        ''' <returns>Returns the character's spell power.</returns>
        ''' <remarks>This represents the amount of spell power the character has.</remarks>
        Public Property SpellPower As Integer

        ''' <summary>
        ''' The character's spell penetration.
        ''' </summary>
        ''' <value>This property gets or sets the SpellPen field.</value>
        ''' <returns>Returns the character's spell penetration.</returns>
        ''' <remarks>This represents the character's spell penetration.</remarks>
        Public Property SpellPen As Integer

        ''' <summary>
        ''' The character's percentage chance to critically strike with spells.
        ''' </summary>
        ''' <value>This property gets or sets the SpellCrit field.</value>
        ''' <returns>Returns the character's percentage chance to critically strike with spells.</returns>
        ''' <remarks>This represents the character's percentage chance to critically strike with spells.</remarks>
        Public Property SpellCrit As Double

        ''' <summary>
        ''' The character's spell critical strike rating.
        ''' </summary>
        ''' <value>This property gets or sets the SpellCritRating field.</value>
        ''' <returns>Returns the character's spell critical strike rating.</returns>
        ''' <remarks>This represents the amount of spell critical strike rating the character has.</remarks>
        Public Property SpellCritRating As Integer

        ''' <summary>
        ''' The amount of mana the character regenerates out of combat every 5 seconds.
        ''' </summary>
        ''' <value>This property gets or sets the Mana5 field.</value>
        ''' <returns>Returns the amount of mana the character regenerates out of combat every 5 seconds.</returns>
        ''' <remarks>This represents the amount of mana the character regenerates out of combat every 5 seconds.</remarks>
        Public Property Mana5 As Double

        ''' <summary>
        ''' The amount of mana the character regenerates in combat every 5 seconds.
        ''' </summary>
        ''' <value>This property gets or sets the Mana5Combat field.</value>
        ''' <returns>Returns the amount of mana the character regenerates in combat every 5 seconds.</returns>
        ''' <remarks>This represents the amount of mana the character regenerates in combat every 5 seconds.</remarks>
        Public Property Mana5Combat As Double

        ''' <summary>
        ''' The character's percentage increase in spell haste.
        ''' </summary>
        ''' <value>This property gets or sets the SpellHaste field.</value>
        ''' <returns>Returns the character's percentage increase in spell haste.</returns>
        ''' <remarks>This represents the character's increase in spell haste.  Use the <see cref="SpellHasteRatingPercent" /> property for a slightly more precise percentage.</remarks>
        Public Property SpellHaste As Double

        ''' <summary>
        ''' The character's spell haste rating.
        ''' </summary>
        ''' <value>This property gets or sets the SpellHasteRating field.</value>
        ''' <returns>Returns the character's spell haste rating.</returns>
        ''' <remarks>This represents the amount of spell haste rating the character has.</remarks>
        Public Property SpellHasteRating As Integer

        ''' <summary>
        ''' The character's percentage increase in spell haste.
        ''' </summary>
        ''' <value>This property gets or sets the SpellHasteRatingPercent field.</value>
        ''' <returns>Returns the character's percentage increase in spell haste.</returns>
        ''' <remarks>This represents the character's increase in spell haste.  This is slightly more precise than the <see cref="SpellHaste" /> property.</remarks>
        Public Property SpellHasteRatingPercent As Double
        ''' <summary>
        ''' The character's armor.
        ''' </summary>
        ''' <value>This property gets or sets the Armor field.</value>
        ''' <returns>Returns the character's armor.</returns>
        ''' <remarks>This represents the amount of armor the character has.</remarks>
        Public Property Armor As Integer

        ''' <summary>
        ''' The character's percentage chance to dodge.
        ''' </summary>
        ''' <value>This property gets or sets the Dodge field.</value>
        ''' <returns>Returns the character's percentage chance to dodge.</returns>
        ''' <remarks>This represents the character's percentage chance to dodge.</remarks>
        Public Property Dodge As Double

        ''' <summary>
        ''' The character's dodge rating.
        ''' </summary>
        ''' <value>This property gets or sets the DodgeRating field.</value>
        ''' <returns>Returns the character's dodge rating.</returns>
        ''' <remarks>This represents the amount of dodge rating the character has.</remarks>
        Public Property DodgeRating As Integer

        ''' <summary>
        ''' The character's percentage chance to parry.
        ''' </summary>
        ''' <value>This property gets or sets the Parry field.</value>
        ''' <returns>Returns the character's percentage chance to parry.</returns>
        ''' <remarks>This represents the character's percentage chance to parry.</remarks>
        Public Property Parry As Double

        ''' <summary>
        ''' The character's parry rating.
        ''' </summary>
        ''' <value>This property gets or sets the ParryRating field.</value>
        ''' <returns>Returns the character's parry rating.</returns>
        ''' <remarks>This represents the amount of parry rating the character has.</remarks>
        Public Property ParryRating As Integer

        ''' <summary>
        ''' The character's percentage chance to block.
        ''' </summary>
        ''' <value>This property gets or sets the Block field.</value>
        ''' <returns>Returns the character's percentage chance to block.</returns>
        ''' <remarks>This represents the character's percentage chance to block.</remarks>
        Public Property Block As Double

        ''' <summary>
        ''' The character's block rating.
        ''' </summary>
        ''' <value>This property gets or sets the BlockRating field.</value>
        ''' <returns>Returns the character's block rating.</returns>
        ''' <remarks>This represents the amount of block rating the character has.</remarks>
        Public Property BlockRating As Integer

        ''' <summary>
        ''' The character's percentage resilience.
        ''' </summary>
        ''' <value>This property gets or sets the PvpResilience field.</value>
        ''' <returns>Returns the character's percentage resilience.</returns>
        ''' <remarks>This represents the character's percentage resilience.</remarks>
        Public Property PvpResilience As Double

        ''' <summary>
        ''' The character's resilience rating.
        ''' </summary>
        ''' <value>This property gets or sets the PvpResilienceRating field.</value>
        ''' <returns>Returns the character's resilience rating.</returns>
        ''' <remarks>This represents the amount of resilience rating the character has.</remarks>
        Public Property PvpResilienceRating As Integer

        ''' <summary>
        ''' The minimum damage the character does with the main hand weapon.
        ''' </summary>
        ''' <value>This property gets or sets the MainHandDmgMin field.</value>
        ''' <returns>Returns the minimum damage the character does with the main hand weapon.</returns>
        ''' <remarks>This represents the minimum damage the character does with the main hand weapon.</remarks>
        Public Property MainHandDmgMin As Double

        ''' <summary>
        ''' The maximum damage the character does with the main hand weapon.
        ''' </summary>
        ''' <value>This property gets or sets the MainHandDmgMax field.</value>
        ''' <returns>Returns the maximum damage the character does with the main hand weapon.</returns>
        ''' <remarks>This represents the maximum damage the character does with the main hand weapon.</remarks>
        Public Property MainHandDmgMax As Double

        ''' <summary>
        ''' The character's main hand weapon speed.
        ''' </summary>
        ''' <value>This property gets or sets the MainHandSpeed field.</value>
        ''' <returns>Returns the character's main hand weapon speed.</returns>
        ''' <remarks>This represents the character's main hand weapon speed.</remarks>
        Public Property MainHandSpeed As Double

        ''' <summary>
        ''' The character's main hand weapon DPS.
        ''' </summary>
        ''' <value>This property gets or sets the MainHandDps field.</value>
        ''' <returns>Returns the character's main hand weapon DPS.</returns>
        ''' <remarks>This represents the character's main hand weapon DPS.</remarks>
        Public Property MainHandDps As Double

        ''' <summary>
        ''' The minimum damage the character does with the off hand weapon.
        ''' </summary>
        ''' <value>This property gets or sets the OffHandDmgMin field.</value>
        ''' <returns>Returns the minimum damage the character does with the off hand weapon.</returns>
        ''' <remarks>This represents the minimum damage the character does with the off hand weapon.</remarks>
        Public Property OffHandDmgMin As Double

        ''' <summary>
        ''' The maximum damage the character does with the off hand weapon.
        ''' </summary>
        ''' <value>This property gets or sets the OffHandDmgMax field.</value>
        ''' <returns>Returns the maximum damage the character does with the off hand weapon.</returns>
        ''' <remarks>This represents the maximum damage the character does with the off hand weapon.</remarks>
        Public Property OffHandDmgMax As Double

        ''' <summary>
        ''' The character's off hand weapon speed.
        ''' </summary>
        ''' <value>This property gets or sets the OffHandSpeed field.</value>
        ''' <returns>Returns the character's off hand weapon speed.</returns>
        ''' <remarks>This represents the character's off hand weapon speed.</remarks>
        Public Property OffHandSpeed As Double

        ''' <summary>
        ''' The character's off hand weapon DPS.
        ''' </summary>
        ''' <value>This property gets or sets the OffHandDps field.</value>
        ''' <returns>Returns the character's off hand weapon DPS.</returns>
        ''' <remarks>This represents the character's off hand weapon DPS.</remarks>
        Public Property OffHandDps As Double

        ''' <summary>
        ''' The minimum damage the character does with the ranged weapon.
        ''' </summary>
        ''' <value>This property gets or sets the RangedDmgMin field.</value>
        ''' <returns>Returns the minimum damage the character does with the ranged weapon.</returns>
        ''' <remarks>This represents the minimum damage the character does with the ranged weapon.</remarks>
        Public Property RangedDmgMin As Double

        ''' <summary>
        ''' The maximum damage the character does with the ranged weapon.
        ''' </summary>
        ''' <value>This property gets or sets the RangedDmgMax field.</value>
        ''' <returns>Returns the maximum damage the character does with the ranged weapon.</returns>
        ''' <remarks>This represents the maximum damage the character does with the ranged weapon.</remarks>
        Public Property RangedDmgMax As Double

        ''' <summary>
        ''' The ranged weapon speed.
        ''' </summary>
        ''' <value>This property gets or sets the RangedSpeed field.</value>
        ''' <returns>Returns the ranged weapon speed.</returns>
        ''' <remarks>This represents the ranged weapon speed.</remarks>
        Public Property RangedSpeed As Double

        ''' <summary>
        ''' The ranged weapon DPS.
        ''' </summary>
        ''' <value>This property gets or sets the RangedDps field.</value>
        ''' <returns>Returns the ranged weapon DPS.</returns>
        ''' <remarks>This represents the ranged weapon DPS.</remarks>
        Public Property RangedDps As Double

        ''' <summary>
        ''' The character's percentage chance to critically strike with a ranged attack.
        ''' </summary>
        ''' <value>This property gets or sets the RangedCrit field.</value>
        ''' <returns>Returns the character's percentage chance to critically strike with a ranged attack.</returns>
        ''' <remarks>This represents the character's percentage chance to critically strike with a ranged attack.</remarks>
        Public Property RangedCrit As Double

        ''' <summary>
        ''' The character's ranged critical strike rating.
        ''' </summary>
        ''' <value>This property gets or sets the RangedCritRating field.</value>
        ''' <returns>Returns the character's ranged critical strike rating.</returns>
        ''' <remarks>This represents the character's ranged critical strike rating.</remarks>
        Public Property RangedCritRating As Integer

        ''' <summary>
        ''' The character's percentage increase in ranged haste.
        ''' </summary>
        ''' <value>This property gets or sets the RangedHaste field.</value>
        ''' <returns>Returns the character's percentage increase in ranged haste.</returns>
        ''' <remarks>This represents the character's increase in ranged haste.  Use the <see cref="RangedHasteRatingPercent" /> property for a slightly more precise percentage.</remarks>
        Public Property RangedHaste As Double

        ''' <summary>
        ''' The character's ranged haste rating.
        ''' </summary>
        ''' <value>This property gets or sets the RangedHasteRating field.</value>
        ''' <returns>Returns the character's ranged haste rating.</returns>
        ''' <remarks>This represents the amount of ranged haste rating the character has.</remarks>
        Public Property RangedHasteRating As Integer

        ''' <summary>
        ''' The character's percentage increase in ranged haste.
        ''' </summary>
        ''' <value>This property gets or sets the RangedHasteRatingPercent field.</value>
        ''' <returns>Returns the character's percentage increase in ranged haste.</returns>
        ''' <remarks>This represents the character's increase in ranged haste.  This is slightly more precise than the <see cref="RangedHaste" /> property.</remarks>
        Public Property RangedHasteRatingPercent As Double

        ''' <summary>
        ''' The character's percentage PvP power.
        ''' </summary>
        ''' <value>This property gets or sets the PvpPower field.</value>
        ''' <returns>Returns the character's percentage PvP power.</returns>
        ''' <remarks>This represents the character's percentage PvP power.</remarks>
        Public Property PvpPower As Double

        ''' <summary>
        ''' The character's PvP power rating.
        ''' </summary>
        ''' <value>This property gets or sets the PvpPowerRating field.</value>
        ''' <returns>Returns the character's PvP power rating.</returns>
        ''' <remarks>This represents the character's PvP power rating.</remarks>
        Public Property PvpPowerRating As Integer

        ''' <summary>
        ''' The character's PvP power damage.
        ''' </summary>
        ''' <value>This property gets or sets the PvpPowerDamage field.</value>
        ''' <returns>Returns the character's PvP power damage.</returns>
        ''' <remarks>This represents the character's PvP power damage.</remarks>
        Public Property PvpPowerDamage As Double

        ''' <summary>
        ''' The character's PvP power healing.
        ''' </summary>
        ''' <value>This property gets or sets the PvpPowerHealing field.</value>
        ''' <returns>Returns the character's PvP power healing.</returns>
        ''' <remarks>This represents the character's PvP power healing.</remarks>
        Public Property PvpPowerHealing As Double

        Friend Sub New(intHealth As Integer, ptPowerType As PowerType, intPower As Integer, intStr As Integer, intAgi As Integer, intSta As Integer, intInt As Integer, intSpr As Integer, intAttackPower As Integer, intRangedAttackPower As Integer, dblPvpResilienceBonus As Double, dblMastery As Double, intMasteryRating As Integer, dblCrit As Double, intCritRating As Integer, dblHaste As Double, intHasteRating As Integer, dblHasteRatingPercent As Double, intExpertiseRating As Integer, intSpellPower As Integer, intSpellPen As Integer, dblSpellCrit As Double, intSpellCritRating As Integer, dblMana5 As Double, dblMana5Combat As Double, dblSpellHaste As Double, intSpellHasteRating As Integer, dblSpellHasteRatingPercent As Double, intArmor As Integer, dblDodge As Double, intDodgeRating As Integer, dblParry As Double, intParryRating As Integer, dblBlock As Double, intBlockRating As Integer, dblPvpResilience As Double, intPvpResilienceRating As Integer, dblMainHandDmgMin As Double, dblMainHandDmgMax As Double, dblMainHandSpeed As Double, dblMainHandDps As Double, dblOffHandDmgMin As Double, dblOffHandDmgMax As Double, dblOffHandSpeed As Double, dblOffHandDps As Double, dblRangedDmgMin As Double, dblRangedDmgMax As Double, dblRangedSpeed As Double, dblRangedDps As Double, dblRangedCrit As Double, intRangedCritRating As Integer, dblRangedHaste As Double, intRangedHasteRating As Integer, dblRangedHasteRatingPercent As Double, dblPvpPower As Double, intPvpPowerRating As Integer, dblPvpPowerDamage As Double, dblPvpPowerHealing As Double)
            Health = intHealth
            PowerType = ptPowerType
            Power = intPower
            Str = intStr
            Agi = intAgi
            Sta = intSta
            Int = intInt
            Spr = intSpr
            AttackPower = intAttackPower
            RangedAttackPower = intRangedAttackPower
            PvpResilienceBonus = dblPvpResilienceBonus
            Mastery = dblMastery
            MasteryRating = intMasteryRating
            Crit = dblCrit
            CritRating = intCritRating
            Haste = dblHaste
            HasteRating = intHasteRating
            HasteRatingPercent = dblHasteRatingPercent
            ExpertiseRating = intExpertiseRating
            SpellPower = intSpellPower
            SpellPen = intSpellPen
            SpellCrit = dblSpellCrit
            SpellCritRating = intSpellCritRating
            Mana5 = dblMana5
            Mana5Combat = dblMana5Combat
            SpellHaste = dblSpellHaste
            SpellHasteRating = intSpellHasteRating
            SpellHasteRatingPercent = dblSpellHasteRatingPercent
            Armor = intArmor
            Dodge = dblDodge
            DodgeRating = intDodgeRating
            Parry = dblParry
            ParryRating = intParryRating
            Block = dblBlock
            BlockRating = intBlockRating
            PvpResilience = dblPvpResilience
            PvpResilienceRating = intPvpResilienceRating
            MainHandDmgMin = dblMainHandDmgMin
            MainHandDmgMax = dblMainHandDmgMax
            MainHandSpeed = dblMainHandSpeed
            MainHandDps = dblMainHandDps
            OffHandDmgMin = dblOffHandDmgMin
            OffHandDmgMax = dblOffHandDmgMax
            OffHandSpeed = dblOffHandSpeed
            OffHandDps = dblOffHandDps
            RangedDmgMin = dblRangedDmgMin
            RangedDmgMax = dblRangedDmgMax
            RangedSpeed = dblRangedSpeed
            RangedDps = dblRangedDps
            RangedCrit = dblRangedCrit
            RangedCritRating = intRangedCritRating
            RangedHaste = dblRangedHaste
            RangedHasteRating = intRangedHasteRating
            RangedHasteRatingPercent = dblRangedHasteRatingPercent
            PvpPower = dblPvpPower
            PvpPowerRating = intPvpPowerRating
            PvpPowerDamage = dblPvpPowerDamage
            dblPvpPowerHealing = dblPvpPowerHealing
        End Sub

    End Class

End Namespace
