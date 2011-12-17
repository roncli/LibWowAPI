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

        ''' <summary>
        ''' Whether or not this stat was reforged.
        ''' </summary>
        ''' <value>This property gets or sets the Reforged field.</value>
        ''' <returns>Returns a boolean indicating whether ot not this stat was reforged.</returns>
        ''' <remarks>This field is always false when looking up an item, because items do not come pre-reforged.</remarks>
        Public Property Reforged As Boolean

        Friend Sub New(sStat As Stat, intAmount As Integer, blnReforged As Boolean)
            Stat = sStat
            Amount = intAmount
            Reforged = blnReforged
        End Sub

    End Class

End Namespace
