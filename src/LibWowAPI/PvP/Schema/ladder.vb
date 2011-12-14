' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI.PvP.Schema

    <DataContract()> Friend Class ladder

        <DataMember()> Public Property arenateam As arenateam()

    End Class

End Namespace
