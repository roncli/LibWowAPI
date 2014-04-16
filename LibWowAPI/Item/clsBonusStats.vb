' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about bonus stats.
    ''' </summary>
    ''' <remarks>This class contains the bonus stats that exist on an item.</remarks>
    Public Class BonusStats

        ''' <summary>
        ''' The stat the bonus is for.
        ''' </summary>
        ''' <value>This property gets or sets the Stat field.</value>
        ''' <returns>Returns the stat the bonus is for.</returns>
        ''' <remarks>This is a <see cref="Enums.Stat" /> enumeration that describes the stat that is on this item.</remarks>
        Public Property Stat As Stat

        ''' <summary>
        ''' The amount the combat stat is increased by.
        ''' </summary>
        ''' <value>This property gets or sets the Amount field.</value>
        ''' <returns>Returns the amount the combat stat is increased by.</returns>
        ''' <remarks>This represents the amount the specified <see cref="BonusStats.Stat" /> is increased by.</remarks>
        Public Property Amount As Integer

        Friend Sub New(sStat As Stat, intAmount As Integer)
            Stat = sStat
            Amount = intAmount
        End Sub

    End Class

End Namespace
