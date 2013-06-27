' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about a character's mount.
    ''' </summary>
    ''' <remarks>This class contains information about the character's mount.</remarks>
    Public Class Mount

        ''' <summary>
        ''' The name of the mount.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the mount.</returns>
        ''' <remarks>This represents the name of the mount.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The spell ID of the mount.
        ''' </summary>
        ''' <value>This property gets or sets the SpellID field.</value>
        ''' <returns>Returns the spell ID of the mount.</returns>
        ''' <remarks>This represents the spell ID of the mount.</remarks>
        Public Property SpellID As Integer

        ''' <summary>
        ''' The creature ID of the mount.
        ''' </summary>
        ''' <value>This property gets or sets the CreatureID field.</value>
        ''' <returns>Returns the creature ID of the mount.</returns>
        ''' <remarks>This represents the creature ID of the mount.</remarks>
        Public Property CreatureID As Integer

        ''' <summary>
        ''' The item ID of the mount.
        ''' </summary>
        ''' <value>This property gets or sets the ItemID field.</value>
        ''' <returns>Returns the item ID of the mount.</returns>
        ''' <remarks>This represents the item ID of the mount.</remarks>
        Public Property ItemID As Integer

        ''' <summary>
        ''' The quality of the mount.
        ''' </summary>
        ''' <value>This property gets or sets the Quality field.</value>
        ''' <returns>Returns the quality of the mount.</returns>
        ''' <remarks>This represents the quality of the mount.</remarks>
        Public Property Quality As Quality

        ''' <summary>
        ''' A path leading to the mount's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the mount's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' Indicates whether this is a ground mount.
        ''' </summary>
        ''' <value>This property gets or sets the IsGround field.</value>
        ''' <returns>Returns whether this is a ground mount.</returns>
        ''' <remarks>This represents whether this is a ground mount.</remarks>
        Public Property IsGround As Boolean

        ''' <summary>
        ''' Indicates whether this is a flying mount.
        ''' </summary>
        ''' <value>This property gets or sets the IsFlying field.</value>
        ''' <returns>Returns whether this is a flying mount.</returns>
        ''' <remarks>This represents whether this is a flying mount.</remarks>
        Public Property IsFlying As Boolean

        ''' <summary>
        ''' Indicates whether this is a aquatic mount.
        ''' </summary>
        ''' <value>This property gets or sets the IsAquatic field.</value>
        ''' <returns>Returns whether this is a aquatic mount.</returns>
        ''' <remarks>This represents whether this is a aquatic mount.</remarks>
        Public Property IsAquatic As Boolean

        ''' <summary>
        ''' Indicates whether this is a jumping mount.
        ''' </summary>
        ''' <value>This property gets or sets the IsJumping field.</value>
        ''' <returns>Returns whether this is a jumping mount.</returns>
        ''' <remarks>This represents whether this is a jumping mount.</remarks>
        Public Property IsJumping As Boolean

        Friend Sub New(strName As String, intSpellID As Integer, intCreatureID As Integer, intItemID As Integer, qQuality As Quality, strIcon As String, blnIsGround As Boolean, blnIsFlying As Boolean, blnIsAquatic As Boolean, blnIsJumping As Boolean)
            Name = strName
            SpellID = intSpellID
            CreatureID = intCreatureID
            ItemID = intItemID
            Quality = qQuality
            Icon = strIcon
            IsGround = blnIsGround
            IsFlying = blnIsFlying
            IsAquatic = blnIsAquatic
            IsJumping = blnIsJumping
        End Sub

    End Class

End Namespace

