﻿' LibWowAPI
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
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions

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
                gpGuild.level,
                CType(gpGuild.side, Side),
                gpGuild.achievementPoints,
                If(gpGuild.achievements Is Nothing, Nothing, SetAchievements(gpGuild.achievements)),
                If(gpGuild.members Is Nothing OrElse gpGuild.members.Count = 0, Nothing,
                    (From m In gpGuild.members
                    Select New Member(
                        New Character(
                            m.character.name,
                            m.character.realm,
                            m.character.class.GetClass(),
                            m.character.race.GetRace(),
                            CType(m.character.gender, Gender),
                            m.character.level,
                            m.character.achievementPoints,
                            m.character.thumbnail
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

        Private Shared Function SetAchievements(aAchievements As Schema.achievements) As Achievements
            Dim colAchievements As New Collection(Of Achievement)
            Dim enumAchievement = aAchievements.achievementsCompleted.GetEnumerator()
            Dim enumAchievementTimestamp = aAchievements.achievementsCompletedTimestamp.GetEnumerator()
            While enumAchievement.MoveNext() And enumAchievementTimestamp.MoveNext()
                colAchievements.Add(New Achievement(CInt(enumAchievement.Current), CLng(enumAchievementTimestamp.Current).BlizzardTimestampToUTC()))
            End While

            Dim colCriteria As New Collection(Of Criteria)
            Dim enumCriteria = aAchievements.criteria.GetEnumerator()
            Dim enumCriteriaQuantity = aAchievements.criteriaQuantity.GetEnumerator()
            Dim enumCriteriaTimestamp = aAchievements.criteriaTimestamp.GetEnumerator()
            Dim enumCriteriaCreated = aAchievements.criteriaCreated.GetEnumerator()
            While enumCriteria.MoveNext() And enumCriteriaCreated.MoveNext() And enumCriteriaQuantity.MoveNext() And enumCriteriaTimestamp.MoveNext()
                colCriteria.Add(New Criteria(
                                CInt(enumCriteria.Current),
                                CLng(enumCriteriaQuantity.Current),
                                CLng(enumCriteriaTimestamp.Current).BlizzardTimestampToUTC(),
                                CLng(enumCriteriaCreated.Current).BlizzardTimestampToUTC()
                                ))
            End While

            Return New Achievements(colAchievements, colCriteria)
        End Function

#End Region

    End Class

End Namespace