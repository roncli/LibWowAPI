' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Quest

    ''' <summary>
    ''' A class that defines options for the quest lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the quest ID to look up a quest. There is no need to create an instance of this class, as the <see cref="QuestLookup.Options" /> property automatically does so for you.</remarks>
    Public Class QuestLookupOptions

        ''' <summary>
        ''' The quest ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the QuestID field.</value>
        ''' <returns>Returns the quest ID to lookup.</returns>
        ''' <remarks>This represents the quest ID to lookup.</remarks>
        Public Property QuestID As Integer

        Friend Sub New()
        End Sub

    End Class

End Namespace
