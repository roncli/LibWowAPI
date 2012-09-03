' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's guild.
    ''' </summary>
    ''' <remarks>Basic guild information is available to retrieve along with the character.  It is the only way to get the name of the guild the character is in.</remarks>
    Public Class Guild

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
        ''' The battlegroup the guild resides on.
        ''' </summary>
        ''' <value>This property gets or sets the Battlegroup field.</value>
        ''' <returns>Returns the battlegroup the guild resides on.</returns>
        ''' <remarks>This is the name of the battlegroup the guild is on.</remarks>
        Public Property Battlegroup As String

        ''' <summary>
        ''' The level of the guild.
        ''' </summary>
        ''' <value>This property gets or sets the Level field.</value>
        ''' <returns>Returns the level of the guild.</returns>
        ''' <remarks>This is the guild level that determines what <see cref="Data.GuildPerks" /> a guild receives.</remarks>
        Public Property Level As Integer

        ''' <summary>
        ''' The number of members in the guild.
        ''' </summary>
        ''' <value>This property gets or sets the Members field.</value>
        ''' <returns>Returns the number of members in the guild.</returns>
        ''' <remarks>This is a count of the number of members in the guild.</remarks>
        Public Property Members As Integer

        ''' <summary>
        ''' The number of guild achievement points the guild has earned.
        ''' </summary>
        ''' <value>This property gets or sets the AchievementPoints field.</value>
        ''' <returns>Returns the number of guild achievement points the guild has earned.</returns>
        ''' <remarks>This is the total number of guild achievement points the guild has.</remarks>
        Public Property AchievementPoints As Integer

        ''' <summary>
        ''' The guild's emblem.
        ''' </summary>
        ''' <value>This property gets or sets the Emblem field.</value>
        ''' <returns>Returns the guild's emblem.</returns>
        ''' <remarks>The <see cref="Emblem" /> class holds information on how to construct the guild's emblem.</remarks>
        Public Property Emblem As Emblem

        Friend Sub New(strName As String, strRealm As String, strBattlegroup As String, intLevel As Integer, intMembers As Integer, intAchievementPoints As Integer, eEmblem As Emblem)
            Name = strName
            Realm = strRealm
            Battlegroup = strBattlegroup
            Level = intLevel
            Members = intMembers
            AchievementPoints = intAchievementPoints
            Emblem = eEmblem
        End Sub

    End Class

End Namespace
