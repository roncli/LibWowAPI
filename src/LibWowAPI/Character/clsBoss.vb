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
        ''' The number of kills on heroic mode.
        ''' </summary>
        ''' <value>This property gets or sets the HeroicKills field.</value>
        ''' <returns>Returns the number of kills on heroic mode.</returns>
        ''' <remarks>For Onyxia and bosses in raids from patch 3.2 and on, this will list all heroic mode kills regardless of the size of the raid.  Ulduar and Obsidian Sanctum hard modes are not included.</remarks>
        Public Property HeroicKills As Integer

        ''' <summary>
        ''' The ID number of the encounter.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the encounter.</returns>
        ''' <remarks>If the encounter is listed as a boss, this is the NPC ID number.  Otherwise, this is likely a Spell ID number, which has no translation yet.</remarks>
        Public Property ID As Integer

        Friend Sub New(strName As String, intNormalKills As Integer, intHeroicKills As Integer, intID As Integer)
            Name = strName
            NormalKills = intNormalKills
            HeroicKills = intHeroicKills
            ID = intID
        End Sub

    End Class

End Namespace
