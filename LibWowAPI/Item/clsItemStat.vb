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
    Public Class ItemStat

        ''' <summary>
        ''' The type of stat.
        ''' </summary>
        ''' <value>This property gets or sets the Stat field.</value>
        ''' <returns>Returns the type of stat.</returns>
        ''' <remarks>This is a <see cref="ItemStatType" /> enumeration that represents the type of stat.</remarks>
        Public Property Stat As ItemStatType

        ''' <summary>
        ''' The original amount of the stat, or the reforged amount if the item was reforged.
        ''' </summary>
        ''' <value>This property gets or sets the Amount field.</value>
        ''' <returns>Returns the original amount of the stat, or the reforged amount if the item was reforged.</returns>
        ''' <remarks>This represents the original amount of the stat, or the reforged amount if the item was reforged.</remarks>
        Public Property Amount As Integer

        Friend Sub New(istStat As ItemStatType, intAmount As Integer)
            Stat = istStat
            Amount = intAmount
        End Sub

    End Class

End Namespace
