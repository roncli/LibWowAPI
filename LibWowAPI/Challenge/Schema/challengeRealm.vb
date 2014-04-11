' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Challenge.Schema

    <DataContract()> Friend Class challengeRealm

        <DataMember()> Public Property challenge As challengeRealmMap()

    End Class

End Namespace
