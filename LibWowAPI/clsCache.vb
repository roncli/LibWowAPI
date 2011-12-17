' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Web

Namespace roncliProductions.LibWowAPI

    Friend Class Cache

        Private Shared hrRuntime As HttpRuntime

        Public Shared ReadOnly Property Cache As System.Web.Caching.Cache
            Get
                If hrRuntime Is Nothing Then
                    hrRuntime = New HttpRuntime
                End If
                Return HttpRuntime.Cache
            End Get
        End Property

        Private Sub New()
        End Sub

    End Class

End Namespace