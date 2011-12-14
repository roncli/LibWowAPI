' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.GuildRewards.Schema

    <DataContract()> Friend Class reward

        <DataMember()> Public Property minGuildLevel As Integer
        <DataMember()> Public Property minGuildRepLevel As Integer
        <DataMember()> Public Property races As Integer()
        <DataMember()> Public Property achievement As achievement
        <DataMember()> Public Property item As item

    End Class

End Namespace
