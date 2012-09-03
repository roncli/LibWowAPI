' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Guild

    ''' <summary>
    ''' A class that defines options for the guild profile lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the realm, name, and other additional fields to look up a guild profile. There is no need to create an instance of this class, as the <see cref="GuildProfile.Options" /> property automatically does so for you.</remarks>
    Public Class GuildProfileOptions

        ''' <summary>
        ''' The realm the guild to lookup resides on.
        ''' </summary>
        ''' <value>This property gets or sets the Realm field.</value>
        ''' <returns>Returns the realm the guild to lookup resides on.</returns>
        ''' <remarks>This property allows you to set the realm to look up the guild profile for.  You may use either the <see cref="LibWowAPI.Realm.Realm.Name" /> or the <see cref="LibWowAPI.Realm.Realm.Slug" />.</remarks>
        Public Property Realm As String

        ''' <summary>
        ''' The name of the guild to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the guild to lookup.</returns>
        ''' <remarks>This property allows you to set the name of the guild to look up.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Determines whether to retrieve the list of members in the guild upon guild lookup.
        ''' </summary>
        ''' <value>This property gets or sets the Members field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the list of members in the guild upon guild lookup.</returns>
        ''' <remarks>When set to true, the API will return a list of the guild's members.</remarks>
        Public Property Members As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the guild's achievements upon guild lookup.
        ''' </summary>
        ''' <value>This property gets or sets the Achievements field.</value>
        ''' <returns>Returns a boolean that determines whether to retrieve the guild's achievements upon guild lookup.</returns>
        ''' <remarks>When set to true, the API will return information about the guild's completed guild achievements and guild achievement criteria.</remarks>
        Public Property Achievements As Boolean = False

        ''' <summary>
        ''' Determines whether to retrieve the guild's news feed upon guild lookup.
        ''' </summary>
        ''' <value>This property gets or sets the News field.</value>
        ''' <returns>Returns a boolean that determines</returns>
        ''' <remarks></remarks>
        Public Property News As Boolean = False

        Friend Sub New()
        End Sub

    End Class

End Namespace
