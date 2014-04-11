' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Challenge

    ''' <summary>
    ''' A class containing challenge mode leaderboards.
    ''' </summary>
    ''' <remarks>This class contains challenge mode leaderboards.</remarks>
    Public Class Challenge

        ''' <summary>
        ''' The realm that the data for this challenge mode is for.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm that the data for this challenge mode is for.</returns>
        ''' <remarks>When this property is null, the challenge mode data is for the entire region.</remarks>
        Public Property Realm As Realm

        ''' <summary>
        ''' The map that the data for this challenge mode is for.
        ''' </summary>
        ''' <value>This property gets or sets the Map field.</value>
        ''' <returns>Returns the map that the data for this challenge mode is for.</returns>
        ''' <remarks>This represents the map that the data for this challenge mode is for.</remarks>
        Public Property Map As Map

        Private colGroups As Collection(Of Group)
        ''' <summary>
        ''' The groups that have completed this challenge mode.
        ''' </summary>
        ''' <value>This property gets the Groups field.</value>
        ''' <returns>Returns the groups that have completed this challenge mode.</returns>
        ''' <remarks>This represents the groups that have completed this challenge mode.</remarks>
        Public ReadOnly Property Groups As Collection(Of Group)
            Get
                Return colGroups
            End Get
        End Property

        Friend Sub New(rRealm As Realm, mMap As Map, gGroups As Collection(Of Group))
            Realm = rRealm
            Map = mMap
            colGroups = gGroups
        End Sub

    End Class

End Namespace
