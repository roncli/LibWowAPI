﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class damage

        <DataMember()> Public Property min As Integer
        <DataMember()> Public Property max As Integer
        <DataMember()> Public Property exactMin As Double
        <DataMember()> Public Property exactMax As Double

    End Class

End Namespace
