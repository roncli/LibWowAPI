' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Globalization
Imports System.Runtime.Serialization

Namespace roncliProductions.LibWowAPI

    ''' <summary>
    ''' A class that represents an error thrown by LibWowAPI.
    ''' </summary>
    ''' <remarks>There have been cases where the API does not throw an error, but the JSON returned by Blizzard is incomplete due to a problem on their end.  When this happens, a <see cref="System.Runtime.Serialization.SerializationException" /> is caught and repackaged in the inner exception of a <see cref="LibWowAPIException" />.</remarks>
    Public Class LibWowAPIException
        Inherits Exception

        Private Sub New()
            MyBase.New()
        End Sub

        Private Sub New(message As String)
            MyBase.New(message)
        End Sub

        Friend Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub

        Private Sub New(info As SerializationInfo, context As StreamingContext)
            MyBase.New(info, context)
        End Sub

    End Class

End Namespace
