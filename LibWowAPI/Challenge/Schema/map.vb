' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Challenge.Schema

    <DataContract()> Friend Class map

        <DataMember()> Public Property id As Integer
        <DataMember()> Public Property name As String
        <DataMember()> Public Property slug As String
        <DataMember()> Public Property hasChallengeMode As Boolean
        <DataMember()> Public Property bronzeCriteria As timeSpan
        <DataMember()> Public Property silverCriteria As timeSpan
        <DataMember()> Public Property goldCriteria As timeSpan

    End Class

End Namespace
