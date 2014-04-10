' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.BattlePets.Schema

    <DataContract()> Friend Class stats

        <DataMember()> Public Property speciesId As Integer
        <DataMember()> Public Property breedId As Integer
        <DataMember()> Public Property petQualityId As Integer
        <DataMember()> Public Property level As Integer
        <DataMember()> Public Property health As Integer
        <DataMember()> Public Property power As Integer
        <DataMember()> Public Property speed As Integer

    End Class

End Namespace
