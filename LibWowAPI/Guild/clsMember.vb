' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Character

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a guild member.
    ''' </summary>
    ''' <remarks>This class contains basic information about a guild member.</remarks>
    Public Class Member

        ''' <summary>
        ''' Information about the character.
        ''' </summary>
        ''' <value>This property gets or sets the Character field.</value>
        ''' <returns>Returns information about the character.</returns>
        ''' <remarks>This is a <see cref="CharacterBasicInfo" /> object that contains further information about the guild member.</remarks>
        Public Property Character As CharacterBasicInfo

        ''' <summary>
        ''' The member's guild rank.
        ''' </summary>
        ''' <value>This property gets or sets the Rank field.</value>
        ''' <returns>Returns the member's guild rank.</returns>
        ''' <remarks>This is an integer that represents the guild rank.  There is currently no way to translate this number into the guild rank name.</remarks>
        Public Property Rank As Integer

        Friend Sub New(cbiCharacter As CharacterBasicInfo, intRank As Integer)
            Character = cbiCharacter
            Rank = intRank
        End Sub

    End Class

End Namespace
