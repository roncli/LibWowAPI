' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Recipe

    ''' <summary>
    ''' A class that retrieves recipe information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about recipes.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve recipe information.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Recipe;
    ''' 
    ''' namespace RecipeLookupExample {
    '''
    '''     public class RecipeLookupClass {
    ''' 
    '''         public Recipe GetRecipe(int recipeID) {
    '''             RecipeLookup lookup = new RecipeLookup();
    '''             lookup.Options.RecipeID(recipeID);
    '''             lookup.Load();
    '''             return lookup.Recipe;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Recipe
    ''' 
    ''' Namespace RecipeLookupExample
    ''' 
    '''     Public Class RecipeLookupClass
    ''' 
    '''         Public Function GetRecipe(recipeID As Integer) As Recipe
    '''             Dim lookup As New RecipeLookup()
    '''             lookup.Options.RecipeID(recipeID)
    '''             lookup.Load()
    '''             Return lookup.Recipe
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class RecipeLookup
        Inherits WowAPIData

        Private rlRecipe As New Schema.recipe

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for recipe information.
        ''' </summary>
        ''' <value>This property gets or sets CacheLength.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for recipe information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache.  The default can be changed at any time before the <see cref="RecipeLookup.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/recipe/{0}", Options.RecipeID), UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.RecipeLookup.{0}", Options.RecipeID)
            End Get
        End Property

#End Region

        Private Overloads Property IfModifiedSince As Date

#End Region

        ''' <summary>
        ''' Loads the recipe.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Recipe" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    rlRecipe = CType(New DataContractJsonSerializer(GetType(Schema.recipe)).ReadObject(msJSON), Schema.recipe)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try
            rRecipe = New Recipe(rlRecipe.id, rlRecipe.name, rlRecipe.profession, rlRecipe.icon)
        End Sub

#End Region

#Region "Properties"

#Region "Public"

        ''' <summary>
        ''' The options for looking up recipe information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up recipe information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New RecipeLookupOptions

        Private rRecipe As Recipe
        ''' <summary>
        ''' The recipe information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Recipe field.</value>
        ''' <returns>Returns the recipe information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is an <see cref="Recipe" /> object that contains information about the recipe specified in the <see cref="RecipeLookup.Options" />.</remarks>
        Public ReadOnly Property Recipe As Recipe
            Get
                Return rRecipe
            End Get
        End Property

#End Region

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve recipe information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="RecipeLookup" /> class.  You must call the <see cref="RecipeLookup.Load" /> method to load the recipe information.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve recipe information for a recipe ID.
        ''' </summary>
        ''' <param name="intRecipeID">The recipe ID to lookup information for.</param>
        ''' <remarks>This method creates a new instance of the <see cref="RecipeLookup" /> class and automatically loads the data for the specified recipe ID.</remarks>
        Public Sub New(intRecipeID As Integer)
            Options.RecipeID = intRecipeID
            Load()
        End Sub

#End Region

    End Class

End Namespace
