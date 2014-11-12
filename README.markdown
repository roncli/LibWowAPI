# LibWowAPI
### Version 1.1 - Released 9/5/2012

LibWowAPI is a library for the .NET framework that interfaces with the Blizzard World of Warcraft API. The [Blizzard World of Warcraft API](http://blizzard.github.com/api-wow-docs) is an online API that interfaces with World of Warcraft.

(c)2008-2012 [Ronald M. Clifford](mailto:roncli@roncli.com)

Licensed under the [LGPL 3.0](http://www.gnu.org/licenses/lgpl.html).

## Usage
See the [Documentation](https://github.com/roncli/LibWowAPI/wiki/LibWowAPI) for more information on how to use LibWowAPI in your .NET application.

## Version History

### 1.1 - 9/5/2012
* New:
 * Upgraded solution and projects to Visual Studio 2012 and .NET 4.5.
 * Added battlegroup across many different classes.
 * Added character profile feed. (Character.Feed)
 * Updated Resilience to PvpResilience and added PvpPower to character profile stats.  (Character.Stats)
 * Character profile talents and pets revamped for patch 5.0.4. (Character.Talents and Character.Pets)
 * Added guild profile news. (Guild.News)
 * Added achievement criteria, account-wide achievements, and icons. (Data.CharacterAchievements, Data.GuildAchievements, and Data.GuildRewards)
 * Added subclass info to item classes. (Data.ItemClasses)
 * Added selected talent spec to guild profile members and PvP classes. (Guild.Members, PvP.ArenaLadder, PvP.ArenaTeam, and PvP.RatedBattlegroundLadder)
 * Added total armor, display info, and item set info to item lookup. (Item.ItemLookup)
 * Added rated battleground ladder. (PvP.RatedBattlegroundLadder)
 * Added locale to realm status. (Realm.RealmStatus)
 * Added Neutral faction (For Panderans who haven't chosen their faction yet.)
* Removed:
 * Prime glyphs. (Removed with patch 5.0.4.)
 * Ranged item slot. (Removed with patch 5.0.4.)
 * Subclass enumeration. (Use the Data.ItemClasses class to retrieve subclass information.)
* Fixes:
 * Removed old SVN bindings from solution.
 * Fixed problems with IfModifiedSince related to Daylight Savings Time.

### 1.0.4 - 4/25/2012
* Added PvpZoneStatus enumeration to describe a realm's PvP zone status, and updated the realm status lookup accordingly.
* Added item socket bonus to the item lookup.
* Added page number and sort order to the arena ladder lookup.
* Added number of characters, page number, and sort order to the rated battleground ladder lookup.
* Added battlegroup to the character profile lookup.
* Added battlegroup to the guild profile lookup.

### 1.0.3 - 4/20/2012
* Added new rated battleground ladder class.
* Added new data to the realm status class.

### 1.0.2 - 12/19/2011
* Added new recipe lookup class.

### 1.0.1 - 12/14/2011
* New:
 * Removed Json.NET dependency.  LibWowAPI is now a standalone library, using System.Runtime.Serialization.Json to deserialize the JSON received from the Blizzard WoW API.
 * Added the TransmogItem property to items in the Character Profile.  See the Character.TooltipParams.TransmogItem property.
 * Added a flag to determine if the pet is the currently selected pet.  See the Character.Pet.Selected property.
 * Added pet talents parsing to the Character Profile.  See the Character.Pet.Talents property.
 * Added Portuguese language support for North American and European realms.
 * Added the IsModified property.  See the WowAPIData.IsModified property.
 * Caching is now optional.  See the WowAPIData.CacheResults property.
 * API request timeout is now configurable, defaulting to 10 seconds.  See the WowAPIData.Timeout property.
 * Moved from CodePlex to Github.
* Fixes:
 * Setting the IsModifiedSince date for a request that has not been modified since that date will no longer crash.
 * Chinese realm requests now return the correct URL.
 * Blizzard errors for GZIPped requests will no longer crash.
 * When retrieving an arena team, the list of members will be set to null if there are no members.

### 1.0 - 8/27/2011
* Implemented gzip compression.
* Added battlegroup listing and auction hall classes.
* Completed the item lookup class.
* Added battlegroup field to the realm lookup class.
* Added talents field to the pet class of the character class.
* Fixed a bug with URLs that contain pound signs (#) that aren't part of hashes and ampersands (&) that aren't part of querystrings. Yes, this was needed.
* Standardized the way the class constructors work so that a constructor with no arguments requires you to call the Load() function while a constructor with arguments does not.
* Help documentation available.

### 0.5 beta - 8/18/2011
* Project name change from LibWowArmory to LibWowAPI.
* Support for BNET authentication.
* Added pvp and quests fields to the character profile.
* Added character achievements, guild achievements, quests, and arena ladder classes.
* Better item lookup support.
* Some properties are now shared/static across the library in order to allow for cleaner code. These properties should be set at startup time, or in the application start event for ASP.NET.
* Changed LastModified header to IfModifiedSince header.
* The library now sends the X-Library and X-LibraryURL headers identifying itself to Blizzard as LibWowAPI and linking to this project. You can optionally send the X-Application and X-ApplicationURL headers - set via the shared/static properties Application and ApplicationURL - to identify your application.
* The JSON is now available by using the Data property.
* Will start providing binaries in addition to the source code.

### 0.4.1 beta - 8/13/2011
* Added better exception handling using the new BlizzardAPIException class.

### 0.4 beta - 8/12/2011
* Json.NET updated to version 4.0r2
* All old Armory classes have been removed, and many new API classes have been added.
* Improved caching, along with adjusting the cache time and adding the ability to manually clear the cache.

### 0.3 beta - 6/14/2010
* Solution upgraded to Visual Studio 2010:
 * Many properties have been converted to the new shorthand properties
 * Many changes recommended by the built-in code analyzer, including a switch from generic Lists to generic Collections
* Json.NET updated to version 3.5r7
* Many classes have been refactored into different namespaces to make the code tree easier to navigate
* Three new classes:
 * ItemTooltip - The information contained within an item's tooltip. Thanks to Lukan Schwigtenberg for his contribution!
 * AchievementStrings - A class used by CharacterFeed to get the available achievement category names IDs.
 * CharacterFeed - Returns a filterable feed of a character's recent achievements, achievement criteria, boss kills, loot received, and talent respecs. Note that Blizzard hasn't implemented respecs just yet.

### 0.2.3 beta - 2/16/2010
* Updated Dungeon class to work with the current Armory, providing more information for the class

### 0.2.2 beta - 2/15/2010
* Updated to work with Json.Net 3.5r6.
* Updated all current classes for the wowarmory.com changes made on January 13th.

### 0.2.1 beta - 9/8/2009
* Added the new TranslationFor and FactionRestriction properties to the ItemInfo class to handle new armory information identifying items as being for a single faction.

### 0.2 beta - 8/30/2009
* Fixed various changes to the Armory XML files, especially when it comes to Character Talents.
* Added character reputation, character calendar, character achievements, and character statistics functions.

### 0.1 beta - 12/18/2008
* Initial version.

## Planned versions

### 2.0
* Summary:
 * This is a large update, upgrading to the .NET Framework v4.5.1, keeping up with Blizzard's latest API changes, refactorization and disambiguation of many classes, and a new unit testing project.  Hence, the major version number increment.
 * There are many breaking changes, so if your code doesn't compile, use this list of changes to determine what might have changed.
 * Moved to use the new Mashery API.  This will require an API key.  Visit http://dev.battle.net for information on how to get a key.  Note: The China region does not have a Mashery URI right now.  Just use the API without an API key for now, until China is supported.
 * There is a new unit testing project.  See the Unit Testing section for information on how to enable Unit Testing.
 * Added many classes that were added since 1.0.4 that did not get added in 1.1.
 * Fixed many broken classes that were changed by Blizzard since 1.1.
 * Refactored many repetitive classes into a single class.  In general, the namespace used was the namespace that makes the most sense for the object.  For instance, completed achievements are in the new Achivement namespace, while talents reside in the Data.Talent namespace.
 * Renamed some classes that may cause confusion, for example two Stats classes were renamed BattlePetStats and CharacterStats.
 * IDs are now more descriptive.
 * Many bug fixes, especially with processing API errors from Blizzard.
* Details:
 * New:
   * Added new LibWowAPITest unit tesitng project.
   * Added ApiKey to the WowAPIData class.  Visit http://dev.battle.net to get a Mashery API key.
   * Added Language.Italiano to send it_IT for Italian.
   * Added achievement lookup. (Achievement.AchievementLookup)
   * Added faction to achievements.
   * Added ItemLevel and Armor to achievement reward items.
   * Added OwnerRealm, SuffixID, UniqueID, PetSpeciesID, PetBreed, PetLevel, and PetQuality to the auction data.
   * Added battle pet ability, species, and stats lookups. (BattlePet.BattlePetAbility, BattlePet.BattlePetSpecies, and BattlePet.BattlePetStats)
   * Added challenge mode leaderboards for realm and region. (Challenge.ChallengeRealm and Challenge.ChallengeRegion)
   * Added TimeZone to realms.
   * Added Guild and GuildRealm to characters displayed within the Guild class.  No, I don't understand why they added redundant information, either.
   * Added FamilyID ans FamilyName to character's hunter pets.
   * Added item level, upgrade information, and stats to a character's equipped items.
   * Added LFR and Flex kills as well as most recent timestamps to all modes for progression in character profile.
   * Added haste, spell haste, ranged haste, ranged expertise, and new PvP values to combat stats in character profile.
   * Added class talents lookup. (Data.ClassTalents)
   * Added pet type lookup. (Data.PetTypes)
   * Added guild challenge modes to the guild profile lookup.
   * Added pets, pet slot, and character audit information to character profile lookup.
   * Added minimum item level to gem info for items.
   * Added context and bonus information for items.
   * Added list of items to an item set in the items.
   * Added spell lookup. (Spell.SpellLookup)
   * Added ConnectedRealms to most realm objects.
 * Removed:
   * Removed PublicKey and PrivateKey from the WowAPIData class.
   * Removed Reforged property from an item's bonus stats.
   * Removed namespace PvP and all classes within, since Blizzard has removed those APIs.
   * Removed references to hit rating and weapon expertise in character stats.
 * Fixes:
   * Upgraded solution and projects to Visual Studio 2013 and .NET 4.5.
   * Language.EnglishEU now correctly sends en_GB.
   * The Auctions class no longer returns an AuctionHouse object for each faction (Alliance, Horde, and Neutral), but now it returns just one AuctionHouse for the entire realm (Auctions).
   * Refactored Character, CharacterAchievements, GuildAchievements, GuildRewards, and Guild objects to use the various classes from the Achievements namespace for achievements, crtieria, and reward items.
   * Achievement criteria are now sorted by their OrderIndex property.
   * All public references to Side have been changed to Faction.
   * Refactored Character objects to use the GuildBasicInfo and Emblem classes from the Guild namespace.
   * PvP data for the character profile has been updated to eliminate teams and use the new brackets.
   * Moved TotalHonorableKills to the base character data to reflect the change made in the API.
   * Changed the Rank field to the Subtext field in the Spell class within the Character namespace.
   * Changed item weapon damage to show both integer and exact min and max values.
   * Refactored Guild objects to use the CharacterBasicInfo class from the Character namespace.
   * Refactored Character, GuildPerks, and Item objects to use the Spell class from the Spell namespace.
   * Refactored Character, CharacterAchievements, GuildAchievements, GuildRewards, and Guild objects to use the ItemBasicInfo class from the Item namespace.
   * Refactored Item objects to use the ItemSet and SetBonus classes from the ItemSet namespace.
   * Refactored Achievement and Guild objects to use the new ItemBasicInfo class from the Item namespace.
   * Refactored Character and Guild objects to use the CompletedAchievements class from the Achievement namespace.
   * Replaced all fields named just "ID" with a more descriptive property.
   * Refactored Character and Guild objects to use the Spec and Glyph classes from the Data.Talents namespace.
   * Refactored Character objects to use new Talent class from the Data.Talent namespace.
   * Refactored Auction objects to use new RealmName class from the Realm namespace.
   * Refactored Class objects for characters to be called CharacterClass.
   * Refactored Class objects for items to be called ItemClass.  The ID field is now correctly called ClassID.
   * Refactored Subclass objects for items to be called ItemSubclass.  The ID field is now correctly called SubclassID.
   * Renamed Stat enumeration to ItemStatType.
   * ItemStatType.FeralAttackPower was removed.
   * Refactored Stat objects for items to be called ItemStat.
   * Refactored Stats objects for characters to be called CharacterStats.
   * Refactored Member objects for guilds to be called GuildMember.
   * Updated Data.Talents.CharacterTalents to group the talents by slot.

## Classes

The following classes are provided:

* Achievement.AchievementLookup
* Auction.AuctionData
* BattlePet.BattlePetAbility
* BattlePet.BattlePetSpecies
* BattlePet.BattlePetStats
* Challenge.ChallengeRealm
* Challenge.ChallengeRegion
* Character.CharacterProfile
* Data.Battlegroups
* Data.CharacterAchievements
* Data.CharacterClasses
* Data.CharacterRaces
* Data.ClassTalents
* Data.GuildAchievements
* Data.GuildPerks
* Data.GuildRewards
* Data.ItemClasses
* Guild.GuildProfile
* Item.ItemLookup
* PvP.ArenaLadder
* PvP.ArenaTeam
* Quest.QuestLookup
* Realms.RealmStatus
* Recipe.RecipeLookup

## Demo

The source code of LibWowAPI comes with the LibWowAPIDemo application. This console application is designed to provide potential developers with a working example of how to use LibWowAPI in their own applications. It's a great way to learn how to use the library.

## Unit Testing

The source code of LibWowAPI also comes with the LibWowAPITest project. This is a unit test project that will allow you to run unit tests in Visual Studio. In order to enable unit testing, you need to provide a file in the LibWowAPITest project directory called "privateConfig.config", and it must contain the following, substituting your Mashery API key for the value:

```
<appSettings>
    <add key="apiKey" value="{Your Mashery API key}" />
</appSettings>
```

## Special Thanks

* Lukan Schwigtenberg contributed the first working copy of the now-removed ItemTooltip class.