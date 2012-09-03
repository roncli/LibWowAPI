' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class items

        <DataMember()> Public Property averageItemLevel As Integer
        <DataMember()> Public Property averageItemLevelEquipped As Integer
        <DataMember()> Public Property head As item
        <DataMember()> Public Property neck As item
        <DataMember()> Public Property shoulder As item
        <DataMember()> Public Property back As item
        <DataMember()> Public Property chest As item
        <DataMember()> Public Property shirt As item
        <DataMember()> Public Property tabard As item
        <DataMember()> Public Property wrist As item
        <DataMember()> Public Property hands As item
        <DataMember()> Public Property waist As item
        <DataMember()> Public Property legs As item
        <DataMember()> Public Property feet As item
        <DataMember()> Public Property finger1 As item
        <DataMember()> Public Property finger2 As item
        <DataMember()> Public Property trinket1 As item
        <DataMember()> Public Property trinket2 As item
        <DataMember()> Public Property mainHand As item
        <DataMember()> Public Property offHand As item

    End Class

End Namespace
