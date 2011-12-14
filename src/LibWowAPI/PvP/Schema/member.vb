' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.PvP.Schema

    <DataContract()> Friend Class member

        <DataMember()> Public Property character As character
        <DataMember()> Public Property rank As Integer
        <DataMember()> Public Property gamesPlayed As Integer
        <DataMember()> Public Property gamesWon As Integer
        <DataMember()> Public Property gamesLost As Integer
        <DataMember()> Public Property sessionGamesPlayed As Integer
        <DataMember()> Public Property sessionGamesWon As Integer
        <DataMember()> Public Property sessionGamesLost As Integer
        <DataMember()> Public Property personalRating As Integer

    End Class

End Namespace
