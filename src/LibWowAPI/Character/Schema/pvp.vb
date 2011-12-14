' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class pvp

        <DataMember()> Public Property ratedBattlegrounds As ratedBattlegrounds
        <DataMember()> Public Property arenaTeams As arenaTeam()
        <DataMember()> Public Property totalHonorableKills As Integer

    End Class

End Namespace
