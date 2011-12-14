' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Drawing

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a guild emblem.
    ''' </summary>
    ''' <remarks>The guild emblem is made up of 5 parts.  The <see cref="Emblem.Icon" /> is an index representing the emblem's logo.  The <see cref="Emblem.IconColor" /> is the color of that logo.  The <see cref="Emblem.Border" /> is an index representing the embelm's border style.  The <see cref="Emblem.BorderColor" /> is the color of that border.  The <see cref="Emblem.BackgroundColor" /> is the background color of the emblem.</remarks>
    Public Class Emblem

        ''' <summary>
        ''' A number representing the guild emblem's icon.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a number representing the guild emblem's icon.</returns>
        ''' <remarks>The icon is stored on the server under the path /wow/static/images/guild/tabards/emblem_<i>Icon Number</i>.png, where the icon number is padded with 1 zero if it is a single digit number.</remarks>
        Public Property Icon As Integer

        ''' <summary>
        ''' The color of the guild emblem's icon.
        ''' </summary>
        ''' <value>This property gets or sets the IconColor field.</value>
        ''' <returns>Returns the color of the guild emblem's icon.</returns>
        ''' <remarks>The color of the icon is represented as a <see cref="Color" /> object.</remarks>
        Public Property IconColor As Color

        ''' <summary>
        ''' A number representing the guild emblem's border.
        ''' </summary>
        ''' <value>This property gets or sets the Border field.</value>
        ''' <returns>Returns a number representing the guild emblem's border.</returns>
        ''' <remarks>The border is stored on the server under the path /wow/static/images/guild/tabards/border_<i>Border Number</i>.png, where the border number is padded with 1 zero if it is a single digit number.</remarks>
        Public Property Border As Integer

        ''' <summary>
        ''' The color of the guild emblem's border.
        ''' </summary>
        ''' <value>This property gets or sets the BorderColor field.</value>
        ''' <returns>Returns the color of the guild emblem's border.</returns>
        ''' <remarks>The border color is represented as a <see cref="Color" /> object.</remarks>
        Public Property BorderColor As Color

        ''' <summary>
        ''' The color of the guild emblem's background.
        ''' </summary>
        ''' <value>This property gets or sets the BackgroundColor field.</value>
        ''' <returns>Returns the color of the guild emblem's background.</returns>
        ''' <remarks>The background color is represented as a <see cref="Color" /> object.</remarks>
        Public Property BackgroundColor As Color

        Friend Sub New(intIcon As Integer, cIconColor As Color, intBorder As Integer, cBorderColor As Color, cBackgroundColor As Color)
            Icon = intIcon
            IconColor = cIconColor
            Border = intBorder
            BorderColor = cBorderColor
            BackgroundColor = cBackgroundColor
        End Sub

    End Class

End Namespace
