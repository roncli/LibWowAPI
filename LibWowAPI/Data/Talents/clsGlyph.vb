' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Data.Talents

    ''' <summary>
    ''' A class containing information about a glyph.
    ''' </summary>
    ''' <remarks>Information about a glyph can be retrieved from this class.</remarks>
    Public Class Glyph

        ''' <summary>
        ''' The ID number of the glyph.
        ''' </summary>
        ''' <value>This property gets or sets the Glyph field.</value>
        ''' <returns>Returns the ID number of the glyph.</returns>
        ''' <remarks>Each glyph has its own ID number that is sepearate from its <see cref="Glyph.Item" /> number.</remarks>
        Public Property Glyph As Integer

        ''' <summary>
        ''' The ID number of the item of the glyph.
        ''' </summary>
        ''' <value>This property gets or sets the Item field.</value>
        ''' <returns>Returns the ID number of the item of the glyph.</returns>
        ''' <remarks>This is the item ID number of the object used to teach this glyph.</remarks>
        Public Property Item As Integer

        ''' <summary>
        ''' The name of the glyph.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the glyph.</returns>
        ''' <remarks>The name of the glyph doesn't necessarily name the ability it is modifying.  Use the <see cref="Glyph.Item" /> ID number with the <see cref="LibWowAPI.Item.ItemLookup" /> class to learn more about the glyph.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The path to the image of the glyph's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns the path to the image of the glyph's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The ID number of the glyph type.
        ''' </summary>
        ''' <value>This property gets or sets the TypeID field.</value>
        ''' <returns>Returns the ID number of the glyph type.</returns>
        ''' <remarks>This will return 0 if the glyph is a major glyph, or a 1 if the glyph is a minor glyph.</remarks>
        Public Property TypeID As Integer

        Friend Sub New(intGlyph As Integer, intItem As Integer, strName As String, strIcon As String, intTypeID As Integer)
            Glyph = intGlyph
            Item = intItem
            Name = strName
            Icon = strIcon
            TypeID = intTypeID
        End Sub

    End Class

End Namespace
