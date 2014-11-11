' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Item.Schema

    <DataContract()> Friend Class bonusSummary

        <DataMember()> Public Property defaultBonusLists As Integer()
        <DataMember()> Public Property chanceBonusLists As Integer()
        <DataMember()> Public Property bonusChances As bonusChance()

    End Class

End Namespace
