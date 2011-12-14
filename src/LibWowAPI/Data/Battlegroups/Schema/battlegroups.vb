' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.Battlegroups.Schema

    <DataContract()> Friend Class battlegroups

        <DataMember()> Public Property battlegroups As battlegroup()

    End Class

End Namespace
