' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about an item's source.
    ''' </summary>
    ''' <remarks>This class gives basic details about the source of an item.</remarks>
    Public Class ItemSource

        ''' <summary>
        ''' The ID number of the item's source.
        ''' </summary>
        ''' <value>This property gets or sets the SourceID field.</value>
        ''' <returns>Returns the ID number of the item's source.</returns>
        ''' <remarks>The meaning of this value varies by the <see cref="SourceType" /> property.  For example, if this is sold by a vendor, this is the NPC ID.  Or, if it's a quest reward, this is the Quest ID.</remarks>
        Public Property SourceID As Integer

        ''' <summary>
        ''' The type of item source.
        ''' </summary>
        ''' <value>This property gets or sets the SourceType field.</value>
        ''' <returns>Returns the type of item source.</returns>
        ''' <remarks>This represents the type of item source.</remarks>
        Public Property SourceType As String

        Friend Sub New(intSourceID As Integer, strSourceType As String)
            SourceID = intSourceID
            SourceType = strSourceType
        End Sub

    End Class

End Namespace
