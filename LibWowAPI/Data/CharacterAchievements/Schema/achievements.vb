' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Data.CharacterAchievements.Schema

    <DataContract()> Friend Class achievements

        <DataMember()> Public Property achievements As category()

    End Class

End Namespace
