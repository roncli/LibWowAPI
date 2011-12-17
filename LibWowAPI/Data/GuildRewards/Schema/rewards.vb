' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.GuildRewards.Schema

    <DataContract()> Friend Class rewards

        <DataMember()> Public Property rewards As reward()

    End Class

End Namespace
