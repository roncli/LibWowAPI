' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Quest.Schema

    <DataContract()> Friend Class quest

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property title As String
        <DataMember()> Public Property reqLevel As Integer
        <DataMember()> Public Property suggestedPartyMembers As Integer
        <DataMember()> Public Property category As String
        <DataMember()> Public Property level As Integer

    End Class

End Namespace
