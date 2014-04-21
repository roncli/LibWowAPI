' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about an item's upgrades.
    ''' </summary>
    ''' <remarks>This class has information about an equipped item's upgrades.</remarks>
    Public Class Upgrade

        ''' <summary>
        ''' The current number of upgrades on the item.
        ''' </summary>
        ''' <value>This property gets or sets the Current field.</value>
        ''' <returns>Returns the current number of upgrades on the item.</returns>
        ''' <remarks>This represents the current number of upgrades on the item.</remarks>
        Public Property Current As Integer

        ''' <summary>
        ''' The total number of upgrades possible on the item.
        ''' </summary>
        ''' <value>This property gets or sets the Total field.</value>
        ''' <returns>Returns the total number of upgrades possible on the item.</returns>
        ''' <remarks>This represents the total number of upgrades possible on the item.</remarks>
        Public Property Total As Integer

        ''' <summary>
        ''' The number of item levels upgraded on the item.
        ''' </summary>
        ''' <value>This property gets or sets the ItemLevelIncrement field.</value>
        ''' <returns>Returns the number of item levels upgraded on the item.</returns>
        ''' <remarks>This represents the number of item levels upgraded on the item.</remarks>
        Public Property ItemLevelIncrement As Integer

        Public Sub New(intCurrent As Integer, intTotal As Integer, intItemLevelIncrement As Integer)
            Current = intCurrent
            Total = intTotal
            ItemLevelIncrement = intItemLevelIncrement
        End Sub

    End Class

End Namespace
