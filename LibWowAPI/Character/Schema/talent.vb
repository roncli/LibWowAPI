' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class talent

        <DataMember()> Public Property selected As Boolean
        <DataMember()> Public Property name As String
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property build As String
        <DataMember()> Public Property trees As tree()
        <DataMember()> Public Property glyphs As glyphs

    End Class

End Namespace
