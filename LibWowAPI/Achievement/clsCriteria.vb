' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Achievement

    ''' <summary>
    ''' A class containing information about criteria for an achievement.
    ''' </summary>
    ''' <remarks>This class provides detailed information about criteria for an achievement.</remarks>
    Public Class Criteria

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

        ''' <summary>
        ''' The order in which the criteria is listed.
        ''' </summary>
        ''' <value>This property gets or sets the OrderIndex field.</value>
        ''' <returns>Returns the order in which the criteria is listed.</returns>
        ''' <remarks>This represents the order in which the criteria is listed.</remarks>
        Public Property OrderIndex As Integer

        ''' <summary>
        ''' The number of times the criteria needs to be done before it is completed.
        ''' </summary>
        ''' <value>This property gets or sets the Max field.</value>
        ''' <returns>Returns the number of times the criteria needs to be done before it is completed.</returns>
        ''' <remarks>This represents the number of times the criteria needs to be done before it is completed.</remarks>
        Public Property Max As Long

        Friend Sub New(intCriteriaID As Integer, strDescription As String, intOrderIndex As Integer, lngMax As Long)
            CriteriaID = intCriteriaID
            Description = strDescription
            OrderIndex = intOrderIndex
            Max = lngMax
        End Sub

    End Class

End Namespace
