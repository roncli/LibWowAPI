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

Namespace roncliProductions.LibWowAPI.Data.CharacterRaces

    ''' <summary>
    ''' A class that retrieves character race information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve the list of character races from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of character races.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.CharacterRaces;
    '''
    ''' namespace CharacterRacesExample {
    '''
    '''     public class CharacterRacesClass {
    '''
    '''         public Collection&lt;Race&gt; GetRaces() {
    '''             CharacterRaces races = new CharacterRaces();
    '''             races.Load();
    '''             return races.Races;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.CharacterRaces
    ''' 
    ''' Namespace CharacterRacesExample
    ''' 
    '''     Public Class CharacterRacesClass
    ''' 
    '''         Public Function GetRaces() As Collection(Of Race)
    '''             Dim races As New CharacterRaces()
    '''             races.Load()
    '''             Return races.Races
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class CharacterRaces
        Inherits WowAPIData

        Private crRaces As New Schema.races

#Region "WowAPIData Overrides"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for character race information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for character race information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="CharacterRaces.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.CharacterRaces"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/wow/data/character/races", UriKind.Relative)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the character races.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Race)" /> of <see cref="Race" />. Each item in the collection represents a character race received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    crRaces = CType(New DataContractJsonSerializer(GetType(Schema.races)).ReadObject(msJSON), Schema.races)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colRaces = (
                From r In crRaces.races
                Select New Race(r.id, r.mask, r.side.GetFaction(), r.name)
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colRaces As Collection(Of Race)
        ''' <summary>
        ''' A list of character races as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Races field.</value>
        ''' <returns>Returns a list of character races as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Race)" /> of <see cref="Race" />, which is a list of all character races.</remarks>
        Public ReadOnly Property Races As Collection(Of Race)
            Get
                Return colRaces
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve character race information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="CharacterRaces" /> class. You must call the <see cref="CharacterRaces.Load" /> method to load the races.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
