' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about an ability required to use an item.
    ''' </summary>
    ''' <remarks>This class describes an ability that is required to use an item.</remarks>
    Public Class RequiredAbility

        ''' <summary>
        ''' The ID number of the ability's spell.
        ''' </summary>
        ''' <value>This property gets or sets the SpellID field.</value>
        ''' <returns>Returns the spell ID number.</returns>
        ''' <remarks>Each spell has a unique ID number that is used to identify it.</remarks>
        Public Property SpellID As Integer

        ''' <summary>
        ''' The name of the ability.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the ability.</returns>
        ''' <remarks>This is the localized name of the ability.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The ability's description.
        ''' </summary>
        ''' <value>This property gets or sets the Description field.</value>
        ''' <returns>Returns the ability's description.</returns>
        ''' <remarks>This is the localized description of the ability.</remarks>
        Public Property Description As String

        Friend Sub New(intSpellID As Integer, strName As String, strDescription As String)
            SpellID = intSpellID
            Name = strName
            Description = strDescription
        End Sub

    End Class

End Namespace
