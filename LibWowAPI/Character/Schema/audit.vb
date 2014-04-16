' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.Generic
Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class audit

        <DataMember()> Public Property numberOfIssues As Integer
        <DataMember()> Public Property slots As Dictionary(Of String, Integer)
        <DataMember()> Public Property emptyGlyphSlots As Integer
        <DataMember()> Public Property unspentTalentPoints As Integer
        <DataMember()> Public Property noSpec As Boolean
        <DataMember()> Public Property unenchantedItems As Dictionary(Of String, Integer)
        <DataMember()> Public Property emptySockets As Integer
        <DataMember()> Public Property itemsWithEmptySockets As Dictionary(Of String, Integer)
        <DataMember()> Public Property appropriateArmorType As Integer
        <DataMember()> Public Property inappropriateArmorType As Dictionary(Of String, Integer)
        <DataMember()> Public Property lowLevelItems As lowLevelItems
        <DataMember()> Public Property lowLevelThreshold As Integer
        <DataMember()> Public Property missingExtraSockets As Dictionary(Of String, Integer)
        <DataMember()> Public Property recommendedBeltBuckle As LibWowAPI.Item.Schema.item
        <DataMember()> Public Property missingBlacksmithSockets As Dictionary(Of String, Integer)
        <DataMember()> Public Property missingEnchanterEnchants As Dictionary(Of String, Integer)
        <DataMember()> Public Property missingEngineerEnchants As Dictionary(Of String, Integer)
        <DataMember()> Public Property missingScribeEnchants As Dictionary(Of String, Integer)
        <DataMember()> Public Property nMissingJewelcrafterGems As Integer
        <DataMember()> Public Property recommendedJewelcrafterGem As LibWowAPI.Item.Schema.item
        <DataMember()> Public Property missingLeatherworkerEnchants As Dictionary(Of String, Integer)

    End Class

End Namespace
