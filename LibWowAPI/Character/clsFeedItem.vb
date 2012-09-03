' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character feed item.
    ''' </summary>
    ''' <remarks>This class contains basic information about a character feed item.  This class must be inherited.</remarks>
    Public MustInherit Class FeedItem

        ''' <summary>
        ''' The date of the feed item.
        ''' </summary>
        ''' <value>This property gets or sets the Date field.</value>
        ''' <returns>Returns the date of the feed item.</returns>
        ''' <remarks>This represents the date of the feed item.</remarks>
        Public Property [Date] As Date

    End Class

End Namespace
