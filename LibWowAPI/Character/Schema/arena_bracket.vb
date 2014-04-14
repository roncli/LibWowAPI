' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class arena_bracket

        <DataMember()> Public Property slug As String
        <DataMember()> Public Property rating As Integer
        <DataMember()> Public Property weeklyPlayed As Integer
        <DataMember()> Public Property weeklyWon As Integer
        <DataMember()> Public Property weeklyLost As Integer
        <DataMember()> Public Property seasonPlayed As Integer
        <DataMember()> Public Property seasonWon As Integer
        <DataMember()> Public Property seasonLost As Integer

    End Class

End Namespace
