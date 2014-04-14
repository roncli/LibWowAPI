' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class boss

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property name As String
        <DataMember()> Public Property normalKills As Integer
        <DataMember()> Public Property normalTimestamp As Long
        <DataMember()> Public Property heroicKills As Integer
        <DataMember()> Public Property heroicTimestamp As Long
        <DataMember()> Public Property lfrKills As Integer
        <DataMember()> Public Property lfrTimestamp As Long
        <DataMember()> Public Property flexKills As Integer
        <DataMember()> Public Property flexTimestamp As Long

    End Class

End Namespace
