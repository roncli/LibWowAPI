' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class character

        <DataMember()> Public Property lastModified As Long
        <DataMember()> Public Property name As String
        <DataMember()> Public Property realm As String
        <DataMember()> Public Property [class] As Integer
        <DataMember()> Public Property race As Integer
        <DataMember()> Public Property gender As Integer
        <DataMember()> Public Property level As Integer
        <DataMember()> Public Property achievementPoints As Integer
        <DataMember()> Public Property thumbnail As String
        <DataMember()> Public Property guild As guild
        <DataMember()> Public Property items As items
        <DataMember()> Public Property stats As stats
        <DataMember()> Public Property professions As professions
        <DataMember()> Public Property reputation As reputation()
        <DataMember()> Public Property titles As title()
        <DataMember()> Public Property achievements As achievements
        <DataMember()> Public Property pets As pet()
        <DataMember()> Public Property talents As talent()
        <DataMember()> Public Property appearance As appearance
        <DataMember()> Public Property mounts As Integer()
        <DataMember()> Public Property companions As Integer()
        <DataMember()> Public Property progression As progression
        <DataMember()> Public Property pvp As pvp
        <DataMember()> Public Property quests As Integer()

    End Class

End Namespace
