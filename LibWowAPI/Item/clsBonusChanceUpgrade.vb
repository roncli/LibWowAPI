' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about the upgrade for an item bonus.
    ''' </summary>
    ''' <remarks>This class gives information about the upgrade for an item bonus.</remarks>
    Public Class BonusChanceUpgrade

        ''' <summary>
        ''' The internal name for the upgrade type.
        ''' </summary>
        ''' <value>This property gets or sets the UpgradeType field.</value>
        ''' <returns>Returns the internal name for the upgrade type.</returns>
        ''' <remarks>This represents the internal name for the upgrade type.</remarks>
        Public Property UpgradeType As String

        ''' <summary>
        ''' The name of the upgrade.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the upgrade.</returns>
        ''' <remarks>This represents the name of the upgrade.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The ID number of the upgrade.
        ''' </summary>
        ''' <value>This property gets or sets the UpgradeID field.</value>
        ''' <returns>Returns the ID number of the upgrade.</returns>
        ''' <remarks>This represents the ID number of the upgrade.</remarks>
        Public Property UpgradeID As Integer

        Friend Sub New(strUpgradeType As String, strName As String, intUpgradeID As Integer)
            UpgradeType = strUpgradeType
            Name = strName
            UpgradeID = intUpgradeID
        End Sub

    End Class

End Namespace
