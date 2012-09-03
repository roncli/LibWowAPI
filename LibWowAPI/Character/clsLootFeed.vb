' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a looted item for the character feed.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a looted item for the character feed.  Inherits from <see cref="FeedItem" />.</remarks>
    Public Class LootFeed
        Inherits FeedItem

        ''' <summary>
        ''' The item ID of the piece of loot won.
        ''' </summary>
        ''' <value>This property gets or sets the ItemID field.</value>
        ''' <returns>Returns the item ID of the piece of loot won.</returns>
        ''' <remarks>This represents the item ID of the piece of loot won.</remarks>
        Public Property ItemID As Integer

        Friend Sub New(dtDate As Date, intItemID As Integer)
            [Date] = dtDate
            ItemID = intItemID
        End Sub

    End Class

End Namespace
