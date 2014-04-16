' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.ItemSet

    ''' <summary>
    ''' A class containing information about an item set.
    ''' </summary>
    ''' <remarks>This class contains detailed information about an item set.</remarks>
    Public Class ItemSet

        ''' <summary>
        ''' The ID number of the set.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the set.</returns>
        ''' <remarks>Each set has a unique ID number that is used to identify the set.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The name of the set.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the set.</returns>
        ''' <remarks>This is the localized name of the set.</remarks>
        Public Property Name As String

        Private Property colSetBonuses As Collection(Of SetBonus)
        ''' <summary>
        ''' The set bonuses given by the set.
        ''' </summary>
        ''' <value>This property gets the SetBonuses field.</value>
        ''' <returns>Returns the set bonuses given by the set.</returns>
        ''' <remarks>This is a <see cref="Collection(Of SetBonus)" /> of <see cref="SetBonus" /> that represents the set bonuses given by the set.</remarks>
        Public ReadOnly Property SetBonuses As Collection(Of SetBonus)
            Get
                Return colSetBonuses
            End Get
        End Property

        Private Property colItems As Collection(Of Integer)
        ''' <summary>
        ''' The list of item IDs in this set.
        ''' </summary>
        ''' <value>This property gets the Items field.</value>
        ''' <returns>Returns the list of item IDs in this set.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Integer)" /> that represents the list of item IDs in this set.</remarks>
        Public ReadOnly Property Items As Collection(Of Integer)
            Get
                Return colItems
            End Get
        End Property

        Friend Sub New(intID As Integer, strName As String, sbSetBonuses As Collection(Of SetBonus), intItems As Collection(Of Integer))
            ID = intID
            Name = strName
            colSetBonuses = sbSetBonuses
            colItems = intItems
        End Sub

    End Class

End Namespace
