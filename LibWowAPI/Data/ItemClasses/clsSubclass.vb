' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Data.ItemClasses

    ''' <summary>
    ''' A class containing information about an item subclass.
    ''' </summary>
    ''' <remarks>This contains basic information about an item subclass.</remarks>
    Public Class Subclass

        ''' <summary>
        ''' The subclass ID number.
        ''' </summary>
        ''' <value>This property gets or sets the Subclass field.</value>
        ''' <returns>Returns the subclass ID number.</returns>
        ''' <remarks>Each subclass has a unique ID number that identifies it.</remarks>
        Public Property Subclass As Integer

        ''' <summary>
        ''' The name of the item subclass.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the item subclass.</returns>
        ''' <remarks>This is the localized name of the item subclass.</remarks>
        Public Property Name As String

        Friend Sub New(intSubclass As Integer, strName As String)
            Subclass = intSubclass
            Name = strName
        End Sub

    End Class

End Namespace
