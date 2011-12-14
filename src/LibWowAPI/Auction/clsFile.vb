' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System

Namespace roncliProductions.LibWowAPI.Auction

    Friend Class File

        Public Property URI As Uri
        Public Property LastModified As Date

        Friend Sub New(uURI As Uri, dtLastModified As Date)
            URI = uURI
            LastModified = dtLastModified
        End Sub

    End Class

End Namespace
