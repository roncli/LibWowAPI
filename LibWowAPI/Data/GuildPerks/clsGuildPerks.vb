' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Data.GuildPerks

    ''' <summary>
    ''' A class that retrieves guild perk information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve the list of guild perks from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of guild perks.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.GuildPerks;
    '''
    ''' namespace GuildPerksExample {
    '''
    '''     public class GuildPerksClass {
    '''
    '''         public Collection&lt;Perk&gt; GetGuildPerks() {
    '''             GuildPerks perks = new GuildPerks();
    '''             perks.Load();
    '''             return perks.Perks;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.GuildPerks
    ''' 
    ''' Namespace GuildPerksExample
    ''' 
    '''     Public Class GuildPerksClass
    ''' 
    '''         Public Function GetGuildPerks() As Collection(Of Perk)
    '''             Dim perks As New GuildPerks()
    '''             perks.Load()
    '''             Return perks.Perks
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class GuildPerks
        Inherits WowAPIData

        Private gpPerks As New Schema.perks

#Region "WowAPIData Overrides"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for guild perk information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for guild perk information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="GuildPerks.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.GuildPerks"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/api/wow/data/guild/perks", UriKind.Relative)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the guild perks.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Perk)" /> of <see cref="Perk" />.  Each item in the collection represents a guild perk received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    gpPerks = CType(New DataContractJsonSerializer(GetType(Schema.perks)).ReadObject(msJSON), Schema.perks)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colPerks = (
                From p In gpPerks.perks
                Select New Perk(
                    p.guildLevel,
                    New Spell.Spell(p.spell.id, p.spell.name, p.spell.subtext, p.spell.icon, p.spell.description, p.spell.range, p.spell.powerCost, p.spell.castTime, p.spell.cooldown)
                    )
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colPerks As Collection(Of Perk)
        ''' <summary>
        ''' A list of guild perks as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Perks field.</value>
        ''' <returns>Returns a list of guild perks as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Perk)" /> of <see cref="Perk" />, which is a list of all guild perks.</remarks>
        Public ReadOnly Property Perks As Collection(Of Perk)
            Get
                Return colPerks
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve guild perk information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="GuildPerks" /> class.  You must call the <see cref="GuildPerks.Load" /> method to load the perks.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
