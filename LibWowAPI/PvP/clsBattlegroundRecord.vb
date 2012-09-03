' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class containing information about a character's battleground record.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a character's battleground record.</remarks>
    Public Class BattlegroundRecord

        ''' <summary>
        ''' The character's ranking.
        ''' </summary>
        ''' <value>This property gets or sets the Rank field.</value>
        ''' <returns>Returns the character's ranking.</returns>
        ''' <remarks>This represents the character's ranking.</remarks>
        Public Property Rank As Integer

        ''' <summary>
        ''' The character's rating.
        ''' </summary>
        ''' <value>This property gets or sets the Rating field.</value>
        ''' <returns>Returns the character's rating.</returns>
        ''' <remarks>This represents the character's rating.</remarks>
        Public Property Rating As Integer

        ''' <summary>
        ''' The number of battlegrounds won this season.
        ''' </summary>
        ''' <value>This property gets or sets the Wins field.</value>
        ''' <returns>Returns the number of battlegrounds won this season.</returns>
        ''' <remarks>This represents the number of battlegrounds won this season.</remarks>
        Public Property Wins As Integer

        ''' <summary>
        ''' The number of battlegrounds lost this season.
        ''' </summary>
        ''' <value>This property gets or sets the Losses field.</value>
        ''' <returns>Returns the number of battlegrounds lost this season.</returns>
        ''' <remarks>This represents the number of battlegrounds lost this season.</remarks>
        Public Property Losses As Integer

        ''' <summary>
        ''' The number of battlegrounds played this season.
        ''' </summary>
        ''' <value>This property gets or sets the Played field.</value>
        ''' <returns>Returns the number of battlegrounds played this season.</returns>
        ''' <remarks>This represents the number of battlegrounds played this season.</remarks>
        Public Property Played As Integer

        ''' <summary>
        ''' The realm the character plays on.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm the character plays on.</returns>
        ''' <remarks>This is a <see cref="Realm" /> object that represents the realm the character plays on.</remarks>
        Public Property Realm As Realm

        ''' <summary>
        ''' The battlegroup the character plays on.
        ''' </summary>
        ''' <value>This property gets or sets the Battlegroup field.</value>
        ''' <returns>Returns the battlegroup the character plays on.</returns>
        ''' <remarks>This is a <see cref="Battlegroup" /> object that represents the battlegroup the character plays on.</remarks>
        Public Property Battlegroup As Battlegroup

        ''' <summary>
        ''' Information about the character.
        ''' </summary>
        ''' <value>This property gets or sets the Character field.</value>
        ''' <returns>Returns information about the character.</returns>
        ''' <remarks>This is a <see cref="Character" /> object that contains further information about the guild member.</remarks>
        Public Property Character As Character

        ''' <summary>
        ''' The date the character was last modified at the server.
        ''' </summary>
        ''' <value>This property gets or sets the LastModified field.</value>
        ''' <returns>Returns the date the character was last modified at the server.</returns>
        ''' <remarks>This date is the time in UTC that the character was last updated on the server.</remarks>
        Public Property LastModified As Date

        Friend Sub New(intRank As Integer, intRating As Integer, intWins As Integer, intLosses As Integer, intPlayed As Integer, rRealm As Realm, bgBattlegroup As Battlegroup, cCharacter As Character, dtLastModified As Date)
            Rank = intRank
            Rating = intRating
            Wins = intWins
            Losses = intLosses
            Played = intPlayed
            Realm = rRealm
            Battlegroup = bgBattlegroup
            Character = cCharacter
            LastModified = dtLastModified
        End Sub

    End Class

End Namespace
