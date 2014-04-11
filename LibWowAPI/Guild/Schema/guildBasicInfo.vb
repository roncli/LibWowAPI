' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Guild.Schema

    <DataContract()> Friend Class guildBasicInfo

        <DataMember()> Public Property name As String
        <DataMember()> Public Property realm As String
        <DataMember()> Public Property battlegroup As String
        <DataMember()> Public Property level As Integer
        <DataMember()> Public Property members As Integer
        <DataMember()> Public Property achievementPoints As Integer
        <DataMember()> Public Property emblem As emblem

    End Class

End Namespace
