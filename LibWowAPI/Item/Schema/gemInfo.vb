' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class gemInfo

        <DataMember()> Public Property bonus As bonus
        <DataMember()> Public Property type As type
        <DataMember()> Public Property minItemLevel As Integer

    End Class

End Namespace
