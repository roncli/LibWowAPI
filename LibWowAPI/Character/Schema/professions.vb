' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class professions

        <DataMember()> Public Property primary As profession()
        <DataMember()> Public Property secondary As profession()

    End Class

End Namespace
