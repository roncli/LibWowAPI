' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.BattlePet.Schema

    <DataContract()> Friend Class speciesAbility
        Inherits ability

        <DataMember()> Public Property slot As Integer
        <DataMember()> Public Property order As Integer
        <DataMember()> Public Property requiredLevel As Integer

    End Class

End Namespace
