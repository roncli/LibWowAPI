' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Auction

    Friend NotInheritable Class AuctionFiles
        Inherits WowAPIData

        Private fFiles As New Schema.files

#Region "WowAPIData Overrides"

#Region "Public Properties"

        Public Overrides Property CacheLength As New TimeSpan(0, 15, 0)

#End Region

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.AuctionFiles.{0}", Options.Realm)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/auction/data/{0}", Options.Realm), UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

#Region "Properties"

        Public Property Options As New AuctionFilesOptions()

        Private colFiles As Collection(Of File)
        Public ReadOnly Property Files As Collection(Of File)
            Get
                Return colFiles
            End Get
        End Property

#End Region

#Region "Methods"

        Public Sub New()
        End Sub

        Public Sub New(strRealm As String)
            Options.Realm = strRealm
            Load()
        End Sub

        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    fFiles = CType(New DataContractJsonSerializer(GetType(Schema.files)).ReadObject(msJSON), Schema.files)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colFiles = (
                From f In fFiles.files
                Select New File(New Uri(f.url), f.lastModified.BlizzardTimestampToUTC())
                ).ToCollection()
        End Sub

#End Region

    End Class

End Namespace
