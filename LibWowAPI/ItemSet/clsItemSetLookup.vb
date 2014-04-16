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

Namespace roncliProductions.LibWowAPI.ItemSet

    ''' <summary>
    ''' A class that retrieves item set information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about item sets.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve item set information.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.ItemSet;
    ''' 
    ''' namespace ItemSetLookupExample {
    '''
    '''     public class ItemSetLookupClass {
    ''' 
    '''         public ItemSet GetItemSet(int itemSetID) {
    '''             ItemSetLookup lookup = new ItemSetLookup();
    '''             lookup.Options.ItemSetID(itemSetID);
    '''             lookup.Load();
    '''             return lookup.ItemSet;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.ItemSet
    ''' 
    ''' Namespace ItemSetLookupExample
    ''' 
    '''     Public Class ItemSetLookupClass
    ''' 
    '''         Public Function GetItemSet(itemSetID As Integer) As ItemSet
    '''             Dim lookup As New ItemSetLookup()
    '''             lookup.Options.ItemSetID(itemSetID)
    '''             lookup.Load()
    '''             Return lookup.ItemSet
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class ItemSetLookup
        Inherits WowAPIData

        Private islItemSet As New Schema.itemSet

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for item set information.
        ''' </summary>
        ''' <value>This property gets or sets CacheLength.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for item set information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache.  The default can be changed at any time before the <see cref="ItemSetLookup.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/item/set/{0}", Options.ItemSetID), UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.ItemSetLookup.{0}", Options.ItemSetID)
            End Get
        End Property

#End Region

        Private Overloads Property IfModifiedSince As Date

#End Region

        ''' <summary>
        ''' Loads the item set.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="ItemSet" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    islItemSet = CType(New DataContractJsonSerializer(GetType(Schema.itemSet)).ReadObject(msJSON), Schema.itemSet)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try
            isItemSet = New ItemSet(
                islItemSet.id,
                islItemSet.name,
                (
                    From b In islItemSet.setBonuses
                    Order By b.threshold
                    Select New SetBonus(
                        b.description,
                        b.threshold
                        )
                    ).ToCollection(),
                islItemSet.items.ToCollection()
                )
        End Sub

#End Region

#Region "Properties"

#Region "Public"

        ''' <summary>
        ''' The options for looking up item set information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up item set information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New ItemSetLookupOptions

        Private isItemSet As ItemSet
        ''' <summary>
        ''' The item set information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the ItemSet field.</value>
        ''' <returns>Returns the item set information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is an <see cref="ItemSet" /> object that contains information about the item set specified in the <see cref="ItemSetLookup.Options" />.</remarks>
        Public ReadOnly Property ItemSet As ItemSet
            Get
                Return isItemSet
            End Get
        End Property

#End Region

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve item set information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="ItemSetLookup" /> class.  You must call the <see cref="ItemSetLookup.Load" /> method to load the item set information.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve item set information for a item set ID.
        ''' </summary>
        ''' <param name="intItemSetID">The item set ID to lookup information for.</param>
        ''' <remarks>This method creates a new instance of the <see cref="ItemSetLookup" /> class and automatically loads the data for the specified item set ID.</remarks>
        Public Sub New(intItemSetID As Integer)
            Options.ItemSetID = intItemSetID
            Load()
        End Sub

#End Region

    End Class

End Namespace
