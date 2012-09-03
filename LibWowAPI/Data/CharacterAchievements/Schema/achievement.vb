﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.CharacterAchievements.Schema

    <DataContract()> Friend Class achievement

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property title As String
        <DataMember()> Public Property points As Integer
        <DataMember()> Public Property description As String
        <DataMember()> Public Property reward As String
        <DataMember()> Public Property rewardItems As rewardItem
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property criteria As criteria()
        <DataMember()> Public Property accountWide As Boolean

    End Class

End Namespace
