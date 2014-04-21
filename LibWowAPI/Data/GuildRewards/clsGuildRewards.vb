' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Achievement
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions
Imports roncliProductions.LibWowAPI.Item

Namespace roncliProductions.LibWowAPI.Data.GuildRewards

    ''' <summary>
    ''' A class that retrieves guild reward information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve the list of guild rewards from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of guild rewards.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.GuildRewards;
    '''
    ''' namespace GuildRewardsExample {
    '''
    '''     public class GuildRewardsClass {
    '''
    '''         public Collection&lt;Reward&gt; GetGuildRewards() {
    '''             GuildRewards rewards = new GuildRewards();
    '''             rewards.Load();
    '''             return rewards.Rewards;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.GuildRewards
    ''' 
    ''' Namespace GuildRewardsExample
    ''' 
    '''     Public Class GuildRewardsClass
    ''' 
    '''         Public Function GetGuildRewards() As Collection(Of Reward)
    '''             Dim rewards As New GuildRewards()
    '''             rewards.Load()
    '''             Return rewards.Rewards
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class GuildRewards
        Inherits WowAPIData

        Private grRewards As New Schema.rewards

#Region "WowAPIData Overrides"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for guild reward information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for guild reward information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="GuildRewards.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.GuildRewards"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/api/wow/data/guild/rewards", UriKind.Relative)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the guild rewards.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Reward)" /> of <see cref="Reward" />.  Each item in the collection represents a guild reward received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    grRewards = CType(New DataContractJsonSerializer(GetType(Schema.rewards)).ReadObject(msJSON), Schema.rewards)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colRewards = (
                From r In grRewards.rewards
                Select New Reward(
                    r.minGuildLevel,
                    CType(r.minGuildRepLevel, Standing),
                    r.races.GetRaces(),
                    If(
                        r.achievement Is Nothing, Nothing,
                        New Achievement.Achievement(
                            r.achievement.id,
                            r.achievement.title,
                            r.achievement.points,
                            r.achievement.description,
                            r.achievement.reward,
                            If(
                                r.achievement.rewardItems Is Nothing, Nothing, (
                                    From ri In r.achievement.rewardItems
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
                                            Select New Item.ItemStat(
                                                CType(s.stat, Enums.ItemStat),
                                                s.amount,
                                                s.reforgedAmount,
                                                s.reforged
                                                )
                                            ).ToCollection(),
                                        ri.armor
                                        )
                                    ).ToCollection()
                                ),
                            r.achievement.icon,
                            (
                                From c In r.achievement.criteria
                                Select New Criteria(
                                    c.id,
                                    c.description,
                                    c.orderIndex,
                                    c.max
                                    )
                                ).ToCollection(),
                            r.achievement.accountWide,
                            CType(r.achievement.factionId, Faction)
                            )
                        ),
                    New ItemBasicInfo(
                        r.item.id,
                        r.item.name,
                        r.item.icon,
                        CType(r.item.quality, Quality),
                        r.item.itemLevel,
                        If(
                            r.item.tooltipParams Is Nothing, Nothing, New TooltipParams(
                                r.item.tooltipParams.GetGems(),
                                r.item.tooltipParams.suffix,
                                r.item.tooltipParams.seed,
                                r.item.tooltipParams.enchant,
                                r.item.tooltipParams.extraSocket,
                                If(r.item.tooltipParams.set Is Nothing, Nothing, r.item.tooltipParams.set.ToCollection()),
                                r.item.tooltipParams.reforge,
                                r.item.tooltipParams.transmogItem,
                                If(
                                    r.item.tooltipParams.upgrade Is Nothing, Nothing, New Upgrade(
                                        r.item.tooltipParams.upgrade.current,
                                        r.item.tooltipParams.upgrade.total,
                                        r.item.tooltipParams.upgrade.itemLevelIncrement
                                        )
                                    )
                                )
                            ),
                        (
                            From s In r.item.stats
                            Select New Item.ItemStat(
                                CType(s.stat, Enums.ItemStat),
                                s.amount,
                                s.reforgedAmount,
                                s.reforged
                                )
                            ).ToCollection(),
                        r.item.armor
                        )
                    )
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colRewards As Collection(Of Reward)
        ''' <summary>
        ''' A list of guild rewards as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Rewards field.</value>
        ''' <returns>Returns a list of guild rewards as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Reward)" /> of <see cref="Reward" />, which is a list of all guild rewards.</remarks>
        Public ReadOnly Property Rewards As Collection(Of Reward)
            Get
                Return colRewards
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve guild rewards information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="GuildRewards" /> class.  You must call the <see cref="GuildRewards.Load" /> method to load the rewards.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
