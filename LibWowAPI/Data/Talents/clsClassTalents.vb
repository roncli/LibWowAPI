' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Data.Talents

    ''' <summary>
    ''' A class that retrieves class talent information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve the list of class talents and glyphs from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve the list of class talents.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Data.Talents;
    '''
    ''' namespace TalentsExample {
    '''
    '''     public class TalentsClass {
    '''
    '''         public Collection&lt;Talents&gt; GetTalents() {
    '''             ClassTalents talents = new ClassTalents();
    '''             talents.Load();
    '''             return talents.Talents;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Data.Talents
    ''' 
    ''' Namespace TalentsExample
    ''' 
    '''     Public Class TalentsClass
    ''' 
    '''         Public Function GetTalents() As Collection(Of Talents)
    '''             Dim talents As New ClassTalents()
    '''             talents.Load()
    '''             Return talents.Talents
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class ClassTalents
        Inherits WowAPIData

        Private tTalents As New Dictionary(Of String, Schema.talents)

#Region "WowAPIData Overrides"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for class talents information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for class talents information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="ClassTalents.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected Properties"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return "LibWowAPI.ClassTalents"
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri("/api/wow/data/talents", UriKind.Relative)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the class talents.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Collection(Of Talents)" /> of <see cref="Talents" />.  Each item in the collection represents talents for a specific class received from the API.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If

            Dim dcjssSettings As New DataContractJsonSerializerSettings()
            dcjssSettings.UseSimpleDictionaryFormat = True

            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    tTalents = CType(New DataContractJsonSerializer(GetType(Dictionary(Of String, Schema.talents)), dcjssSettings).ReadObject(msJSON), Dictionary(Of String, Schema.talents))
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            colTalents = (
                From t In tTalents
                Select New Talents(
                    CInt(t.Key),
                    If(
                        t.Value.petSpecs Is Nothing, Nothing, (
                            From p In t.Value.petSpecs
                            Order By p.order
                            Select New Spec(
                                p.name,
                                p.role,
                                p.backgroundImage,
                                p.icon,
                                p.description,
                                p.order
                                )
                            ).ToCollection()
                        ),
                    (
                        From g In t.Value.glyphs
                        Select New Glyph(
                            g.glyph,
                            g.item,
                            g.name,
                            g.icon,
                            g.typeId
                            )
                        ).ToCollection(),
                    (
                        From ta In t.Value.talents
                        Order By ta(0).tier
                        Select New TalentTier(
                            ta(0).tier,
                            (
                                From tal In ta
                                Order By tal.column
                                Select New Talent(
                                    tal.tier,
                                    tal.column,
                                    New Spell.Spell(
                                        tal.spell.id,
                                        tal.spell.name,
                                        tal.spell.subtext,
                                        tal.spell.icon,
                                        tal.spell.description,
                                        tal.spell.range,
                                        tal.spell.powerCost,
                                        tal.spell.castTime,
                                        tal.spell.cooldown
                                        )
                                    )
                                ).ToCollection()
                            )
                        ).ToCollection(),
                    t.Value.class,
                    (
                        From s In t.Value.specs
                        Order By s.order
                        Select New Spec(
                            s.name,
                            s.role,
                            s.backgroundImage,
                            s.icon,
                            s.description,
                            s.order
                            )
                        ).ToCollection()
                    )
                ).ToCollection()
        End Sub

#End Region

#Region "Properties"

        Private colTalents As Collection(Of Talents)
        ''' <summary>
        ''' A list of class talents as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Talents field.</value>
        ''' <returns>Returns a list of class talents as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Talents)" /> of <see cref="Talents" />, which is a list of class talents.</remarks>
        Public ReadOnly Property Talents As Collection(Of Talents)
            Get
                Return colTalents
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve class talents information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="ClassTalents" /> class.  You must call the <see cref="ClassTalents.Load" /> method to load the class talents.</remarks>
        Public Sub New()
        End Sub

#End Region

    End Class

End Namespace
