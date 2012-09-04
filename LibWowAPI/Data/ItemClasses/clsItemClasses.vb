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

Namespace roncliProductions.LibWowAPI.Data.ItemClasses

    ''' <summary>
    ''' A class that retrieves item class information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve the list of item classes from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of item classes.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.ItemClasses;
    '''
    ''' namespace ItemClassesExample {
    '''
    '''     public class ItemClassesClass {
    '''
    '''         public Collection&lt;Class&gt; GetItemClasses() {
    '''             ItemClasses classes = new ItemClasses();
    '''             classes.Load();
    '''             return classes.Classes;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.ItemClasses
    ''' 
    ''' Namespace ItemClassesExample
    ''' 
    '''     Public Class ItemClassesClass
    ''' 
    '''         Public Function GetItemClasses() As Collection(Of [Class])
    '''             Dim classes As New ItemClasses()
    '''             classes.Load()
    '''             Return classes.Classes
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class ItemClasses
        Inherits WowAPIData

        Private icClasses As New Schema.classes

#Region "WowAPIData Overrides"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for item class information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for item class information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="ItemClasses.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.ItemClasses"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/api/wow/data/item/classes", UriKind.Relative)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the item classes.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of [Class])" /> of <see cref="[Class]" />.  Each item in the collection represents an item class received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    icClasses = CType(New DataContractJsonSerializer(GetType(Schema.classes)).ReadObject(msJSON), Schema.classes)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colClasses = (
                From c In icClasses.classes
                Select New [Class](c.class, c.name, (From s In c.subclasses Select New Subclass(s.subclass, s.name)).ToCollection())
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colClasses As Collection(Of [Class])
        ''' <summary>
        ''' A list of item classes as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Classes field.</value>
        ''' <returns>Returns a list of item classes as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of [Class])" /> of <see cref="[Class]" />, which is a list of all item classes.</remarks>
        Public ReadOnly Property Classes As Collection(Of [Class])
            Get
                Return colClasses
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve item class information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="ItemClasses" /> class.  You must call the <see cref="ItemClasses.Load" /> method to load the item classes.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
