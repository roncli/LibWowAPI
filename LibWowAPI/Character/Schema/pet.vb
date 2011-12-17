' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class pet

        <DataMember()> Public Property name As String
        <DataMember()> Public Property creature As Integer
        <DataMember()> Public Property selected As Boolean
        <DataMember()> Public Property slot As Integer
        <DataMember()> Public Property talents As talent

    End Class

End Namespace
