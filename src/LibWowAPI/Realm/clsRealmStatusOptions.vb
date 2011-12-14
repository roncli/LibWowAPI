' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Realm

    ''' <summary>
    ''' A class that defines options for the realm status lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the realms to look up status information for. There is no need to create an instance of this class, as the <see cref="RealmStatus.Options" /> property automatically does so for you.</remarks>
    Public Class RealmStatusOptions

        Private colRealms As New Collection(Of String)
        ''' <summary>
        ''' The list of realms to look up the status for.
        ''' </summary>
        ''' <value>This property gets the Realms field.</value>
        ''' <returns>Returns the list of realms to lookup the status for.</returns>
        ''' <remarks>This is a <see cref="Collection(Of String)" /> of realms to lookup the status for.</remarks>
        Public ReadOnly Property Realms As Collection(Of String)
            Get
                Return colRealms
            End Get
        End Property

        Friend Sub New()
        End Sub

    End Class

End Namespace
