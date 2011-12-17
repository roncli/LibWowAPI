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

        Friend Sub New(bBonus As Bonus, strType As String)
            Bonus = bBonus
            Type = strType
        End Sub

    End Class

End Namespace
