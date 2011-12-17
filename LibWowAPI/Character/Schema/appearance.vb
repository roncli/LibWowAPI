' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class appearance

        <DataMember()> Public Property faceVariation As Integer
        <DataMember()> Public Property skinColor As Integer
        <DataMember()> Public Property hairVariation As Integer
        <DataMember()> Public Property hairColor As Integer
        <DataMember()> Public Property featureVariation As Integer
        <DataMember()> Public Property showHelm As Boolean
        <DataMember()> Public Property showCloak As Boolean

    End Class

End Namespace
