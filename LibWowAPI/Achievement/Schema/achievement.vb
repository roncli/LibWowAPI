' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Item.Schema

Namespace roncliProductions.LibWowAPI.Achievement.Schema

    <DataContract()> Friend Class achievement

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property title As String
        <DataMember()> Public Property points As Integer
        <DataMember()> Public Property description As String
        <DataMember()> Public Property reward As String
        <DataMember()> Public Property rewardItems As itemBasicInfo()
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property criteria As criteria()
        <DataMember()> Public Property accountWide As Boolean
        <DataMember()> Public Property factionId As Integer

    End Class

End Namespace
