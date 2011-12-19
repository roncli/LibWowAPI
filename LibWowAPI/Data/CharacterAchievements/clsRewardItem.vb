' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Data.CharacterAchievements

    ''' <summary>
    ''' A class containing information about a reward item from an achievement.
    ''' </summary>
    ''' <remarks>This class contains some of the information about an item received as a reward from an achievement.</remarks>
    Public Class RewardItem

        ''' <summary>
        ''' The item ID number.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the item ID number.</returns>
        ''' <remarks>Each item has its own ID number and can be used in the <see cref="LibWowAPI.Item.ItemLookup" /> class to get more detail about the item.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The name of the item.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the item.</returns>
        ''' <remarks>This is the localized name of the item.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' A path leading to the item's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the item's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The quality of the item.
        ''' </summary>
        ''' <value>This property gets or sets the Quality field.</value>
        ''' <returns>Returns the quality of the item.</returns>
        ''' <remarks>This is a <see cref="Enums.Quality" /> enumeration that describes the quality of the item.</remarks>
        Public Property Quality As Quality

        Friend Sub New(intID As Integer, strName As String, strIcon As String, qQuality As Quality)
            ID = intID
            Name = strName
            Icon = strIcon
            Quality = qQuality
        End Sub

    End Class

End Namespace
