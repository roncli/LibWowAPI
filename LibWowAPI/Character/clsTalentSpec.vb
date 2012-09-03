' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's or combat pet's talent build.
    ''' </summary>
    ''' <remarks>This class represents a single talent spec.  You can determine if it is the currently selected talent spec by checking the <see cref="TalentSpec.Selected" /> property.</remarks>
    Public Class TalentSpec

        ''' <summary>
        ''' Indicates whether this is the currently selected talent spec.
        ''' </summary>
        ''' <value>This property gets or sets the Selected field.</value>
        ''' <returns>Returns a boolean that indicates whether this is the currently selected talent spec.</returns>
        ''' <remarks>There may only be one active talent spec.  If this property is true, this is the selected spec.</remarks>
        Public Property Selected As Boolean

        Private colTalents As Collection(Of Talent)
        ''' <summary>
        ''' The selected talents.
        ''' </summary>
        ''' <value>This property gets the Talents field.</value>
        ''' <returns>Returns the selected talents.</returns>
        ''' <remarks>Each character can have up to 6 talents selected.  The <see cref="Talent" /> class contains information about each selected talent.</remarks>
        Public ReadOnly Property Talents As Collection(Of Talent)
            Get
                Return colTalents
            End Get
        End Property

        ''' <summary>
        ''' The equipped glyphs.
        ''' </summary>
        ''' <value>This property gets the Glyphs field.</value>
        ''' <returns>Returns the equipped glyphs.</returns>
        ''' <remarks>Each character can have up to 9 glyphs equipped.  The <see cref="Glyphs" /> class divides them into the Major and Minor sets.</remarks>
        Public Property Glyphs As Glyphs

        ''' <summary>
        ''' Information about the talent spec.
        ''' </summary>
        ''' <value>This property gets or sets the Spec field.</value>
        ''' <returns>Returns information about the talent spec.</returns>
        ''' <remarks>This is a <see cref="Spec" /> object which represents information about the talent spec.</remarks>
        Public Property Spec As Spec

        ''' <summary>
        ''' The string that identifies the selected talents in the official talent calculator.
        ''' </summary>
        ''' <value>This property gets or sets the CalcTalent field.</value>
        ''' <returns>Returns the string that identifies the selected talents in the official talent calculator.</returns>
        ''' <remarks>This is the second field of the parameter for the talent calculator.</remarks>
        Public Property CalcTalent As String

        ''' <summary>
        ''' The string that identifies the spec in the official talent calculator.
        ''' </summary>
        ''' <value>This property gets or sets the CalcSpec field.</value>
        ''' <returns>Returns the string that identifies the spec in the official talent calculator.</returns>
        ''' <remarks>This is the second character in the first field of the parameter for the talent calculator.</remarks>
        Public Property CalcSpec As String

        ''' <summary>
        ''' The string that identifies the equipped glyphs in the official talent calculator.
        ''' </summary>
        ''' <value>This property gets or sets the CalcGlyph field.</value>
        ''' <returns>Returns the string that identifies the equipped glyphs in the official talent calculator.</returns>
        ''' <remarks>This is the third field of the parameter for the talent calculator.</remarks>
        Public Property CalcGlyph As String

        Friend Sub New(blnSelected As Boolean, tTalents As Collection(Of Talent), gGlyphs As Glyphs, sSpec As Spec, strCalcTalent As String, strCalcSpec As String, strCalcGlyph As String)
            Selected = blnSelected
            colTalents = tTalents
            Glyphs = gGlyphs
            Spec = sSpec
            CalcTalent = strCalcTalent
            CalcSpec = strCalcSpec
            CalcGlyph = strCalcGlyph
        End Sub

    End Class

End Namespace
