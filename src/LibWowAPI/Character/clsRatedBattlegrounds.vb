' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's rated battleground statistics.
    ''' </summary>
    ''' <remarks>Statistics about the character's performance in each rated battleground can be found here.</remarks>
    Public Class RatedBattlegrounds

        ''' <summary>
        ''' The character's personal rated battleground rating.
        ''' </summary>
        ''' <value>This property gets or sets the PersonalRating field.</value>
        ''' <returns>Returns the character's personal rated battleground rating.</returns>
        ''' <remarks>Each character has a personal rating in rated battlegrounds that can be used to compare their performance to other players.</remarks>
        Public Property PersonalRating As Integer

        Private colBattlegrounds As Collection(Of Battleground)
        ''' <summary>
        ''' Statistics for each individual battleground.
        ''' </summary>
        ''' <value>This property gets the Battlegrounds field.</value>
        ''' <returns>Returns statistics for each individual battleground.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Battleground)" /> of <see cref="Battleground" /> that contains information about a character's performance in each battleground.</remarks>
        Public ReadOnly Property Battlegrounds As Collection(Of Battleground)
            Get
                Return colBattlegrounds
            End Get
        End Property

        Friend Sub New(intPersonalRating As Integer, bBattlegrounds As Collection(Of Battleground))
            PersonalRating = intPersonalRating
            colBattlegrounds = bBattlegrounds
        End Sub

    End Class

End Namespace
