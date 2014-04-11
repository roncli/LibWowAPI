' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Guild

Namespace roncliProductions.LibWowAPI.Challenge

    ''' <summary>
    ''' A class containing information about a challenge mode run's group.
    ''' </summary>
    ''' <remarks>This class contains information about a challenge mode run's group.</remarks>
    Public Class Group

        ''' <summary>
        ''' The group's ranking.
        ''' </summary>
        ''' <value>This property gets or sets the Ranking field.</value>
        ''' <returns>Returns the group's ranking.</returns>
        ''' <remarks>This represents the group's ranking.</remarks>
        Public Property Ranking As Integer

        ''' <summary>
        ''' The time the group took to complete the map.
        ''' </summary>
        ''' <value>This property gets or sets the Time field.</value>
        ''' <returns>Returns the time the group took to complete the map.</returns>
        ''' <remarks>This represents the time the group took to complete the map.</remarks>
        Public Property Time As TimeSpan

        ''' <summary>
        ''' The date the run was completed.
        ''' </summary>
        ''' <value>This property gets or sets the Date field.</value>
        ''' <returns>Returns the date the run was completed.</returns>
        ''' <remarks>This represents the date the run was completed.</remarks>
        Public Property [Date] As DateTime

        ''' <summary>
        ''' The medal received by the group for this run.
        ''' </summary>
        ''' <value>This property gets or sets the Medal field.</value>
        ''' <returns>Returns the medal received by the group for this run.</returns>
        ''' <remarks>This represents the medal received by the group for this run.</remarks>
        Public Property Medal As String

        ''' <summary>
        ''' The faction the group belongs to.
        ''' </summary>
        ''' <value>This property gets or sets the Faction field.</value>
        ''' <returns>Returns the faction the group belongs to.</returns>
        ''' <remarks>This represents the faction the group belongs to.</remarks>
        Public Property Faction As Faction

        ''' <summary>
        ''' Determines whether any of the members of this group have a higher ranking for this map.
        ''' </summary>
        ''' <value>This property gets or sets the IsRecurring field.</value>
        ''' <returns>Returns whether any of the members of this group have a higher ranking for this map.</returns>
        ''' <remarks>This determines whether any of the members of this group have a higher ranking for this map.</remarks>
        Public Property IsRecurring As Boolean

        Private colMembers As Collection(Of Member)
        ''' <summary>
        ''' The members in the group.
        ''' </summary>
        ''' <value>This property gets the Members field.</value>
        ''' <returns>Returns the members in the group.</returns>
        ''' <remarks>This represents the members in the group.</remarks>
        Public ReadOnly Property Members As Collection(Of Member)
            Get
                Return colMembers
            End Get
        End Property

        ''' <summary>
        ''' The guild the members in the group are from.
        ''' </summary>
        ''' <value>This property gets or sets the Guild field.</value>
        ''' <returns>Returns the guild the members in the group are from.</returns>
        ''' <remarks>This represents the guild the members in the group are from.</remarks>
        Public Property Guild As GuildBasicInfo

        Public Sub New(intRanking As Integer, tsTime As TimeSpan, dtDate As DateTime, strMedal As String, fFaction As Faction, blnIsRecurring As Boolean, mMembers As Collection(Of Member), gbiGuild As GuildBasicInfo)
            Ranking = intRanking
            Time = tsTime
            [Date] = dtDate
            Medal = strMedal
            Faction = fFaction
            IsRecurring = blnIsRecurring
            colMembers = mMembers
            Guild = gbiGuild
        End Sub

    End Class

End Namespace
