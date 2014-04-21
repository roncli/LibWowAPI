' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Achievement
Imports roncliProductions.LibWowAPI.Challenge
Imports roncliProductions.LibWowAPI.Character
Imports roncliProductions.LibWowAPI.Data.Talents
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions
Imports roncliProductions.LibWowAPI.Item
Imports roncliProductions.LibWowAPI.Realm

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class that retrieves guild profile information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about a guild.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' There are boolean options that can retrieve a guild's members or guild achievements.  The following example demonstrates how to make a call to the API to retrieve a guild profile, using these options.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Guild;
    ''' 
    ''' namespace GuildExample {
    '''
    '''     public class GuildClass {
    ''' 
    '''         public Guild GetGuild(string realm, string name) {
    '''             GuildProfile guild = new GuildProfile();
    '''             guild.Options.Realm = realm;
    '''             guild.Options.Name = name;
    '''             guild.Options.Members = true;
    '''             guild.Options.Achievements = true;
    '''             guild.Load();
    '''             return guild.Guild;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Guild
    ''' 
    ''' Namespace GuildExample
    ''' 
    '''     Public Class GuildClass
    ''' 
    '''         Public Function GetGuild(realm As String, name As String) As Guild
    '''             Dim guild As New GuildProfile()
    '''             guild.Options.Realm = realm
    '''             guild.Options.Name = name
    '''             guild.Options.Members = True
    '''             guild.Options.Achievements = True
    '''             guild.Load()
    '''             Return guild.Guild
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class GuildProfile
        Inherits WowAPIData

        Private gpGuild As New Schema.guild

#Region "WowAPIData Overrides"

#Region "Properties"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                QueryString.Clear()
                If Not String.IsNullOrWhiteSpace(FieldList) Then
                    QueryString.Add("fields", FieldList)
                End If
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/guild/{0}/{1}", Options.Realm, Options.Name), UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.GuildProfile.{0}.{1}.{2}", Options.Realm, Options.Name, FieldList)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the guild profile.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Guild" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    gpGuild = CType(New DataContractJsonSerializer(GetType(Schema.guild)).ReadObject(msJSON), Schema.guild)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            gGuild = New Guild(
                gpGuild.lastModified.BlizzardTimestampToUTC(),
                gpGuild.name,
                gpGuild.realm,
                gpGuild.battlegroup,
                gpGuild.level,
                CType(gpGuild.side, Faction),
                gpGuild.achievementPoints,
                If(gpGuild.achievements Is Nothing, Nothing, SetAchievements(gpGuild.achievements)),
                If(
                    gpGuild.members Is Nothing OrElse gpGuild.members.Count = 0, Nothing, (
                        From m In gpGuild.members
                        Select New Member(
                            New CharacterBasicInfo(
                                m.character.name,
                                m.character.realm,
                                m.character.battlegroup,
                                m.character.class.GetClass(),
                                m.character.race.GetRace(),
                                CType(m.character.gender, Gender),
                                m.character.level,
                                m.character.achievementPoints,
                                m.character.thumbnail,
                                If(
                                    m.character.spec Is Nothing, Nothing, New Spec(
                                        m.character.spec.name,
                                        m.character.spec.role,
                                        m.character.spec.backgroundImage,
                                        m.character.spec.icon,
                                        m.character.spec.description,
                                        m.character.spec.order
                                        )
                                    ),
                                m.character.guild,
                                m.character.guildRealm
                                ),
                            m.rank
                            )
                        ).ToCollection()
                    ),
                New Emblem(
                    gpGuild.emblem.icon,
                    gpGuild.emblem.iconColor.ArgbHexToColor(),
                    gpGuild.emblem.border,
                    gpGuild.emblem.borderColor.ArgbHexToColor(),
                    gpGuild.emblem.backgroundColor.ArgbHexToColor()
                    ),
                If(
                    gpGuild.news Is Nothing, Nothing, (
                        From n In gpGuild.news
                        Select CreateNewsItem(n)
                        ).ToCollection()
                    ),
                If(
                    gpGuild.challenge Is Nothing, Nothing, (
                        From c In gpGuild.challenge
                        Select New Challenge.Challenge(
                            New RealmBasicInfo(
                                c.realm.name,
                                c.realm.slug,
                                c.realm.battlegroup,
                                c.realm.locale,
                                c.realm.timezone
                                ),
                            New Map(
                                c.map.id,
                                c.map.name,
                                c.map.slug,
                                c.map.hasChallengeMode,
                                New TimeSpan(0, 0, 0, 0, c.map.bronzeCriteria.time),
                                New TimeSpan(0, 0, 0, 0, c.map.silverCriteria.time),
                                New TimeSpan(0, 0, 0, 0, c.map.goldCriteria.time)
                                ),
                            (
                                From g In c.groups
                                Select New Group(
                                    g.ranking,
                                    New TimeSpan(0, 0, 0, 0, g.time.time),
                                    DateTime.Parse(g.date, CultureInfo.InvariantCulture),
                                    g.medal,
                                    g.faction.GetFaction(),
                                    g.isRecurring,
                                    (
                                        From m In g.members
                                        Select New Challenge.Member(
                                            If(
                                                m.character Is Nothing, Nothing, New CharacterBasicInfo(
                                                    m.character.name,
                                                    m.character.realm,
                                                    m.character.battlegroup,
                                                    m.character.class.GetClass(),
                                                    m.character.race.GetRace(),
                                                    CType(m.character.gender, Gender),
                                                    m.character.level,
                                                    m.character.achievementPoints,
                                                    m.character.thumbnail,
                                                    If(
                                                        m.character.spec Is Nothing, Nothing, New Spec(
                                                            m.character.spec.name,
                                                            m.character.spec.role,
                                                            m.character.spec.backgroundImage,
                                                            m.character.spec.icon,
                                                            m.character.spec.description,
                                                            m.character.spec.order
                                                            )
                                                        ),
                                                    m.character.guild,
                                                    m.character.guildRealm
                                                    )
                                                ),
                                            New Spec(
                                                m.spec.name,
                                                m.spec.role,
                                                m.spec.backgroundImage,
                                                m.spec.icon,
                                                m.spec.description,
                                                m.spec.order
                                                )
                                            )
                                        ).ToCollection(),
                                    If(
                                        g.guild Is Nothing, Nothing, New GuildBasicInfo(
                                            g.guild.name,
                                            g.guild.realm,
                                            g.guild.battlegroup,
                                            g.guild.level,
                                            g.guild.members,
                                            g.guild.achievementPoints,
                                            New Emblem(
                                                g.guild.emblem.icon,
                                                g.guild.emblem.iconColor.ArgbHexToColor(),
                                                g.guild.emblem.border,
                                                g.guild.emblem.borderColor.ArgbHexToColor(),
                                                g.guild.emblem.backgroundColor.ArgbHexToColor()
                                                )
                                            )
                                        )
                                    )
                                ).ToCollection()
                            )
                        ).ToCollection()
                    )
                )
        End Sub

#End Region

#Region "Properties"

#Region "Public"

        ''' <summary>
        ''' The options for looking up guild profile information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up guild profile information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New GuildProfileOptions

        Private gGuild As Guild
        ''' <summary>
        ''' Guild profile information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Character field.</value>
        ''' <returns>Returns guild profile information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is a <see cref="Guild" /> object that contains information about the guild specified in the <see cref="GuildProfile.Options" />.</remarks>
        Public ReadOnly Property Guild As Guild
            Get
                Return gGuild
            End Get
        End Property

#End Region

#Region "Private"

        Private ReadOnly Property FieldList As String
            Get
                Dim lstFields As New List(Of String)
                If Options.Members Then lstFields.Add("members")
                If Options.Achievements Then lstFields.Add("achievements")
                If Options.News Then lstFields.Add("news")
                If Options.Challenge Then lstFields.Add("challenge")
                Return String.Join(",", lstFields)
            End Get
        End Property

#End Region

#End Region

#Region "Methods"

#Region "Constructors"

        ''' <summary>
        ''' A default constructor to retrieve guild profile information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="GuildProfile" /> class.  You must set the <see cref="GuildProfileOptions.Realm" /> and <see cref="GuildProfileOptions.Name" /> properties of the <see cref="GuildProfile.Options" /> property, along with any other boolean options you wish to set, and then call the <see cref="GuildProfile.Load" /> method to load the guild profile.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve a guild's profile.
        ''' </summary>
        ''' <param name="strRealm">The realm to lookup the guild in.</param>
        ''' <param name="strName">The name of the guild to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="GuildProfile" /> class and automatically loads the data for the specified realm and name.</remarks>
        Public Sub New(strRealm As String, strName As String)
            Options.Realm = strRealm
            Options.Name = strName
            Load()
        End Sub

#End Region

#Region "Private"

        Private Shared Function SetAchievements(aAchievements As Achievement.Schema.completedAchievements) As CompletedAchievements
            Dim colAchievements As New Collection(Of CompletedAchievement)
            Dim enumAchievement = aAchievements.achievementsCompleted.GetEnumerator()
            Dim enumAchievementTimestamp = aAchievements.achievementsCompletedTimestamp.GetEnumerator()
            While enumAchievement.MoveNext() And enumAchievementTimestamp.MoveNext()
                colAchievements.Add(New CompletedAchievement(CInt(enumAchievement.Current), CLng(enumAchievementTimestamp.Current).BlizzardTimestampToUTC()))
            End While

            Dim colCriteria As New Collection(Of CompletedCriteria)
            Dim enumCriteria = aAchievements.criteria.GetEnumerator()
            Dim enumCriteriaQuantity = aAchievements.criteriaQuantity.GetEnumerator()
            Dim enumCriteriaTimestamp = aAchievements.criteriaTimestamp.GetEnumerator()
            Dim enumCriteriaCreated = aAchievements.criteriaCreated.GetEnumerator()
            While enumCriteria.MoveNext() And enumCriteriaCreated.MoveNext() And enumCriteriaQuantity.MoveNext() And enumCriteriaTimestamp.MoveNext()
                colCriteria.Add(
                    New CompletedCriteria(
                        CInt(enumCriteria.Current),
                        CLng(enumCriteriaQuantity.Current),
                        CLng(enumCriteriaTimestamp.Current).BlizzardTimestampToUTC(),
                        CLng(enumCriteriaCreated.Current).BlizzardTimestampToUTC()
                        )
                    )
            End While

            Return New CompletedAchievements(colAchievements, colCriteria)
        End Function

        Private Shared Function CreateNewsItem(nNews As Schema.news) As NewsItem
            Select Case nNews.type.ToUpperInvariant()
                Case "GUILDCREATED"
                    Return New GuildCreatedNews(nNews.timestamp.BlizzardTimestampToUTC())
                Case "ITEMLOOT"
                    Return New ItemLootNews(nNews.timestamp.BlizzardTimestampToUTC(), nNews.character, nNews.itemId)
                Case "ITEMPURCHASE"
                    Return New ItemPurchaseNews(nNews.timestamp.BlizzardTimestampToUTC(), nNews.character, nNews.itemId)
                Case "GUILDLEVEL"
                    Return New GuildLevelNews(nNews.timestamp.BlizzardTimestampToUTC(), nNews.levelUp)
                Case "GUILDACHIEVEMENT"
                    Return New GuildAchievementNews(
                        nNews.timestamp.BlizzardTimestampToUTC(),
                        nNews.character,
                        New NewsAchievement(
                            nNews.achievement.id,
                            nNews.achievement.title,
                            nNews.achievement.points,
                            nNews.achievement.description,
                            nNews.achievement.reward,
                            (
                                From ri In nNews.achievement.rewardItems
                                Select New ItemBasicInfo(
                                    ri.id,
                                    ri.name,
                                    ri.icon,
                                    CType(ri.quality, Quality),
                                    ri.itemLevel,
                                    If(
                                        ri.tooltipParams Is Nothing, Nothing, New TooltipParams(
                                            ri.tooltipParams.GetGems(),
                                            ri.tooltipParams.suffix,
                                            ri.tooltipParams.seed,
                                            ri.tooltipParams.enchant,
                                            ri.tooltipParams.extraSocket,
                                            If(ri.tooltipParams.set Is Nothing, Nothing, ri.tooltipParams.set.ToCollection()),
                                            ri.tooltipParams.reforge,
                                            ri.tooltipParams.transmogItem,
                                            If(
                                                ri.tooltipParams.upgrade Is Nothing, Nothing, New Upgrade(
                                                    ri.tooltipParams.upgrade.current,
                                                    ri.tooltipParams.upgrade.total,
                                                    ri.tooltipParams.upgrade.itemLevelIncrement
                                                    )
                                                )
                                            )
                                        ),
                                    (
                                        From s In ri.stats
                                        Select New Item.Stat(
                                            CType(s.stat, Enums.Stat),
                                            s.amount,
                                            s.reforgedAmount,
                                            s.reforged
                                            )
                                        ).ToCollection(),
                                    ri.armor
                                    )
                                ).ToCollection(),
                            nNews.achievement.icon,
                            (
                                From c In nNews.achievement.criteria
                                Select New NewsCriteria(
                                    c.id,
                                    c.description
                                    )
                                ).ToCollection()
                            )
                        )
                Case "PLAYERACHIEVEMENT"
                    Return New PlayerAchievementNews(
                        nNews.timestamp.BlizzardTimestampToUTC(),
                        nNews.character,
                        New NewsAchievement(
                            nNews.achievement.id,
                            nNews.achievement.title,
                            nNews.achievement.points,
                            nNews.achievement.description,
                            nNews.achievement.reward,
                            (
                                From ri In nNews.achievement.rewardItems
                                Select New ItemBasicInfo(
                                    ri.id,
                                    ri.name,
                                    ri.icon,
                                    CType(ri.quality, Quality),
                                    ri.itemLevel,
                                    If(
                                        ri.tooltipParams Is Nothing, Nothing, New TooltipParams(
                                            ri.tooltipParams.GetGems(),
                                            ri.tooltipParams.suffix,
                                            ri.tooltipParams.seed,
                                            ri.tooltipParams.enchant,
                                            ri.tooltipParams.extraSocket,
                                            If(ri.tooltipParams.set Is Nothing, Nothing, ri.tooltipParams.set.ToCollection()),
                                            ri.tooltipParams.reforge,
                                            ri.tooltipParams.transmogItem,
                                            If(
                                                ri.tooltipParams.upgrade Is Nothing, Nothing, New Upgrade(
                                                    ri.tooltipParams.upgrade.current,
                                                    ri.tooltipParams.upgrade.total,
                                                    ri.tooltipParams.upgrade.itemLevelIncrement
                                                    )
                                                )
                                            )
                                        ),
                                    (
                                        From s In ri.stats
                                        Select New Item.Stat(
                                            CType(s.stat, Enums.Stat),
                                            s.amount,
                                            s.reforgedAmount,
                                            s.reforged
                                            )
                                        ).ToCollection(),
                                    ri.armor
                                    )
                                ).ToCollection(),
                            nNews.achievement.icon,
                            (
                                From c In nNews.achievement.criteria
                                Select New NewsCriteria(
                                    c.id,
                                    c.description
                                    )
                                ).ToCollection()
                            )
                        )
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region

#End Region

    End Class

End Namespace
