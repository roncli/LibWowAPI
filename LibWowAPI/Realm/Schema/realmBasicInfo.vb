' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Realm.Schema

    <DataContract()> Friend Class realmBasicInfo
        Inherits realmName

        <DataMember()> Public Property battlegroup As String
        <DataMember()> Public Property locale As String
        <DataMember()> Public Property timezone As String
        <DataMember()> Public Property connected_realms As String()

    End Class

End Namespace
