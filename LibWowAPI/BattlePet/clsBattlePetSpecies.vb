' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.BattlePet

    ''' <summary>
    ''' A class that looks up information for a single battle pet species from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve information for a single battle pet species from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve a battle pet species.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.BattlePets;
    '''
    ''' namespace SpeciesExample {
    '''
    '''     public class SpeciesClass {
    '''
    '''         public Species GetSpecies(int speciesID) {
    '''             BattlePetSpecies species = new BattlePetSpecies();
    '''             species.Options.SpeciesID = speciesID;
    '''             species.Load();
    '''             return species.Species;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.BattlePets
    ''' 
    ''' Namespace SpeciesExample
    ''' 
    '''     Public Class SpeciesClass
    ''' 
    '''         Public Function GetSpecies(speciesID As Integer) As Species
    '''             Dim species As New BattlePetSpecies()
    '''             species.Options.SpeciesID = speciesID
    '''             species.Load()
    '''             Return species.Species
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class BattlePetSpecies
        Inherits WowAPIData

        Private bpsSpecies As New Schema.species

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for battle pet species information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for battle pet species information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="BattlePetSpecies.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.BattlePetSpecies.{0}", Options.SpeciesID)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/wow/battlePet/species/{0}", Options.SpeciesID), UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the battle pet species.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into an <see cref="Species" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    bpsSpecies = CType(New DataContractJsonSerializer(GetType(Schema.species)).ReadObject(msJSON), Schema.species)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            sSpecies = New Species(
                bpsSpecies.speciesId,
                bpsSpecies.petTypeId.GetPetType(),
                bpsSpecies.creatureId,
                bpsSpecies.name,
                bpsSpecies.canBattle,
                bpsSpecies.icon,
                bpsSpecies.description,
                bpsSpecies.source,
                If(
                    bpsSpecies.abilities Is Nothing, Nothing, (
                        From a In bpsSpecies.abilities
                        Order By a.order
                        Select New SpeciesAbility(
                            a.slot,
                            a.order,
                            a.requiredLevel,
                            a.id,
                            a.name,
                            a.icon,
                            a.cooldown,
                            a.rounds,
                            a.petTypeId.GetPetType(),
                            a.isPassive,
                            a.hideHints
                            )
                        ).ToCollection()
                    )
                )
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up a battle pet species.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up a battle pet species.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New BattlePetSpeciesOptions

        Private sSpecies As Species
        ''' <summary>
        ''' The battle pet species returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Species field.</value>
        ''' <returns>Returns battle pet species information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is an <see cref="Species" /> object that contains information about the battle pet species specified in the <see cref="BattlePetSpecies.Options" />.</remarks>
        Public ReadOnly Property Species As Species
            Get
                Return sSpecies
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve information for a single battle pet species from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="BattlePetSpecies" /> class.  You must call the <see cref="BattlePetSpecies.Load" /> method to load a battle pet species.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve information for a single battle pet species from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="intSpeciesID">The species ID to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="BattlePetSpecies" /> class and automatically loads the data for the specified battle pet species ID.</remarks>
        Public Sub New(intSpeciesID As Integer)
            Options.SpeciesID = intSpeciesID
            Load()
        End Sub

#End Region

    End Class

End Namespace
