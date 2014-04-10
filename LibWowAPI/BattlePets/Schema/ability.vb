' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.BattlePets.Schema

    <DataContract()> Friend Class ability

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property name As String
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property cooldown As Integer
        <DataMember()> Public Property rounds As Integer
        <DataMember()> Public Property petTypeId As Integer
        <DataMember()> Public Property isPassive As Boolean
        <DataMember()> Public Property hideHints As Boolean

    End Class

End Namespace
