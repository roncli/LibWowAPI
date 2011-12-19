' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Recipe

    ''' <summary>
    ''' A class containing information about a recipe.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a recipe.</remarks>
    Public Class Recipe

        ''' <summary>
        ''' The ID number of the recipe.
        ''' </summary>
        ''' <value>This property gets or sets the RecipeID field.</value>
        ''' <returns>Returns the ID number of the recipe.</returns>
        ''' <remarks>Each recipe has a unique ID number that is used to identify the recipe.</remarks>
        Public Property RecipeID As Integer

        ''' <summary>
        ''' The name of the recipe.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the recipe.</returns>
        ''' <remarks>This represents the name of the recipe.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The profession the recipe is created with.
        ''' </summary>
        ''' <value>This property gets or sets the Profession field.</value>
        ''' <returns>Returns the profession the recipe is created with.</returns>
        ''' <remarks>This represents the profession the recipe is created with.</remarks>
        Public Property Profession As String

        ''' <summary>
        ''' A path leading to the recipe's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the recipe's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        Friend Sub New(intRecipeID As Integer, strName As String, strProfession As String, strIcon As String)
            RecipeID = intRecipeID
            Name = strName
            Profession = strProfession
            Icon = strIcon
        End Sub

    End Class

End Namespace
