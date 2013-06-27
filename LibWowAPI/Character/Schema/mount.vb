' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class mount

        <DataMember()> Public Property name As String
        <DataMember()> Public Property spellId As Integer
        <DataMember()> Public Property creatureId As Integer
        <DataMember()> Public Property itemId As Integer
        <DataMember()> Public Property qualityId As Integer
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property isGround As Boolean
        <DataMember()> Public Property isFlying As Boolean
        <DataMember()> Public Property isAquatic As Boolean
        <DataMember()> Public Property isJumping As Boolean

    End Class

End Namespace
