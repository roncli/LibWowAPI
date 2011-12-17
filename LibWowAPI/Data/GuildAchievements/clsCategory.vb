' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Data.GuildAchievements

    ''' <summary>
    ''' A class containing information about a guild achievement category.
    ''' </summary>
    ''' <remarks>A guild achievement category can contain other categories as well as guild achievements.</remarks>
    Public Class Category

        ''' <summary>
        ''' The ID number of the guild achievement category.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the guild achievement category.</returns>
        ''' <remarks>Each guild achievement category has an ID number that can be used to identify it.</remarks>
        Public Property ID As Integer

        Private colCategories As Collection(Of Category)
        ''' <summary>
        ''' The guild achievement category's subcategories.
        ''' </summary>
        ''' <value>This property gets the Categories field.</value>
        ''' <returns>Returns the guild achievment category's subcategories.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Category)" /> of <see cref="Category" />, which represents a list of subcategories in this particular guild achievement category.</remarks>
        Public ReadOnly Property Categories As Collection(Of Category)
            Get
                Return colCategories
            End Get
        End Property

        ''' <summary>
        ''' The name of the guild achievement category.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the guild achievement category.</returns>
        ''' <remarks>This is the localized name of the guild achievement category.</remarks>
        Public Property Name As String

        Private colAchievements As Collection(Of Achievement)
        ''' <summary>
        ''' The guild achievements within this category.
        ''' </summary>
        ''' <value>This property gets the Achievements field.</value>
        ''' <returns>Returns the guild achievements within this category.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Achievement)" /> of <see cref="Achievement" />, which is a list of all of the guild achievements in this category.</remarks>
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
