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

Namespace roncliProductions.LibWowAPI.BattlePet

    ''' <summary>
    ''' A class that looks up information for a single battle pet ability from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>This data class provides a way to retrieve information for a single battle pet ability from the API.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve a battle pet ability.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.BattlePets;
    '''
    ''' namespace AbilityExample {
    '''
    '''     public class AbilityClass {
    '''
    '''         public Ability GetAbility(int abilityID) {
    '''             BattlePetAbility ability = new BattlePetAbility();
    '''             ability.Options.AbilityID = abilityID;
    '''             ability.Load();
    '''             return ability.Ability;
    '''         }
    '''
    '''     }
    '''
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.BattlePets
    ''' 
    ''' Namespace AbilityExample
    ''' 
    '''     Public Class AbilityClass
    ''' 
    '''         Public Function GetAbility(abilityID As Integer) As Ability
    '''             Dim ability As New BattlePetAbility()
    '''             ability.Options.AbilityID = abilityID
    '''             ability.Load()
    '''             Return ability.Ability
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class BattlePetAbility
        Inherits WowAPIData

        Private bpaAbility As New Schema.ability

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for battle pet ability information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for battle pet ability information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache. The default can be changed at any time before the <see cref="BattlePetAbility.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.BattlePetAbility.{0}", Options.AbilityID)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/battlePet/ability/{0}", Options.AbilityID), UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the battle pet ability.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into an <see cref="Ability" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    bpaAbility = CType(New DataContractJsonSerializer(GetType(Schema.ability)).ReadObject(msJSON), Schema.ability)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            aAbility = New Ability(
                bpaAbility.id,
                bpaAbility.name,
                bpaAbility.icon,
                bpaAbility.cooldown,
                bpaAbility.rounds,
                bpaAbility.petTypeId,
                bpaAbility.isPassive,
                bpaAbility.hideHints
                )
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up a battle pet ability.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up a battle pet ability.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New BattlePetAbilityOptions

        Private aAbility As Ability
        ''' <summary>
        ''' The battle pet ability returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Ability field.</value>
        ''' <returns>Returns battle pet ability information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is an <see cref="Ability" /> object that contains information about the battle pet ability specified in the <see cref="BattlePetAbility.Options" />.</remarks>
        Public ReadOnly Property Ability As Ability
            Get
                Return aAbility
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve information for a single battle pet ability from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="BattlePetAbility" /> class.  You must call the <see cref="BattlePetAbility.Load" /> method to load a battle pet ability.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve information for a single battle pet ability from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="intAbilityID">The ability ID to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="BattlePetAbility" /> class and automatically loads the data for the specified battle pet ability ID.</remarks>
        Public Sub New(intAbilityID As Integer)
            Options.AbilityID = intAbilityID
            Load()
        End Sub

#End Region

    End Class

End Namespace
