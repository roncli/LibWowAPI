' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Data.Talents

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's glyphs.
    ''' </summary>
    ''' <remarks>Glyphs are divided into two categories, <see cref="Glyphs.Major" /> and <see cref="Glyphs.Minor" />.</remarks>
    Public Class Glyphs

        Private colMajor As Collection(Of Glyph)
        ''' <summary>
        ''' The character's major glyphs.
        ''' </summary>
        ''' <value>This property gets the Major field.</value>
        ''' <returns>Returns the character's major glyphs.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Glyph)" /> of <see cref="Glyph" /> that represents the character's major glyphs.</remarks>
        Public ReadOnly Property Major As Collection(Of Glyph)
            Get
                Return colMajor
            End Get
        End Property

        Private colMinor As Collection(Of Glyph)
        ''' <summary>
        ''' The character's minor glyphs.
        ''' </summary>
        ''' <value>This property gets the Minor field.</value>
        ''' <returns>Returns the character's minor glyphs.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Glyph)" /> of <see cref="Glyph" /> that represents the character's minor glyphs.</remarks>
        Public ReadOnly Property Minor As Collection(Of Glyph)
            Get
                Return colMinor
            End Get
        End Property

        Friend Sub New(gMajor As Collection(Of Glyph), gMinor As Collection(Of Glyph))
            colMajor = gMajor
            colMinor = gMinor
        End Sub

    End Class

End Namespace
