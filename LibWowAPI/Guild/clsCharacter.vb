' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Data.CharacterClasses
Imports roncliProductions.LibWowAPI.Data.CharacterRaces
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a character who is a member of the guild.
    ''' </summary>
    ''' <remarks>This class contains basic information about the character.</remarks>
    Public Class Character

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
        ''' <remarks>The character's race is represented by a <see cref="Data.CharacterRaces.Race" /> object.  See the <see cref="Data.CharacterRaces.Race.Name" /> property to get the name of the race, and the <see cref="Data.CharacterRaces.Race.Side" /> property to get the character's faction.</remarks>
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

        Friend Sub New(strName As String, strRealm As String, cClass As [Class], rRace As Race, gGender As Gender, intLevel As Integer, intAchievementPoints As Integer, strThumbnail As String)
            Name = strName
            Realm = strRealm
            [Class] = cClass
            Race = rRace
            Gender = gGender
            Level = intLevel
            AchievementPoints = intAchievementPoints
            Thumbnail = strThumbnail
        End Sub

    End Class

End Namespace
