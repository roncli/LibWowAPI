' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Leaderboard.Schema

    <DataContract()> Friend Class row

        <DataMember()> Public Property ranking As Integer
        <DataMember()> Public Property rating As Integer
        <DataMember()> Public Property name As String
        <DataMember()> Public Property realmId As Integer
        <DataMember()> Public Property realmName As String
        <DataMember()> Public Property realmSlug As String
        <DataMember()> Public Property raceId As Integer
        <DataMember()> Public Property classId As Integer
        <DataMember()> Public Property specId As Integer
        <DataMember()> Public Property factionId As Integer
        <DataMember()> Public Property genderId As Integer
        <DataMember()> Public Property seasonWins As Integer
        <DataMember()> Public Property seasonLosses As Integer
        <DataMember()> Public Property weeklyWins As Integer
        <DataMember()> Public Property weeklyLosses As Integer

    End Class

End Namespace
