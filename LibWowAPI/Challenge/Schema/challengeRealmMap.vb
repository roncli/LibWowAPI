﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Challenge.Schema

    <DataContract()> Friend Class challengeRealmMap

        <DataMember()> Public Property realm As Realm
        <DataMember()> Public Property map As map
        <DataMember()> Public Property groups As group()

    End Class

End Namespace
