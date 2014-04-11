' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Challenge

    ''' <summary>
    ''' A class containing information about a challenge mode map.
    ''' </summary>
    ''' <remarks>This class contains information about a challenge mode map.</remarks>
    Public Class Map

        ''' <summary>
        ''' The ID number of the map.
        ''' </summary>
        ''' <value>This property gets or sets the ID field.</value>
        ''' <returns>Returns the ID number of the map.</returns>
        ''' <remarks>Each map has a unique ID number that is used to identify the map.</remarks>
        Public Property ID As Integer

        ''' <summary>
        ''' The name of the map.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the map.</returns>
        ''' <remarks>This represents the localized name of the map.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Blizzard's internal name for the map.
        ''' </summary>
        ''' <value>This property gets or sets the Slug field.</value>
        ''' <returns>Returns Blizzard's internal name for the map.</returns>
        ''' <remarks>This represents Blizzard's internal name for the map.</remarks>
        Public Property Slug As String

        ''' <summary>
        ''' Determines whether the map has a challenge mode.
        ''' </summary>
        ''' <value>This property gets or sets the HasChallengeMode field.</value>
        ''' <returns>Returns whether the map has a challenge mode.</returns>
        ''' <remarks>This determines whether the map has a challenge mode.</remarks>
        Public Property HasChallengeMode As Boolean

        ''' <summary>
        ''' The time limit to receive a bronze medal for this map's challenge mode.
        ''' </summary>
        ''' <value>This property gets or sets the BronzeCriteria field.</value>
        ''' <returns>Returns the time limit to receive a bronze medal for this map's challenge mode.</returns>
        ''' <remarks>This represents the time limit to recieve a bronze medal for this map's challenge mode.</remarks>
        Public Property BronzeCriteria As TimeSpan

        ''' <summary>
        ''' The time limit to receive a silver medal for this map's challenge mode.
        ''' </summary>
        ''' <value>This property gets or sets the SilverCriteria field.</value>
        ''' <returns>Returns the time limit to receive a silver medal for this map's challenge mode.</returns>
        ''' <remarks>This represents the time limit to recieve a silver medal for this map's challenge mode.</remarks>
        Public Property SilverCriteria As TimeSpan

        ''' <summary>
        ''' The time limit to receive a gold medal for this map's challenge mode.
        ''' </summary>
        ''' <value>This property gets or sets the GoldCriteria field.</value>
        ''' <returns>Returns the time limit to receive a gold medal for this map's challenge mode.</returns>
        ''' <remarks>This represents the time limit to recieve a gold medal for this map's challenge mode.</remarks>
        Public Property GoldCriteria As TimeSpan

        Public Sub New(intID As Integer, strName As String, strSlug As String, blnHasChallengeMode As Boolean, tsBronzeCriteria As TimeSpan, tsSilverCriteria As TimeSpan, tsGoldCriteria As TimeSpan)
            ID = intID
            Name = strName
            Slug = strSlug
            HasChallengeMode = blnHasChallengeMode
            BronzeCriteria = tsBronzeCriteria
            SilverCriteria = tsSilverCriteria
            GoldCriteria = tsGoldCriteria
        End Sub

    End Class

End Namespace
