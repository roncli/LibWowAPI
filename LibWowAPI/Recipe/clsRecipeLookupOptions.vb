' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Recipe

    ''' <summary>
    ''' A class that defines options for the recipe lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the ID number to look up recipe information for. There is no need to create an instance of this class, as the <see cref="RecipeLookup.Options" /> property automatically does so for you.</remarks>
    Public Class RecipeLookupOptions

        ''' <summary>
        ''' The recipe ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the RecipeID field.</value>
        ''' <returns>Returns the recipe ID to lookup.</returns>
        ''' <remarks>This represents the recipe ID to lookup.</remarks>
        Public Property RecipeID As Integer

        Friend Sub New()
        End Sub

    End Class

End Namespace
