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
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Data.Battlegroups

    ''' <summary>
    '''  A class that retrieves a list of battlegroups from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>Each region has a number of battlegroups.  This data class provides a way to retrieve those from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of battlegroups for the current region.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.Battlegroups;
    ''' 
    ''' namespace BattlegroupsExample {
    ''' 
    '''     public class BattlegroupsClass {
    ''' 
    '''         public Collection&lt;Battlegroup&gt; GetBattlegroups() {
    '''             Battlegroups battlegroups = new Battlegroups();
    '''             battlegroups.Load();
    '''             return battlegroups.Battlegroups;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.Battlegroups
    ''' 
    ''' Namespace BattlegroupsExample
    ''' 
    '''     Public Class BattlegroupsClass
    ''' 
    '''         Public Function GetBattlegroups() As Collection(Of Battlegroup)
    '''             Dim battlegroups As New Battlegroups()
    '''             battlegroups.Load()
    '''             Return battlegroups.Battlegroups
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class Battlegroups
        Inherits WowAPIData

        Private bBattlegroups As New Schema.battlegroups

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for battlegroup information.
        ''' </summary>
        ''' <value>This property gets or sets CacheLength.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for battlegroup information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache.  The default can be changed at any time before the <see cref="Battlegroups.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.Battlegroups"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/wow/data/battlegroups/", UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the battlegroups.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Battlegroup)" /> of <see cref="Battlegroup" />.  Each item in the collection represents one battlegroup received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    bBattlegroups = CType(New DataContractJsonSerializer(GetType(Schema.battlegroups)).ReadObject(msJSON), Schema.battlegroups)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colBattlegroups = (
                From b In bBattlegroups.battlegroups
                Select New Battlegroup(b.name, b.slug)
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colBattlegroups As Collection(Of Battlegroup)
        ''' <summary>
        ''' A list of battlegroups as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Battlegroups field.</value>
        ''' <returns>Returns a list of battlegroups as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Battlegroup)" /> of <see cref="Battlegroup" />, which is a list of all of the battlegroups in the region.</remarks>
        Public ReadOnly Property Battlegroups As Collection(Of Battlegroup)
            Get
                Return colBattlegroups
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve battlegroup information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="Battlegroups" /> class.  You must call the <see cref="Battlegroups.Load" /> method to load the battlegroups.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
