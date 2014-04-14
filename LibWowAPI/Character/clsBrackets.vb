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
    Public Class Brackets

        ''' <summary>
        ''' The character's 2v2 arena stats.
        ''' </summary>
        ''' <value>This property gets or sets the ArenaBracket2v2 field.</value>
        ''' <returns>Returns the character's 2v2 arena stats.</returns>
        ''' <remarks>This is an <see cref="ArenaBracket" /> object that represents the character's 2v2 arena stats.</remarks>
        Public Property ArenaBracket2v2 As ArenaBracket

        ''' <summary>
        ''' The character's 3v3 arena stats.
        ''' </summary>
        ''' <value>This property gets or sets the ArenaBracket3v3 field.</value>
        ''' <returns>Returns the character's 3v3 arena stats.</returns>
        ''' <remarks>This is an <see cref="ArenaBracket" /> object that represents the character's 3v3 arena stats.</remarks>
        Public Property ArenaBracket3v3 As ArenaBracket

        ''' <summary>
        ''' The character's 5v5 arena stats.
        ''' </summary>
        ''' <value>This property gets or sets the ArenaBracket5v5 field.</value>
        ''' <returns>Returns the character's 5v5 arena stats.</returns>
        ''' <remarks>This is an <see cref="ArenaBracket" /> object that represents the character's 5v5 arena stats.</remarks>
        Public Property ArenaBracket5v5 As ArenaBracket

        ''' <summary>
        ''' The character's rated battleground stats.
        ''' </summary>
        ''' <value>This property gets or sets the ArenaBracketRBG field.</value>
        ''' <returns>Returns the character's rated battleground stats.</returns>
        ''' <remarks>This is an <see cref="ArenaBracket" /> object that represents the character's rated battleground stats.</remarks>
        Public Property ArenaBracketRBG As ArenaBracket

        Friend Sub New(abArenaBracket2v2 As ArenaBracket, abArenaBracket3v3 As ArenaBracket, abArenaBracket5v5 As ArenaBracket, abArenaBracketRBG As ArenaBracket)
            ArenaBracket2v2 = abArenaBracket2v2
            ArenaBracket3v3 = abArenaBracket3v3
            ArenaBracket5v5 = abArenaBracket5v5
            ArenaBracketRBG = abArenaBracketRBG
        End Sub

    End Class

End Namespace
