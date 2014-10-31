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

        Private colTalentSlots As Collection(Of TalentSlot)
        ''' <summary>
        ''' The possible talent slots for this class.
        ''' </summary>
        ''' <value>This property gets the TalentSlots field.</value>
        ''' <returns>Returns the possible talent slots for this class.</returns>
        ''' <remarks>This is a <see cref="Collection(Of TalentSlot)" /> of <see cref="TalentSlot" /> objects that represent the possible talent slots for this class.</remarks>
        Public ReadOnly Property TalentSlots As Collection(Of TalentSlot)
            Get
                Return colTalentSlots
            End Get
        End Property

        Friend Sub New(intTier As Integer, tsTalentSlots As Collection(Of TalentSlot))
            Tier = intTier
            colTalentSlots = tsTalentSlots
        End Sub

    End Class

End Namespace
