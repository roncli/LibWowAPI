' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI

    <DataContract()> Friend Class BlizzardAPIError

        <DataMember()> Public Property status As String
        <DataMember()> Public Property reason As String
        <DataMember()> Public Property code As Integer
        <DataMember()> Public Property type As String
        <DataMember()> Public Property detail As String

    End Class

End Namespace
