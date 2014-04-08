' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Achievements.Schema

    <DataContract()> Friend Class criteria

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property description As String
        <DataMember()> Public Property orderIndex As Integer
        <DataMember()> Public Property max As Long

    End Class

End Namespace
