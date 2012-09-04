' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.ItemClasses.Schema

    <DataContract()> Friend Class subclass

        <DataMember()> Public Property subclass As Integer
        <DataMember()> Public Property name As String

    End Class

End Namespace
