' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class that defines options for the arena team lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the realm, teamsize, and name of an arena team to lookup. There is no need to create an instance of this class, as the <see cref="ArenaTeam.Options" /> property automatically does so for you.</remarks>
    Public Class ArenaTeamOptions

        ''' <summary>
        ''' The realm the arena team to lookup resides on.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm the arena team to lookup resides on.</returns>
        ''' <remarks>This property allows you to set the realm to look up the arena team for.  You may use either the <see cref="LibWowAPI.Realm.Realm.Name" /> or the <see cref="LibWowAPI.Realm.Realm.Slug" />.</remarks>
        Public Property Realm As String

        ''' <summary>
        ''' The team size of the arena team.
        ''' </summary>
        ''' <value>This property gets or sets the TeamSize field.</value>
        ''' <returns>Returns the team size of the arena team.</returns>
        ''' <remarks>This property allows you to set the team size to look up.</remarks>
        Public Property TeamSize As Integer

        ''' <summary>
        ''' The name of the arena team to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the arena team to lookup.</returns>
        ''' <remarks>This property allows you to set the name to look up the arena team for.</remarks>
        Public Property Name As String

        Friend Sub New()
        End Sub

    End Class

End Namespace
