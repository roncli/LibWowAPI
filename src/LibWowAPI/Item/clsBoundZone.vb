' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about a zone an item is bound to.
    ''' </summary>
    ''' <remarks>This provides basic information about the zone an item is bound to.</remarks>
    Public Class BoundZone

        ''' <summary>
        ''' The ID number of the zone.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the zone.</returns>
        ''' <remarks>Each zone has a unique ID number that identifies the zone.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The name of the zone.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the zone.</returns>
        ''' <remarks>This is the localized name of the zone.</remarks>
        Public Property Name As String

        Friend Sub New(intID As Integer, strName As String)
            ID = intID
            Name = strName
        End Sub

    End Class

End Namespace
