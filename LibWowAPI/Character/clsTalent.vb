' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's or combat pet's talent build.
    ''' </summary>
    ''' <remarks>This class represents a single talent spec.  You can determine if it is the currently selected talent spec by checking the <see cref="Talent.Selected" /> property.</remarks>
    Public Class Talent

        ''' <summary>
        ''' Indicates whether this is the currently selected talent spec.
        ''' </summary>
        ''' <value>This property gets or sets the Selected field.</value>
        ''' <returns>Returns a boolean that indicates whether this is the currently selected talent spec.</returns>
        ''' <remarks>There may only be one active talent spec.  If this property is true, this is the selected spec.</remarks>
        Public Property Selected As Boolean

        ''' <summary>
        ''' The name of the primary talent tree for this spec.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the primary talent tree for this spec.</returns>
        ''' <remarks>When initially selecting talents, there is an option to pick one of three specs.  This field lists the spec that was chosen.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The path leading to the primary talent tree's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns the path leading to the primary talent tree's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icoins/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' A string representing the talent build.
        ''' </summary>
        ''' <value>This property gets or sets the Build field.</value>
        ''' <returns>Returns a string representing the talent build.</returns>
        ''' <remarks>Each character is a digit that represents the number of talent points in a talent.  The order of the characters is so that the first character represents the first talent in the first tier of the first talent tree, and continues through the talents in that tier, then through the tiers of that talent tree, and likewise through the rest of the talent trees.</remarks>
        Public Property Build As String

        Private colTrees As Collection(Of Tree)
        ''' <summary>
        ''' A list of the talent trees.
        ''' </summary>
        ''' <value>This property gets the Trees field.</value>
        ''' <returns>Returns a list of the talent trees.</returns>
        ''' <remarks>There are three talent trees.  The order of the talent trees are alphabetical by the name of the tree.</remarks>
        Public ReadOnly Property Trees As Collection(Of Tree)
            Get
                Return colTrees
            End Get
        End Property

        ''' <summary>
        ''' The equipped glyphs.
        ''' </summary>
        ''' <value>This property gets the Glyphs field.</value>
        ''' <returns>Returns the equipped glyphs.</returns>
        ''' <remarks>Each character can have up to 9 glyphs equipped.  The <see cref="Glyphs" /> class divides them into the Prime, Major, and Minor slots.  For pets, this will contain empty collections.</remarks>
        Public Property Glyphs As Glyphs

        Friend Sub New(blnSelected As Boolean, strName As String, strIcon As String, strBuild As String, tTrees As Collection(Of Tree), gGlyphs As Glyphs)
            Selected = blnSelected
            Name = strName
            Icon = strIcon
            Build = strBuild
            colTrees = tTrees
            Glyphs = gGlyphs
        End Sub

    End Class

End Namespace
