' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's title.
    ''' </summary>
    ''' <remarks>Check the <see cref="Title.Selected" /> property to see if this is the character's currently selected title.</remarks>
    Public Class Title

        ''' <summary>
        ''' The ID number of the title.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the title.</returns>
        ''' <remarks>Each title has a unique ID number to represent it.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The tokenized name of the title.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the tokenized name of the title.</returns>
        ''' <remarks>This is the localized name of the title, tokenized with the string "%s" to indicate where the character's name should go.  Replace "%s" with the character's name for their complete title.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Indicates whether this is the character's chosen title.
        ''' </summary>
        ''' <value>This property gets or sets the Selected field.</value>
        ''' <returns>Returns a boolean that indicates whether this is the character's chosen title.</returns>
        ''' <remarks>When true, this is the character's current title.</remarks>
        Public Property Selected As Boolean

        Friend Sub New(intID As Integer, strName As String, blnSelected As Boolean)
            ID = intID
            Name = strName
            Selected = blnSelected
        End Sub

    End Class

End Namespace
