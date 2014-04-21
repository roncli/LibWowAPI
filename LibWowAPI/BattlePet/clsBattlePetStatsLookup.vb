' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.BattlePet

    ''' <summary>
    ''' A class that looks up information for a single battle pet's stats from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve information for a single battle pet's stats from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve a battle pet's stats.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.BattlePet;
    '''
    ''' namespace StatsExample {
    '''
    '''     public class StatsClass {
    '''
    '''         public Stats GetStats(int speciesID) {
    '''             BattlePetStatsLookup stats = new BattlePetStatsLookup();
    '''             stats.Options.SpeciesID = speciesID;
    '''             stats.Load();
    '''             return stats.Stats;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.BattlePet
    ''' 
    ''' Namespace StatsExample
    ''' 
    '''     Public Class StatsClass
    ''' 
    '''         Public Function GetStats(speciesID As Integer) As Stats
    '''             Dim stats As New BattlePetStatsLookup()
    '''             stats.Options.SpeciesID = speciesID
    '''             stats.Load()
    '''             Return stats.Stats
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class BattlePetStatsLookup
        Inherits WowAPIData

        Private bpsStats As New Schema.stats

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for battle pet stats information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for battle pet stats information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="BattlePetStatsLookup.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.BattlePetStatsLookup.{0}.{1}.{2}.{3}", Options.SpeciesID, Options.Level, Options.Breed, Options.Quality)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                QueryString.Clear()
                If Options.Level <> 0 Then
                    QueryString.Add("level", Options.Level.ToString(CultureInfo.InvariantCulture))
                End If
                If Options.Breed <> BattlePetBreed.Unknown Then
                    QueryString.Add("breedId", CInt(Options.Breed).ToString(CultureInfo.InvariantCulture))
                End If
                If Options.Quality <> Quality.Unknown Then
                    QueryString.Add("qualityId", CInt(Options.Quality).ToString(CultureInfo.InvariantCulture))
                End If
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/battlePet/stats/{0}", Options.SpeciesID), UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the battle pet's stats.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Stats" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    bpsStats = CType(New DataContractJsonSerializer(GetType(Schema.stats)).ReadObject(msJSON), Schema.stats)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            sStats = New BattlePetStats(
                bpsStats.speciesId,
                CType(bpsStats.breedId, BattlePetBreed),
                CType(bpsStats.petQualityId, Quality),
                bpsStats.level,
                bpsStats.health,
                bpsStats.power,
                bpsStats.speed
                )
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up a battle pet's stats.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up a battle pet's stats.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New BattlePetStatsLookupOptions

        Private sStats As BattlePetStats
        ''' <summary>
        ''' The battle pet's stats returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Stats field.</value>
        ''' <returns>Returns battle pet's stats information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is a <see cref="BattlePetStats" /> object that contains information about the battle pet's stats specified in the <see cref="BattlePetStatsLookup.Options" />.</remarks>
        Public ReadOnly Property Stats As BattlePetStats
            Get
                Return sStats
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve information for a single battle pet's stats from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="BattlePetStatsLookup" /> class.  You must call the <see cref="BattlePetStatsLookup.Load" /> method to load a battle pet's stats.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve information for a single battle pet's stats from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="intSpeciesID">The species ID to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="BattlePetStatsLookup" /> class and automatically loads the data for the specified battle pet species ID.</remarks>
        Public Sub New(intSpeciesID As Integer)
            Options.SpeciesID = intSpeciesID
            Load()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve information for a single battle pet's stats from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="intSpeciesID">The species ID to lookup.</param>
        ''' <param name="intLevel">The pet's level.</param>
        ''' <param name="bpbBreed">The pet's breed.</param>
        ''' <param name="qQuality">The pet's quality.</param>
        ''' <remarks>This method creates a new instance of the <see cref="BattlePetStatsLookup" /> class and automatically loads the data for the specified battle pet species ID, adjusted for the pet's level, breed, and quality.</remarks>
        Public Sub New(intSpeciesID As Integer, intLevel As Integer, bpbBreed As BattlePetBreed, qQuality As Quality)
            Options.SpeciesID = intSpeciesID
            Options.Level = intLevel
            Options.Breed = bpbBreed
            Options.Quality = qQuality
            Load()
        End Sub

#End Region

    End Class

End Namespace
