' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class containing information about a character's battlegroup.
    ''' </summary>
    ''' <remarks>This class contains basic information about a character's battlegroup.</remarks>
    Public Class Battlegroup

        ''' <summary>
        ''' The name of the battlegroup.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the battlegroup.</returns>
        ''' <remarks>This represents the localized name of the battlegroup.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Blizzard's internal name for the battlegroup.
        ''' </summary>
        ''' <value>This property gets or sets the Slug field.</value>
        ''' <returns>Returns Blizzard's internal name for the battlegroup.</returns>
        ''' <remarks>This represents Blizzard's internal name for the battlegroup.</remarks>
        Public Property Slug As String

        Friend Sub New(strName As String, strSlug As String)
            Name = strName
            Slug = strSlug
        End Sub

    End Class

End Namespace
