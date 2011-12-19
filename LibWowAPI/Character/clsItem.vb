' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about an equipped item.
    ''' </summary>
    ''' <remarks>This class has basic information about an equipped item.  More detailed information about the item can be found by taking the <see cref="Item.ID" /> property and using it in the <see cref="LibWowAPI.Item.ItemLookup" /> class.</remarks>
    Public Class Item

        ''' <summary>
        ''' The ID number of the item.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the item.</returns>
        ''' <remarks>Each item has its own ID number and can be used in the <see cref="LibWowAPI.Item.ItemLookup" /> class to get more detail about the item.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The name of the item.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the item.</returns>
        ''' <remarks>This is the name of the item, including any random enchantment suffix.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' A path leading to the item's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the item's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The item's quality.
        ''' </summary>
        ''' <value>This property gets or sets the Quality field.</value>
        ''' <returns>Returns the item's quality.</returns>
        ''' <remarks>This is a <see cref="Enums.Quality" /> enumeration indicating the quality of the item.</remarks>
        Public Property Quality As Quality

        ''' <summary>
        ''' Parameters belonging to this specific instance of the item.
        ''' </summary>
        ''' <value>This property gets or sets the TooltipParams field.</value>
        ''' <returns>Returns parameters belonging to this specific instance of the item.</returns>
        ''' <remarks>This is a <see cref="TooltipParams" /> object that describes extra parameters specific to this instance of the item.</remarks>
        Public Property TooltipParams As TooltipParams

        Friend Sub New(intID As Integer, strName As String, strIcon As String, qQuality As Quality, tpTooltipParams As TooltipParams)
            ID = intID
            Name = strName
            Icon = strIcon
            Quality = qQuality
            TooltipParams = tpTooltipParams
        End Sub

    End Class

End Namespace
