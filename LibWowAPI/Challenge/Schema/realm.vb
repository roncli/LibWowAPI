﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Challenge.Schema

    <DataContract()> Friend Class realm

        <DataMember()> Public Property name As String
        <DataMember()> Public Property slug As String
        <DataMember()> Public Property battlegroup As String
        <DataMember()> Public Property locale As String
        <DataMember()> Public Property timezone As String

    End Class

End Namespace
