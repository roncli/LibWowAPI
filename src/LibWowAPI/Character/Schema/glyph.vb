' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class glyph

        <DataMember()> Public Property glyph As Integer
        <DataMember()> Public Property item As Integer
        <DataMember()> Public Property name As String
        <DataMember()> Public Property icon As String

    End Class

End Namespace
