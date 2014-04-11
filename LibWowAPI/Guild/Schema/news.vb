' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Guild.Schema

    <DataContract()> Friend Class news

        <DataMember()> Public Property type As String
        <DataMember()> Public Property character As String
        <DataMember()> Public Property timestamp As Long
        <DataMember()> Public Property itemId As Integer
        <DataMember()> Public Property levelUp As Integer
        <DataMember()> Public Property achievement As Achievement.Schema.achievement

    End Class

End Namespace
