' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Specialized
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Json
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.Encoding
Imports System.Web
Imports roncliProductions.LibWowAPI.Extensions
Imports roncliProductions.LibWowAPI.Internationalization

Namespace roncliProductions.LibWowAPI

    ''' <summary>
    ''' A base class that allows classes based on it to easily access the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>
    ''' WowAPIData serves two purposes.  First, it has several static properties which allows you to have global settings across your application.  Second, it acts as a base class for all of LibWowAPI's classes which make API calls.
    ''' <h5>Internationalization</h5>
    ''' LibWowAPI supports all regions and languages.  Internationalization is set globally by setting the <see cref="WowAPIData.Region" /> and <see cref="WowAPIData.Language" /> static properties.  The <see cref="WowAPIData.Region" /> property accepts a <see cref="Internationalization.Region" /> enumeration while the <see cref="WowAPIData.Language" /> property accepts a <see cref="Internationalization.Language" /> enumeration.
    ''' <h5>Authentication</h5>
    ''' BNET Authentication is supported by LibWowAPI.  See http://blizzard.github.com/api-wow-docs/#id3379854 for details.  If you have received a public key and private key from Blizzard, you may assign them to the <see cref="WowAPIData.PublicKey" /> and <see cref="WowAPIData.PrivateKey" /> static properties.
    ''' <h5>Metadata</h5>
    ''' LibWowAPI automatically identifies itself to Blizzard in special HTTP headers.  You may optionally choose to identify your application as well by using the <see cref="WowAPIData.Application" /> and <see cref="WowAPIData.ApplicationURL" /> static properties.
    ''' <h5>Loading Data</h5>
    ''' A typically class based on <see cref="WowAPIData" /> will have a default constructor and a <see cref="WowAPIData.Load" /> method.  This method is responsible for loading the JSON data from the API and deserializing it into a form more usable by .NET.  A class may also optionally provide constructors that take one or more parameters.  These constructors will always automatically call the <see cref="WowAPIData.Load" /> function for you.
    ''' <h5>Accessing the JSON</h5>
    ''' The JSON data returned by the API is available in the <see cref="WowAPIData.Data" /> property.
    ''' <h5>Caching</h5>
    ''' Caching is a very important aspect of LibWowAPI.  All requests are cached by the library in order to save on unnecessary API calls for commonly called requests.  The <see cref="WowAPIData.CacheLength" /> property determines how long the data is stored for.  The default value varies depending on the type of data being returned:
    ''' <ul>
    ''' <li>Data that changes at most once per major patch is cached for 30 days.</li>
    ''' <li>Data that changes on a daily basis is cached once every 24 hours.</li>
    ''' <li>Data that is time-sensitive is cached for 15 minutes.</li>
    ''' </ul>
    ''' You can change the default by assigning a new <see cref="System.TimeSpan" /> to the <see cref="WowAPIData.CacheLength" /> property prior to calling the <see cref="WowAPIData.Load" /> method.  To determine if there was a cache hit, check the <see cref="WowAPIData.CacheHit" /> property.  Note that this property is of type <see cref="System.Nullable(Of Boolean)" /> of <see cref="Boolean" />.  The value of the property is null prior to the <see cref="WowAPIData.Load" /> method being called, and is only given a value once that method is complete.  Finally, you can clear the cache for the current request by calling the <see cref="WowAPIData.Clear" /> method.  If desired, caching may be turned off for the class by setting the <see cref="WowAPIData.CacheResults" /> property to false.
    ''' <h5>IfModifiedSince</h5>
    ''' You can use the <see cref="WowAPIData.IfModifiedSince" /> property to only receive data if it is newer than a specified <see cref="Date" />.
    ''' </remarks>
    Public MustInherit Class WowAPIData

#Region "Properties"

#Region "Public"

        ''' <summary>
        ''' The region to retrieve data from.
        ''' </summary>
        ''' <value>This property gets or sets the Region static field.</value>
        ''' <returns>Returns the region to retrieve data from.</returns>
        ''' <remarks>Blizzard operates World of Warcraft in a number of regions.  Use this static property to select which region to retrieve data from.</remarks>
        Public Shared Property Region As Region = Region.NorthAmerica

        ''' <summary>
        ''' The language to retrieve data with.
        ''' </summary>
        ''' <value>This property gets or sets the Language static field.</value>
        ''' <returns>Returns the language to retrieve data with.</returns>
        ''' <remarks>It is possible to return most of the data from the API in a language other than the region's default.  However, there are some restrictions on which languages can be used by region.  In addition to  <see cref="Internationalization.Language.EnglishUS" /> being available for every region, there is a list of acceptable locales to use at http://blizzard.github.com/api-wow-docs/#id3379677.</remarks>
        Public Shared Property Language As Language = Language.EnglishUS

        ''' <summary>
        ''' The public key to use for authentication.
        ''' </summary>
        ''' <value>This property gets or sets the PublicKey static field.</value>
        ''' <returns>Returns the public key to use for authentication.</returns>
        ''' <remarks>The public key is used for BNET authentication.  You can apply for authentication at http://blizzard.github.com/api-wow-docs/#id3379854.</remarks>
        Public Shared Property PublicKey As String

        ''' <summary>
        ''' The private key to use for authentication.
        ''' </summary>
        ''' <value>This property gets or sets the PrivateKey static field.</value>
        ''' <returns>Returns the private key to use for authentication.</returns>
        ''' <remarks>The private key is used for BNET authentication.  You can apply for authentication at http://blizzard.github.com/api-wow-docs/#id3379854.</remarks>
        Public Shared Property PrivateKey As String

        ''' <summary>
        ''' The name of the application.  This gets passed as an HTTP header.
        ''' </summary>
        ''' <value>This property gets or sets the Application static field.</value>
        ''' <returns>Returns the name of the application.</returns>
        ''' <remarks>The application name is sent to Blizzard on every API request via the X-Applicaiton http header.  The purpose is to identify the application with Blizzard.</remarks>
        Public Shared Property Application As String

        ''' <summary>
        ''' The URL of the application.  This gets passed as an HTTP header.
        ''' </summary>
        ''' <value>This property gets or sets the ApplicationURL static field.</value>
        ''' <returns>Returns the URL of the application.</returns>
        ''' <remarks>The application URL is sent to Blizzard on every API request via the X-ApplicationURL http header.  The purpose is to identify the application with Blizzard.  This URL should point to either the URL of the web application or another web page that describes what the application is doing.</remarks>
        Public Shared Property ApplicationURL As String

        ''' <summary>
        ''' The time in seconds that requests to the WoW API should time out after.
        ''' </summary>
        ''' <value>This property gets or sets the Timeout field.</value>
        ''' <returns>Returns the time in seconds that requests to the WoW API should time out after.</returns>
        ''' <remarks>Typically the Blizzard WoW API returns requests in under a second, so if the default 10 second timeout is too long, this property can be changed to reduce it.</remarks>
        Public Shared Property Timeout As Integer = 10

        ''' <summary>
        ''' The JSON data that was received from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets or sets the Data field.</value>
        ''' <returns>Returns the JSON data that was received from the Blizzard WoW API.</returns>
        ''' <remarks>When the <see cref="WowAPIData.Load" /> method is called, one of the things that should happen is this property will get populated with JSON data.  While the method should also parse the JSON into a usable typed class, you also have the freedom to use the JSON provided by the API.</remarks>
        Public Property Data As String

        Private dtIfModifiedSince As Date = Date.MinValue
        ''' <summary>
        ''' The date the information was last modified.
        ''' </summary>
        ''' <value>This property gets or sets the IfModifiedSince field.</value>
        ''' <returns>Returns the date the information was last modified.</returns>
        ''' <remarks>This field should be set when you have previously retrieved the information from the API and it is unknown if the data has changed since a given date.</remarks>
        Public Property IfModifiedSince As Date
            Get
                Return dtIfModifiedSince
            End Get
            Set(value As Date)
                dtIfModifiedSince = value
            End Set
        End Property

        Private blnModified As New Boolean?
        ''' <summary>
        ''' A <see cref="System.Nullable(Of Boolean)" /> of <see cref="Boolean"/> that indicates whether the request was modified since the <see cref="IfModifiedSince" /> date.
        ''' </summary>
        ''' <value>This property gets the Modified field.</value>
        ''' <returns>Returns whether the request was modified since the <see cref="IfModifiedSince" /> date.</returns>
        ''' <remarks>When using the <see cref="IfModifiedSince" /> property, you can use this method to determine if the data has been modified since that date.</remarks>
        Public ReadOnly Property Modified As Boolean?
            Get
                Return blnModified
            End Get
        End Property

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 1 day.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 1 day.</returns>
        ''' <remarks>The CacheLength is a <see cref="System.TimeSpan" /> that determines how long an API request should be stored in the cache.  Each class based on <see cref="WowAPIData" /> can define its own cache time, and the default can be changed at any time before the <see cref="WowAPIData.Load" /> method is called.</remarks>
        Public Overridable Property CacheLength As New TimeSpan(1, 0, 0, 0)

        Private blnCacheHit As New Boolean?
        ''' <summary>
        ''' A <see cref="System.Nullable(Of Boolean)" /> of <see cref="Boolean" /> that indicates whether there was a cache hit within LibWowAPI.
        ''' </summary>
        ''' <value>This property gets the CacheHit field.</value>
        ''' <returns>Returns whether there was a cache hit within LibWowAPI.</returns>
        ''' <remarks>LibWowAPI caches all API requests.  This is null until a request is made.  If the most recent request resulted in a cache hit, this will be true.</remarks>
        Public ReadOnly Property CacheHit As Boolean?
            Get
                Return blnCacheHit
            End Get
        End Property

        Private blnCacheResults As Boolean = True
        ''' <summary>
        ''' Determines whether or not the results are cached.
        ''' </summary>
        ''' <value>This property gets or sets the CacheResults field.</value>
        ''' <returns>Returns a boolean that determines whether or not the results are cached.</returns>
        ''' <remarks>LibWowAPI caches results automatically.  However, in cases where you may be calling the API many thousands of times for different requests, this can cause an <see cref="OutOfMemoryException" />.  In these cases, you will need to set this property to false for each call to the API you make.</remarks>
        Public Property CacheResults As Boolean
            Get
                Return blnCacheResults
            End Get
            Set(value As Boolean)
                blnCacheResults = value
            End Set
        End Property

#End Region

#Region "Protected"

        Private qsQueryString As New NameValueCollection()
        Protected ReadOnly Property QueryString As NameValueCollection
            Get
                Return qsQueryString
            End Get
        End Property

        Protected MustOverride ReadOnly Property URI As Uri

        Protected MustOverride ReadOnly Property CacheKey As String

        Private ReadOnly Property InternalCacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "{0}.{1}.{2}", CacheKey, CInt(Region), CInt(Language))
            End Get
        End Property

#End Region

#End Region

#Region "Methods"

#Region "Public"

        ''' <summary>
        ''' A function to load the data from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method is overridden by all of the classes based on <see cref="WowAPIData" />.  The purpose of this method is to load the JSON data from the API and convert it into typed classes that can be used in .NET.</remarks>
        ''' <exception cref="BlizzardAPIException">If the API throws a <see cref="System.Net.WebException" /> and returns additional data with the exception, both the exception and the data will be packaged up into a <see cref="BlizzardAPIException" />.</exception>
        Public MustOverride Sub Load()

        ''' <summary>
        ''' Clears the cache associated with the current options.
        ''' </summary>
        ''' <remarks>Calling this method will immediately clear the cache for the object associated with the currently selected options.  Not recommended for most activities within LibWowAPI, but exists if you need it.</remarks>
        Public Sub Clear()
            If Cache.Cache(InternalCacheKey) IsNot Nothing Then
                Cache.Cache.Remove(InternalCacheKey)
            End If
        End Sub

#End Region

#Region "Private"

        Private Shared Function GetBaseURI() As Uri
            Select Case Region
                Case Region.China
                    Return New Uri("https://www.battlenet.com.cn/")
                Case Region.Europe
                    Return New Uri("https://eu.battle.net/")
                Case Region.Korea
                    Return New Uri("https://kr.battle.net/")
                Case Region.Taiwan
                    Return New Uri("https://tw.battle.net/")
                Case Else
                    Return New Uri("https://us.battle.net/")
            End Select
        End Function

        Private Shared Function GetLocale() As String
            Select Case Language
                Case Language.Deutsch
                    Return "de_DE"
                Case Language.EnglishEU
                    Return "en_EU"
                Case Language.EspañolAL
                    Return "es_MX"
                Case Language.PortuguêsAL
                    Return "pt_BR"
                Case Language.EspañolEU
                    Return "es_ES"
                Case Language.Français
                    Return "fr_FR"
                Case Language.PortuguêsEU
                    Return "pt_PT"
                Case Language.Русский
                    Return "ru_RU"
                Case Language.한국어
                    Return "ko_KR"
                Case Language.简体中文
                    Return "zh_CN"
                Case Language.繁體中文
                    Return "zh_TW"
                Case Else
                    Return "en_US"
            End Select
        End Function

#End Region

        ''' <summary>
        ''' Retrieves the data based on the supplied query
        ''' </summary>
        ''' <remarks></remarks>
        Protected Sub Retrieve()
            If Cache.Cache(InternalCacheKey) Is Nothing Then
                blnCacheHit = False

                Dim uriPath = New Uri(GetBaseURI, URI.ToString().Replace("%", "%25").Replace("#", "%23"))
                Dim uqsURI As New URIQueryStringCollection(uriPath)
                For Each strKey As String In QueryString.Keys
                    uqsURI.Add(strKey, QueryString(strKey))
                Next
                uqsURI.Add("locale", GetLocale())

                Dim hwrRequest = CType(HttpWebRequest.Create(uqsURI.ToURI()), HttpWebRequest)
                If IfModifiedSince <> Date.MinValue Then
                    hwrRequest.Headers.Add(HttpRequestHeader.LastModified, String.Format(CultureInfo.InvariantCulture, "{0:ddd, dd MMM yyyy hh:mm:ss} GMT", TimeZoneInfo.ConvertTimeToUtc(IfModifiedSince)))
                End If
                hwrRequest.Timeout = Timeout * 1000

                hwrRequest.Headers.Add("Accept-Encoding", "gzip")
                hwrRequest.Headers.Add("X-Library", "LibWowAPI")
                hwrRequest.Headers.Add("X-LibraryURL", "http://libwowarmory.codeplex.com")
                If Not String.IsNullOrWhiteSpace(Application) Then
                    hwrRequest.Headers.Add("X-Application", Application)
                End If
                If Not String.IsNullOrWhiteSpace(ApplicationURL) Then
                    hwrRequest.Headers.Add("X-ApplicationURL", ApplicationURL)
                End If

                If Not (String.IsNullOrWhiteSpace(PublicKey) And String.IsNullOrWhiteSpace(PrivateKey)) Then
                    Dim strEncoding As String
                    hwrRequest.Date = Date.UtcNow

                    Dim strStringToSign = String.Format(CultureInfo.InvariantCulture, "GET{0}{1:r}{0}{2}{0}", System.Convert.ToChar(10), hwrRequest.Date.ToUniversalTime(), uriPath.AbsolutePath)
                    Using shaEncryptor As New HMACSHA1(Encoding.UTF8.GetBytes(PrivateKey))
                        strEncoding = String.Format(CultureInfo.InvariantCulture, "BNET {0}:{1}", PublicKey, System.Convert.ToBase64String(shaEncryptor.ComputeHash(Encoding.UTF8.GetBytes(strStringToSign))))
                    End Using
                    hwrRequest.Headers.Add(HttpRequestHeader.Authorization, strEncoding)
                End If
                Try
                    Using wrResponse = hwrRequest.GetResponse
                        Data = wrResponse.GetResponse()
                        blnModified = CType(wrResponse, HttpWebResponse).StatusCode <> HttpStatusCode.NotModified
                    End Using

                    If blnCacheResults Then
                        Cache.Cache.Add(InternalCacheKey, Data, Nothing, Date.Now.Add(CacheLength), Caching.Cache.NoSlidingExpiration, Caching.CacheItemPriority.NotRemovable, Nothing)
                    End If
                Catch wex As WebException
                    If wex.Response Is Nothing Then Throw

                    Dim baeError As BlizzardAPIError = Nothing

                    If Data IsNot Nothing Then
                        Try
                            Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                                baeError = CType(New DataContractJsonSerializer(GetType(BlizzardAPIError)).ReadObject(msJSON), BlizzardAPIError)
                            End Using
                        Catch ex As Exception
                        End Try
                    End If

                    If baeError Is Nothing Then
                        Throw
                    Else
                        Throw New BlizzardAPIException(baeError.status, baeError.reason, wex)
                    End If
                End Try
                hwrRequest = Nothing
            Else
                blnCacheHit = True
                blnModified = True
                Data = System.Convert.ToString(Cache.Cache(InternalCacheKey), CultureInfo.InvariantCulture)
            End If
        End Sub

#End Region

    End Class

End Namespace
