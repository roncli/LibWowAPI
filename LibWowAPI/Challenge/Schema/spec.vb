' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Challenge.Schema

    <DataContract()> Friend Class spec

        <DataMember()> Public Property name As String
        <DataMember()> Public Property role As String
        <DataMember()> Public Property backgroundImage As String
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property description As String
        <DataMember()> Public Property order As Integer

    End Class

End Namespace
