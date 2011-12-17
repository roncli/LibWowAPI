' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a single talent tree.
    ''' </summary>
    ''' <remarks>This contains basic information about a single talent tree.</remarks>
    Public Class Tree

        ''' <summary>
        ''' A string representing the talent tree's build.
        ''' </summary>
        ''' <value>This property gets or sets the Points field.</value>
        ''' <returns>Returns a string representing the talent tree's build.</returns>
        ''' <remarks>This is simply a substring of <see cref="Talent.Build" />, containing only information for this talent tree.</remarks>
        Public Property Points As String

        ''' <summary>
        ''' The total number of points allocated to this talent tree.
        ''' </summary>
        ''' <value>This property gets or sets the Total field.</value>
        ''' <returns>Returns the total number of points allocated to this talent tree.</returns>
        ''' <remarks>This represents the total number of points allocated to this talent tree.</remarks>
        Public Property Total As Integer

        Friend Sub New(strPoints As String, intTotal As Integer)
            Points = strPoints
            Total = intTotal
        End Sub

    End Class

End Namespace
