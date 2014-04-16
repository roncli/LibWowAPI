' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about a gem.
    ''' </summary>
    ''' <remarks>This class gives information about a socketable gem.</remarks>
    Public Class GemInfo

        ''' <summary>
        ''' The gem's bonus stats.
        ''' </summary>
        ''' <value>This property gets or sets the Bonus field.</value>
        ''' <returns>Returns the gem's bonus stats.</returns>
        ''' <remarks>This is a <see cref="LibWowAPI.Item.Bonus" /> class that describes a gem's bonus properties.</remarks>
        Public Property Bonus As Bonus

        ''' <summary>
        ''' The type of the gem.
        ''' </summary>
        ''' <value>This property gets or sets the Type field.</value>
        ''' <returns>Returns the type of the gem.</returns>
        ''' <remarks>This describes the type of gem.  It can be a color, a meta gem, a prismatic gem, or an engineering gem type.</remarks>
        Public Property Type As String

        ''' <summary>
        ''' The minimum item level required for an item to use this gem.
        ''' </summary>
        ''' <value>This property gets or sets the MinItemLevel field.</value>
        ''' <returns>Returns the minimum item level required for an item to use this gem.</returns>
        ''' <remarks>This represents the minimum item level required for an item to use this gem.</remarks>
        Public Property MinItemLevel As Integer

        Friend Sub New(bBonus As Bonus, strType As String, intMinItemLevel As Integer)
            Bonus = bBonus
            Type = strType
            MinItemLevel = intMinItemLevel
        End Sub

    End Class

End Namespace
