' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.CharacterClasses.Schema

    <DataContract()> Friend Class [class]

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property mask As Integer
        <DataMember()> Public Property powerType As String
        <DataMember()> Public Property name As String

    End Class

End Namespace
