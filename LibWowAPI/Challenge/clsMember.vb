' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Character
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Data.Talents

Namespace roncliProductions.LibWowAPI.Challenge

    ''' <summary>
    ''' A class containing information about a challenge mode group's member.
    ''' </summary>
    ''' <remarks>This class contains information about a challenge mode group's member.</remarks>
    Public Class Member

        ''' <summary>
        ''' Information about the character.
        ''' </summary>
        ''' <value>This property gets or sets the Character field.</value>
        ''' <returns>Returns information about the character.</returns>
        ''' <remarks>This is a <see cref="CharacterBasicInfo" /> object that contains further information about the guild member.</remarks>
        Public Property Character As CharacterBasicInfo

        ''' <summary>
        ''' The member's spec at the time of the run.
        ''' </summary>
        ''' <value>This property gets or sets the Spec field.</value>
        ''' <returns>Returns the member's spec at the time of the run.</returns>
        ''' <remarks>This represents the member's spec at the time of the run.</remarks>
        Public Property Spec As Spec

        Friend Sub New(cbiCharacter As CharacterBasicInfo, sSpec As Spec)
            Character = cbiCharacter
            sSpec = sSpec
        End Sub

    End Class

End Namespace
