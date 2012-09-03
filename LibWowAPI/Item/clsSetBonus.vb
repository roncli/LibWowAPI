' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about a set bonus.
    ''' </summary>
    ''' <remarks>This class contains detailed information about an item's set bonus.</remarks>
    Public Class SetBonus

        ''' <summary>
        ''' The description of what the set bonus does.
        ''' </summary>
        ''' <value>This property gets or sets the Description field.</value>
        ''' <returns>Returns the description of what the set bonus does.</returns>
        ''' <remarks>This is the localized description of what the set bonus does.</remarks>
        Public Property Description As String

        ''' <summary>
        ''' The minimum number of items required in the set to trigger the bonus.
        ''' </summary>
        ''' <value>This property gets or sets the Threshold field.</value>
        ''' <returns>Returns the minimum number of items required in the set to trigger the bonus.</returns>
        ''' <remarks>This represents the minimum number of items required in the set to trigger the bonus.</remarks>
        Public Property Threshold As Integer

        Friend Sub New(strDescription As String, intThreshold As Integer)
            Description = strDescription
            Threshold = intThreshold
        End Sub

    End Class

End Namespace
