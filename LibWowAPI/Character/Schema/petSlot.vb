' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class petSlot

        <DataMember()> Public Property slot As Integer
        <DataMember()> Public Property battlePetGuid As String
        <DataMember()> Public Property isEmpty As Boolean
        <DataMember()> Public Property isLocked As Boolean
        <DataMember()> Public Property abilities As Integer()

    End Class

End Namespace
