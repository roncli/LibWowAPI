' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Guild.Schema

    <DataContract()> Friend Class character

        <DataMember()> Public Property name As String
        <DataMember()> Public Property realm As String
        <DataMember()> Public Property [class] As Integer
        <DataMember()> Public Property race As Integer
        <DataMember()> Public Property gender As Integer
        <DataMember()> Public Property level As Integer
        <DataMember()> Public Property achievementPoints As Integer
        <DataMember()> Public Property thumbnail As String

    End Class

End Namespace
