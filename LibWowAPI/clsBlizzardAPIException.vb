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

        ''' <summary>
        ''' The status of the request as provided by Blizzard.
        ''' </summary>
        ''' <value>This property gets or sets the Status field.</value>
        ''' <returns>Returns the status of the request as provided by Blizzard.</returns>
        ''' <remarks>This is the status of the request as provided by Blizzard.  While this typically returns "nok", it is not known if values other than "nok" exist.</remarks>
        Public Property Status As String

        ''' <summary>
        ''' The reason for the error as provided by Blizzard.
        ''' </summary>
        ''' <value>This property gets or sets the Reason field.</value>
        ''' <returns>Returns the reason why the error occurred as provided by Blizzard.</returns>
        ''' <remarks>This is the reason why the error occurred as provided by Blizzard.  While there is a list of possible errors at http://blizzard.github.com/api-wow-docs/#id3380043 it is neither exhaustive nor 100% accurate.</remarks>
        Public Property Reason As String

        Friend Sub New(strStatus As String, strReason As String, innerException As Exception)
            MyBase.New(String.Format(CultureInfo.InvariantCulture, "The Blizzard API threw the following error: {0} - {1}", strStatus, strReason), innerException)
            Status = strStatus
            Reason = strReason
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

    End Class

End Namespace
