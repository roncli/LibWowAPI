' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Data.Talents

    ''' <summary>
    ''' A class containing the talents that are in a specific talent slot.
    ''' </summary>
    ''' <remarks>Each slot of a talent can have one or more talents in the slot depending on the class of the player.  This class exposes each <see cref="Talent" /> available in the slot.</remarks>
    Public Class TalentSlot

        ''' <summary>
        ''' The column the talents are on.
        ''' </summary>
        ''' <value>This property gets or sets the Column field.</value>
        ''' <returns>Returns the column the talents are on.</returns>
        ''' <remarks>This represents the column the talents are on.</remarks>
        Public Property Column As Integer

        Private colTalents As Collection(Of Talent)
        ''' <summary>
        ''' The possible talents for this talent slot.
        ''' </summary>
        ''' <value>This property gets the Talents field.</value>
        ''' <returns>Returns the possible talents for this talent slot.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Talent)" /> of <see cref="Talent" /> objects that represent the possible talents for this talent slot.</remarks>
        Public ReadOnly Property Talents As Collection(Of Talent)
            Get
                Return colTalents
            End Get
        End Property

        Friend Sub New(intColumn As Integer, tTalents As Collection(Of Talent))
            Column = intColumn
            colTalents = tTalents
        End Sub

    End Class

End Namespace
