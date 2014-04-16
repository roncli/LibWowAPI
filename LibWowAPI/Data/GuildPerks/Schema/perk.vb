' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.GuildPerks.Schema

    <DataContract()> Friend Class perk

        <DataMember()> Public Property guildLevel As Integer
        <DataMember()> Public Property spell As Spell.Schema.spell

    End Class

End Namespace
