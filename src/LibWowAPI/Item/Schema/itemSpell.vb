' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class itemSpell

        <DataMember()> Public Property spellId As Integer
        <DataMember()> Public Property spell As spell
        <DataMember()> Public Property nCharges As Integer
        <DataMember()> Public Property consumable As Boolean
        <DataMember()> Public Property categoryId As Integer

    End Class

End Namespace
