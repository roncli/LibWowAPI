' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Data.CharacterClasses
Imports roncliProductions.LibWowAPI.Data.CharacterRaces
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Guild
Imports roncliProductions.LibWowAPI.Data.Talents

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing basic information about a character.
    ''' </summary>
    ''' <remarks>This class contains basic information about the character</remarks>
    Public Class CharacterBasicInfo

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
        ''' The battlegroup the character resides on.
        ''' </summary>
        ''' <value>This property gets or sets the Battlegroup field.</value>
        ''' <returns>Returns the battlegroup the character resides on.</returns>
        ''' <remarks>The character's battlegroup is reprsented here.</remarks>
        Public Property Battlegroup As String

        ''' <summary>
        ''' The character's class.
        ''' </summary>
        ''' <value>This property gets or sets the Class field.</value>
        ''' <returns>Returns the character's class.</returns>
        ''' <remarks>The character's class is represented by a <see cref="Data.CharacterClasses.[Class]" /> object.  See the <see cref="Data.CharacterClasses.[Class].Name" /> property to get the name of the class.</remarks>
        Public Property [Class] As [Class]

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
        ''' Information about the character's talent spec.
        ''' </summary>
        ''' <value>This property gets or sets the Spec field.</value>
        ''' <returns>Returns information about the character's talent spec.</returns>
        ''' <remarks>This is a <see cref="Spec" /> object which represents information about the character's talent spec.</remarks>
        Public Property Spec As Spec

        ''' <summary>
        ''' The guild the character is from.
        ''' </summary>
        ''' <value>This property gets or sets the Guild field.</value>
        ''' <returns>Returns the guild the character is from.</returns>
        ''' <remarks>This represents the guild the character is from.</remarks>
        Public Property Guild As String

        ''' <summary>
        ''' The realm the character's guild resides on.
        ''' </summary>
        ''' <value>This property gets or sets the GuildRealm field.</value>
        ''' <returns>Returns the realm the character's guild resides on.</returns>
        ''' <remarks>This represents the realm the character's guild resides on.</remarks>
        Public Property GuildRealm As String

        Friend Sub New(strName As String, strRealm As String, strBattlegroup As String, cClass As [Class], rRace As Race, gGender As Gender, intLevel As Integer, intAchievementPoints As Integer, strThumbnail As String, sSpec As Spec, strGuild As String, strGuildRealm As String)
            Name = strName
            Realm = strRealm
            Battlegroup = strBattlegroup
            [Class] = cClass
            Race = rRace
            Gender = gGender
            Level = intLevel
            AchievementPoints = intAchievementPoints
            Thumbnail = strThumbnail
            Spec = sSpec
            Guild = strGuild
            GuildRealm = strGuildRealm
        End Sub

    End Class

End Namespace
