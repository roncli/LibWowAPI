' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Data.GuildPerks

    ''' <summary>
    ''' A class containing information about a guild perk.
    ''' </summary>
    ''' <remarks>This class contains the <see cref="Perk.Spell" /> and the <see cref="Perk.GuildLevel" /> you get the spell at.</remarks>
    Public Class Perk

        ''' <summary>
        ''' The guild level required to earn this perk.
        ''' </summary>
        ''' <value>This property gets or sets the GuildLevel field.</value>
        ''' <returns>Returns the guild level required to earn this perk.</returns>
        ''' <remarks>This represents the guild level required to earn this perk.</remarks>
        Public Property GuildLevel As Integer

        ''' <summary>
        ''' The spell associated with this guild perk.
        ''' </summary>
        ''' <value>This property gets or sets the Spell field.</value>
        ''' <returns>Returns the spell associated with this guild perk.</returns>
        ''' <remarks>This is a <see cref="Data.GuildPerks.Spell" /> object that retrieves the guild perk.</remarks>
        Public Property Spell As Spell

        Friend Sub New(intGuildLevel As Integer, sSpell As Spell)
            GuildLevel = intGuildLevel
            Spell = sSpell
        End Sub

    End Class

End Namespace
