' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class stats

        <DataMember()> Public Property health As Integer
        <DataMember()> Public Property powerType As String
        <DataMember()> Public Property power As Integer
        <DataMember()> Public Property str As Integer
        <DataMember()> Public Property agi As Integer
        <DataMember()> Public Property sta As Integer
        <DataMember()> Public Property int As Integer
        <DataMember()> Public Property spr As Integer
        <DataMember()> Public Property attackPower As Integer
        <DataMember()> Public Property rangedAttackPower As Integer
        <DataMember()> Public Property mastery As Double
        <DataMember()> Public Property masteryRating As Integer
        <DataMember()> Public Property crit As Double
        <DataMember()> Public Property critRating As Integer
        <DataMember()> Public Property hitPercent As Double
        <DataMember()> Public Property hitRating As Integer
        <DataMember()> Public Property hasteRating As Integer
        <DataMember()> Public Property expertiseRating As Integer
        <DataMember()> Public Property spellPower As Integer
        <DataMember()> Public Property spellPen As Integer
        <DataMember()> Public Property spellCrit As Double
        <DataMember()> Public Property spellCritRating As Integer
        <DataMember()> Public Property spellHitPercent As Double
        <DataMember()> Public Property spellHitRating As Integer
        <DataMember()> Public Property mana5 As Double
        <DataMember()> Public Property mana5Combat As Double
        <DataMember()> Public Property armor As Integer
        <DataMember()> Public Property dodge As Double
        <DataMember()> Public Property dodgeRating As Integer
        <DataMember()> Public Property parry As Double
        <DataMember()> Public Property parryRating As Integer
        <DataMember()> Public Property block As Double
        <DataMember()> Public Property blockRating As Integer
        <DataMember()> Public Property resil As Integer
        <DataMember()> Public Property mainHandDmgMin As Double
        <DataMember()> Public Property mainHandDmgMax As Double
        <DataMember()> Public Property mainHandSpeed As Double
        <DataMember()> Public Property mainHandDps As Double
        <DataMember()> Public Property mainHandExpertise As Integer
        <DataMember()> Public Property offHandDmgMin As Double
        <DataMember()> Public Property offHandDmgMax As Double
        <DataMember()> Public Property offHandSpeed As Double
        <DataMember()> Public Property offHandDps As Double
        <DataMember()> Public Property offHandExpertise As Integer
        <DataMember()> Public Property rangedDmgMin As Double
        <DataMember()> Public Property rangedDmgMax As Double
        <DataMember()> Public Property rangedSpeed As Double
        <DataMember()> Public Property rangedDps As Double
        <DataMember()> Public Property rangedCrit As Double
        <DataMember()> Public Property rangedCritRating As Integer
        <DataMember()> Public Property rangedHitPercent As Double
        <DataMember()> Public Property rangedHitRating As Integer

    End Class

End Namespace
