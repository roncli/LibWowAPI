' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Achievement.Schema

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class feed

        <DataMember()> Public Property type As String
        <DataMember()> Public Property timestamp As Long
        <DataMember()> Public Property itemId As Integer
        <DataMember()> Public Property achievement As Achievement.Schema.achievement
        <DataMember()> Public Property featOfStrength As Boolean
        <DataMember()> Public Property criteria As criteria
        <DataMember()> Public Property quantity As Integer
        <DataMember()> Public Property name As String

    End Class

End Namespace
