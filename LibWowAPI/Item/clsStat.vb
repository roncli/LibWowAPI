' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about an item's stat.
    ''' </summary>
    ''' <remarks>This class has information about an equipped item's stats.</remarks>
    Public Class Stat

        ''' <summary>
        ''' The type of stat.
        ''' </summary>
        ''' <value>This property gets or sets the Stat field.</value>
        ''' <returns>Returns the type of stat.</returns>
        ''' <remarks>This is a <see cref="Enums.Stat" /> enumeration that represents the type of stat.</remarks>
        Public Property Stat As Enums.Stat

        ''' <summary>
        ''' The original amount of the stat, or the reforged amount if the item was reforged.
        ''' </summary>
        ''' <value>This property gets or sets the Amount field.</value>
        ''' <returns>Returns the original amount of the stat, or the reforged amount if the item was reforged.</returns>
        ''' <remarks>This represents the original amount of the stat, or the reforged amount if the item was reforged.</remarks>
        Public Property Amount As Integer

        ''' <summary>
        ''' The amount of the stat that was reforged away.
        ''' </summary>
        ''' <value>This property gets or sets the ReforgedAmount field.</value>
        ''' <returns>Returns the amount of the stat that was reforged away.</returns>
        ''' <remarks>This represents the amount of the stat that was reforged away, or 0 if this item was not reforged.</remarks>
        Public Property ReforgedAmount As Integer

        ''' <summary>
        ''' The total amount of the stat on this item.
        ''' </summary>
        ''' <value>This property gets the TotalAmount field.</value>
        ''' <returns>Returns the total amount of the stat on this item.</returns>
        ''' <remarks>This represents the total amount of the stat on this item.</remarks>
        Public ReadOnly Property TotalAmount As Integer
            Get
                Return Amount + ReforgedAmount
            End Get
        End Property

        ''' <summary>
        ''' Determines whether the item has been reforged.
        ''' </summary>
        ''' <value>This property gets or sets the Reforged field.</value>
        ''' <returns>Returns whether the item has been reforged.</returns>
        ''' <remarks>This represents whether the item has been reforged.</remarks>
        Public Property Reforged As Boolean

        Public Sub New(sStat As Enums.Stat, intAmount As Integer, intReforgedAmount As Integer, blnReforged As Boolean)
            Stat = sStat
            Amount = intAmount
            ReforgedAmount = intReforgedAmount
            Reforged = blnReforged
        End Sub

    End Class

End Namespace
