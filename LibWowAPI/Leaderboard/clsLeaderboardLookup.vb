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
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Leaderboard

    ''' <summary>
    ''' A class that retrieves PvP leaderboard information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides a leaderboard for various PvP modes.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve PvP leaderboards.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Enums
    ''' using roncliProductions.LibWowAPI.Leaderboard;
    ''' 
    ''' namespace LeaderboardExample {
    '''
    '''     public class LeaderboardClass {
    ''' 
    '''         public Collection&lt;Leaderboard&gt; GetLeaderboard(LeaderboardType type) {
    '''             LeaderboardLookup leaderboard = new LeaderboardLookup();
    '''             leaderboard.Options.Type = type;
    '''             leaderboard.Load();
    '''             return leaderboard.Leaderboard;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Enums
    ''' Imports roncliProductions.LibWowAPI.Leaderboard
    ''' 
    ''' Namespace LeaderboardExample
    ''' 
    '''     Public Class LeaderboardClass
    ''' 
    '''         Public Function GetLeaderboard(type As LeaderboardType) As Collection(Of Leaderboard)
    '''             Dim leaderboard As New LeaderboardLookup()
    '''             leaderboard.Options.Type = type
    '''             leaderboard.Load()
    '''             Return leaderboard.Leaderboard
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class LeaderboardLookup
        Inherits WowAPIData

        Private lLeaderboard As New Schema.leaderboard

#Region "WowAPIData Overrides"

#Region "Properties"

#Region "Protected"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Dim strType As String
                Select Case Options.Type
                    Case LeaderboardType.Arena2v2
                        strType = "2v2"
                    Case LeaderboardType.Arena3v3
                        strType = "3v3"
                    Case LeaderboardType.Arena5v5
                        strType = "5v5"
                    Case LeaderboardType.RatedBattlegrounds
                        strType = "rbg"
                    Case Else
                        Throw New LibWowAPIException("Invalid leaderboard type.", Nothing)
                End Select
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/leaderboard/{0}", strType), UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.Leaderboard.{0}", Options.Type)
            End Get
        End Property

#End Region

        Private Overloads Property IfModifiedSince As Date

#End Region

        ''' <summary>
        ''' Loads the leaderboard.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Leaderboard)" /> of <see cref="Leaderboard" />.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    lLeaderboard = CType(New DataContractJsonSerializer(GetType(Schema.leaderboard)).ReadObject(msJSON), Schema.leaderboard)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try
            colLeaderboard = (
                From r In lLeaderboard.rows
                Select New Leaderboard(
                    r.ranking,
                    r.rating,
                    r.name,
                    r.realmId,
                    r.realmName,
                    r.realmSlug,
                    r.raceId,
                    r.classId,
                    r.specId,
                    CType(r.factionId, Faction),
                    CType(r.genderId, Gender),
                    r.seasonWins,
                    r.seasonLosses,
                    r.weeklyWins,
                    r.weeklyLosses
                    )
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

#Region "Public"

        ''' <summary>
        ''' The options for looking up PvP leaderboard information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up PvP leaderboard information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New LeaderboardLookupOptions

        Private colLeaderboard As Collection(Of Leaderboard)
        ''' <summary>
        ''' PvP leaderboard information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Leaderboard field.</value>
        ''' <returns>Returns PvP leaderboard information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Leaderboard)" /> of <see cref="Leaderboard" /> that represents PvP leaderboard information as specified in the <see cref="LeaderboardLookup.Options" />.</remarks>
        Public ReadOnly Property Leaderboard As Collection(Of Leaderboard)
            Get
                Return colLeaderboard
            End Get
        End Property

#End Region

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve PvP leaderboard information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="LeaderboardLookup" /> class.  You must call the <see cref="LeaderboardLookup.Load" /> method to load the PvP leaderboard information.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve PvP leaderboard information for a specific leaderboard type.
        ''' </summary>
        ''' <param name="ltType">The type of leaderboard to retrieve information for.</param>
        ''' <remarks>This method creates a new instance of the <see cref="LeaderboardLookup" /> class and automatically loads the data for the specified leaderboard type.</remarks>
        Public Sub New(ltType As LeaderboardType)
            Options.Type = ltType
            Load()
        End Sub

#End Region

    End Class

End Namespace
