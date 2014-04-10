' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.BattlePet

    ''' <summary>
    ''' A class that defines options for the battle pet species lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the species ID to look up a battle pet species. There is no need to create an instance of this class, as the <see cref="BattlePetSpecies.Options" /> property automatically does so for you.</remarks>
    Public Class BattlePetSpeciesOptions

        ''' <summary>
        ''' The species ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the SpeciesID field.</value>
        ''' <returns>Returns the species ID to lookup.</returns>
        ''' <remarks>This represents the species ID to lookup.</remarks>
        Public Property SpeciesID As Integer

        Friend Sub New()
        End Sub

    End Class

End Namespace
