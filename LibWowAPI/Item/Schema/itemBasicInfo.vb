﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class itemBasicInfo

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property name As String
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property quality As Integer
        <DataMember()> Public Property itemLevel As Integer
        <DataMember()> Public Property tooltipParams As tooltipParams
        <DataMember()> Public Property stats As item_stat()
        <DataMember()> Public Property armor As Integer
        <DataMember()> Public Property context As String
        <DataMember()> Public Property bonusLists As Integer()

    End Class

End Namespace
