' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Data.Battlegroups

    ''' <summary>
    ''' A class containing information about a battlegroup.
    ''' </summary>
    ''' <remarks>This contains basic information about a battlegroup.</remarks>
    Public Class Battlegroup

        ''' <summary>
        ''' The name of the battlegroup.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the battlegroup.</returns>
        ''' <remarks>This returns the name of the battlegroup.  This field cannot be localized.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Blizzard's internal name for the battlegroup.
        ''' </summary>
        ''' <value>This property gets or sets the Slug field.</value>
        ''' <returns>Returns Blizzard's internal name for the battlegroup.</returns>
        ''' <remarks>Blizzard has an internal name for each battlegroup that does not include capital letters or spaces. The Slug can be used in place of the <see cref="Battlegroup.Name" /> in most API operations.</remarks>
        Public Property Slug As String

        Friend Sub New(strName As String, strSlug As String)
            Name = strName
            Slug = strSlug
        End Sub

    End Class

End Namespace
