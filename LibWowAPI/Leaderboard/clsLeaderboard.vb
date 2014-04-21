' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Data.CharacterClasses
Imports roncliProductions.LibWowAPI.Data.CharacterRaces
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Leaderboard

    ''' <summary>
    ''' A class containing information about a PvP leaderboard.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a PvP leaderboard.</remarks>
    Public Class Leaderboard

        ''' <summary>
        ''' The character's ranking on the leaderboard.
        ''' </summary>
        ''' <value>This property gets or sets the Ranking field.</value>
        ''' <returns>Returns the character's ranking on the leaderboard.</returns>
        ''' <remarks>This represents the character's ranking on the leaderboard.</remarks>
        Public Property Ranking As Integer

        ''' <summary>
        ''' The character's rating on the leaderboard.
        ''' </summary>
        ''' <value>This property gets or sets the Rating field.</value>
        ''' <returns>Returns the character's rating on the leaderboard.</returns>
        ''' <remarks>This represents the character's rating on the leaderboard.</remarks>
        Public Property Rating As Integer

        ''' <summary>
        ''' The character's name.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the character's name.</returns>
        ''' <remarks>This represents the character's name.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The realm ID of the character's realm.
        ''' </summary>
        ''' <value>This property gets or sets the RealmID field.</value>
        ''' <returns>Returns the realm ID of the charater's realm.</returns>
        ''' <remarks>This represents the realm ID of the character's realm.</remarks>
        Public Property RealmID As Integer

        ''' <summary>
        ''' The name of the character's realm.
        ''' </summary>
        ''' <value>This property gets or sets the RealmName field.</value>
        ''' <returns>Returns the name of the character's realm.</returns>
        ''' <remarks>This represents the localized name of the character's realm.</remarks>
        Public Property RealmName As String

        ''' <summary>
        ''' The slug of the character's realm.
        ''' </summary>
        ''' <value>This property gets or sets the RealmSlug field.</value>
        ''' <returns>Returns the slug of the character's realm.</returns>
        ''' <remarks>This is Blizzard's internal representation of the character's realm.</remarks>
        Public Property RealmSlug As String

        ''' <summary>
        ''' The race ID of the character.
        ''' </summary>
        ''' <value>This property gets or sets the RaceID field.</value>
        ''' <returns>Returns the race ID of the character.</returns>
        ''' <remarks>This is a <see cref="Race" /> object that represents the Race ID of the character.  Use the <see cref="Data.CharacterRaces.CharacterRaces" /> class to get information about the character's race.</remarks>
        Public Property Race As Race

        ''' <summary>
        ''' The class of the character.
        ''' </summary>
        ''' <value>This property gets or sets the Class field.</value>
        ''' <returns>Returns the class of the character.</returns>
        ''' <remarks>This is a <see cref="CharacterClass" /> object that represents the Class of the characteer.</remarks>
        Public Property [Class] As CharacterClass

        ''' <summary>
        ''' The spec ID of the character.
        ''' </summary>
        ''' <value>This property gets or sets the SpecID field.</value>
        ''' <returns>Returns the spec ID of the character.</returns>
        ''' <remarks>This represents the Spec ID of the character.</remarks>
        Public Property SpecID As Integer

        ''' <summary>
        ''' The faction of the character.
        ''' </summary>
        ''' <value>This property gets or sets the Faction field.</value>
        ''' <returns>Returns the faction of the character.</returns>
        ''' <remarks>This is a <see cref="Enums.Faction" /> enumeration that represents the faction of the character.</remarks>
        Public Property Faction As Faction

        ''' <summary>
        ''' The gender of the character.
        ''' </summary>
        ''' <value>This property gets or sets the Gender field.</value>
        ''' <returns>Returns the gender of the character.</returns>
        ''' <remarks>This is a <see cref="Enums.Gender" /> enumeration that represents the gender of the character.</remarks>
        Public Property Gender As Gender

        ''' <summary>
        ''' The number of wins for the season.
        ''' </summary>
        ''' <value>This property gets or sets the SeasonWins field.</value>
        ''' <returns>Returns the number of wins for the season.</returns>
        ''' <remarks>This represents the number of wins for the season.</remarks>
        Public Property SeasonWins As Integer

        ''' <summary>
        ''' The number of losses for the season.
        ''' </summary>
        ''' <value>This property gets or sets the SeasonLosses field.</value>
        ''' <returns>Returns the number of losses for the season.</returns>
        ''' <remarks>This represents the number of losses for the season.</remarks>
        Public Property SeasonLosses As Integer

        ''' <summary>
        ''' The number of wins for the week.
        ''' </summary>
        ''' <value>This property gets or sets the WeeklyWins field.</value>
        ''' <returns>Returns the number of wins for the week.</returns>
        ''' <remarks>This represents the number of wins for the week.</remarks>
        Public Property WeeklyWins As Integer

        ''' <summary>
        ''' The number of losses for the week.
        ''' </summary>
        ''' <value>This property gets or sets the WeeklyLosses field.</value>
        ''' <returns>Returns the number of losses for the week.</returns>
        ''' <remarks>This represents the number of losses for the week.</remarks>
        Public Property WeeklyLosses As Integer

        Friend Sub New(intRanking As Integer, intRating As Integer, strName As String, intRealmID As Integer, strRealmName As String, strRealmSlug As String, rRace As Race, ccClass As CharacterClass, intSpecID As Integer, fFaction As Faction, gGender As Gender, intSeasonWins As Integer, intSeasonLosses As Integer, intWeeklyWins As Integer, intWeeklyLosses As Integer)
            Ranking = intRanking
            Rating = intRating
            Name = strName
            RealmID = intRealmID
            RealmName = strRealmName
            RealmSlug = strRealmSlug
            Race = rRace
            [Class] = ccClass
            SpecID = intSpecID
            Faction = fFaction
            Gender = gGender
            SeasonWins = intSeasonWins
            SeasonLosses = intSeasonLosses
            WeeklyWins = intWeeklyWins
            WeeklyLosses = intWeeklyLosses
        End Sub

    End Class

End Namespace
