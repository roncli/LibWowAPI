' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class tooltipParams

        <DataMember()> Public Property gem0 As Integer
        <DataMember()> Public Property gem1 As Integer
        <DataMember()> Public Property gem2 As Integer
        <DataMember()> Public Property suffix As Integer
        <DataMember()> Public Property seed As Integer
        <DataMember()> Public Property enchant As Integer
        <DataMember()> Public Property extraSocket As Boolean
        <DataMember()> Public Property [set] As Integer()
        <DataMember()> Public Property reforge As Integer
        <DataMember()> Public Property transmogItem As Integer

    End Class

End Namespace
