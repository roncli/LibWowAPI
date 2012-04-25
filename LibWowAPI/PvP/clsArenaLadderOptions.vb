' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class that defines options for the arena ladder lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the battlegroup, team size, number of teams, the page number, and sort order to lookup on an arena ladder. There is no need to create an instance of this class, as the <see cref="ArenaLadder.Options" /> property automatically does so for you.</remarks>
    Public Class ArenaLadderOptions

        ''' <summary>
        ''' The battlegroup to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the Battlegroup field.</value>
        ''' <returns>Returns the battlegroup to lookup.</returns>
        ''' <remarks>This property allows you to set the battlegroup to look up.  You may use either the <see cref="Data.Battlegroups.Battlegroup.Name" /> or the <see cref="Data.Battlegroups.Battlegroup.Slug" />.</remarks>
        Public Property Battlegroup As String

        ''' <summary>
        ''' The team size of the arena team.
        ''' </summary>
        ''' <value>This property gets or sets the TeamSize field.</value>
        ''' <returns>Returns the team size of the arena team.</returns>
        ''' <remarks>This property allows you to set the team size to look up.</remarks>
        Public Property TeamSize As Integer

        ''' <summary>
        ''' The number of teams to return.
        ''' </summary>
        ''' <value>This property gets or sets the Teams field.</value>
        ''' <returns>Returns the number of teams to return.</returns>
        ''' <remarks>This property allows you to set the number of teams to return on the ladder, up to 2000.  Defaults to 50.</remarks>
        Public Property Teams As Integer

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
        ''' <remarks>This property is a <see cref="System.Nullable(Of Boolean)" /> of <see cref="Boolean" /> that, when set to false, returns teams in descending ranking.  Defaults to True.</remarks>
        Public Property Ascending As New Boolean?

        Friend Sub New()
        End Sub

    End Class

End Namespace
