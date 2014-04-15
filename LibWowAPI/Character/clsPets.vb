' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's pets.
    ''' </summary>
    ''' <remarks>The data contained within this class contains information about a character's pets.</remarks>
    Public Class Pets

        ''' <summary>
        ''' The number of pets the character has collected.
        ''' </summary>
        ''' <value>This property gets or sets the NumCollected field.</value>
        ''' <returns>Returns the number of pets the character has collected.</returns>
        ''' <remarks>This represents the number of pets the character has collected.</remarks>
        Public Property NumCollected As Integer

        ''' <summary>
        ''' The number of pets the character has not collected.
        ''' </summary>
        ''' <value>This property gets or sets the NumNotCollected field.</value>
        ''' <returns>Returns the number of pets the character has not collected.</returns>
        ''' <remarks>This represents the number of pets the character has not collected.</remarks>
        Public Property NumNotCollected As Integer

        Private colCollected As Collection(Of Collected)
        ''' <summary>
        ''' The pets the character has collected.
        ''' </summary>
        ''' <value>This property gets the Collected field.</value>
        ''' <returns>Returns the pets the character has collected.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Collected)" /> of <see cref="Collected" /> objects that represents the pets the character has collected.</remarks>
        Public ReadOnly Property Collected As Collection(Of Collected)
            Get
                Return colCollected
            End Get
        End Property

        Friend Sub New(intNumCollected As Integer, intNumNotCollected As Integer, cCollected As Collection(Of Collected))
            NumCollected = intNumCollected
            NumNotCollected = intNumNotCollected
            colCollected = cCollected
        End Sub

    End Class

End Namespace
