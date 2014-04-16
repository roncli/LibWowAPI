' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Guild.Schema

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class character

        <DataMember()> Public Property lastModified As Long
        <DataMember()> Public Property name As String
        <DataMember()> Public Property realm As String
        <DataMember()> Public Property battlegroup As String
        <DataMember()> Public Property [class] As Integer
        <DataMember()> Public Property race As Integer
        <DataMember()> Public Property gender As Integer
        <DataMember()> Public Property level As Integer
        <DataMember()> Public Property achievementPoints As Integer
        <DataMember()> Public Property thumbnail As String
        <DataMember()> Public Property calcClass As String
        <DataMember()> Public Property totalHonorableKills As Integer
        <DataMember()> Public Property guild As guildBasicInfo
        <DataMember()> Public Property items As items
        <DataMember()> Public Property stats As stats
        <DataMember()> Public Property professions As professions
        <DataMember()> Public Property reputation As reputation()
        <DataMember()> Public Property titles As title()
        <DataMember()> Public Property achievements As achievements
        <DataMember()> Public Property hunterPets As hunterPet()
        <DataMember()> Public Property talents As talentSpec()
        <DataMember()> Public Property appearance As appearance
        <DataMember()> Public Property mounts As mounts
        <DataMember()> Public Property progression As progression
        <DataMember()> Public Property pvp As pvp
        <DataMember()> Public Property quests As Integer()
        <DataMember()> Public Property feed As feed()
        <DataMember()> Public Property pets As pets
        <DataMember()> Public Property petSlots As petSlot()
        <DataMember()> Public Property audit As audit

    End Class

End Namespace
