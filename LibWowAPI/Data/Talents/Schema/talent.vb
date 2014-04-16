' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.Talents.Schema

    <DataContract()> Friend Class talent

        <DataMember()> Public Property tier As Integer
        <DataMember()> Public Property column As Integer
        <DataMember()> Public Property spell As Spell.Schema.spell

    End Class

End Namespace
