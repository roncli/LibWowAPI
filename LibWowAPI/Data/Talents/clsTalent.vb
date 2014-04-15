' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Data.Talents

    ''' <summary>
    ''' A class containing information about a talent.
    ''' </summary>
    ''' <remarks>This class contains details of a talent.</remarks>
    Public Class Talent

        ''' <summary>
        ''' The tier the talent is in.
        ''' </summary>
        ''' <value>This property gets or sets the Tier field.</value>
        ''' <returns>Returns the tier the talent is in.</returns>
        ''' <remarks>This represents the tier the talent is in.</remarks>
        Public Property Tier As Integer

        ''' <summary>
        ''' The column the talent is in.
        ''' </summary>
        ''' <value>This property gets or sets the Column field.</value>
        ''' <returns>Returns the column the talent is in.</returns>
        ''' <remarks>This represents the column the talent is in.</remarks>
        Public Property Column As Integer

        ''' <summary>
        ''' The talent's spell.
        ''' </summary>
        ''' <value>This property gets or sets the Spell field.</value>
        ''' <returns>Returns the talent's spell.</returns>
        ''' <remarks>This is a <see cref="Spell" /> object representing the talent's spell.</remarks>
        Public Property Spell As Spell

        Friend Sub New(intTier As Integer, intColumn As Integer, sSpell As Spell)
            Tier = intTier
            Column = intColumn
            Spell = sSpell
        End Sub

    End Class

End Namespace
