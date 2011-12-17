' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's instance progression.
    ''' </summary>
    ''' <remarks>Currently, instance progression is limited to raid instances.</remarks>
    Public Class Progression

        Private colRaids As Collection(Of Instance)
        ''' <summary>
        ''' A list of the character's progression in raid instances.
        ''' </summary>
        ''' <value>This property gets the Raids field.</value>
        ''' <returns>Returns a list of the character's progression in raid instances.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Instance)" /> of <see cref="Instance" />, each of which describes the character's progress through that instance.</remarks>
        Public ReadOnly Property Raids As Collection(Of Instance)
            Get
                Return colRaids
            End Get
        End Property

        Friend Sub New(iRaids As Collection(Of Instance))
            colRaids = iRaids
        End Sub

    End Class

End Namespace
