' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Guild.Schema

    <DataContract()> Friend Class emblem

        <DataMember()> Public Property icon As Integer
        <DataMember()> Public Property iconColor As String
        <DataMember()> Public Property border As Integer
        <DataMember()> Public Property borderColor As String
        <DataMember()> Public Property backgroundColor As String

    End Class

End Namespace
