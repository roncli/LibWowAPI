' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Challenge.Schema

    <DataContract()> Friend Class timeSpan

        <DataMember()> Public Property time As Integer
        <DataMember()> Public Property hours As Integer
        <DataMember()> Public Property minutes As Integer
        <DataMember()> Public Property seconds As Integer
        <DataMember()> Public Property milliseconds As Integer
        <DataMember()> Public Property isPositive As Boolean

    End Class

End Namespace
