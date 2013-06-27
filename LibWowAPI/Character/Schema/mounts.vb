' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.Character.Schema

    <DataContract()> Friend Class mounts

        <DataMember()> Public Property numCollected As Integer
        <DataMember()> Public Property numNotCollected As Integer
        <DataMember()> Public Property collected As mount()

    End Class

End Namespace
