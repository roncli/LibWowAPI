' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's PvP stats.
    ''' </summary>
    ''' <remarks>PvP statistics are stored for each character's arena matches and rated battlegrounds.</remarks>
    Public Class PvP

        ''' <summary>
        ''' The character's PvP statistics broken down by bracket.
        ''' </summary>
        ''' <value>This property gets or sets the Brakcets field.</value>
        ''' <returns>Returns the character's PvP statistics broken down by bracket.</returns>
        ''' <remarks>This represents the character's PvP statistics broken down by bracket.</remarks>
        Public Property Brackets As Brackets

        Friend Sub New(bBrackets As Brackets)
            Brackets = bBrackets
        End Sub

    End Class

End Namespace
