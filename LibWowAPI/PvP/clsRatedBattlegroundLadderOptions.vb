' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class that defines options for the rated battleground ladder lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the number of characters, the page number, and sort order to lookup on the rated battleground ladder. There is no need to create an instance of this class, as the <see cref="RatedBattlegroundLadder.Options" /> property automatically does so for you.</remarks>
    Public Class RatedBattlegroundLadderOptions

        ''' <summary>
        ''' The number of characters to return.
        ''' </summary>
        ''' <value>This property gets or sets the Characters field.</value>
        ''' <returns>Returns the number of characters to return.</returns>
        ''' <remarks>This property allows you to set the number of characters to return on the ladder.  Defaults to 50.</remarks>
        Public Property Characters As Integer

        ''' <summary>
        ''' The page number to return.
        ''' </summary>
        ''' <value>This property gets or sets the Page field.</value>
        ''' <returns>Returns the page number to return.</returns>
        ''' <remarks>This property allows you to set the page number of results to return.  Defaults to 1.</remarks>
        Public Property Page As Integer

        ''' <summary>
        ''' A boolean indicating whether to return results in ascending or descending order.
        ''' </summary>
        ''' <value>This property gets or sets the Ascending field.</value>
        ''' <returns>Returns a boolean indicating whether to return results in ascending or descending order.</returns>
        ''' <remarks>This property is a <see cref="System.Nullable(Of Boolean)" /> of <see cref="Boolean" /> that, when set to false, returns characters in descending ranking.  Defaults to True.</remarks>
        Public Property Ascending As New Boolean?

        Friend Sub New()
        End Sub

    End Class

End Namespace
