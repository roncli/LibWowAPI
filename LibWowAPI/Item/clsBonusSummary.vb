' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing a summary about item bonuses.
    ''' </summary>
    ''' <remarks>This class provides a summary about item bonuses.</remarks>
    Public Class BonusSummary

        Private Property colDefaultBonuses As Collection(Of Integer)
        ''' <summary>
        ''' A list of bonus IDs that all items with this Item ID have.
        ''' </summary>
        ''' <value>This gets the DefaultBonuses field.</value>
        ''' <returns>Returns a list of bonus IDs that all items with this Item ID have.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Integer)" /> that represents a list of bonus IDs that all items with this Item ID have.  While not required, you should include all bonus IDs in this list when adding bonus IDs to the <see cref="ItemLookupOptions.Bonuses" /> property of <see cref="ItemLookup.Options" />.</remarks>
        Public ReadOnly Property DefaultBonuses As Collection(Of Integer)
            Get
                Return colDefaultBonuses
            End Get
        End Property

        Private Property colChanceBonuses As Collection(Of Integer)
        ''' <summary>
        ''' A list of bonus IDs that items with this Item ID have a chance to include.
        ''' </summary>
        ''' <value>This gets the ChanceBonuses field.</value>
        ''' <returns>Returns a list of bonus IDs that items with this Item ID have a chance to include.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Integer)" /> that represents a list of bonus IDs that items with this Item ID have a chance to include.  You may optionally add one or more of these bonus IDs in this list when adding bonus IDs to the <see cref="ItemLookupOptions.Bonuses" /> property of <see cref="ItemLookup.Options" />.</remarks>
        Public ReadOnly Property ChanceBonuses As Collection(Of Integer)
            Get
                Return colChanceBonuses
            End Get
        End Property

        Private Property colBonusChances As Collection(Of BonusChance)
        ''' <summary>
        ''' A list of possible item enhancements for this Item ID.
        ''' </summary>
        ''' <value>This gets the BonusChances field.</value>
        ''' <returns>Returns a list of possible item enhancements for this Item ID.</returns>
        ''' <remarks>This is a <see cref="Collection(Of BonusChance)" /> of <see cref="BonusChance" /> objects that represent a list of possible item enhancements for this Item ID.</remarks>
        Public ReadOnly Property BonusChances As Collection(Of BonusChance)
            Get
                Return colBonusChances
            End Get
        End Property

        Friend Sub New(intDefaultBonuses As Collection(Of Integer), intChanceBonuses As Collection(Of Integer), bcBonusChances As Collection(Of BonusChance))
            colDefaultBonuses = intDefaultBonuses
            colChanceBonuses = intChanceBonuses
            colBonusChances = bcBonusChances
        End Sub

    End Class

End Namespace
