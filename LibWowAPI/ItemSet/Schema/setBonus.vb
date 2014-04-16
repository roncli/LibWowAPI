' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.ItemSet.Schema

    <DataContract()> Friend Class setBonus

        <DataMember()> Public Property description As String
        <DataMember()> Public Property threshold As Integer

    End Class

End Namespace
