' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a guild.
    ''' </summary>
    ''' <remarks>This class contains basic information about the guild, plus any additional information that was requested using the <see cref="GuildProfile.Options" /> property of the <see cref="GuildProfile" /> class.</remarks>
    Public Class Guild

        ''' <summary>
        ''' The date the guild profile was last modified on the server.
        ''' </summary>
        ''' <value>This property gets or sets the LastModified field.</value>
        ''' <returns>Returns the date the guild was last modified at the server.</returns>
        ''' <remarks>This date is the time in UTC that the guild was last updated on the server.  You can use this value for the <see cref="WowAPIData.IfModifiedSince" /> property of the <see cref="WowAPIData" /> class.</remarks>
        Public Property LastModified As Date

        ''' <summary>
        ''' The name of the guild.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the guild.</returns>
        ''' <remarks>The name of the character's guild is only available here.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The realm the guild resides on.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm the guild resides on.</returns>
        ''' <remarks>This is the name of the realm the guild is on.</remarks>
        Public Property Realm As String

        ''' <summary>
        ''' The battleground the guild's realm is in.
        ''' </summary>
        ''' <value>This property gets or sets the Battlegroup field.</value>
        ''' <returns>Returns the battleground the guild's realm is in.</returns>
        ''' <remarks>This represents the battleground the guild's realm is in.</remarks>
        Public Property Battlegroup As String

        ''' <summary>
        ''' The level of the guild.
        ''' </summary>
        ''' <value>This property gets or sets the Level field.</value>
        ''' <returns>Returns the level of the guild.</returns>
        ''' <remarks>This is the guild level that determines what <see cref="Data.GuildPerks" /> a guild receives.</remarks>
        Public Property Level As Integer

        ''' <summary>
        ''' The side the guild is on.
        ''' </summary>
        ''' <value>This property gets or sets the Side field.</value>
        ''' <returns>Returns the side the guild is on.</returns>
        ''' <remarks>This is a <see cref="Enums.Side" /> enumeration that tells which side the guild is on.</remarks>
        Public Property Side As Side

        ''' <summary>
        ''' The number of guild achievement points the guild has earned.
        ''' </summary>
        ''' <value>This property gets or sets the AchievementPoints field.</value>
        ''' <returns>Returns the number of guild achievement points the guild has earned.</returns>
        ''' <remarks>This is the total number of guild achievement points the guild has.</remarks>
        Public Property AchievementPoints As Integer

        ''' <summary>
        ''' The guild's completed achievements and achievement criteria.
        ''' </summary>
        ''' <value>This property gets or sets the Achievements field.</value>
        ''' <returns>Returns the guild's completed achievements and achievement criteria.</returns>
        ''' <remarks>If the <see cref="GuildProfileOptions.Achievements" /> property of the <see cref="GuildProfile.Options" /> property is set to true, an <see cref="Achievements" /> class will be available, containing information about the guild's completed guild achievements and guild achievement criteria.</remarks>
        Public Property Achievements As Achievements

        Private Property lstMembers As Collection(Of Member)
        ''' <summary>
        ''' A list of members in the guild.
        ''' </summary>
        ''' <value>This property gets the Members field.</value>
        ''' <returns>Returns a list of members in the guild.</returns>
        ''' <remarks>If the <see cref="GuildProfileOptions.Members" /> property of the <see cref="GuildProfile.Options" /> property is set to true, a <see cref="Collection(Of Member)" /> of <see cref="Member" /> will be available, containing information about the guild's members.</remarks>
        Public ReadOnly Property Members As Collection(Of Member)
            Get
                Return lstMembers
            End Get
        End Property

        ''' <summary>
        ''' The guild's emblem.
        ''' </summary>
        ''' <value>This property gets or sets the Emblem field.</value>
        ''' <returns>Returns the guild's emblem.</returns>
        ''' <remarks>The <see cref="Emblem" /> class holds information on how to construct the guild's emblem.</remarks>
        Public Property Emblem As Emblem

        Private colNews As Collection(Of NewsItem)
        ''' <summary>
        ''' The guild's news feed.
        ''' </summary>
        ''' <value>This property gets the News field.</value>
        ''' <returns>Returns the guild's news feed.</returns>
        ''' <remarks>If the <see cref="GuildProfileOptions.News" /> property of the <see cref="GuildProfile.Options" /> property is set to true, a <see cref="Collection(Of NewsItem)" /> of <see cref="NewsItem" /> will be available, containing the guild's news feed.</remarks>
        Public ReadOnly Property News As Collection(Of NewsItem)
            Get
                Return colNews
            End Get
        End Property

        Friend Sub New(dtLastModified As Date, strName As String, strRealm As String, strBattlegroup As String, intLevel As Integer, sSide As Side, intAchievementPoints As Integer, aAchievements As Achievements, mMembers As Collection(Of Member), eEmblem As Emblem, nNews As Collection(Of NewsItem))
            LastModified = dtLastModified
            Name = strName
            Realm = strRealm
            Battlegroup = strBattlegroup
            Level = intLevel
            Side = sSide
            AchievementPoints = intAchievementPoints
            Achievements = aAchievements
            lstMembers = mMembers
            Emblem = eEmblem
            colNews = nNews
        End Sub

    End Class

End Namespace
