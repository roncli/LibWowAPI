' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Achievement.Schema
Imports roncliProductions.LibWowAPI.Item.Schema

Namespace roncliProductions.LibWowAPI.Data.GuildRewards.Schema

    <DataContract()> Friend Class reward

        <DataMember()> Public Property minGuildLevel As Integer
        <DataMember()> Public Property minGuildRepLevel As Integer
        <DataMember()> Public Property races As Integer()
        <DataMember()> Public Property achievement As Achievement.Schema.achievement
        <DataMember()> Public Property item As itemBasicInfo

    End Class

End Namespace
