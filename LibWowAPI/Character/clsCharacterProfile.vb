' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Text.Encoding
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Extensions

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class that retrieves character profile information from the Blizzard WoW API.
    ''' </summary>
    ''' <remarks>The Blizzard API provides detailed information about a character.  This class can be used to retrieve that data.</remarks>
    ''' <example>
    ''' There are more than a dozen boolean options that can retrieve more information about the character.  See the <see cref="CharacterProfileOptions" /> class for a complete list.  The following example demonstrates how to make a call to the API to retrieve a character profile, using some of these options.
    ''' <code>
    ''' using roncliProductions.LibWowAPI.Character;
    ''' 
    ''' namespace CharacterExample {
    '''
    '''     public class CharacterClass {
    ''' 
    '''         public Character GetCharacter(string realm, string name) {
    '''             CharacterProfile character = new CharacterProfile();
    '''             character.Options.Realm = realm;
    '''             character.Options.Name = name;
    '''             character.Options.Guild = true;
    '''             character.Options.Achievements = true;
    '''             character.Options.PvP = true;
    '''             character.Load();
    '''             return character.Character;
    '''         }
    ''' 
    '''     }
    ''' 
    ''' }
    ''' </code>
    ''' <code lang="vbnet">
    ''' Imports roncliProductions.LibWowAPI.Character
    ''' 
    ''' Namespace CharacterExample
    ''' 
    '''     Public Class CharacterClass
    ''' 
    '''         Public Function GetCharacter(realm As String, name As String) As Character
    '''             Dim character As New CharacterProfile()
    '''             character.Options.Realm = realm
    '''             character.Options.Name = name
    '''             character.Options.Guild = True
    '''             character.Options.Achievements = True
    '''             character.Options.PvP = True
    '''             character.Load()
    '''             Return character.Character
    '''         End Function
    ''' 
    '''     End Class
    ''' 
    ''' End Namespace
    ''' </code>
    ''' </example>
    Public NotInheritable Class CharacterProfile
        Inherits WowAPIData

        Private cpCharacter As New Schema.character

#Region "WowAPIData Overrides"

#Region "Protected"

        Protected Overrides ReadOnly Property URI As Uri
            Get
                QueryString.Clear()
                If Not String.IsNullOrWhiteSpace(FieldList) Then
                    QueryString.Add("fields", FieldList)
                End If
                Return New Uri(String.Format(CultureInfo.InvariantCulture, "/api/wow/character/{0}/{1}", Options.Realm, Options.Name), UriKind.Relative)
            End Get
        End Property

        Protected Overrides ReadOnly Property CacheKey As String
            Get
                Return String.Format(CultureInfo.InvariantCulture, "LibWowAPI.CharacterProfile.{0}.{1}.{2}", Options.Realm, Options.Name, FieldList)
            End Get
        End Property

#End Region

        ''' <summary>
        ''' Loads the character profile.
        ''' </summary>
        ''' <remarks>This method calls the Blizzard WoW API, receives the JSON, and translates it into a <see cref="Character" /> object.</remarks>
        ''' <exception cref="LibWowAPIException">If the JSON received from the API is invalid, the exception that caused it is packaged into the <see cref="LibWowAPIException.InnerException" /> of a <see cref="LibWowAPIException" />.</exception>
        Public Overrides Sub Load()
            MyBase.Retrieve()
            If Modified.HasValue AndAlso Not Modified Then
                Return
            End If
            Try
                Using msJSON As New MemoryStream(Unicode.GetBytes(Data))
                    cpCharacter = CType(New DataContractJsonSerializer(GetType(Schema.character)).ReadObject(msJSON), Schema.character)
                End Using
            Catch sex As SerializationException
                Throw New LibWowAPIException("The data returned by the Armory is invalid.", sex)
            End Try

            ' TODO: Add pets and petSlots
            cCharacter = New Character(
                cpCharacter.lastModified.BlizzardTimestampToUTC(),
                cpCharacter.name,
                cpCharacter.realm,
                cpCharacter.battlegroup,
                cpCharacter.class.GetClass(),
                cpCharacter.race.GetRace(),
                CType(cpCharacter.gender, Gender),
                cpCharacter.level,
                cpCharacter.achievementPoints,
                cpCharacter.thumbnail,
                cpCharacter.calcClass,
                If(cpCharacter.guild Is Nothing, Nothing,
                    New Guild(
                        cpCharacter.guild.name,
                        cpCharacter.guild.realm,
                        cpCharacter.guild.battlegroup,
                        cpCharacter.guild.level,
                        cpCharacter.guild.members,
                        cpCharacter.guild.achievementPoints,
                        New Emblem(
                            cpCharacter.guild.emblem.icon,
                            cpCharacter.guild.emblem.iconColor.ArgbHexToColor(),
                            cpCharacter.guild.emblem.border,
                            cpCharacter.guild.emblem.borderColor.ArgbHexToColor(),
                            cpCharacter.guild.emblem.backgroundColor.ArgbHexToColor()
                            )
                        )
                    ),
                If(cpCharacter.items Is Nothing, Nothing,
                    New Items(
                        cpCharacter.items.averageItemLevel,
                        cpCharacter.items.averageItemLevelEquipped,
                        If(cpCharacter.items.head Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.head.id,
                                cpCharacter.items.head.name,
                                cpCharacter.items.head.icon,
                                CType(cpCharacter.items.head.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.head.tooltipParams.gem0, cpCharacter.items.head.tooltipParams.gem1, cpCharacter.items.head.tooltipParams.gem2),
                                    cpCharacter.items.head.tooltipParams.suffix,
                                    cpCharacter.items.head.tooltipParams.seed,
                                    cpCharacter.items.head.tooltipParams.enchant,
                                    cpCharacter.items.head.tooltipParams.extraSocket,
                                    If(cpCharacter.items.head.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.head.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.head.tooltipParams.reforge,
                                    cpCharacter.items.head.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.neck Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.neck.id,
                                cpCharacter.items.neck.name,
                                cpCharacter.items.neck.icon,
                                CType(cpCharacter.items.neck.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.neck.tooltipParams.gem0, cpCharacter.items.neck.tooltipParams.gem1, cpCharacter.items.neck.tooltipParams.gem2),
                                    cpCharacter.items.neck.tooltipParams.suffix,
                                    cpCharacter.items.neck.tooltipParams.seed,
                                    cpCharacter.items.neck.tooltipParams.enchant,
                                    cpCharacter.items.neck.tooltipParams.extraSocket,
                                    If(cpCharacter.items.neck.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.neck.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.neck.tooltipParams.reforge,
                                    cpCharacter.items.neck.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.shoulder Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.shoulder.id,
                                cpCharacter.items.shoulder.name,
                                cpCharacter.items.shoulder.icon,
                                CType(cpCharacter.items.shoulder.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.shoulder.tooltipParams.gem0, cpCharacter.items.shoulder.tooltipParams.gem1, cpCharacter.items.shoulder.tooltipParams.gem2),
                                    cpCharacter.items.shoulder.tooltipParams.suffix,
                                    cpCharacter.items.shoulder.tooltipParams.seed,
                                    cpCharacter.items.shoulder.tooltipParams.enchant,
                                    cpCharacter.items.shoulder.tooltipParams.extraSocket,
                                    If(cpCharacter.items.shoulder.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.shoulder.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.shoulder.tooltipParams.reforge,
                                    cpCharacter.items.shoulder.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.back Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.back.id,
                                cpCharacter.items.back.name,
                                cpCharacter.items.back.icon,
                                CType(cpCharacter.items.back.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.back.tooltipParams.gem0, cpCharacter.items.back.tooltipParams.gem1, cpCharacter.items.back.tooltipParams.gem2),
                                    cpCharacter.items.back.tooltipParams.suffix,
                                    cpCharacter.items.back.tooltipParams.seed,
                                    cpCharacter.items.back.tooltipParams.enchant,
                                    cpCharacter.items.back.tooltipParams.extraSocket,
                                    If(cpCharacter.items.back.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.back.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.back.tooltipParams.reforge,
                                    cpCharacter.items.back.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.chest Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.chest.id,
                                cpCharacter.items.chest.name,
                                cpCharacter.items.chest.icon,
                                CType(cpCharacter.items.chest.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.chest.tooltipParams.gem0, cpCharacter.items.chest.tooltipParams.gem1, cpCharacter.items.chest.tooltipParams.gem2),
                                    cpCharacter.items.chest.tooltipParams.suffix,
                                    cpCharacter.items.chest.tooltipParams.seed,
                                    cpCharacter.items.chest.tooltipParams.enchant,
                                    cpCharacter.items.chest.tooltipParams.extraSocket,
                                    If(cpCharacter.items.chest.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.chest.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.chest.tooltipParams.reforge,
                                    cpCharacter.items.chest.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.shirt Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.shirt.id,
                                cpCharacter.items.shirt.name,
                                cpCharacter.items.shirt.icon,
                                CType(cpCharacter.items.shirt.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.shirt.tooltipParams.gem0, cpCharacter.items.shirt.tooltipParams.gem1, cpCharacter.items.shirt.tooltipParams.gem2),
                                    cpCharacter.items.shirt.tooltipParams.suffix,
                                    cpCharacter.items.shirt.tooltipParams.seed,
                                    cpCharacter.items.shirt.tooltipParams.enchant,
                                    cpCharacter.items.shirt.tooltipParams.extraSocket,
                                    If(cpCharacter.items.shirt.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.shirt.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.shirt.tooltipParams.reforge,
                                    cpCharacter.items.shirt.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.tabard Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.tabard.id,
                                cpCharacter.items.tabard.name,
                                cpCharacter.items.tabard.icon,
                                CType(cpCharacter.items.tabard.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.tabard.tooltipParams.gem0, cpCharacter.items.tabard.tooltipParams.gem1, cpCharacter.items.tabard.tooltipParams.gem2),
                                    cpCharacter.items.tabard.tooltipParams.suffix,
                                    cpCharacter.items.tabard.tooltipParams.seed,
                                    cpCharacter.items.tabard.tooltipParams.enchant,
                                    cpCharacter.items.tabard.tooltipParams.extraSocket,
                                    If(cpCharacter.items.tabard.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.tabard.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.tabard.tooltipParams.reforge,
                                    cpCharacter.items.tabard.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.wrist Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.wrist.id,
                                cpCharacter.items.wrist.name,
                                cpCharacter.items.wrist.icon,
                                CType(cpCharacter.items.wrist.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.wrist.tooltipParams.gem0, cpCharacter.items.wrist.tooltipParams.gem1, cpCharacter.items.wrist.tooltipParams.gem2),
                                    cpCharacter.items.wrist.tooltipParams.suffix,
                                    cpCharacter.items.wrist.tooltipParams.seed,
                                    cpCharacter.items.wrist.tooltipParams.enchant,
                                    cpCharacter.items.wrist.tooltipParams.extraSocket,
                                    If(cpCharacter.items.wrist.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.wrist.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.wrist.tooltipParams.reforge,
                                    cpCharacter.items.wrist.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.hands Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.hands.id,
                                cpCharacter.items.hands.name,
                                cpCharacter.items.hands.icon,
                                CType(cpCharacter.items.hands.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.hands.tooltipParams.gem0, cpCharacter.items.hands.tooltipParams.gem1, cpCharacter.items.hands.tooltipParams.gem2),
                                    cpCharacter.items.hands.tooltipParams.suffix,
                                    cpCharacter.items.hands.tooltipParams.seed,
                                    cpCharacter.items.hands.tooltipParams.enchant,
                                    cpCharacter.items.hands.tooltipParams.extraSocket,
                                    If(cpCharacter.items.hands.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.hands.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.hands.tooltipParams.reforge,
                                    cpCharacter.items.hands.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.waist Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.waist.id,
                                cpCharacter.items.waist.name,
                                cpCharacter.items.waist.icon,
                                CType(cpCharacter.items.waist.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.waist.tooltipParams.gem0, cpCharacter.items.waist.tooltipParams.gem1, cpCharacter.items.waist.tooltipParams.gem2),
                                    cpCharacter.items.waist.tooltipParams.suffix,
                                    cpCharacter.items.waist.tooltipParams.seed,
                                    cpCharacter.items.waist.tooltipParams.enchant,
                                    cpCharacter.items.waist.tooltipParams.extraSocket,
                                    If(cpCharacter.items.waist.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.waist.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.waist.tooltipParams.reforge,
                                    cpCharacter.items.waist.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.legs Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.legs.id,
                                cpCharacter.items.legs.name,
                                cpCharacter.items.legs.icon,
                                CType(cpCharacter.items.legs.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.legs.tooltipParams.gem0, cpCharacter.items.legs.tooltipParams.gem1, cpCharacter.items.legs.tooltipParams.gem2),
                                    cpCharacter.items.legs.tooltipParams.suffix,
                                    cpCharacter.items.legs.tooltipParams.seed,
                                    cpCharacter.items.legs.tooltipParams.enchant,
                                    cpCharacter.items.legs.tooltipParams.extraSocket,
                                    If(cpCharacter.items.legs.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.legs.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.legs.tooltipParams.reforge,
                                    cpCharacter.items.legs.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.feet Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.feet.id,
                                cpCharacter.items.feet.name,
                                cpCharacter.items.feet.icon,
                                CType(cpCharacter.items.feet.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.feet.tooltipParams.gem0, cpCharacter.items.feet.tooltipParams.gem1, cpCharacter.items.feet.tooltipParams.gem2),
                                    cpCharacter.items.feet.tooltipParams.suffix,
                                    cpCharacter.items.feet.tooltipParams.seed,
                                    cpCharacter.items.feet.tooltipParams.enchant,
                                    cpCharacter.items.feet.tooltipParams.extraSocket,
                                    If(cpCharacter.items.feet.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.feet.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.feet.tooltipParams.reforge,
                                    cpCharacter.items.feet.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.finger1 Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.finger1.id,
                                cpCharacter.items.finger1.name,
                                cpCharacter.items.finger1.icon,
                                CType(cpCharacter.items.finger1.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.finger1.tooltipParams.gem0, cpCharacter.items.finger1.tooltipParams.gem1, cpCharacter.items.finger1.tooltipParams.gem2),
                                    cpCharacter.items.finger1.tooltipParams.suffix,
                                    cpCharacter.items.finger1.tooltipParams.seed,
                                    cpCharacter.items.finger1.tooltipParams.enchant,
                                    cpCharacter.items.finger1.tooltipParams.extraSocket,
                                    If(cpCharacter.items.finger1.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.finger1.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.finger1.tooltipParams.reforge,
                                    cpCharacter.items.finger1.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.finger2 Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.finger2.id,
                                cpCharacter.items.finger2.name,
                                cpCharacter.items.finger2.icon,
                                CType(cpCharacter.items.finger2.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.finger2.tooltipParams.gem0, cpCharacter.items.finger2.tooltipParams.gem1, cpCharacter.items.finger2.tooltipParams.gem2),
                                    cpCharacter.items.finger2.tooltipParams.suffix,
                                    cpCharacter.items.finger2.tooltipParams.seed,
                                    cpCharacter.items.finger2.tooltipParams.enchant,
                                    cpCharacter.items.finger2.tooltipParams.extraSocket,
                                    If(cpCharacter.items.finger2.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.finger2.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.finger2.tooltipParams.reforge,
                                    cpCharacter.items.finger2.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.trinket1 Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.trinket1.id,
                                cpCharacter.items.trinket1.name,
                                cpCharacter.items.trinket1.icon,
                                CType(cpCharacter.items.trinket1.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.trinket1.tooltipParams.gem0, cpCharacter.items.trinket1.tooltipParams.gem1, cpCharacter.items.trinket1.tooltipParams.gem2),
                                    cpCharacter.items.trinket1.tooltipParams.suffix,
                                    cpCharacter.items.trinket1.tooltipParams.seed,
                                    cpCharacter.items.trinket1.tooltipParams.enchant,
                                    cpCharacter.items.trinket1.tooltipParams.extraSocket,
                                    If(cpCharacter.items.trinket1.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.trinket1.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.trinket1.tooltipParams.reforge,
                                    cpCharacter.items.trinket1.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.trinket2 Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.trinket2.id,
                                cpCharacter.items.trinket2.name,
                                cpCharacter.items.trinket2.icon,
                                CType(cpCharacter.items.trinket2.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.trinket2.tooltipParams.gem0, cpCharacter.items.trinket2.tooltipParams.gem1, cpCharacter.items.trinket2.tooltipParams.gem2),
                                    cpCharacter.items.trinket2.tooltipParams.suffix,
                                    cpCharacter.items.trinket2.tooltipParams.seed,
                                    cpCharacter.items.trinket2.tooltipParams.enchant,
                                    cpCharacter.items.trinket2.tooltipParams.extraSocket,
                                    If(cpCharacter.items.trinket2.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.trinket2.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.trinket2.tooltipParams.reforge,
                                    cpCharacter.items.trinket2.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.mainHand Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.mainHand.id,
                                cpCharacter.items.mainHand.name,
                                cpCharacter.items.mainHand.icon,
                                CType(cpCharacter.items.mainHand.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.mainHand.tooltipParams.gem0, cpCharacter.items.mainHand.tooltipParams.gem1, cpCharacter.items.mainHand.tooltipParams.gem2),
                                    cpCharacter.items.mainHand.tooltipParams.suffix,
                                    cpCharacter.items.mainHand.tooltipParams.seed,
                                    cpCharacter.items.mainHand.tooltipParams.enchant,
                                    cpCharacter.items.mainHand.tooltipParams.extraSocket,
                                    If(cpCharacter.items.mainHand.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.mainHand.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.mainHand.tooltipParams.reforge,
                                    cpCharacter.items.mainHand.tooltipParams.transmogItem
                                    )
                                )
                            ),
                        If(cpCharacter.items.offHand Is Nothing, Nothing,
                            New Item(
                                cpCharacter.items.offHand.id,
                                cpCharacter.items.offHand.name,
                                cpCharacter.items.offHand.icon,
                                CType(cpCharacter.items.offHand.quality, Quality),
                                New TooltipParams(
                                    GetGems(cpCharacter.items.offHand.tooltipParams.gem0, cpCharacter.items.offHand.tooltipParams.gem1, cpCharacter.items.offHand.tooltipParams.gem2),
                                    cpCharacter.items.offHand.tooltipParams.suffix,
                                    cpCharacter.items.offHand.tooltipParams.seed,
                                    cpCharacter.items.offHand.tooltipParams.enchant,
                                    cpCharacter.items.offHand.tooltipParams.extraSocket,
                                    If(cpCharacter.items.offHand.tooltipParams.set Is Nothing, New Collection(Of Integer), cpCharacter.items.offHand.tooltipParams.set.ToCollection()),
                                    cpCharacter.items.offHand.tooltipParams.reforge,
                                    cpCharacter.items.offHand.tooltipParams.transmogItem
                                    )
                                )
                            )
                        )
                    ),
                If(cpCharacter.stats Is Nothing, Nothing,
                    New Stats(
                        cpCharacter.stats.health,
                        cpCharacter.stats.powerType.GetPowerType(),
                        cpCharacter.stats.power,
                        cpCharacter.stats.str,
                        cpCharacter.stats.agi,
                        cpCharacter.stats.sta,
                        cpCharacter.stats.int,
                        cpCharacter.stats.spr,
                        cpCharacter.stats.attackPower,
                        cpCharacter.stats.rangedAttackPower,
                        cpCharacter.stats.mastery,
                        cpCharacter.stats.masteryRating,
                        cpCharacter.stats.crit,
                        cpCharacter.stats.critRating,
                        cpCharacter.stats.hitPercent,
                        cpCharacter.stats.hitRating,
                        cpCharacter.stats.hasteRating,
                        cpCharacter.stats.expertiseRating,
                        cpCharacter.stats.spellPower,
                        cpCharacter.stats.spellPen,
                        cpCharacter.stats.spellCrit,
                        cpCharacter.stats.spellCritRating,
                        cpCharacter.stats.spellHitPercent,
                        cpCharacter.stats.spellHitRating,
                        cpCharacter.stats.mana5,
                        cpCharacter.stats.mana5Combat,
                        cpCharacter.stats.armor,
                        cpCharacter.stats.dodge,
                        cpCharacter.stats.dodgeRating,
                        cpCharacter.stats.parry,
                        cpCharacter.stats.parryRating,
                        cpCharacter.stats.block,
                        cpCharacter.stats.blockRating,
                        cpCharacter.stats.pvpResilience,
                        cpCharacter.stats.pvpResilienceRating,
                        cpCharacter.stats.mainHandDmgMin,
                        cpCharacter.stats.mainHandDmgMax,
                        cpCharacter.stats.mainHandSpeed,
                        cpCharacter.stats.mainHandDps,
                        cpCharacter.stats.mainHandExpertise,
                        cpCharacter.stats.offHandDmgMin,
                        cpCharacter.stats.offHandDmgMax,
                        cpCharacter.stats.offHandSpeed,
                        cpCharacter.stats.offHandDps,
                        cpCharacter.stats.offHandExpertise,
                        cpCharacter.stats.rangedDmgMin,
                        cpCharacter.stats.rangedDmgMax,
                        cpCharacter.stats.rangedSpeed,
                        cpCharacter.stats.rangedDps,
                        cpCharacter.stats.rangedCrit,
                        cpCharacter.stats.rangedCritRating,
                        cpCharacter.stats.rangedHitPercent,
                        cpCharacter.stats.rangedHitRating,
                        cpCharacter.stats.pvpPower,
                        cpCharacter.stats.pvpPowerRating
                        )
                    ),
                If(cpCharacter.professions Is Nothing, Nothing,
                    New Professions(
                        (From p In cpCharacter.professions.primary
                         Select New Profession(
                             CType(p.id, Enums.Profession),
                             p.name,
                             p.icon,
                             p.rank,
                             p.max,
                             If(p.recipes Is Nothing, New Collection(Of Integer), p.recipes.ToCollection())
                             )
                         ).ToCollection(),
                        (From p In cpCharacter.professions.secondary
                         Select New Profession(
                             CType(p.id, Enums.Profession),
                             p.name,
                             p.icon,
                             p.rank,
                             p.max,
                             If(p.recipes Is Nothing, New Collection(Of Integer), p.recipes.ToCollection())
                             )
                         ).ToCollection()
                        )
                    ),
                If(cpCharacter.reputation Is Nothing, Nothing,
                    (From r In cpCharacter.reputation
                     Select New Reputation(
                         r.id,
                         r.name,
                         CType(r.standing, Standing),
                         r.value,
                         r.max
                         )
                     ).ToCollection()
                    ),
                If(cpCharacter.titles Is Nothing, Nothing,
                    (From t In cpCharacter.titles
                     Select New Title(
                         t.id,
                         t.name,
                         t.selected
                         )
                     ).ToCollection()
                    ),
                If(cpCharacter.achievements Is Nothing, Nothing, SetAchievements(cpCharacter.achievements)),
                If(cpCharacter.hunterPets Is Nothing, Nothing, (
                    From p In cpCharacter.hunterPets
                    Select New HunterPet(
                        p.name,
                        p.creature,
                        p.selected,
                        p.slot,
                        If(p.spec Is Nothing, Nothing,
                            New Spec(
                                p.spec.name,
                                p.spec.role,
                                p.spec.backgroundImage,
                                p.spec.icon,
                                p.spec.description,
                                p.spec.order
                                )
                            ),
                        p.calcSpec
                        )
                    ).ToCollection()
                ),
                If(cpCharacter.talents Is Nothing, Nothing,
                    (From t In cpCharacter.talents
                     Select New TalentSpec(
                         t.selected,
                         (From tal In t.talents
                          Select New Talent(
                              tal.tier,
                              tal.column,
                              New Spell(
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
                          ).ToCollection(),
                         New Glyphs(
                             (From g In t.glyphs.major
                              Select New Glyph(
                                  g.glyph,
                                  g.item,
                                  g.name,
                                  g.icon
                                  )
                              ).ToCollection(),
                             (From g In t.glyphs.minor
                              Select New Glyph(
                                  g.glyph,
                                  g.item,
                                  g.name,
                                  g.icon
                                  )
                              ).ToCollection()
                             ),
                         If(
                             t.spec Is Nothing, Nothing, New Spec(
                                 t.spec.name,
                                 t.spec.role,
                                 t.spec.backgroundImage,
                                 t.spec.icon,
                                 t.spec.description,
                                 t.spec.order
                                 )
                             ),
                         t.calcTalent,
                         t.calcSpec,
                         t.calcGlyph
                         )
                     ).ToCollection()
                    ),
                If(cpCharacter.appearance Is Nothing, Nothing,
                    New Appearance(
                        cpCharacter.appearance.faceVariation,
                        cpCharacter.appearance.skinColor,
                        cpCharacter.appearance.hairVariation,
                        cpCharacter.appearance.hairColor,
                        cpCharacter.appearance.featureVariation,
                        cpCharacter.appearance.showHelm,
                        cpCharacter.appearance.showCloak
                        )
                    ),
                If(cpCharacter.mounts Is Nothing, Nothing, (
                    New Mounts(
                        cpCharacter.mounts.numCollected,
                        cpCharacter.mounts.numNotCollected,
                        (From m In cpCharacter.mounts.collected
                         Select New Mount(
                             m.name,
                             m.spellId,
                             m.creatureId,
                             m.itemId,
                             CType(m.qualityId, Quality),
                             m.icon,
                             m.isGround,
                             m.isFlying,
                             m.isAquatic,
                             m.isJumping
                             )
                         ).ToCollection()
                        )
                    )),
                If(cpCharacter.progression Is Nothing, Nothing,
                    New Progression(
                        (From r In cpCharacter.progression.raids
                         Select New Instance(
                             r.name,
                             CType(r.normal, Progress),
                             CType(r.heroic, Progress),
                             r.id,
                             (From b In r.bosses
                              Select New Boss(
                                  b.name,
                                  b.normalKills,
                                  b.heroicKills,
                                  b.id
                                  )
                              ).ToCollection()
                             )
                         ).ToCollection()
                        )
                    ),
                If(cpCharacter.pvp Is Nothing, Nothing,
                   New PvP(
                       New RatedBattlegrounds(
                           cpCharacter.pvp.ratedBattlegrounds.personalRating,
                           (From b In cpCharacter.pvp.ratedBattlegrounds.battlegrounds
                            Select New Battleground(
                                b.name,
                                b.played,
                                b.won
                                )
                            ).ToCollection()
                           ),
                       (From t In cpCharacter.pvp.arenaTeams
                        Select New ArenaTeam(
                            t.name,
                            t.personalRating,
                            t.teamRating,
                            System.Convert.ToInt32(t.size.Substring(0, 1), CultureInfo.InvariantCulture)
                            )
                        ).ToCollection(),
                       cpCharacter.pvp.totalHonorableKills
                       )
                   ),
                If(cpCharacter.quests Is Nothing, Nothing, cpCharacter.quests.ToCollection()),
                If(cpCharacter.feed Is Nothing, Nothing,
                   (From f In cpCharacter.feed
                    Select CreateFeedItem(f)
                       ).ToCollection()
                   )
                )
        End Sub

#End Region

#Region "Properties"

#Region "Public"

        ''' <summary>
        ''' The options for looking up character profile information.
        ''' </summary>
        ''' <value>This property gets or sets the Options field.</value>
        ''' <returns>Returns the options for looking up character profile information.</returns>
        ''' <remarks>To set the options for the current request, set the appropriate properties on this object.</remarks>
        Public Property Options As New CharacterProfileOptions

        Private cCharacter As Character
        ''' <summary>
        ''' Character profile information as returned from the Blizzard WoW API.
        ''' </summary>
        ''' <value>This property gets the Character field.</value>
        ''' <returns>Returns character profile information as returned from the Blizzard WoW API.</returns>
        ''' <remarks>This property is a <see cref="Character" /> object that contains information about the character specified in the <see cref="CharacterProfile.Options" />.</remarks>
        Public ReadOnly Property Character As Character
            Get
                Return cCharacter
            End Get
        End Property

#End Region

#Region "Private"

        Private ReadOnly Property FieldList As String
            Get
                Dim lstFields As New List(Of String)
                If Options.Guild Then lstFields.Add("guild")
                If Options.Stats Then lstFields.Add("stats")
                If Options.Talents Then lstFields.Add("talents")
                If Options.Items Then lstFields.Add("items")
                If Options.Reputation Then lstFields.Add("reputation")
                If Options.Titles Then lstFields.Add("titles")
                If Options.Professions Then lstFields.Add("professions")
                If Options.Appearance Then lstFields.Add("appearance")
                ' TODO: Add pets and petSlots
                '                If Options.Companions Then lstFields.Add("companions")
                If Options.Mounts Then lstFields.Add("mounts")
                If Options.HunterPets Then lstFields.Add("hunterPets")
                If Options.Achievements Then lstFields.Add("achievements")
                If Options.Progression Then lstFields.Add("progression")
                If Options.PvP Then lstFields.Add("pvp")
                If Options.Quests Then lstFields.Add("quests")
                If Options.Feed Then lstFields.Add("feed")
                Return String.Join(",", lstFields)
            End Get
        End Property

#End Region

#End Region

#Region "Methods"

#Region "Constructors"

        ''' <summary>
        ''' A default constructor to retrieve character profile information from the Blizzard WoW API.
        ''' </summary>
        ''' <remarks>This method creates a new instance of the <see cref="CharacterProfile" /> class.  You must set the <see cref="CharacterProfileOptions.Realm" /> and <see cref="CharacterProfileOptions.Name" /> properties of the <see cref="CharacterProfile.Options" /> property, along with any other boolean options you wish to set, and then call the <see cref="CharacterProfile.Load" /> method to load the character profile.</remarks>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' A constructor to retrieve a character's profile.
        ''' </summary>
        ''' <param name="strRealm">The realm to lookup the character in.</param>
        ''' <param name="strName">The name of the character to lookup.</param>
        ''' <remarks>This method creates a new instance of the <see cref="CharacterProfile" /> class and automatically loads the data for the specified realm and name.</remarks>
        Public Sub New(strRealm As String, strName As String)
            Options.Realm = strRealm
            Options.Name = strName
            Me.Load()
        End Sub

#End Region

#Region "Private"

        Private Shared Function GetGems(intGem0 As Integer, intGem1 As Integer, intGem2 As Integer) As Collection(Of Integer)
            Dim lstGems As New Collection(Of Integer)
            If intGem0 <> 0 Then lstGems.Add(intGem0)
            If intGem1 <> 0 Then lstGems.Add(intGem1)
            If intGem2 <> 0 Then lstGems.Add(intGem2)
            Return lstGems
        End Function

        Private Shared Function SetAchievements(aAchievements As Schema.achievements) As Achievements
            Dim colAchievements As New Collection(Of CompletedAchievement)
            Dim enumAchievement = aAchievements.achievementsCompleted.GetEnumerator()
            Dim enumAchievementTimestamp = aAchievements.achievementsCompletedTimestamp.GetEnumerator()
            While enumAchievement.MoveNext() And enumAchievementTimestamp.MoveNext()
                colAchievements.Add(New CompletedAchievement(CInt(enumAchievement.Current), CLng(enumAchievementTimestamp.Current).BlizzardTimestampToUTC()))
            End While

            Dim colCriteria As New Collection(Of CompletedCriteria)
            Dim enumCriteria = aAchievements.criteria.GetEnumerator()
            Dim enumCriteriaQuantity = aAchievements.criteriaQuantity.GetEnumerator()
            Dim enumCriteriaTimestamp = aAchievements.criteriaTimestamp.GetEnumerator()
            Dim enumCriteriaCreated = aAchievements.criteriaCreated.GetEnumerator()
            While enumCriteria.MoveNext() And enumCriteriaCreated.MoveNext() And enumCriteriaQuantity.MoveNext() And enumCriteriaTimestamp.MoveNext()
                colCriteria.Add(New CompletedCriteria(
                                CInt(enumCriteria.Current),
                                CLng(enumCriteriaQuantity.Current),
                                CLng(enumCriteriaTimestamp.Current).BlizzardTimestampToUTC(),
                                CLng(enumCriteriaCreated.Current).BlizzardTimestampToUTC()
                                ))
            End While

            Return New Achievements(colAchievements, colCriteria)
        End Function

        Private Shared Function CreateFeedItem(fFeed As Schema.feed) As FeedItem
            Select Case fFeed.type.ToUpperInvariant()
                Case "LOOT"
                    Return New LootFeed(
                        fFeed.timestamp.BlizzardTimestampToUTC(),
                        fFeed.itemId
                        )
                Case "BOSSKILL"
                    Return New BossKillFeed(
                        fFeed.timestamp.BlizzardTimestampToUTC(),
                        New FeedAchievement(
                            fFeed.achievement.id,
                            fFeed.achievement.title,
                            fFeed.achievement.points,
                            fFeed.achievement.description,
                            fFeed.achievement.reward,
                            (
                                From ri In fFeed.achievement.rewardItems
                                Select New RewardItem(
                                    ri.id, ri.name, ri.icon, CType(ri.quality, Quality)
                                    )
                                ).ToCollection(),
                            fFeed.achievement.icon,
                            (
                                From c In fFeed.achievement.criteria
                                Select New FeedCriteria(
                                    c.id,
                                    c.description
                                    )
                                ).ToCollection()
                            ),
                        fFeed.featOfStrength,
                        New FeedCriteria(
                            fFeed.criteria.id,
                            fFeed.criteria.description
                            ),
                        fFeed.quantity,
                        fFeed.name
                        )
                Case "ACHIEVEMENT"
                    Return New AchievementFeed(
                        fFeed.timestamp.BlizzardTimestampToUTC(),
                        New FeedAchievement(
                            fFeed.achievement.id,
                            fFeed.achievement.title,
                            fFeed.achievement.points,
                            fFeed.achievement.description,
                            fFeed.achievement.reward,
                            (
                                From ri In fFeed.achievement.rewardItems
                                Select New RewardItem(
                                    ri.id, ri.name, ri.icon, CType(ri.quality, Quality)
                                    )
                                ).ToCollection(),
                            fFeed.achievement.icon,
                            (
                                From c In fFeed.achievement.criteria
                                Select New FeedCriteria(
                                    c.id,
                                    c.description
                                    )
                                ).ToCollection()
                            ),
                        fFeed.featOfStrength
                        )
                Case "CRITERIA"
                    Return New CriteriaFeed(
                        fFeed.timestamp.BlizzardTimestampToUTC(),
                        New FeedAchievement(
                            fFeed.achievement.id,
                            fFeed.achievement.title,
                            fFeed.achievement.points,
                            fFeed.achievement.description,
                            fFeed.achievement.reward,
                            (
                                From ri In fFeed.achievement.rewardItems
                                Select New RewardItem(
                                    ri.id, ri.name, ri.icon, CType(ri.quality, Quality)
                                    )
                                ).ToCollection(),
                            fFeed.achievement.icon,
                            (
                                From c In fFeed.achievement.criteria
                                Select New FeedCriteria(
                                    c.id,
                                    c.description
                                    )
                                ).ToCollection()
                            ),
                        fFeed.featOfStrength,
                        New FeedCriteria(
                            fFeed.criteria.id,
                            fFeed.criteria.description
                            )
                        )
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region

#End Region

    End Class

End Namespace
