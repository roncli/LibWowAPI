﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class weaponInfo

        <DataMember()> Public Property damage As damage
        <DataMember()> Public Property weaponSpeed As Double
        <DataMember()> Public Property dps As Double

    End Class

End Namespace
