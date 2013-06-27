' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class that defines options for the character profile lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the realm, name, and other additional fields to look up a character profile. There is no need to create an instance of this class, as the <see cref="CharacterProfile.Options" /> property automatically does so for you.</remarks>
    Public Class CharacterProfileOptions

        ''' <summary>
        ''' The realm the character to lookup resides on.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm the character to lookup resides on.</returns>
        ''' <remarks>This property allows you to set the realm to look up the character profile for.  You may use either the <see cref="LibWowAPI.Realm.Realm.Name" /> or the <see cref="LibWowAPI.Realm.Realm.Slug" />.</remarks>
        Public Property Realm As String

        ''' <summary>
        ''' The name of the character to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the character to lookup.</returns>
        ''' <remarks>This property allows you to set the name of the character to look up.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Determines whether to retrieve the guild the character is in.
        ''' </summary>
        ''' <value>This property gets or sets the Guild field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the guild the character is in.</returns>
        ''' <remarks>When set to true, the API will return information about the character's guild.</remarks>
        Public Property Guild As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's combat statistics.
        ''' </summary>
        ''' <value>This property gets or sets the Stats field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's combat statistics.</returns>
        ''' <remarks>When set to true, the API will return information about the character's combat statistics.</remarks>
        Public Property Stats As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's talent specs.
        ''' </summary>
        ''' <value>This property gets or sets the Talents field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's talent specs.</returns>
        ''' <remarks>When set to true, the API will return information about the character's talent specs.</remarks>
        Public Property Talents As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's equipped items.
        ''' </summary>
        ''' <value>This property gets or sets the Items field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's equipped items.</returns>
        ''' <remarks>When set to true, the API will return information about the character's equipped items.</remarks>
        Public Property Items As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's faction reputations.
        ''' </summary>
        ''' <value>This property gets or sets the Reputation field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's faction reputations.</returns>
        ''' <remarks>When set to true, the API will return information about the character's faction reputations.</remarks>
        Public Property Reputation As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's known titles.
        ''' </summary>
        ''' <value>This property gets or sets the Titles field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's known titles.</returns>
        ''' <remarks>When set to true, the API will return the character's known titles.</remarks>
        Public Property Titles As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's professions.
        ''' </summary>
        ''' <value>This property gets or sets the Professions field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's professions.</returns>
        ''' <remarks>When set to true, the API will return the character's professions.</remarks>
        Public Property Professions As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's appearance.
        ''' </summary>
        ''' <value>This property gets or sets the Appearance field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's appearance.</returns>
        ''' <remarks>When set to true, the API will return information about the character's appearance.</remarks>
        Public Property Appearance As Boolean = False

        ' TODO: Add pets and petSlots
        ' Public Property Companions As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's mounts.
        ''' </summary>
        ''' <value>This property gets or sets the Mounts field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's mounts.</returns>
        ''' <remarks>When set to true, the API will return the character's mounts.</remarks>
        Public Property Mounts As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's hunter pets.
        ''' </summary>
        ''' <value>This property gets or sets the HunterPets field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's hunter pets.</returns>
        ''' <remarks>When set to true, the API will return information about the character's hunter pets.</remarks>
        Public Property HunterPets As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's completed achievements and achievement criteria.
        ''' </summary>
        ''' <value>This property gets or sets the Achievements field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's completed achievements and achievement criteria.</returns>
        ''' <remarks>When set to true, the API will return information about the character's completed achievements and achievement criteria.</remarks>
        Public Property Achievements As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's instance progression.
        ''' </summary>
        ''' <value>This property gets or sets the Progression field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's instance progression.</returns>
        ''' <remarks>When set to true, the API will return information about the character's instance progression.</remarks>
        Public Property Progression As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's PvP statistics.
        ''' </summary>
        ''' <value>This property gets or sets the PvP field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's PvP statistics.</returns>
        ''' <remarks>When set to true, the API will return information about the character's PvP statistics.</remarks>
        Public Property PvP As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's completed quests.
        ''' </summary>
        ''' <value>This property gets or sets the Quests field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's completed quests.</returns>
        ''' <remarks>When set to true, the API will return the character's completed quests.</remarks>
        Public Property Quests As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the character's feed.
        ''' </summary>
        ''' <value>This property gets or sets the Feed field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the character's feed.</returns>
        ''' <remarks>When set to true, the API will return the character's feed.</remarks>
        Public Property Feed As Boolean = False

        Friend Sub New()
        End Sub

    End Class

End Namespace
