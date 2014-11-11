' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class bonusChance

        <DataMember()> Public Property chanceType As String
        <DataMember()> Public Property upgrade As bonusChance_upgrade
        <DataMember()> Public Property stats As bonusChance_stat()
        <DataMember()> Public Property sockets As socket()

    End Class

End Namespace
