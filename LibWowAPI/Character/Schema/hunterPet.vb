' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Data.Talents.Schema

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class hunterPet

        <DataMember()> Public Property name As String
        <DataMember()> Public Property creature As Integer
        <DataMember()> Public Property selected As Boolean
        <DataMember()> Public Property slot As Integer
        <DataMember()> Public Property spec As spec
        <DataMember()> Public Property calcSpec As String
        <DataMember()> Public Property familyId As Integer
        <DataMember()> Public Property familyName As String

    End Class

End Namespace
