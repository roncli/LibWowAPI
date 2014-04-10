' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.BattlePet.Schema

    <DataContract()> Friend Class species

        <DataMember()> Public Property speciesId As Integer
        <DataMember()> Public Property petTypeId As Integer
        <DataMember()> Public Property creatureId As Integer
        <DataMember()> Public Property name As String
        <DataMember()> Public Property canBattle As Boolean
        <DataMember()> Public Property icon As String
        <DataMember()> Public Property description As String
        <DataMember()> Public Property source As String
        <DataMember()> Public Property abilities As speciesAbility()

    End Class

End Namespace
