' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

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

        Friend Sub New()
        End Sub

    End Class

End Namespace
