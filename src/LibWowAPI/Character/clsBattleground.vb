' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about statistics about one of a character's rated battlegrounds.
    ''' </summary>
    ''' <remarks>Statistics for each rated battleground is kept for each character and can be accessed through this class.</remarks>
    Public Class Battleground

        ''' <summary>
        ''' The name of the battleground.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the battleground.</returns>
        ''' <remarks>This property identifies which battleground the statistics are for.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The number of times the character played in this battleground.
        ''' </summary>
        ''' <value>This property gets or sets the Played field.</value>
        ''' <returns>Returns the number of times the character played in this battleground.</returns>
        ''' <remarks>This can be used along with the <see cref="Battleground.Won" /> property to determine a winning percentage.</remarks>
        Public Property Played As Integer

        ''' <summary>
        ''' The number of times the character won this battleground.
        ''' </summary>
        ''' <value>This property gets or sets the Won field.</value>
        ''' <returns>Returns the number of times the character won this battleground.</returns>
        ''' <remarks>This can be used along with the <see cref="Battleground.Played" /> property to determine a winning percentage.</remarks>
        Public Property Won As Integer

        Friend Sub New(strName As String, intPlayed As Integer, intWon As Integer)
            Name = strName
            Played = intPlayed
            Won = intWon
        End Sub

    End Class

End Namespace
