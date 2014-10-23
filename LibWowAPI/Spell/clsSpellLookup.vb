' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding

Namespace roncliProductions.LibWowAPI.Spell

    ''' <summary>
    ''' A class that retrieves spell information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about spells.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve spell information.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Spell;
    ''' 
    ''' namespace SpellLookupExample {
    '''
    '''     public class SpellLookupClass {
    ''' 
    '''         public Spell GetSpell(int spellID) {
    '''             SpellLookup lookup = new SpellLookup();
    '''             lookup.Options.SpellID(spellID);
    '''             lookup.Load();
    '''             return lookup.Spell;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Spell
    ''' 
    ''' Namespace SpellLookupExample
    ''' 
    '''     Public Class SpellLookupClass
    ''' 
    '''         Public Function GetSpell(spellID As Integer) As Spell
    '''             Dim lookup As New SpellLookup()
    '''             lookup.Options.SpellID(spellID)
    '''             lookup.Load()
    '''             Return lookup.Spell
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class SpellLookup
        Inherits WowAPIData

        Private slSpell As New Schema.spell

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for spell information.
        ''' </summary>
        ''' <value>This property gets or sets CacheLength.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for spell information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache.  The default can be changed at any time before the <see cref="SpellLookup.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/wow/spell/{0}", Options.SpellID), UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.SpellLookup.{0}", Options.SpellID)
            End Get
        End Property

#End Region

        Private Overloads Property IfModifiedSince As Date

#End Region

        ''' <summary>
        ''' Loads the spell.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Spell" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    slSpell = CType(New DataContractJsonSerializer(GetType(Schema.spell)).ReadObject(msJSON), Schema.spell)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try
            sSpell = New Spell(
                slSpell.id,
                slSpell.name,
                slSpell.subtext,
                slSpell.icon,
                slSpell.description,
                slSpell.range,
                slSpell.powerCost,
                slSpell.castTime,
                slSpell.cooldown
                )
        End Sub

#End Region

#Region "Properties"

#Region "Public"

        ''' <summary>
        ''' The options for looking up spell information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up spell information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New SpellLookupOptions

        Private sSpell As Spell
        ''' <summary>
        ''' The spell information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Spell field.</value>
        ''' <returns>Returns the spell information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is an <see cref="Spell" /> object that contains information about the spell specified in the <see cref="SpellLookup.Options" />.</remarks>
        Public ReadOnly Property Spell As Spell
            Get
                Return sSpell
            End Get
        End Property

#End Region

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve spell information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="SpellLookup" /> class.  You must call the <see cref="SpellLookup.Load" /> method to load the spell information.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve spell information for a spell ID.
        ''' </summary>
        ''' <param name="intSpellID">The spell ID to lookup information for.</param>
        ''' <remarks>This method creates a new instance of the <see cref="SpellLookup" /> class and automatically loads the data for the specified spell ID.</remarks>
        Public Sub New(intSpellID As Integer)
            Options.SpellID = intSpellID
            Load()
        End Sub

#End Region

    End Class

End Namespace
