' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Leaderboard.Schema

    <DataContract()> Friend Class leaderboard

        <DataMember()> Public Property rows As row()

    End Class

End Namespace
