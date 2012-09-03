' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Realm.Schema

    <DataContract()> Friend Class pvpZone

        <DataMember()> Public Property area As Integer
        <DataMember(Name:="controlling-faction")> Public Property controllingFaction As Integer
        <DataMember()> Public Property status As Integer
        <DataMember()> Public Property [next] As Long

    End Class

End Namespace
