' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Character
Imports roncliProductions.LibWowAPI.Data.Talents
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions
Imports roncliProductions.LibWowAPI.Guild
Imports roncliProductions.LibWowAPI.Realm

Namespace roncliProductions.LibWowAPI.Challenge

    ''' <summary>
    ''' A class that looks up challenge mode leaderboards for a single realm from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve leaderboards for a single realm from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve a challenge mode leaderboard for a single realm.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Challenge;
    '''
    ''' namespace ChallengeExample {
    '''
    '''     public class ChallengeClass {
    '''
    '''         public Challenge GetChallenge(string realm) {
    '''             ChallengeRealm challenge = new ChallengeRealm();
    '''             challenge.Options.Realm = realm;
    '''             challenge.Load();
    '''             return challenge.Challenge;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Challenge
    ''' 
    ''' Namespace ChallengeExample
    ''' 
    '''     Public Class ChallengeClass
    ''' 
    '''         Public Function GetChallenge(realm As String) As Challenge
    '''             Dim challenge As New ChallengeRealm()
    '''             challenge.Options.Realm = realm
    '''             challenge.Load()
    '''             Return challenge.Challenge
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class ChallengeRealm
        Inherits WowAPIData

        Private crChallengeRealm As New Schema.challengeRealm

#Region "WowAPIData Overrides"

#Region "Properties"

#Region "Protected"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.ChallengeRealm.{0}", Options.Realm)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/challenge/{0}", Options.Realm), UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the challenge mode leaderboard.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Challenge" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    crChallengeRealm = CType(New DataContractJsonSerializer(GetType(Schema.challengeRealm)).ReadObject(msJSON), Schema.challengeRealm)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            cChallenge = (
                From crm In crChallengeRealm.challenge
                Select New Challenge(
                    If(
                        crm.realm Is Nothing, Nothing, New RealmBasicInfo(crm.realm.name, crm.realm.slug, crm.realm.battlegroup, crm.realm.locale, crm.realm.timezone)
                        ),
                    New Map(
                        crm.map.id,
                        crm.map.name,
                        crm.map.slug,
                        crm.map.hasChallengeMode,
                        New TimeSpan(0, 0, 0, 0, crm.map.bronzeCriteria.time),
                        New TimeSpan(0, 0, 0, 0, crm.map.silverCriteria.time),
                        New TimeSpan(0, 0, 0, 0, crm.map.goldCriteria.time)
                        ),
                    (
                        From g In crm.groups
                        Select New Group(
                            g.ranking,
                            New TimeSpan(0, 0, 0, 0, g.time.time),
                            DateTime.Parse(g.date, CultureInfo.InvariantCulture),
                            g.medal,
                            g.faction.GetFaction(),
                            g.isRecurring,
                            (
                                From m In g.members
                                Select New GroupMember(
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
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up challenge mode leaderboards for a single realm.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up leaderboards for a single realm.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New ChallengeRealmOptions

        Private cChallenge As Collection(Of Challenge)
        ''' <summary>
        ''' The leaderboards returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Challenge field.</value>
        ''' <returns>Returns the leaderboards as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is a <see cref="Collection(Of Challenge)" /> of <see cref="Challenge" /> objects that contains information about challenge mode leaderboards specified in the <see cref="ChallengeRealm.Options" />.</remarks>
        Public ReadOnly Property Challenge As Collection(Of Challenge)
            Get
                Return cChallenge
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve challenge mode leaderboards from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="ChallengeRealm" /> class.  You must call the <see cref="ChallengeRealm.Load" /> method to load the leaderboards.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve challenge mode leaderboards from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="strRealm">The realm to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="ChallengeRealm" /> class and automatically loads the data for the specified realm's leaderboards.</remarks>
        Public Sub New(strRealm As String)
            Options.Realm = strRealm
            Load()
        End Sub

#End Region

    End Class

End Namespace
