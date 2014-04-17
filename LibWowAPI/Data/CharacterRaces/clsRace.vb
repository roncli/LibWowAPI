' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Data.CharacterRaces

    ''' <summary>
    ''' A class containing information about a character race.
    ''' </summary>
    ''' <remarks>This class provides detailed information about a character race.</remarks>
    Public Class Race

        ''' <summary>
        ''' The race ID number.
        ''' </summary>
        ''' <value>This property gets or sets the RaceID field.</value>
        ''' <returns>Returns the race ID number.</returns>
        ''' <remarks>Each race has a unique ID number that represents the race.</remarks>
        Public Property RaceID As Integer

        ''' <summary>
        ''' The value of the mask.  Used for flags.
        ''' </summary>
        ''' <value>This property gets or sets the Mask field.</value>
        ''' <returns>Returns the value of the mask.  Used for flags.</returns>
        ''' <remarks>This seems to always be 2 ^ (<see cref="Race.RaceID" /> - 1).  Given that so far every API that has a collection of races returns an array of integers, it is unclear what this property is actually used for.</remarks>
        Public Property Mask As Integer

        ''' <summary>
        ''' The faction the race belongs to, Alliance or Horde.
        ''' </summary>
        ''' <value>This property gets or sets the Faction field.</value>
        ''' <returns>Returns the faction the race belongs to, Alliance or Horde.</returns>
        ''' <remarks>This is a <see cref="Enums.Faction" /> enumeration that tells which faction the race belongs to, Alliance or Horde.</remarks>
        Public Property Faction As Faction

        ''' <summary>
        ''' The name of the race.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the race.</returns>
        ''' <remarks>This is the localized name of the race.</remarks>
        Public Property Name As String

        Friend Sub New(intRaceID As Integer, intMask As Integer, fFaction As Faction, strName As String)
            RaceID = intRaceID
            Mask = intMask
            Faction = fFaction
            Name = strName
        End Sub

    End Class

End Namespace
