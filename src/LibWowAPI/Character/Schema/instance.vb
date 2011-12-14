' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class instance

        <DataMember()> Public Property name As String
        <DataMember()> Public Property normal As Integer
        <DataMember()> Public Property heroic As Integer
        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property bosses As boss()

    End Class

End Namespace
