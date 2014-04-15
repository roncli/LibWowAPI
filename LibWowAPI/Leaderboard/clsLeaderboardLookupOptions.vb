' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Leaderboard

    ''' <summary>
    ''' A class that defines options for the leaderboard lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the realms to look up leaderboard information for. There is no need to create an instance of this class, as the <see cref="LeaderboardLookup.Options" /> property automatically does so for you.</remarks>
    Public Class LeaderboardLookupOptions

        ''' <summary>
        ''' The leaderboard type to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the Type field.</value>
        ''' <returns>Returns the leaderboard type to lookup.</returns>
        ''' <remarks>This is a <see cref="LeaderboardType" /> enumeration that represents the leaderboard type to lookup.</remarks>
        Public Property Type As LeaderboardType

        Friend Sub New()
        End Sub

    End Class

End Namespace
