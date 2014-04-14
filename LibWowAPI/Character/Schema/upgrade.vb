' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class upgrade

        <DataMember()> Public Property current As Integer
        <DataMember()> Public Property total As Integer
        <DataMember()> Public Property itemLevelIncrement As Integer

    End Class

End Namespace
