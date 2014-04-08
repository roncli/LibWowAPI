' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Achievements.Schema

    <DataContract()> Friend Class category

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property categories As category()
        <DataMember()> Public Property name As String
        <DataMember()> Public Property achievements As Achievement()

    End Class

End Namespace
