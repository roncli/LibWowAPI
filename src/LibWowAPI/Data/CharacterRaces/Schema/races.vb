' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.CharacterRaces.Schema

    <DataContract()> Friend Class races

        <DataMember()> Public Property races As race()

    End Class

End Namespace
