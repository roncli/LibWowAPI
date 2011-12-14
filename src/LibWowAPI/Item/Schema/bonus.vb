' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class bonus

        <DataMember()> Public Property name As String
        <DataMember()> Public Property srcItemId As Integer
        <DataMember()> Public Property requiredSkillId As Integer
        <DataMember()> Public Property requiredSkillRank As Integer
        <DataMember()> Public Property minLevel As Integer
        <DataMember()> Public Property itemLevel As Integer

    End Class

End Namespace
