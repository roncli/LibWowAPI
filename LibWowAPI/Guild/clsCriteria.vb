' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a guild achievement criteria.
    ''' </summary>
    ''' <remarks>This class contains various statistics about completed guild achievement criteria.</remarks>
    Public Class Criteria

        ''' <summary>
        ''' The ID number of the guild achievement criteria.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the guild achievement criteria.</returns>
        ''' <remarks>Each criteria has a unique ID number.  Guild achievements are completed when one or more criteria are completed.  However, there is currently no mapping to tell which criteria complete which guild achievements.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The amount of the guild achievement criteria completed.
        ''' </summary>
        ''' <value>This property gets or sets the Quantity field.</value>
        ''' <returns>Returns the amount of the guild achievement criteria completed.</returns>
        ''' <remarks>Some criteria have a quantity requirement, such as to spend so much gold on repair bills, or to complete a certain number of quests.  This property contains that quantity.</remarks>
        Public Property Quantity As Long

        ''' <summary>
        ''' The date the guild achievement criteria was completed.
        ''' </summary>
        ''' <value>This property gets or sets the Timestamp field.</value>
        ''' <returns>Returns the date the guild achievement criteria was completed.</returns>
        ''' <remarks>This date is the time in UTC that the criteria was completed.</remarks>
        Public Property Timestamp As Date

        ''' <summary>
        ''' The date the guild achievement criteria was started.
        ''' </summary>
        ''' <value>This property gets or sets the Created field.</value>
        ''' <returns>Returns the date the guild achievement criteria was started.</returns>
        ''' <remarks>This date is the time in UTC that the criteria was started.  This will be equal to the <see cref="Criteria.Timestamp" /> property if the required <see cref="Criteria.Quantity" /> is 1.</remarks>
        Public Property Created As Date

        Friend Sub New(intID As Integer, lngQuantity As Long, dtTimestamp As Date, dtCreated As Date)
            ID = intID
            Quantity = lngQuantity
            Timestamp = dtTimestamp
            Created = dtCreated
        End Sub

    End Class

End Namespace
