' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.PvP.Schema

    <DataContract()> Friend Class arenateam

        <DataMember()> Public Property realm As String
        <DataMember()> Public Property ranking As Integer
        <DataMember()> Public Property rating As Integer
        <DataMember()> Public Property teamsize As Integer
        <DataMember()> Public Property created As String
        <DataMember()> Public Property name As String
        <DataMember()> Public Property gamesPlayed As Integer
        <DataMember()> Public Property gamesWon As Integer
        <DataMember()> Public Property gamesLost As Integer
        <DataMember()> Public Property sessionGamesPlayed As Integer
        <DataMember()> Public Property sessionGamesWon As Integer
        <DataMember()> Public Property sessionGamesLost As Integer
        <DataMember()> Public Property lastSessionRanking As Integer
        <DataMember()> Public Property side As String
        <DataMember()> Public Property currentWeekRanking As Integer
        <DataMember()> Public Property members As member()

    End Class

End Namespace