' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Data.CharacterClasses

    ''' <summary>
    ''' A class containing information about a character class.
    ''' </summary>
    ''' <remarks>This class provides detailed information about a character class.</remarks>
    Public Class CharacterClass

        ''' <summary>
        ''' The class ID number.
        ''' </summary>
        ''' <value>This property gets or sets the ClassID field.</value>
        ''' <returns>Returns the class ID number.</returns>
        ''' <remarks>Each class has a unique ID number that represents the class.</remarks>
        Public Property ClassID As Integer

        ''' <summary>
        ''' The value of the mask.  Used for flags.
        ''' </summary>
        ''' <value>This property gets or sets the Mask field.</value>
        ''' <returns>Returns the value of the mask.  Used for flags.</returns>
        ''' <remarks>This seems to always be 2 ^ (<see cref="ClassID" /> - 1).  Given that so far every API that has a collection of classes returns an array of integers, it is unclear what this property is actually used for.</remarks>
        Public Property Mask As Integer

        ''' <summary>
        ''' The power type that this class uses for special abilities.
        ''' </summary>
        ''' <value>This property gets or sets the PowerType field.</value>
        ''' <returns>Returns the power type that this class uses for special abilities.</returns>
        ''' <remarks>This is a <see cref="Enums.PowerType" /> enumeration that indicates the type of power the class uses.</remarks>
        Public Property PowerType As PowerType

        ''' <summary>
        ''' The name of the class.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the class.</returns>
        ''' <remarks>This is the localized name of the class.</remarks>
        Public Property Name As String

        Friend Sub New(intClassID As Integer, intMask As Integer, ptPowerType As PowerType, strName As String)
            ClassID = intClassID
            Mask = intMask
            PowerType = ptPowerType
            Name = strName
        End Sub

    End Class

End Namespace