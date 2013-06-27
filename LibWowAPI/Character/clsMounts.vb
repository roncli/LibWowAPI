' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's mounts.
    ''' </summary>
    ''' <remarks>This class contains information about the character's mounts.</remarks>
    Public Class Mounts

        ''' <summary>
        ''' The number of mounts collected by the character.
        ''' </summary>
        ''' <value>This property gets or sets the NumCollected field.</value>
        ''' <returns>Returns the number of mounts collected by the character.</returns>
        ''' <remarks>This represents the number of mounts collected by the character.</remarks>
        Public Property NumCollected As Integer

        ''' <summary>
        ''' The number of mounts not collected by the character.
        ''' </summary>
        ''' <value>This property gets or sets the NumNotCollected field.</value>
        ''' <returns>Returns the number of mounts not collected by the character.</returns>
        ''' <remarks>This represents the number of mounts not collected by the character.</remarks>
        Public Property NumNotCollected As Integer

        Private colMount As Collection(Of Mount)
        ''' <summary>
        ''' The mounts collected by the character.
        ''' </summary>
        ''' <value>This property gets the mounts collected by the character.</value>
        ''' <returns>Returns the mounts collected by the character.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Mount)" /> of <see cref="Mount" /> collected by the character.</remarks>
        Public ReadOnly Property Collected As Collection(Of Mount)
            Get
                Return colMount
            End Get
        End Property

        Friend Sub New(intNumCollected As Integer, intNumNotCollected As Integer, mMount As Collection(Of Mount))
            NumCollected = intNumCollected
            NumNotCollected = intNumNotCollected
            colMount = mMount
        End Sub

    End Class

End Namespace
