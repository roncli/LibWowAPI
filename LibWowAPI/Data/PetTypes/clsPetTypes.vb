' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Data.PetTypes

    ''' <summary>
    ''' A class that retrieves pet type information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve the list of pet types from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of pet types.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.PetTypes;
    '''
    ''' namespace PetTypesExample {
    '''
    '''     public class PetTypesClass {
    '''
    '''         public Collection&lt;PetType&gt; GetPetTypes() {
    '''             PetTypes types = new PetTypes();
    '''             types.Load();
    '''             return types.PetTypes;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.PetTypes
    ''' 
    ''' Namespace PetTypesExample
    ''' 
    '''     Public Class PetTypesClass
    ''' 
    '''         Public Function GetPetTypes() As Collection(Of PetType)
    '''             Dim types As New PetTypes()
    '''             types.Load()
    '''             Return types.PetTypes
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class PetTypes
        Inherits WowAPIData

        Private ptPetTypes As New Schema.petTypes

#Region "WowAPIData Overrides"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for pet types information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for pet types information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="PetTypes.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.PetTypes"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/wow/data/pet/types", UriKind.Relative)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the pet types.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of PetTypes)" /> of <see cref="PetTypes" />.  Each item in the collection represents a pet type received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If

            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    ptPetTypes = CType(New DataContractJsonSerializer(GetType(Schema.petTypes)).ReadObject(msJSON), Schema.petTypes)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colPetTypes = (
                From pt In ptPetTypes.petTypes
                Select New PetType(
                    pt.id,
                    pt.key,
                    pt.name,
                    pt.typeAbilityId,
                    pt.strongAgainstId,
                    pt.weakAgainstId
                    )
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colPetTypes As Collection(Of PetType)
        ''' <summary>
        ''' A list of pet types as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the PetTypes field.</value>
        ''' <returns>Returns a list of pet types as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of PetType)" /> of <see cref="PetType" />, which is a list of pet types.</remarks>
        Public ReadOnly Property PetTypes As Collection(Of PetType)
            Get
                Return colPetTypes
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve pet types information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="PetTypes" /> class.  You must call the <see cref="PetTypes.Load" /> method to load the pet types.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
