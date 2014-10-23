' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Data.CharacterClasses

    ''' <summary>
    ''' A class that retrieves character class information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve the list of character classes from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of character classes.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.CharacterClasses;
    '''
    ''' namespace CharacterClassesExample {
    '''
    '''     public class CharacterClassesClass {
    '''
    '''         public Collection&lt;Class&gt; GetClasses() {
    '''             CharacterClasses classes = new CharacterClasses();
    '''             classes.Load();
    '''             return classes.Classes;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.CharacterClasses
    ''' 
    ''' Namespace CharacterClassesExample
    ''' 
    '''     Public Class CharacterClassesClass
    ''' 
    '''         Public Function GetClasses() As Collection(Of [Class])
    '''             Dim classes As New CharacterClasses()
    '''             classes.Load()
    '''             Return classes.Classes
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class CharacterClasses
        Inherits WowAPIData

        Private ccClasses As New Schema.classes

#Region "WowAPIData Overrides"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for character class information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for character class information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="CharacterClasses.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.CharacterClasses"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/wow/data/character/classes", UriKind.Relative)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the character classes.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of CharacterClass)" /> of <see cref="CharacterClass" />. Each item in the collection represents a character class received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    ccClasses = CType(New DataContractJsonSerializer(GetType(Schema.classes)).ReadObject(msJSON), Schema.classes)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colClasses = (
                From c In ccClasses.classes
                Select New CharacterClass(c.id, c.mask, c.powerType.GetPowerType(), c.name)
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colClasses As Collection(Of CharacterClass)
        ''' <summary>
        ''' A list of character classes as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Classes field.</value>
        ''' <returns>Returns a list of character classes as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of CharacterClass)" /> of <see cref="CharacterClass" />, which is a list of all character classes.</remarks>
        Public ReadOnly Property Classes As Collection(Of CharacterClass)
            Get
                Return colClasses
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve character class information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="CharacterClasses" /> class. You must call the <see cref="CharacterClasses.Load" /> method to load the classes.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
