' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Specialized
Imports System.Web

Namespace roncliProductions.LibWowAPI

    Friend Class URIQueryStringCollection
        Inherits NameValueCollection

        Private Property BaseURI As Uri

        Friend Sub New(uBaseURI As Uri)
            BaseURI = uBaseURI
        End Sub

        Friend Function ToURI() As Uri
            Dim ubURI As New UriBuilder(BaseURI)
            Dim hvcCollection = HttpUtility.ParseQueryString(String.Empty)

            For Each strKey As String In MyBase.Keys
                hvcCollection(strKey) = MyBase.Item(strKey)
            Next

            ubURI.Query = hvcCollection.ToString()
            Return ubURI.Uri
        End Function

    End Class

End Namespace
