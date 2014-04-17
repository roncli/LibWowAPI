' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's experience in killing a boss.
    ''' </summary>
    ''' <remarks>Statistics about a player's experience with a boss is kept and can be accessed through this class.</remarks>
    Public Class Boss

        ''' <summary>
        ''' The ID number of the encounter.
        ''' </summary>
        ''' <value>This property gets or sets the EncounterID field.</value>
        ''' <returns>Returns the ID number of the encounter.</returns>
        ''' <remarks>If the encounter is listed as a boss, this is the NPC ID number.  Otherwise, this is likely a Spell ID number, which has no translation yet.</remarks>
        Public Property EncounterID As Integer

        ''' <summary>
        ''' The name of the boss.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the boss.</returns>
        ''' <remarks>This field identifies which boss the statistics are for.  For council fights, only one of the bosses are listed here.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The number of kills on normal mode.
        ''' </summary>
        ''' <value>This property gets or sets the NormalKills field.</value>
        ''' <returns>Returns the number of kills on normal mode.</returns>
        ''' <remarks>For Onyxia's Lair and for bosses in raids prior to patch 3.2, this will list all of the kills regardless of the size of the raid and, in the case of Ulduar and Obsidian Sanctum, whether the hard modes were activated.  The API sometimes bugs out and reports -1.</remarks>
        Public Property NormalKills As Integer

        ''' <summary>
        ''' The date of the most recent normal kill.
        ''' </summary>
        ''' <value>This property gets or sets the NormalTimestamp field.</value>
        ''' <returns>Returns the date of the most recent normal kill.</returns>
        ''' <remarks>This represents the date of the most recent normal kill.</remarks>
        Public Property NormalTimestamp As Date

        ''' <summary>
        ''' The number of kills on heroic mode.
        ''' </summary>
        ''' <value>This property gets or sets the HeroicKills field.</value>
        ''' <returns>Returns the number of kills on heroic mode.</returns>
        ''' <remarks>For Onyxia and bosses in raids from patch 3.2 and on, this will list all heroic mode kills regardless of the size of the raid.  Ulduar and Obsidian Sanctum hard modes are not included.</remarks>
        Public Property HeroicKills As Integer

        ''' <summary>
        ''' The date of the most recent heroic kill.
        ''' </summary>
        ''' <value>This property gets or sets the HeroicTimestamp field.</value>
        ''' <returns>Returns the date of the most recent heroic kill.</returns>
        ''' <remarks>This represents the date of the most recent heroic kill.</remarks>
        Public Property HeroicTimestamp As Date

        ''' <summary>
        ''' The number of kills on LFR mode.
        ''' </summary>
        ''' <value>This property gets or sets the LFRKills field.</value>
        ''' <returns>Returns the number of kills on LFR mode.</returns>
        ''' <remarks>This represents the date of the most recent LFR kill.</remarks>
        Public Property LFRKills As Integer

        ''' <summary>
        ''' The date of the most recent LFR kill.
        ''' </summary>
        ''' <value>This property gets or sets the LFRTimestamp field.</value>
        ''' <returns>Returns the date of the most recent LFR kill.</returns>
        ''' <remarks>This represents the date of the most recent LFR kill.</remarks>
        Public Property LFRTimestamp As Date

        ''' <summary>
        ''' The number of kills on flex mode.
        ''' </summary>
        ''' <value>This property gets or sets the FlexKills field.</value>
        ''' <returns>Returns the number of kills on flex mode.</returns>
        ''' <remarks>This represents the date of the most recent flex kill.</remarks>
        Public Property FlexKills As Integer

        ''' <summary>
        ''' The date of the most recent flex kill.
        ''' </summary>
        ''' <value>This property gets or sets the FlexTimestamp field.</value>
        ''' <returns>Returns the date of the most recent flex kill.</returns>
        ''' <remarks>This represents the date of the most recent flex kill.</remarks>
        Public Property FlexTimestamp As Date

        Friend Sub New(intEncounterID As Integer, strName As String, intNormalKills As Integer, dtNormalTimestamp As Date, intHeroicKills As Integer, dtHeroicTimestamp As Date, intLFRKills As Integer, dtLFRTimestamp As Date, intFlexKills As Integer, dtFlexTimestamp As Date)
            EncounterID = intEncounterID
            Name = strName
            NormalKills = intNormalKills
            NormalTimestamp = dtNormalTimestamp
            HeroicKills = intHeroicKills
            HeroicTimestamp = dtHeroicTimestamp
            LFRKills = intLFRKills
            LFRTimestamp = dtLFRTimestamp
            FlexKills = intFlexKills
            FlexTimestamp = dtFlexTimestamp
        End Sub

    End Class

End Namespace
