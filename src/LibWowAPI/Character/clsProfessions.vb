' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's professions.
    ''' </summary>
    ''' <remarks>Professions are divided into primary and secondary professions.</remarks>
    Public Class Professions

        Private colPrimary As Collection(Of Profession)
        ''' <summary>
        ''' The character's primary professions.
        ''' </summary>
        ''' <value>This property gets the Primary field.</value>
        ''' <returns>Returns the character's primary professions.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Profession)" /> of <see cref="Profession" /> that includes the character's primary professions.</remarks>
        Public ReadOnly Property Primary As Collection(Of Profession)
            Get
                Return colPrimary
            End Get
        End Property

        Private colSecondary As Collection(Of Profession)
        ''' <summary>
        ''' The character's secondary professions.
        ''' </summary>
        ''' <value>This property gets the Secondary field.</value>
        ''' <returns>Returns the character's secondary professions.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Profession)" /> of <see cref="Profession" /> that includes the character's secondary professions.</remarks>
        Public ReadOnly Property Secondary As Collection(Of Profession)
            Get
                Return colSecondary
            End Get
        End Property

        Friend Sub New(pPrimary As Collection(Of Profession), pSecondary As Collection(Of Profession))
            colPrimary = pPrimary
            colSecondary = pSecondary
        End Sub

    End Class

End Namespace
