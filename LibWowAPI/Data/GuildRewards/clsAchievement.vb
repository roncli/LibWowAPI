﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Data.GuildRewards

    ''' <summary>
    ''' A class containing information about a guild achievement required for a guild reward.
    ''' </summary>
    ''' <remarks>This class represents the guild achievement required to obtain a guild reward.</remarks>
    Public Class Achievement

        ''' <summary>
        ''' The ID number of the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the guild achievement.</returns>
        ''' <remarks>Each guild achievement has a unique ID number that identifies the achievement.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The title of the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Title field.</value>
        ''' <returns>Returns the title of the guild achievement.</returns>
        ''' <remarks>This is the localized title of the guild achievement.</remarks>
        Public Property Title As String

        ''' <summary>
        ''' The number of guild achievement points earned by completing this guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Points field.</value>
        ''' <returns>Returns the number of guild achievement points earned by completing this guild achievement.</returns>
        ''' <remarks>Each successfully completed guild achievement earns a set number of guild achievement points for the guild.</remarks>
        Public Property Points As Integer

        ''' <summary>
        ''' The description of the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Description field.</value>
        ''' <returns>Returns the description of the guild achievement.</returns>
        ''' <remarks>This is the localized description of the guild achievement.</remarks>
        Public Property Description As String

        ''' <summary>
        ''' The reward offered by the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Reward field.</value>
        ''' <returns>Returns the reward offered by the guild achievement.</returns>
        ''' <remarks>This is the reward received for completing the guild achievement.  This is not localized.</remarks>
        Public Property Reward As String

        Private colRewardItems As Collection(Of RewardItem)
        ''' <summary>
        ''' The items obtained as a reward for completing the guild achievement.
        ''' </summary>
        ''' <value>This property gets or sets the RewardItem field.</value>
        ''' <returns>Returns the items obtained as a reward for completing the guild achievement.</returns>
        ''' <remarks>This is a <see cref="Collection(Of RewardItem)" /> of <see cref="RewardItem" /> that contains details about the items received for completing the guild achievement.</remarks>
        Public ReadOnly Property RewardItems As Collection(Of RewardItem)
            Get
                Return colRewardItems
            End Get
        End Property

        ''' <summary>
        ''' The icon of the achievement.
        ''' </summary>
        ''' <value>This property gets or sets the Icon field.</value>
        ''' <returns>Returns the icon of the achievement.</returns>
        ''' <remarks>The icon is stored on the server under the path http://<i>Base URL</i>/wow/icons/<i>size</i>/<i>Icon</i>.jpg.  The Base URL is <i>region</i>.media.blizzard.com, except in China, where it is content.battlenet.com.cn.  The size can be one of 18, 36, or 56.</remarks>
        Public Property Icon As String

        Private colCriteria As Collection(Of Criteria)
        ''' <summary>
        ''' The criteria required to complete the achievement.
        ''' </summary>
        ''' <value>This property gets the Criteria field.</value>
        ''' <returns>Returns the criteria required to complete the achievement.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Criteria)" /> of <see cref="Criteria" /> which represents a list of criteria required to complete the achievement.</remarks>
        Public ReadOnly Property Criteria As Collection(Of Criteria)
            Get
                Return colCriteria
            End Get
        End Property

        ''' <summary>
        ''' Determines whether the achievement is account-wide.
        ''' </summary>
        ''' <value>This property gets or sets the AccountWide field.</value>
        ''' <returns>Returns whether the achievement is account-wide.</returns>
        ''' <remarks>This represents whether the achievement is account-wide.</remarks>
        Public Property AccountWide As Boolean

        Friend Sub New(intID As Integer, strTitle As String, intPoints As Integer, strDescription As String, strReward As String, riRewardItems As Collection(Of RewardItem), strIcon As String, cCriteria As Collection(Of Criteria), blnAccountWide As Boolean)
            ID = intID
            Title = strTitle
            Points = intPoints
            Description = strDescription
            Reward = strReward
            colRewardItems = riRewardItems
            Icon = strIcon
            colCriteria = cCriteria
            AccountWide = blnAccountWide
        End Sub

    End Class

End Namespace
