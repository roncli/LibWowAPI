' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.BattlePet

    ''' <summary>
    ''' A class that defines options for the battle pet stats lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define several properties to look up a battle pet's stats. There is no need to create an instance of this class, as the <see cref="BattlePetStatsLookup.Options" /> property automatically does so for you.</remarks>
    Public Class BattlePetStatsLookupOptions

        ''' <summary>
        ''' The species ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the SpeciesID field.</value>
        ''' <returns>Returns the species ID to lookup.</returns>
        ''' <remarks>This represents the species ID to lookup.</remarks>
        Public Property SpeciesID As Integer

        ''' <summary>
        ''' The level of the pet to calculate stats for.
        ''' </summary>
        ''' <value>This property gets or sets the Level field.</value>
        ''' <returns>Returns the level of the pet to calculate stats for.</returns>
        ''' <remarks>This represents the level of the pet to calculate stats for.</remarks>
        Public Property Level As Integer

        ''' <summary>
        ''' The breed of the pet to calculate stats for.
        ''' </summary>
        ''' <value>This property gets or sets the Breed field.</value>
        ''' <returns>Returns the breed of the pet to calculate stats for.</returns>
        ''' <remarks>This represents the breed of the pet to calculate stats for.</remarks>
        Public Property Breed As BattlePetBreed = BattlePetBreed.Unknown

        ''' <summary>
        ''' The quality of the pet to calculate stats for.
        ''' </summary>
        ''' <value>This property gets or sets the Quality field.</value>
        ''' <returns>Returns the quality of the pet to calculate stats for.</returns>
        ''' <remarks>This represents the quality of the pet to calculate stats for.</remarks>
        Public Property Quality As Quality = Quality.Unknown

        Friend Sub New()
        End Sub

    End Class

End Namespace
