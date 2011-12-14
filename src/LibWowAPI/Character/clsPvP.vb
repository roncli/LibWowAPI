' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's PvP stats.
    ''' </summary>
    ''' <remarks>PvP statistics are stored for each character's arena matches, rated battlegrounds, and overall total number of honorable kills.</remarks>
    Public Class PvP

        ''' <summary>
        ''' The character's rated battleground stats.
        ''' </summary>
        ''' <value>This property gets or sets the RatedBattlegrounds field.</value>
        ''' <returns>Returns the character's rated battleground stats.</returns>
        ''' <remarks>All statistics related to rated battlegrounds are found in this <see cref="RatedBattlegrounds" /> object.</remarks>
        Public Property RatedBattlegrounds As RatedBattlegrounds

        Private colArenaTeams As Collection(Of ArenaTeam)
        ''' <summary>
        ''' The character's arena team stats.
        ''' </summary>
        ''' <value>This property gets the ArenaTeams field.</value>
        ''' <returns>Returns the character's arena team stats.</returns>
        ''' <remarks>This is a <see cref="Collection(Of ArenaTeam)" /> of <see cref="ArenaTeam" />, each of which gives statistics about one of the character's arena teams.</remarks>
        Public ReadOnly Property ArenaTeams As Collection(Of ArenaTeam)
            Get
                Return colArenaTeams
            End Get
        End Property

        ''' <summary>
        ''' The total number of honorable kills the character has made.
        ''' </summary>
        ''' <value>This property gets or sets the TotalHonorableKills field.</value>
        ''' <returns>Returns the total number of honorable kills the character has made.</returns>
        ''' <remarks>This number keeps track of how many honorable kills the character has earned.</remarks>
        Public Property TotalHonorableKills As Integer

        Friend Sub New(rbRatedBattlegrounds As RatedBattlegrounds, atArenaTeams As Collection(Of ArenaTeam), intTotalHonorableKills As Integer)
            RatedBattlegrounds = rbRatedBattlegrounds
            colArenaTeams = atArenaTeams
            TotalHonorableKills = intTotalHonorableKills
        End Sub

    End Class

End Namespace
