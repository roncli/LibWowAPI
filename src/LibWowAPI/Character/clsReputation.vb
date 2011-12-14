' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's reputation with an NPC faction.
    ''' </summary>
    ''' <remarks>A player may gain reputation with various NPC factions.  This class shows a character's reptuations with these factions.</remarks>
    Public Class Reputation

        ''' <summary>
        ''' The ID number of the faction.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the faction.</returns>
        ''' <remarks>This is a unique value that identifies the faction.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The name of the faction.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the faction.</returns>
        ''' <remarks>This property returns the localized faction name.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The character's standing with the faction.
        ''' </summary>
        ''' <value>This property gets or sets the Standing field.</value>
        ''' <returns>Returns the character's standing with the faction.</returns>
        ''' <remarks>This is a <see cref="Standing" /> enumeration that determines the player's standing with the faction.</remarks>
        Public Property Standing As Standing

        ''' <summary>
        ''' The number of reputation points the character currently has with the faction.
        ''' </summary>
        ''' <value>This property gets or sets the Value field.</value>
        ''' <returns>Returns the number of reputation points the character currently has with the faction.</returns>
        ''' <remarks>This value is the character's current progress through the current <see cref="Reputation.Standing" /> with the faction.</remarks>
        Public Property Value As Integer

        ''' <summary>
        ''' The maximum number of reuptation points the character can earn with this faction before advancing to the next standing.
        ''' </summary>
        ''' <value>This property gets or sets the Max field.</value>
        ''' <returns>Returns the maximum number of reputation points the character can earn with this faction before advancing to the next standing.</returns>
        ''' <remarks>When the character's <see cref="Reputation.Value" /> reaches this value, their <see cref="Reputation.Standing" /> with the faction increses, unless it's already at <see cref="Standing.Exalted" />.</remarks>
        Public Property Max As Integer

        Friend Sub New(intID As Integer, strName As String, sStanding As Standing, intValue As Integer, intMax As Integer)
            ID = intID
            Name = strName
            Standing = sStanding
            Value = intValue
            Max = intMax
        End Sub

    End Class

End Namespace
