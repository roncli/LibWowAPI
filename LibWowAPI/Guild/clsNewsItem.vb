' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a guild news item.
    ''' </summary>
    ''' <remarks>This class contains basic information about a guild news item.  This class must be inherited.</remarks>
    Public MustInherit Class NewsItem

        ''' <summary>
        ''' The date of the news item.
        ''' </summary>
        ''' <value>This property gets or sets the Date field.</value>
        ''' <returns>Returns the date of the news item.</returns>
        ''' <remarks>This represents the date of the news item.</remarks>
        Public Property [Date] As Date

    End Class

End Namespace
