' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class item

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property disenchantingSkillRank As Integer
        <DataMember()> Public Property description As String
        <DataMember()> Public Property name As String
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property stackable As Integer
        <DataMember()> Public Property allowableClasses As Integer()
        <DataMember()> Public Property boundZone As boundZone
        <DataMember()> Public Property allowableRaces As Integer()
        <DataMember()> Public Property itemBind As Integer
        <DataMember()> Public Property bonusStats As item_stat()
        <DataMember()> Public ReadOnly itemSpells As itemSpell()
        <DataMember()> Public Property buyPrice As Integer
        <DataMember()> Public Property itemClass As Integer
        <DataMember()> Public Property itemSubClass As Integer
        <DataMember()> Public Property containerSlots As Integer
        <DataMember()> Public Property weaponInfo As weaponInfo
        <DataMember()> Public Property gemInfo As gemInfo
        <DataMember()> Public Property inventoryType As Integer
        <DataMember()> Public Property equippable As Boolean
        <DataMember()> Public Property itemLevel As Integer
        <DataMember()> Public Property itemSet As ItemSet.Schema.itemSet
        <DataMember()> Public Property maxCount As Integer
        <DataMember()> Public Property maxDurability As Integer
        <DataMember()> Public Property minFactionId As Integer
        <DataMember()> Public Property minReputation As Integer
        <DataMember()> Public Property quality As Integer
        <DataMember()> Public Property sellPrice As Integer
        <DataMember()> Public Property requiredSkill As Integer
        <DataMember()> Public Property requiredAbility As requiredAbility
        <DataMember()> Public Property requiredLevel As Integer
        <DataMember()> Public Property requiredSkillRank As Integer
        <DataMember()> Public Property socketInfo As socketInfo
        <DataMember()> Public Property itemSource As itemSource
        <DataMember()> Public Property baseArmor As Integer
        <DataMember()> Public Property hasSockets As Boolean
        <DataMember()> Public Property isAuctionable As Boolean
        <DataMember()> Public Property armor As Integer
        <DataMember()> Public Property displayInfoId As Integer
        <DataMember()> Public Property nameDescription As String
        <DataMember()> Public Property nameDescriptionColor As String
        <DataMember()> Public Property upgradable As Boolean
        <DataMember()> Public Property heroicTooltip As Boolean
        <DataMember()> Public Property context As String
        <DataMember()> Public Property bonusLists As Integer()
        <DataMember()> Public Property availableContexts As String()
        <DataMember()> Public Property bonusSummary As bonusSummary

    End Class

End Namespace
