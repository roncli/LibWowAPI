' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Guild.Schema

    <DataContract()> Friend Class achievements

        <DataMember()> Public Property achievementsCompleted As Integer()
        <DataMember()> Public Property achievementsCompletedTimestamp As Long()
        <DataMember()> Public Property criteria As Integer()
        <DataMember()> Public Property criteriaQuantity As Long()
        <DataMember()> Public Property criteriaTimestamp As Long()
        <DataMember()> Public Property criteriaCreated As Long()

    End Class

End Namespace
