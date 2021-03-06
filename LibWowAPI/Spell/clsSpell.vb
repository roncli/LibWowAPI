﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Spell

    ''' <summary>
    ''' A class containing information about a spell.
    ''' </summary>
    ''' <remarks>This class contains details of a spell.</remarks>
    Public Class Spell

        ''' <summary>
        ''' The spell ID number.
        ''' </summary>
        ''' <value>This gets or sets the SpellID field.</value>
        ''' <returns>Returns the spell ID number.</returns>
        ''' <remarks>Each spell has a unique ID number that is used to identify it.</remarks>
        Public Property SpellID As Integer

        ''' <summary>
        ''' The name of the spell.
        ''' </summary>
        ''' <value>This gets or sets the Name field.</value>
        ''' <returns>Returns the name of the spell.</returns>
        ''' <remarks>This is the localized name of the spell.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The spell's subtext.
        ''' </summary>
        ''' <value>This gets or sets the Subtext field.</value>
        ''' <returns>Returns the spell's subtext.</returns>
        ''' <remarks>This is the localized subtext of the spell.</remarks>
        Public Property Subtext As String

        ''' <summary>
        ''' A path leading to the spell's icon on the server.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns a path leading to the spells's icon on the server.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        ''' <summary>
        ''' The description of the spell.
        ''' </summary>
        ''' <value>This gets or sets the Description field.</value>
        ''' <returns>Returns the description of the spell.</returns>
        ''' <remarks>This is the localized description of the spell.</remarks>
        Public Property Description As String

        ''' <summary>
        ''' The spell's range.
        ''' </summary>
        ''' <value>This gets or sets the Range field.</value>
        ''' <returns>Returns the spell's range.</returns>
        ''' <remarks>This is the localized range of the spell.</remarks>
        Public Property Range As String

        ''' <summary>
        ''' Blizzard's internal representation of the power cost of the item.
        ''' </summary>
        ''' <value>This gets or sets the PowerCost field.</value>
        ''' <returns>Returns Blizzard's internal representation of the power cost of the item.</returns>
        ''' <remarks>This represents Blizzard's internal representation of the power cost of the item.</remarks>
        Public Property PowerCost As String

        ''' <summary>
        ''' The cast time of the spell.
        ''' </summary>
        ''' <value>This gets or sets the CastTime field.</value>
        ''' <returns>Returns the cast time of the spell.</returns>
        ''' <remarks>This is the localized cast time of the spell.</remarks>
        Public Property CastTime As String

        ''' <summary>
        ''' The spell's cooldown.
        ''' </summary>
        ''' <value>This gets or sets the Cooldown field.</value>
        ''' <returns>Returns the spell's cooldown.</returns>
        ''' <remarks>This is the localized cooldown of the spell.</remarks>
        Public Property Cooldown As String

        Friend Sub New(intSpellID As Integer, strName As String, strSubtext As String, strIcon As String, strDescription As String, strRange As String, strPowerCost As String, strCastTime As String, strCooldown As String)
            SpellID = intSpellID
            Name = strName
            Subtext = strSubtext
            Icon = strIcon
            Description = strDescription
            Range = strRange
            PowerCost = strPowerCost
            CastTime = strCastTime
            Cooldown = strCooldown
        End Sub

    End Class

End Namespace
