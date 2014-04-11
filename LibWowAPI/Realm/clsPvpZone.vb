' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Realm

    ''' <summary>
    ''' A class containing information about a realm's PvP zone.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a realm's PvP zone.</remarks>
    Public Class PvpZone

        ''' <summary>
        ''' Blizzard's internal ID for the zone.
        ''' </summary>
        ''' <value>This property gets or sets the Area field.</value>
        ''' <returns>Returns Blizzard's internal ID for the zone.</returns>
        ''' <remarks>This represents Blizzard's internal ID for the zone.</remarks>
        Public Property Area As Integer

        ''' <summary>
        ''' The faction that controls the zone.
        ''' </summary>
        ''' <value>This property gets or sets the ControllingFaction field.</value>
        ''' <returns>Returns the faction that controls the zone.</returns>
        ''' <remarks>This is a <see cref="Enums.Faction" /> enumeration that represents the faction that controls the zone.</remarks>
        Public Property ControllingFaction As Faction

        ''' <summary>
        ''' The status of the zone.
        ''' </summary>
        ''' <value>This property gets or sets the Status field.</value>
        ''' <returns>Returns the status of the zone.</returns>
        ''' <remarks>This is a <see cref="Enums.PvpZoneStatus" /> enumeration that represents the status of the zone.</remarks>
        Public Property Status As PvpZoneStatus

        ''' <summary>
        ''' The date and time of the next battle for the zone.
        ''' </summary>
        ''' <value>This property gets or sets the Next field.</value>
        ''' <returns>Returns the date and time of the next battle for the zone.</returns>
        ''' <remarks>This represents the date and time of the next battle for the zone.</remarks>
        Public Property [Next] As Date

        Friend Sub New(intArea As Integer, fControllingFaction As Faction, pzsStatus As PvpZoneStatus, dtNext As Date)
            Area = intArea
            ControllingFaction = fControllingFaction
            Status = pzsStatus
            [Next] = dtNext
        End Sub

    End Class

End Namespace
