' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class that retrieves item information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about an item.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' The following example demonstrates how to make a call to the API to retrieve an item.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Item;
    ''' 
    ''' namespace ItemExample {
    '''
    '''     public class ItemClass {
    ''' 
    '''         public Item GetItem(int itemID) {
    '''             ItemLookup item = new ItemLookup();
    '''             item.Options.ItemID = itemID;
    '''             item.Load();
    '''             return item.Item;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Item
    ''' 
    ''' Namespace ItemExample
    ''' 
    '''     Public Class ItemClass
    ''' 
    '''         Public Function GetItem(itemID As Integer) As Item
    '''             Dim item As New ItemLookup()
    '''             item.Options.ItemID = itemID
    '''             item.Load()
    '''             Return item.Item
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class ItemLookup
        Inherits WowAPIData

        Private ilItem As New Schema.item

#Region "WowAPIData Overrides"

#Region "Properties"

        ''' <summary>
        ''' The length of time the data should be cached for, defaulting to 30 days for item information.
        ''' </summary>
        ''' <value>This property gets or sets the CacheLength field.</value>
        ''' <returns>Returns the length of time the data should be cached for, defaulting to 30 days for item information.</returns>
        ''' <remarks>The CacheLength is a <see cref="TimeSpan" /> that determines how long an API request should be stored in the cache.  The default can be changed at any time before the <see cref="ItemLookup.Load" /> method is called.</remarks>
        Public Overrides Property CacheLength As New TimeSpan(30, 0, 0, 0)

#Region "Protected"

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.Item.{0}", Options.ItemID)
            End Get
        End Property

        Protected Overrides ReadOnly Property URI As Uri
            Get
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/item/{0}", Options.ItemID), UriKind.Relative)
            End Get
        End Property

#End Region

#End Region

        ''' <summary>
        ''' Loads the item.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into an <see cref="Item" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    ilItem = CType(New DataContractJsonSerializer(GetType(Schema.item)).ReadObject(msJSON), Schema.item)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            iItem = New Item(
                ilItem.id,
                ilItem.disenchantingSkillRank,
                ilItem.description,
                ilItem.name,
                ilItem.icon,
                ilItem.stackable,
                ilItem.allowableClasses.GetClasses(),
                If(ilItem.boundZone Is Nothing, Nothing,
                    New BoundZone(ilItem.boundZone.id, ilItem.boundZone.name)
                    ),
                ilItem.allowableRaces.GetRaces(),
                CType(ilItem.itemBind, Binding),
                If(
                    ilItem.bonusStats.Count = 0, Nothing, (
                        From s In ilItem.bonusStats
                        Select New BonusStats(
                            CType(s.stat, Stat),
                            s.amount
                            )
                        ).ToCollection()
                    ),
                If(
                    ilItem.itemSpells.Count = 0, Nothing, (
                        From s In ilItem.itemSpells
                        Select New ItemSpell(
                            s.spellId,
                            New Spell(
                                s.spell.id,
                                s.spell.name,
                                s.spell.subtext,
                                s.spell.icon,
                                s.spell.description,
                                s.spell.range,
                                s.spell.powerCost,
                                s.spell.castTime,
                                s.spell.cooldown
                                ),
                            s.nCharges,
                            s.consumable,
                            s.categoryId,
                            s.trigger.GetItemSpellTrigger()
                            )
                        ).ToCollection()
                    ),
                ilItem.buyPrice,
                ilItem.itemClass.GetItemClass(),
                ilItem.itemClass.GetItemSubclassForClass(ilItem.itemSubClass),
                ilItem.containerSlots,
                If(ilItem.weaponInfo Is Nothing, Nothing,
                    New WeaponInfo(
                        (
                            From d In ilItem.weaponInfo.damage
                            Select New Damage(
                                d.min,
                                d.max,
                                d.exactMin,
                                d.exactMax
                                )
                            ).ToCollection(),
                        ilItem.weaponInfo.weaponSpeed,
                        ilItem.weaponInfo.dps
                        )
                    ),
                If(ilItem.gemInfo Is Nothing, Nothing,
                    New GemInfo(
                        New Bonus(
                            ilItem.gemInfo.bonus.name,
                            ilItem.gemInfo.bonus.srcItemId,
                            CType(ilItem.gemInfo.bonus.requiredSkillId, Profession),
                            ilItem.gemInfo.bonus.requiredSkillRank,
                            ilItem.gemInfo.bonus.minLevel,
                            ilItem.gemInfo.bonus.itemLevel
                            ),
                        ilItem.gemInfo.type.type,
                        ilItem.gemInfo.minItemLevel
                        )
                    ),
                CType(ilItem.inventoryType, InventoryType),
                ilItem.equippable,
                ilItem.itemLevel,
                If(ilItem.itemSet Is Nothing, Nothing,
                   New ItemSet(
                       ilItem.itemSet.id,
                       ilItem.itemSet.name,
                       If(ilItem.itemSet.setBonuses Is Nothing, Nothing,
                           (
                               From sb In ilItem.itemSet.setBonuses
                               Select New SetBonus(
                                   sb.description,
                                   sb.threshold
                                   )
                               ).ToCollection()
                           ),
                       ilItem.itemSet.items.ToCollection()
                       )
                   ),
                ilItem.maxCount,
                ilItem.maxDurability,
                ilItem.minFactionId,
                CType(ilItem.minReputation, Standing),
                CType(ilItem.quality, Quality),
                ilItem.sellPrice,
                CType(ilItem.requiredSkill, Profession),
                If(ilItem.requiredAbility Is Nothing, Nothing,
                    New RequiredAbility(
                        ilItem.requiredAbility.spellId,
                        ilItem.requiredAbility.name,
                        ilItem.requiredAbility.description
                        )
                    ),
                ilItem.requiredLevel,
                ilItem.requiredSkillRank,
                If(ilItem.socketInfo Is Nothing OrElse ilItem.socketInfo.sockets.Count = 0, Nothing,
                    (
                        From s In ilItem.socketInfo.sockets
                        Select s.type
                        ).ToCollection()
                    ),
                If(ilItem.socketInfo Is Nothing, Nothing, ilItem.socketInfo.socketBonus),
                If(ilItem.itemSource Is Nothing, Nothing,
                    New ItemSource(
                        ilItem.itemSource.sourceId,
                        ilItem.itemSource.sourceType
                        )
                    ),
                ilItem.baseArmor,
                ilItem.hasSockets,
                ilItem.isAuctionable,
                ilItem.armor,
                ilItem.displayInfoId,
                ilItem.nameDescription,
                ilItem.nameDescriptionColor.RgbHexToColor(),
                ilItem.upgradable,
                ilItem.heroicTooltip
                )
        End Sub

#End Region

#Region "Properties"

        ''' <summary>
        ''' The options for looking up an item.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up an item.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New ItemLookupOptions

        Private iItem As Item
        ''' <summary>
        ''' The item returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Item field.</value>
        ''' <returns>Returns item information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is an <see cref="Item" /> object that contains information about the item specified in the <see cref="ItemLookup.Options" />.</remarks>
        Public ReadOnly Property Item As Item
            Get
                Return iItem
            End Get
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' A default constructor to retrieve item information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="ItemLookup" /> class.  You must set the <see cref="ItemLookupOptions.ItemID" /> property of the <see cref="ItemLookup.Options" /> property and then call the <see cref="ItemLookup.Load" /> method to load the item.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve item information for an item from the Blizzard WoW API.
        ''' </summary>
        ''' <param name="intItemID">The item ID to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="ItemLookup" /> class and automatically loads the data for the specified item ID.</remarks>
        Public Sub New(intItemID As Integer)
            Options.ItemID = intItemID
            Load()
        End Sub

#End Region

    End Class

End Namespace
