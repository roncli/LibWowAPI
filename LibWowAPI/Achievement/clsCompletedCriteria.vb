' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Achievement

    ''' <summary>
    ''' A class containing information about an achievement criteria.
    ''' </summary>
    ''' <remarks>This class contains various statistics about completed achievement criteria.</remarks>
    Public Class CompletedCriteria

        ''' <summary>
        ''' The ID number of the achievement criteria.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the achievement criteria.</returns>
        ''' <remarks>Each criteria has a unique ID number.  Achievements are completed when one or more criteria are completed.  However, there is currently no mapping to tell which criteria complete which achievements.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The amount of the achievement criteria completed.
        ''' </summary>
        ''' <value>This property gets or sets the Quantity field.</value>
        ''' <returns>Returns the amount of the achievement criteria completed.</returns>
        ''' <remarks>Some criteria have a quantity requirement, such as to earn so much gold from looting, or to obtain a certain number of mounts.  This property contains that quantity.</remarks>
        Public Property Quantity As Long

        ''' <summary>
        ''' The date the achievement criteria was completed.
        ''' </summary>
        ''' <value>This property gets or sets the Timestamp field.</value>
        ''' <returns>Returns the date the achievement criteria was completed.</returns>
        ''' <remarks>This date is the time in UTC that the criteria was completed.</remarks>
        Public Property Timestamp As Date

        ''' <summary>
        ''' The date the achievement criteria was started.
        ''' </summary>
        ''' <value>This property gets or sets the Created field.</value>
        ''' <returns>Returns the date the achievement criteria was started.</returns>
        ''' <remarks>This date is the time in UTC that the criteria was started.  This will be equal to the <see cref="CompletedCriteria.Timestamp" /> property if the required <see cref="CompletedCriteria.Quantity" /> is 1.</remarks>
        Public Property Created As Date

        Friend Sub New(intID As Integer, lngQuantity As Long, dtTimestamp As Date, dtCreated As Date)
            ID = intID
            Quantity = lngQuantity
            Timestamp = dtTimestamp
            Created = dtCreated
        End Sub

    End Class

End Namespace
