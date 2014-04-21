' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Data.Talents.Schema

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class talentSpec

        <DataMember()> Public Property selected As Boolean
        <DataMember()> Public Property talents As talent()
        <DataMember()> Public Property glyphs As glyphs
        <DataMember()> Public Property spec As spec
        <DataMember()> Public Property calcTalent As String
        <DataMember()> Public Property calcSpec As String
        <DataMember()> Public Property calcGlyph As String

    End Class

End Namespace
