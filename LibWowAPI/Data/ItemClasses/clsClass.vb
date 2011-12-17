' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Data.ItemClasses

    ''' <summary>
    ''' A class containing information about an item class.
    ''' </summary>
    ''' <remarks>This contains basic information about an item class.</remarks>
    Public Class [Class]

        ''' <summary>
        ''' The class ID number.
        ''' </summary>
        ''' <value>This property gets or sets the Class field.</value>
        ''' <returns>Returns the class ID number.</returns>
        ''' <remarks>Each class has a unique ID number that identifies it.</remarks>
        Public Property [Class] As Integer

        ''' <summary>
        ''' The name of the item class.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the item class.</returns>
        ''' <remarks>This is the localized name of the item class.</remarks>
        Public Property Name As String

        Friend Sub New(intClass As Integer, strName As String)
            [Class] = intClass
            Name = strName
        End Sub

    End Class

End Namespace
