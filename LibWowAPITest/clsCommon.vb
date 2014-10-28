' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Configuration
Imports roncliProductions.LibWowAPI

Public Class clsCommon

    Private Shared strApiKey As String

    Shared Sub LoadApiKey()
        If strApiKey Is Nothing Then
            Dim settings = ConfigurationManager.AppSettings
            If Not settings.HasKeys Then
                Throw New ConfigurationErrorsException("Missing appSettings in privateConfig.config file.")
            End If

            If settings.Get("apiKey") Is Nothing Then
                Throw New ConfigurationErrorsException("Missing apiKey from appSettings in privateConfig.config file.")
            End If

            strApiKey = settings.Get("apiKey")
        End If

        WowAPIData.ApiKey = strApiKey
    End Sub

End Class
