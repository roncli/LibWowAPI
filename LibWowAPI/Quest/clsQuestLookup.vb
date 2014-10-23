' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding

Namespace roncliProductions.LibWowAPI.Quest

    ''' <summary>
    ''' A class that retrieves quest information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about a quest.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve a quest.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Quest;
    ''' 
    ''' namespace QuestExample {
    '''
    '''     public class QuestClass {
    ''' 
    '''         public Quest GetQuest(int questID) {
    '''             QuestLookup quest = new QuestLookup();
    '''             quest.Options.QuestID = questID;
    '''             quest.Load();
    '''             return quest.Quest;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Item
    ''' 
    ''' Namespace QuestExample
    ''' 
    '''     Public Class QuestClass
    ''' 
    '''         Public Function GetQuest(questID As Integer) As Quest
    '''             Dim quest As New QuestLookup()
    '''             quest.Options.QuestID = questID
    '''             quest.Load()
    '''             Return quest.Quest
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class QuestLookup
        Inherits WowAPIData

        Private qlQuest As New Schema.quest

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for quest information.
        ''' </summary>
        ''' <value>This property gets or sets CacheLength.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for quest information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache.  The default can be changed at any time before the <see cref="QuestLookup.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.Quest.{0}", Options.QuestID)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/wow/quest/{0}", Options.QuestID), UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the quest.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Quest" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    qlQuest = CType(New DataContractJsonSerializer(GetType(Schema.quest)).ReadObject(msJSON), Schema.quest)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try
            qQuest = New Quest(
                qlQuest.id,
                qlQuest.title,
                qlQuest.reqLevel,
                qlQuest.suggestedPartyMembers,
                qlQuest.category,
                qlQuest.level
                )
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up a quest.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up a quest.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New QuestLookupOptions

        Private qQuest As Quest
        ''' <summary>
        ''' The quest returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets or sets the Quest field.</value>
        ''' <returns>Returns the quest returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="LibWowAPI.Quest.Quest" /> object that contains information about the quest specified in the <see cref="QuestLookup.Options" />.</remarks>
        Public ReadOnly Property Quest As Quest
            Get
                Return qQuest
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve quest information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="QuestLookup" /> class.  You must set the <see cref="QuestLookupOptions.QuestID" /> property of the <see cref="QuestLookup.Options" /> property and then call the <see cref="QuestLookup.Load" /> method to load the quest.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve quest information for a quest from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="intQuestID">The quest ID to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="QuestLookup" /> class and automatically loads the data for the specified quest ID.</remarks>
        Public Sub New(intQuestID As Integer)
            Options.QuestID = intQuestID
            Load()
        End Sub

#End Region

    End Class

End Namespace
