' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Realm.Schema

    <DataContract()> Friend Class realm
        Inherits realmBasicInfo

        <DataMember()> Public Property type As String
        <DataMember()> Public Property population As String
        <DataMember()> Public Property queue As Boolean
        <DataMember()> Public Property wintergrasp As pvpZone
        <DataMember(name:="tol-barad")> Public Property tolBarad As pvpZone
        <DataMember()> Public Property status As Boolean

    End Class

End Namespace
