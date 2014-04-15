' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.PetTypes.Schema

    <DataContract()> Friend Class petTypes

        <DataMember()> Public Property petTypes As petType()

    End Class

End Namespace
