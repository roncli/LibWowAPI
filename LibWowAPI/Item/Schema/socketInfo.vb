﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class socketInfo

        <DataMember()> Public Property sockets As socketInfo_socket()
        <DataMember()> Public Property socketBonus As String

    End Class

End Namespace
