' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class arenaTeam

        <DataMember()> Public Property name As String
        <DataMember()> Public Property personalRating As Integer
        <DataMember()> Public Property teamRating As Integer
        <DataMember()> Public Property size As String

    End Class

End Namespace
