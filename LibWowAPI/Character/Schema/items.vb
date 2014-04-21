' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Item.Schema

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class items

        <DataMember()> Public Property averageItemLevel As Integer
        <DataMember()> Public Property averageItemLevelEquipped As Integer
        <DataMember()> Public Property head As itemBasicInfo
        <DataMember()> Public Property neck As itemBasicInfo
        <DataMember()> Public Property shoulder As itemBasicInfo
        <DataMember()> Public Property back As itemBasicInfo
        <DataMember()> Public Property chest As itemBasicInfo
        <DataMember()> Public Property shirt As itemBasicInfo
        <DataMember()> Public Property tabard As itemBasicInfo
        <DataMember()> Public Property wrist As itemBasicInfo
        <DataMember()> Public Property hands As itemBasicInfo
        <DataMember()> Public Property waist As itemBasicInfo
        <DataMember()> Public Property legs As itemBasicInfo
        <DataMember()> Public Property feet As itemBasicInfo
        <DataMember()> Public Property finger1 As itemBasicInfo
        <DataMember()> Public Property finger2 As itemBasicInfo
        <DataMember()> Public Property trinket1 As itemBasicInfo
        <DataMember()> Public Property trinket2 As itemBasicInfo
        <DataMember()> Public Property mainHand As itemBasicInfo
        <DataMember()> Public Property offHand As itemBasicInfo

    End Class

End Namespace
