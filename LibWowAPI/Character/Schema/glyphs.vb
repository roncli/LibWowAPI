' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class glyphs

        <DataMember()> Public Property major As glyph()
        <DataMember()> Public Property minor As glyph()

    End Class

End Namespace
