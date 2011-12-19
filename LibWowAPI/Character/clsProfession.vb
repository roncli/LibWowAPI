' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's profession.
    ''' </summary>
    ''' <remarks>A profession includes not only the type of profession, but the recipee for each profession as well.</remarks>
    Public Class Profession

        ''' <summary>
        ''' The profession.
        ''' </summary>
        ''' <value>This property gets or sets the Profession field.</value>
        ''' <returns>Returns the profession.</returns>
        ''' <remarks>This is a <see cref="Enums.Profession" /> that identifies the profession this is.</remarks>
        Public Property Profession As Enums.Profession

        ''' <summary>
        ''' The name of the profession.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the profession.</returns>
        ''' <remarks>This is the localized profession name.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' A path leading to the profession's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the profession's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The current number of skill points the character has in this profession.
        ''' </summary>
        ''' <value>This property gets or sets the Rank field.</value>
        ''' <returns>Returns the current number of skill points the character has in this profession.</returns>
        ''' <remarks>This number represents the current skill the character has earned in this profession.</remarks>
        Public Property Rank As Integer

        ''' <summary>
        ''' The maximum number of skill points the character can get in this profession.
        ''' </summary>
        ''' <value>This property gets or sets the Max field.</value>
        ''' <returns>Returns the maximum number of skill points the character can get in this profession.</returns>
        ''' <remarks>This is the limit to the number of skill points the character can have in this profession.</remarks>
        Public Property Max As Integer

        Private colRecipes As Collection(Of Integer)
        ''' <summary>
        ''' A list of spell IDs representing the recipes the character knows for this profession.
        ''' </summary>
        ''' <value>This property gets the Recipes field.</value>
        ''' <returns>Returns a list of spell IDs representing the recipes the character knows for this profession.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Integer)" /> of IDs that represent recipe spells, indicating what recipes the player knows in this profession.</remarks>
        Public ReadOnly Property Recipes As Collection(Of Integer)
            Get
                Return colRecipes
            End Get
        End Property

        Friend Sub New(pProfession As Enums.Profession, strName As String, strIcon As String, intRank As Integer, intMax As Integer, intRecipes As Collection(Of Integer))
            Profession = pProfession
            Name = strName
            Icon = strIcon
            Rank = intRank
            Max = intMax
            colRecipes = intRecipes
        End Sub

    End Class

End Namespace
