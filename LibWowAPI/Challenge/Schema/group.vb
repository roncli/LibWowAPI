' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Challenge.Schema

    <DataContract()> Friend Class group

        <DataMember()> Public Property ranking As Integer
        <DataMember()> Public Property time As timeSpan
        <DataMember()> Public Property [date] As String
        <DataMember()> Public Property medal As String
        <DataMember()> Public Property faction As String
        <DataMember()> Public Property isRecurring As Boolean
        <DataMember()> Public Property members As member()
        <DataMember()> Public Property guild As guild

    End Class

End Namespace
