' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums
Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's progression in an instance.
    ''' </summary>
    ''' <remarks>This class provides current instance progression for a single instance.</remarks>
    Public Class Instance

        ''' <summary>
        ''' The name of the instance.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the instance.</returns>
        ''' <remarks>This property represents the name of the instance.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The character's progression in the normal version of the instance.
        ''' </summary>
        ''' <value>This property gets or sets the Normal field.</value>
        ''' <returns>Returns the character's progression in the normal version of the instance.</returns>
        ''' <remarks>This is a <see cref="Enums.Progress" /> enumeration that determines the character's progression through the normal mode of the instance.</remarks>
        Public Property Normal As Progress

        ''' <summary>
        ''' The character's progression in the heroic version of the instance.
        ''' </summary>
        ''' <value>This property gets or sets the Heroic field.</value>
        ''' <returns>Returns the character's progression in the heroic version of the instance.</returns>
        ''' <remarks>This is a <see cref="Enums.Progress" /> enumeration that determines the character's progression through the heroic mode of the instance.</remarks>
        Public Property Heroic As Progress

        ''' <summary>
        ''' The ID number of the instance.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the instance.</returns>
        ''' <remarks>This ID number is unique to the instance.</remarks>
        Public Property ID As Integer

        Private colBosses As Collection(Of Boss)
        ''' <summary>
        ''' A list of bosses in the instance and the character's kill statistics with them.
        ''' </summary>
        ''' <value>This property gets the Bosses field.</value>
        ''' <returns>Returns a list of bosses in the instance and the character's kill statistics with them.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Boss)" /> of <see cref="Boss" /> that has information about how many times the character has killed each boss and on what mode.</remarks>
        Public ReadOnly Property Bosses As Collection(Of Boss)
            Get
                Return colBosses
            End Get
        End Property

        Friend Sub New(strName As String, pNormal As Progress, pHeroic As Progress, intID As Integer, bBosses As Collection(Of Boss))
            Name = strName
            Normal = pNormal
            Heroic = pHeroic
            ID = intID
            colBosses = bBosses
        End Sub

    End Class

End Namespace
