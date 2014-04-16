' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Spell.Schema

    <DataContract()> Friend Class spell

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property name As String
        <DataMember()> Public Property subtext As String
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property description As String
        <DataMember()> Public Property range As String
        <DataMember()> Public Property powerCost As String
        <DataMember()> Public Property castTime As String
        <DataMember()> Public Property cooldown As String

    End Class

End Namespace
