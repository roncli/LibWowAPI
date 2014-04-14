' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class brackets

        <DataMember()> Public Property ARENA_BRACKET_2v2 As arena_bracket
        <DataMember()> Public Property ARENA_BRACKET_3v3 As arena_bracket
        <DataMember()> Public Property ARENA_BRACKET_5v5 As arena_bracket
        <DataMember()> Public Property ARENA_BRACKET_RBG As arena_bracket

    End Class

End Namespace
