' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Achievements

    ''' <summary>
    ''' A class containing information about an achievement category.
    ''' </summary>
    ''' <remarks>An achievement category can contain other categories as well as achievements.</remarks>
    Public Class Category

        ''' <summary>
        ''' The ID number of the achievement category.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the achievement category.</returns>
        ''' <remarks>Each achievement category has an ID number that can be used to identify it.</remarks>
        Public Property ID As Integer

        Private colCategories As Collection(Of Category)
        ''' <summary>
        ''' The achievement category's subcategories.
        ''' </summary>
        ''' <value>This property gets the Categories field.</value>
        ''' <returns>Returns the achievment category's subcategories.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Category)" /> of <see cref="Category" />, which represents a list of subcategories in this particular achievement category.</remarks>
        Public ReadOnly Property Categories As Collection(Of Category)
            Get
                Return colCategories
            End Get
        End Property

        ''' <summary>
        ''' The name of the achievement category.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the achievement category.</returns>
        ''' <remarks>This is the localized name of the achievement category.</remarks>
        Public Property Name As String

        Private colAchievements As Collection(Of Achievement)
        ''' <summary>
        ''' The achievements within this category.
        ''' </summary>
        ''' <value>This property gets the Achievements field.</value>
        ''' <returns>Returns the achievements within this category.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Achievement)" /> of <see cref="Achievement" />, which is a list of all of the achievements in this category.</remarks>
        Public ReadOnly Property Achievements As Collection(Of Achievement)
            Get
                Return colAchievements
            End Get
        End Property

        Friend Sub New(intID As Integer, cCategories As Collection(Of Category), strName As String, aAchievements As Collection(Of Achievement))
            ID = intID
            colCategories = cCategories
            Name = strName
            colAchievements = aAchievements
        End Sub

    End Class

End Namespace
