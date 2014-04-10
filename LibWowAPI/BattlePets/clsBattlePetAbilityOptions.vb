' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.BattlePets

    ''' <summary>
    ''' A class that defines options for the battle pet ability lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the ability ID to look up a battle pet ability. There is no need to create an instance of this class, as the <see cref="BattlePetAbility.Options" /> property automatically does so for you.</remarks>
    Public Class BattlePetAbilityOptions

        ''' <summary>
        ''' The ability ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the AbilityID field.</value>
        ''' <returns>Returns the ability ID to lookup.</returns>
        ''' <remarks>This represents the ability ID to lookup.</remarks>
        Public Property AbilityID As Integer

        Friend Sub New()
        End Sub

    End Class

End Namespace
