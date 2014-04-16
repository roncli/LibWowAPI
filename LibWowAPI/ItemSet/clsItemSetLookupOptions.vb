' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.ItemSet

    ''' <summary>
    ''' A class that defines options for the item set lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the ID number to look up item set information for. There is no need to create an instance of this class, as the <see cref="ItemSetLookup.Options" /> property automatically does so for you.</remarks>
    Public Class ItemSetLookupOptions

        ''' <summary>
        ''' The item set ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the ItemSetID field.</value>
        ''' <returns>Returns the item set ID to lookup.</returns>
        ''' <remarks>This represents the item set ID to lookup.</remarks>
        Public Property ItemSetID As Integer

        Friend Sub New()
        End Sub

    End Class

End Namespace
