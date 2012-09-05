' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a guild member looting an item for the guild news.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a guild member looting an item for the guild news.  Inherits from <see cref="NewsItem" />.</remarks>
    Public Class ItemLootNews
        Inherits NewsItem

        ''' <summary>
        ''' The name of the guild member looting the item.
        ''' </summary>
        ''' <value>This property gets or sets the Character field.</value>
        ''' <returns>Returns the name of the guild member looting the item.</returns>
        ''' <remarks>This represents the name of the guild member looting the item.</remarks>
        Public Property Character As String

        ''' <summary>
        ''' The item ID of the piece of loot won.
        ''' </summary>
        ''' <value>This property gets or sets the ItemID field.</value>
        ''' <returns>Returns the item ID of the piece of loot won.</returns>
        ''' <remarks>This represents the item ID of the piece of loot won.</remarks>
        Public Property ItemID As Integer

        Friend Sub New(dtDate As Date, strCharacter As String, intItemID As Integer)
            [Date] = dtDate
            Character = strCharacter
            ItemID = intItemID
        End Sub

    End Class

End Namespace
