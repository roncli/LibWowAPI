﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.PetTypes.Schema

    <DataContract()> Friend Class petType

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property key As String
        <DataMember()> Public Property name As String
        <DataMember()> Public Property typeAbilityId As Integer
        <DataMember()> Public Property strongAgainstId As Integer
        <DataMember()> Public Property weakAgainstId As Integer

    End Class

End Namespace
