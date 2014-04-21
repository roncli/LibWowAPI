' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Character.Schema
Imports roncliProductions.LibWowAPI.Data.Talents.Schema

Namespace roncliProductions.LibWowAPI.Challenge.Schema

    <DataContract()> Friend Class member

        <DataMember()> Public Property character As Character.Schema.characterBasicInfo
        <DataMember()> Public Property spec As spec

    End Class

End Namespace
