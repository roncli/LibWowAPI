' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Achievements

    ''' <summary>
    ''' A class that defines options for the achievement lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the achievement ID to look up an achievement. There is no need to create an instance of this class, as the <see cref="AchievementLookup.Options" /> property automatically does so for you.</remarks>
    Public Class AchievementLookupOptions

        ''' <summary>
        ''' The achievement ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the AchievementID field.</value>
        ''' <returns>Returns the achievement ID to lookup.</returns>
        ''' <remarks>This represents the achievement ID to lookup.</remarks>
        Public Property AchievementID As Integer

        Friend Sub New()
        End Sub

    End Class

End Namespace
