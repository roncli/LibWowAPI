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

Namespace roncliProductions.LibWowAPI.Realm

    ''' <summary>
    ''' A class that retrieves realm status information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about realms and their status.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve realm status.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Realm;
    ''' 
    ''' namespace RealmStatusExample {
    '''
    '''     public class RealmStatusClass {
    ''' 
    '''         public Collection(Of Realm) GetRealmStatus(string realm) {
    '''             RealmStatus status = new RealmStatus();
    '''             status.Options.Realms.Add(realm);
    '''             status.Load();
    '''             return status.Realms;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Realm
    ''' 
    ''' Namespace RealmStatusExample
    ''' 
    '''     Public Class RealmStatusClass
    ''' 
    '''         Public Function GetRealmStatus(realm As String) As Collection(Of Realm)
    '''             Dim status As New RealmStatus()
    '''             status.Options.Realms.Add(realm)
    '''             status.Load()
    '''             Return status.Realms
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class RealmStatus
        Inherits WowAPIData

        Private rRealms As New Schema.realms

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 15 minutes for realm status information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 15 minutes for realm status information.</returns>
        ''' <remarks>The CacheLength is a <see cref="System.TimeSpan" /> that determines how long an API request should be stored in the cache.  The default can be changed at any time before the <see cref="RealmStatus.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(0, 15, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                QueryString.Clear()
                If Options.Realms.Count > 0 Then
                    QueryString.Add("realms", RealmList)
                End If
                Return New Uri("/api/wow/realm/status", UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.RealmStatus.{0}", RealmList)
            End Get
        End Property

#End Region

        Private Overloads Property IfModifiedSince As Date

#End Region

        ''' <summary>
        ''' Loads the realm status.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Realm)" /> of <see cref="Realm" />.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    rRealms = CType(New DataContractJsonSerializer(GetType(Schema.realms)).ReadObject(msJSON), Schema.realms)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try
            colRealms = (
                From r In rRealms.realms
                Select New Realm(
                    r.type.GetRealmType(),
                    r.population,
                    r.queue,
                    New PvpZone(
                        r.wintergrasp.area,
                        CType(r.wintergrasp.controllingFaction, Side),
                        r.wintergrasp.status,
                        r.wintergrasp.next.BlizzardTimestampToUTC()
                        ),
                    New PvpZone(
                        r.tolBarad.area,
                        CType(r.tolBarad.controllingFaction, Side),
                        r.tolBarad.status,
                        r.tolBarad.next.BlizzardTimestampToUTC()
                        ),
                    r.status,
                    r.name,
                    r.battlegroup,
                    r.slug
                    )
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

#Region "Public"

        ''' <summary>
        ''' The options for looking up realm status information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up realm status information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New RealmStatusOptions

        Private colRealms As Collection(Of Realm)
        ''' <summary>
        ''' A list of realm status information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Realms field.</value>
        ''' <returns>Returns a list of realm status information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Realm)" /> of <see cref="Realm" /> that is a list of realms complete with status information as specified in the <see cref="RealmStatus.Options" />.</remarks>
        Public ReadOnly Property Realms As Collection(Of Realm)
            Get
                Return colRealms
            End Get
        End Property

#End Region

        Private ReadOnly Property RealmList As String
            Get
                Return String.Join(",", Options.Realms)
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve realm status information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="RealmStatus" /> class.  You must call the <see cref="RealmStatus.Load" /> method to load the realm status information.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve realm status information for a single realm.
        ''' </summary>
        ''' <param name="strRealm">The realm to lookup status information for.</param>
        ''' <remarks>This method creates a new instance of the <see cref="RealmStatus" /> class and automatically loads the data for the specified realm.</remarks>
        Public Sub New(strRealm As String)
            Options.Realms.Add(strRealm)
            Load()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve realm status information for multiple realms.
        ''' </summary>
        ''' <param name="strRealm">The list of realms to lookup status information for.</param>
        ''' <remarks>This method creates a new instance of the <see cref="RealmStatus" /> class and automatically loads the data for the specified realms.</remarks>
        Public Sub New(strRealm As IEnumerable(Of String))
            Options.Realms.AddRange(strRealm)
            Load()
        End Sub

#End Region

    End Class

End Namespace
