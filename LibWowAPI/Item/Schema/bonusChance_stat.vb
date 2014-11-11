' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class bonusChance_stat

        <DataMember()> Public Property statId As String
        <DataMember()> Public Property delta As Integer

    End Class

End Namespace
