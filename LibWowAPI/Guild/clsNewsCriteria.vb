' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about criteria for an achievement for the guild news.
    ''' </summary>
    ''' <remarks>This class provides detailed information about criteria for an achievement.</remarks>
    Public Class NewsCriteria

        ''' <summary>
        ''' The ID number of the criteria.
        ''' </summary>
        ''' <value>This property gets or sets the CriteriaID field.</value>
        ''' <returns>Returns the ID number of the criteria.</returns>
        ''' <remarks>Each achievement criteria has a unique ID number to identify it.</remarks>
        Public Property CriteriaID As Integer

        ''' <summary>
        ''' The description of the criteria.
        ''' </summary>
        ''' <value>This property gets or sets the Description field.</value>
        ''' <returns>Returns the description of the criteria.</returns>
        ''' <remarks>This is the localized description of the criteria.</remarks>
        Public Property Description As String

        Friend Sub New(intCriteriaID As Integer, strDescription As String)
            CriteriaID = intCriteriaID
            Description = strDescription
        End Sub

    End Class

End Namespace
