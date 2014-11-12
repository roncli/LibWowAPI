' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about a stat for an item bonus.
    ''' </summary>
    ''' <remarks>This class gives information about a stat for an item bonus.</remarks>
    Public Class BonusChanceStat

        ''' <summary>
        ''' The type of stat.
        ''' </summary>
        ''' <value>This property gets or sets the Stat field.</value>
        ''' <returns>Return the type of stat.</returns>
        ''' <remarks>This represents the type of stat.</remarks>
        Public Property Stat As ItemStatType

        ''' <summary>
        ''' The amount of change in the stat.
        ''' </summary>
        ''' <value>This property gets or sets the Delta field.</value>
        ''' <returns>Returns the amount of change in the stat.</returns>
        ''' <remarks>This represents the amount of change in the stat.</remarks>
        Public Property Delta As Integer

        Friend Sub New(istStat As ItemStatType, intDelta As Integer)
            Stat = istStat
            Delta = intDelta
        End Sub

    End Class

End Namespace
