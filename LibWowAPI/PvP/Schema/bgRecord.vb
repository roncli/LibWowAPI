' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.PvP.Schema

    <DataContract()> Friend Class bgRecord

        <DataMember()> Public Property rank As Integer
        <DataMember()> Public Property bgRating As Integer
        <DataMember()> Public Property wins As Integer
        <DataMember()> Public Property losses As Integer
        <DataMember()> Public Property played As Integer
        <DataMember()> Public Property realm As realm
        <DataMember()> Public Property battlegroup As battlegroup
        <DataMember()> Public Property character As character
        <DataMember()> Public Property lastModified As Long

    End Class

End Namespace
