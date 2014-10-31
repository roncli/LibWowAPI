' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.Talents.Schema

    <DataContract()> Friend Class talents

        <DataMember()> Public Property petSpecs As spec()
        <DataMember()> Public Property glyphs As glyph()
        <DataMember()> Public Property talents As talent()()()
        <DataMember()> Public Property [class] As String
        <DataMember()> Public Property specs As spec()

    End Class

End Namespace
