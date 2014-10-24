' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Data.Talents

    ''' <summary>
    ''' A class containing the talents that are in a specific talent tier.
    ''' </summary>
    ''' <remarks>Each tier of a talent tree has 3 talents.  This class exposes the tier as well as each <see cref="Talent" /> available in the tier.</remarks>
    Public Class TalentTier

        ''' <summary>
        ''' The tier the talents are on.
        ''' </summary>
        ''' <value>This property gets or sets the Tier field.</value>
        ''' <returns>Returns the tier the talents are on.</returns>
        ''' <remarks>This represents the tier the talents are on.</remarks>
        Public Property Tier As Integer

        Private colTalents As Collection(Of Talent)
        ''' <summary>
        ''' The possible talents for this class.
        ''' </summary>
        ''' <value>This property gets the Talents field.</value>
        ''' <returns>Returns the possible talents for this class.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Talent)" /> of <see cref="Talent" /> objects that represent the possible talents for this class.</remarks>
        Public ReadOnly Property Talents As Collection(Of Talent)
            Get
                Return colTalents
            End Get
        End Property

        Friend Sub New(intTier As Integer, tTalents As Collection(Of Talent))
            Tier = intTier
            colTalents = tTalents
        End Sub

    End Class

End Namespace
