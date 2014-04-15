' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.BattlePet.Schema

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class collected

        <DataMember()> Public Property name As String
        <DataMember()> Public Property spellId As Integer
        <DataMember()> Public Property creatureId As Integer
        <DataMember()> Public Property itemId As Integer
        <DataMember()> Public Property qualityId As Integer
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property stats As BattlePet.Schema.stats
        <DataMember()> Public Property battlePetGuid As String
        <DataMember()> Public Property isFavorite As Boolean
        <DataMember()> Public Property isFirstAbilitySlotSelected As Boolean
        <DataMember()> Public Property isSecondAbilitySlotSelected As Boolean
        <DataMember()> Public Property isThirdAbilitySlotSelected As Boolean
        <DataMember()> Public Property creatureName As String
        <DataMember()> Public Property canBattle As Boolean

    End Class

End Namespace
