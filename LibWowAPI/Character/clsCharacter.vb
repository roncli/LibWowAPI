﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Achievement
Imports roncliProductions.LibWowAPI.Data.CharacterClasses
Imports roncliProductions.LibWowAPI.Data.CharacterRaces
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Guild

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character.
    ''' </summary>
    ''' <remarks>This class contains basic information about the character, plus any additional information that was requested using the <see cref="CharacterProfile.Options" /> property of the <see cref="CharacterProfile" /> class.</remarks>
    Public Class Character

        ''' <summary>
        ''' The date the character was last modified at the server.
        ''' </summary>
        ''' <value>This property gets or sets the LastModified field.</value>
        ''' <returns>Returns the date the character was last modified at the server.</returns>
        ''' <remarks>This date is the time in UTC that the character was last updated on the server.  You can use this value for the <see cref="WowAPIData.IfModifiedSince" /> property of the <see cref="WowAPIData" /> class.</remarks>
        Public Property LastModified As Date

        ''' <summary>
        ''' The character's name.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the character's name.</returns>
        ''' <remarks>The name of the character is represented here.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The realm the character resides on.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm the character resides on.</returns>
        ''' <remarks>The character's realm is represented here.</remarks>
        Public Property Realm As String

        ''' <summary>
        ''' The battleground the character's realm is in.
        ''' </summary>
        ''' <value>This property gets or sets the Battlegroup field.</value>
        ''' <returns>Returns the battleground the character's realm is in.</returns>
        ''' <remarks>This represents the battleground the character's realm is in.</remarks>
        Public Property Battlegroup As String

        ''' <summary>
        ''' The character's class.
        ''' </summary>
        ''' <value>This property gets or sets the Class field.</value>
        ''' <returns>Returns the character's class.</returns>
        ''' <remarks>The character's class is represented by a <see cref="Data.CharacterClasses.CharacterClass" /> object.  See the <see cref="Data.CharacterClasses.CharacterClass.Name" /> property to get the name of the class.</remarks>
        Public Property [Class] As CharacterClass

        ''' <summary>
        ''' The character's race.
        ''' </summary>
        ''' <value>This property gets or sets the Race field.</value>
        ''' <returns>Returns the character's race.</returns>
        ''' <remarks>The character's race is represented by a <see cref="Data.CharacterRaces.Race" /> object.  See the <see cref="Data.CharacterRaces.Race.Name" /> property to get the name of the race, and the <see cref="Data.CharacterRaces.Race.Faction" /> property to get the character's faction.</remarks>
        Public Property Race As Race

        ''' <summary>
        ''' The character's gender.
        ''' </summary>
        ''' <value>This property gets or sets the Gender field.</value>
        ''' <returns>Returns the character/s gender.</returns>
        ''' <remarks>The character's <see cref="Enums.Gender" /> is represented here.</remarks>
        Public Property Gender As Gender

        ''' <summary>
        ''' The character's level.
        ''' </summary>
        ''' <value>This property gets or sets the Level field.</value>
        ''' <returns>Returns the character's level.</returns>
        ''' <remarks>The character's level is represented here.</remarks>
        Public Property Level As Integer

        ''' <summary>
        ''' The number of achievement points the character has.
        ''' </summary>
        ''' <value>This property gets or sets the AchievementPoints field.</value>
        ''' <returns>Returns the number of achievement points the player has earned.</returns>
        ''' <remarks>The character's number of earned achievement points is represented here.</remarks>
        Public Property AchievementPoints As Integer

        ''' <summary>
        ''' A path to an image thumbnail of the character on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Thumbnail field.</value>
        ''' <returns>Returns a path to an image thumbnail of the character on the server.</returns>
        ''' <remarks>Blizzard generates thumbnails of characters on a regular basis.  These are located under the directory http://<i>Base URL</i>/static-render/<i>region</i>/  For example, for US characters, the Base URL is "us.battle.net", and the region is "us".</remarks>
        Public Property Thumbnail As String

        ''' <summary>
        ''' The string that identifies the class in the official talent calculator.
        ''' </summary>
        ''' <value>This property gets or sets the CalcClass field.</value>
        ''' <returns>Returns the string that identifies the class in the official talent calculator.</returns>
        ''' <remarks>This is the first character in the first field of the parameter for the talent calculator.</remarks>
        Public Property CalcClass As String

        ''' <summary>
        ''' The total number of honorable kills the character has.
        ''' </summary>
        ''' <value>This property gets or sets the TotalHonorableKills field.</value>
        ''' <returns>Returns the total number of honorable kills the character has.</returns>
        ''' <remarks>This represents the total number of honorable kills the character has.</remarks>
        Public Property TotalHonorableKills As Integer

        ''' <summary>
        ''' The character's guild.
        ''' </summary>
        ''' <value>This property gets or sets the Guild field.</value>
        ''' <returns>Returns the character's guild.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Guild" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="GuildBasicInfo" /> class will be available, containing information about the character's guild.</remarks>
        Public Property Guild As GuildBasicInfo

        ''' <summary>
        ''' The character's equipped items.
        ''' </summary>
        ''' <value>This property gets or sets the Items field.</value>
        ''' <returns>Returns the character's equipped items.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Items" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Items" /> class will be available, containing information about the character's equipped items.</remarks>
        Public Property Items As Items

        ''' <summary>
        ''' The character's combat statistics.
        ''' </summary>
        ''' <value>This property gets or sets the Stats field.</value>
        ''' <returns>Returns the character's combat statistics.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Stats" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="CharacterStats" /> class will be available, containing information about the character's combat statistics.</remarks>
        Public Property Stats As CharacterStats

        ''' <summary>
        ''' The character's professions.
        ''' </summary>
        ''' <value>This property gets or sets the Professions field.</value>
        ''' <returns>Returns the character's professions.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Professions" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Professions" /> class will be available, containing information about the character's professions.</remarks>
        Public Property Professions As Professions

        Private colReputation As Collection(Of Reputation)
        ''' <summary>
        ''' A list of the character's reputations.
        ''' </summary>
        ''' <value>This property gets the Reputation field.</value>
        ''' <returns>Returns a list of the character's reputations.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Reputation" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Collection(Of Reptutation)" /> of <see cref="Reputation" /> will be available, containing information about the character's reputations.</remarks>
        Public ReadOnly Property Reputation As Collection(Of Reputation)
            Get
                Return colReputation
            End Get
        End Property

        Private colTitles As Collection(Of Title)
        ''' <summary>
        ''' A list of titles the character has earned.
        ''' </summary>
        ''' <value>This property gets the Titles field.</value>
        ''' <returns>Returns a list of titles the character has earned.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Titles" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Collection(Of Title)" /> of <see cref="Title" /> will be available, containing information about the titles the character has earned.  Some recent titles may not be returned, see http://us.battle.net/wow/en/forum/topic/2743700663.</remarks>
        Public ReadOnly Property Titles As Collection(Of Title)
            Get
                Return colTitles
            End Get
        End Property

        ''' <summary>
        ''' The character's completed achievements and achievement criteria.
        ''' </summary>
        ''' <value>This property gets or sets the Achievements field.</value>
        ''' <returns>Returns the character's completed achievements and achievement criteria.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Achievements" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="CompletedAchievements" /> class will be available, containing information about the character's completed achievements and achievement criteria.</remarks>
        Public Property Achievements As CompletedAchievements

        Private colHunterPets As Collection(Of HunterPet)
        ''' <summary>
        ''' A list of the character's hunter pets.
        ''' </summary>
        ''' <value>This property gets the HunterPets field.</value>
        ''' <returns>Returns a list of the character's hunter pets.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.HunterPets" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Collection(Of HunterPet)" /> of <see cref="HunterPet" /> will be available, containing information about the character's hunter pets.</remarks>
        Public ReadOnly Property HunterPets As Collection(Of HunterPet)
            Get
                Return colHunterPets
            End Get
        End Property

        Private colTalents As Collection(Of TalentSpec)
        ''' <summary>
        ''' The character's talents and glyphs.
        ''' </summary>
        ''' <value>This property gets the Talents field.</value>
        ''' <returns>Returns the character's talents and glyphs.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Talents" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Collection(Of TalentSpec)" /> of <see cref="TalentSpec" /> will be available, containing information about the character's talent specs.</remarks>
        Public ReadOnly Property Talents As Collection(Of TalentSpec)
            Get
                Return colTalents
            End Get
        End Property

        ''' <summary>
        ''' The character's appearance.
        ''' </summary>
        ''' <value>This property gets or sets the Appearance field.</value>
        ''' <returns>Returns the character's appearance.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Appearance" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Appearance" /> class will be available, containing information about the character's appearance.</remarks>
        Public Property Appearance As Appearance

        ''' <summary>
        ''' A list of the character's mounts.
        ''' </summary>
        ''' <value>This property gets the Mounts field.</value>
        ''' <returns>Returns a list of the character's mounts.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Mounts" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Mounts" /> class will be available, containing information about the character's mounts.</remarks>
        Public Property Mounts As Mounts

        ''' <summary>
        ''' The character's instance progression.
        ''' </summary>
        ''' <value>This property gets or sets the Progression field.</value>
        ''' <returns>Returns the character's instance progression.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Progression" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Progression" /> class will be available, containing information about a character's instance progression.</remarks>
        Public Property Progression As Progression

        ''' <summary>
        ''' The character's PvP statistics.
        ''' </summary>
        ''' <value>This property gets or sets the PvP field.</value>
        ''' <returns>Returns the character's PvP statistics.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.PvP" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="PvP" /> class will be available, containing information about a character's PvP statistics.</remarks>
        Public Property PvP As PvP

        Private colQuests As Collection(Of Integer)
        ''' <summary>
        ''' The character's completed quests.
        ''' </summary>
        ''' <value>This property gets the Quests field.</value>
        ''' <returns>Returns the character's completed quests.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Quests" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Collection(Of Integer)" /> of IDs will be available, containing a list of quest IDs for quests that the character has completed.  You can get more information about a quest using the <see cref="Quest.QuestLookup" /> class.</remarks>
        Public ReadOnly Property Quests As Collection(Of Integer)
            Get
                Return colQuests
            End Get
        End Property

        Private colFeed As Collection(Of FeedItem)
        ''' <summary>
        ''' The character's feed.
        ''' </summary>
        ''' <value>This property gets the Feed field.</value>
        ''' <returns>Returns the character's feed.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Feed" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Collection(Of FeedItem)" /> of <see cref="FeedItem" /> will be available, containing the character's feed.</remarks>
        Public ReadOnly Property Feed As Collection(Of FeedItem)
            Get
                Return colFeed
            End Get
        End Property

        ''' <summary>
        ''' The character's pets.
        ''' </summary>
        ''' <value>This property gets or sets the Pets field.</value>
        ''' <returns>Returns the character's pets.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Pets" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Pets" /> object will be available, containing the character's pets.</remarks>
        Public Property Pets As Pets

        Private colPetSlots As Collection(Of PetSlot)
        ''' <summary>
        ''' The character's pet slots.
        ''' </summary>
        ''' <value>This property gets the PetSlots field.</value>
        ''' <returns>Returns the character's pet slots.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.PetSlots" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, a <see cref="Collection(Of PetSlot)" /> of <see cref="PetSlot" /> will be available, containing the character's pet slots.</remarks>
        Public ReadOnly Property PetSlots As Collection(Of PetSlot)
            Get
                Return colPetSlots
            End Get
        End Property

        ''' <summary>
        ''' The character's equipment audit.
        ''' </summary>
        ''' <value>This property gets or sets the Audit field.</value>
        ''' <returns>Returns the character's equipment audit.</returns>
        ''' <remarks>If the <see cref="CharacterProfileOptions.Audit" /> property of the <see cref="CharacterProfile.Options" /> property is set to true, an <see cref="Audit" /> object will be available, containing the character's equipement audit.</remarks>
        Public Property Audit As Audit

        Friend Sub New(dtLastModified As Date, strName As String, strRealm As String, strBattlegroup As String, ccClass As CharacterClass, rRace As Race, gGender As Gender, intLevel As Integer, intAchievementPoints As Integer, strThumbnail As String, strCalcClass As String, intTotalHonorableKills As Integer, gbiGuild As GuildBasicInfo, iItems As Items, csStats As CharacterStats, pProfessions As Professions, rReputation As Collection(Of Reputation), tTitles As Collection(Of Title), caAchievements As CompletedAchievements, pHunterPets As Collection(Of HunterPet), tTalents As Collection(Of TalentSpec), aAppearance As Appearance, mMounts As Mounts, pProgression As Progression, pPvP As PvP, intQuests As Collection(Of Integer), fiFeed As Collection(Of FeedItem), pPets As Pets, psPetSlots As Collection(Of PetSlot), aAudit As Audit)
            LastModified = dtLastModified
            Name = strName
            Realm = strRealm
            Battlegroup = strBattlegroup
            [Class] = ccClass
            Race = rRace
            Gender = gGender
            Level = intLevel
            AchievementPoints = intAchievementPoints
            Thumbnail = strThumbnail
            CalcClass = strCalcClass
            TotalHonorableKills = intTotalHonorableKills
            Guild = gbiGuild
            Items = iItems
            Stats = csStats
            Professions = pProfessions
            colReputation = rReputation
            colTitles = tTitles
            Achievements = caAchievements
            colHunterPets = pHunterPets
            colTalents = tTalents
            Appearance = aAppearance
            Mounts = mMounts
            Progression = pProgression
            PvP = pPvP
            colQuests = intQuests
            colFeed = fiFeed
            Pets = pPets
            colPetSlots = psPetSlots
            Audit = aAudit
        End Sub

    End Class

End Namespace
