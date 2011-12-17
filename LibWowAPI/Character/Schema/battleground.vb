' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class battleground

        <DataMember()> Public Property name As String
        <DataMember()> Public Property played As Integer
        <DataMember()> Public Property won As Integer

    End Class

End Namespace
