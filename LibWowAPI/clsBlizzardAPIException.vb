' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Globalization
Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI

    ''' <summary>
    ''' A class that represents an error thrown by Blizzard's API.
    ''' </summary>
    ''' <remarks>When there is a problem with the API request, the API will throw a <see cref="System.Net.WebException" />.  The API often will also include some information about the error that was thrown.  In this case, the <see cref="System.Net.WebException" /> is caught and is repackaged along with the additional information as a <see cref="BlizzardAPIException" />.</remarks>
    Public Class BlizzardAPIException
        Inherits Exception

        Friend Sub New(baeError As BlizzardAPIError, innerException As Exception)
            MyBase.New(ErrorString(baeError), innerException)
        End Sub

        Private Sub New()
            MyBase.New()
        End Sub

        Private Sub New(message As String)
            MyBase.New(message)
        End Sub

        Private Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub

        Protected Sub New(info As SerializationInfo, context As StreamingContext)
            MyBase.New(info, context)
        End Sub

        Private Shared Function ErrorString(baeError As BlizzardAPIError) As String
            If baeError.code = 0 Then
                Return String.Format(CultureInfo.InvariantCulture, "The Blizzard API threw the following error: {0} - {1}", baeError.status, baeError.reason)
            Else
                Return String.Format(CultureInfo.InvariantCulture, "The Blizzard API threw the following error: {0} - {1} - {2}", baeError.code, baeError.type, baeError.detail)
            End If
        End Function

    End Class

End Namespace
