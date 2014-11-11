' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class that defines options for the item lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the item ID to look up an item. There is no need to create an instance of this class, as the <see cref="ItemLookup.Options" /> property automatically does so for you.</remarks>
    Public Class ItemLookupOptions

        ''' <summary>
        ''' The item ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the ItemID field.</value>
        ''' <returns>Returns the item ID to lookup.</returns>
        ''' <remarks>This represents the item ID to lookup.</remarks>
        Public Property ItemID As Integer

        ''' <summary>
        ''' The context to lookup the item in.
        ''' </summary>
        ''' <value>This property gets or sets the Context field.</value>
        ''' <returns>Returns the context to lookup the item in.</returns>
        ''' <remarks>Some items can only be retrieved using a context.  If you retrieve an item that only has a list of items in the <see cref="Item.AvailableContexts" /> collection, then you can select one of those contexts and pass it into this property to get the item with properties specific to the context specified.</remarks>
        Public Property Context As String

        Private Property colBonuses As New Collection(Of Integer)
        ''' <summary>
        ''' The bonuses to lookup on the item.
        ''' </summary>
        ''' <value>This property gets the Bonuses field.</value>
        ''' <returns>Returns the bonuses to lookup on the item.</returns>
        ''' <remarks>You can optionally add one or more bonus IDs into the query by adding each bonus ID into this property.  You can determine what the default Bonus ID is by checking the <see cref="Item.BonusSummary.DefaultBonuses" /> collection.  Additionally, you can determine what other possible Bonus IDs are allowed on an item by checking the <see cref="Item.BonusSummary.ChanceBonuses" /> property.</remarks>
        Public ReadOnly Property Bonuses As Collection(Of Integer)
            Get
                Return colBonuses
            End Get
        End Property

        Friend Sub New()
        End Sub

    End Class

End Namespace
