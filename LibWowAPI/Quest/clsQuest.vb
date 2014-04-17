' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Quest

    ''' <summary>
    ''' A class that contains information about a quest.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a quest.</remarks>
    Public Class Quest

        ''' <summary>
        ''' The ID number of the quest.
        ''' </summary>
        ''' <value>This property gets or sets the QuestID field.</value>
        ''' <returns>Returns the ID number of the quest.</returns>
        ''' <remarks>Each question has a unique ID number that identifies the quest.</remarks>
        Public Property QuestID As Integer

        ''' <summary>
        ''' The title of the quest.
        ''' </summary>
        ''' <value>This property gets or sets the Title field.</value>
        ''' <returns>Returns the title of the quest.</returns>
        ''' <remarks>This is the localized title of the quest.</remarks>
        Public Property Title As String

        ''' <summary>
        ''' The required level to accept the quest.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredLevel field.</value>
        ''' <returns>Returns the required level to accept the quest.</returns>
        ''' <remarks>This represents the required level to accept the quest.</remarks>
        Public Property RequiredLevel As Integer

        ''' <summary>
        ''' The suggested number of party members needed to complete the quest
        ''' </summary>
        ''' <value>This property gets or sets the SuggestedPartyMembers field.</value>
        ''' <returns>Returns the suggested number of party members needed to complete the quest.</returns>
        ''' <remarks>This returns 0 when it's not a group quest.</remarks>
        Public Property SuggestedPartyMembers As Integer

        ''' <summary>
        ''' The category of the quest.
        ''' </summary>
        ''' <value>This property gets or sets the Category field.</value>
        ''' <returns>Returns the category of the quest.</returns>
        ''' <remarks>This is the localized category of the quest.</remarks>
        Public Property Category As String

        ''' <summary>
        ''' The level of the quest.
        ''' </summary>
        ''' <value>This property gets or sets the Level field.</value>
        ''' <returns>Returns the level of the quest.</returns>
        ''' <remarks>This returns -1 if the quest is not level-dependent, for example holiday quests.</remarks>
        Public Property Level As Integer

        Friend Sub New(intQuestID As Integer, strTitle As String, intRequiredLevel As Integer, intSuggestedPartyMembers As Integer, strCategory As String, intLevel As Integer)
            QuestID = intQuestID
            Title = strTitle
            RequiredLevel = intRequiredLevel
            SuggestedPartyMembers = intSuggestedPartyMembers
            Category = strCategory
            Level = intLevel
        End Sub

    End Class

End Namespace
