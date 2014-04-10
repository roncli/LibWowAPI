' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Auction.Schema

    <DataContract()> Friend Class auction

        <DataMember()> Public Property auc As Long
        <DataMember()> Public Property item As Integer
        <DataMember()> Public Property owner As String
        <DataMember()> Public Property ownerRealm As String
        <DataMember()> Public Property bid As Long
        <DataMember()> Public Property buyout As Long
        <DataMember()> Public Property quantity As Integer
        <DataMember()> Public Property timeLeft As String
        <DataMember()> Public Property rand As Integer
        <DataMember()> Public Property seed As Long
        <DataMember()> Public Property petSpeciesId As Integer
        <DataMember()> Public Property petBreedId As Integer
        <DataMember()> Public Property petLevel As Integer
        <DataMember()> Public Property petQualityId As Integer

    End Class

End Namespace
