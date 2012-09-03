' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about the guild being created for the guild news.
    ''' </summary>
    ''' <remarks>This class contains detailed information about the guild being created for the guild news.  Inherits from <see cref="NewsItem" />.</remarks>
    Public Class GuildCreatedNews
        Inherits NewsItem

        Friend Sub New(dtDate As Date)
            [Date] = dtDate
        End Sub

    End Class

End Namespace
