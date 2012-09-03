' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class containing information about a spec.
    ''' </summary>
    ''' <remarks>This contains basic information about a spec.</remarks>
    Public Class Spec

        ''' <summary>
        ''' The name of the spec.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the spec.</returns>
        ''' <remarks>This represents the name of the spec.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The role of the spec.
        ''' </summary>
        ''' <value>This property gets or sets the Role field.</value>
        ''' <returns>Returns the role of the spec.</returns>
        ''' <remarks>This will be one of "DPS", "HEALING", or "TANK".</remarks>
        Public Property Role As String

        ''' <summary>
        ''' The background image for the spec.
        ''' </summary>
        ''' <value>This property gets or sets the BackgroundImage field.</value>
        ''' <returns>Returns the background image for the spec.</returns>
        ''' <remarks>It is currently unknown where this is used.</remarks>
        Public Property BackgroundImage As String

        ''' <summary>
        ''' The icon for the spec.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns the icon for the spec.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The description of the spec.
        ''' </summary>
        ''' <value>This property gets or sets the Description field.</value>
        ''' <returns>Returns the description of the spec.</returns>
        ''' <remarks>This is only used for player specs.  For pet specs, this returns an empty string.</remarks>
        Public Property Description As String

        ''' <summary>
        ''' The order the spec is displayed in relation to the other specs.
        ''' </summary>
        ''' <value>This property gets or sets the Order field.</value>
        ''' <returns>Returns the order the spec is displayed in relation to the other specs.</returns>
        ''' <remarks>This represents the order the spec is displayed in relation to the other specs.</remarks>
        Public Property Order As Integer

        Friend Sub New(strName As String, strRole As String, strBackgroundImage As String, strIcon As String, strDescription As String, intOrder As Integer)
            Name = strName
            Role = strRole
            BackgroundImage = strBackgroundImage
            Icon = strIcon
            Description = strDescription
            Order = intOrder
        End Sub

    End Class

End Namespace
