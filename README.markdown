# LibWowAPI
### Version 1.0.1 - 2011-12-14

LibWowAPI is a library for the .NET framework that interfaces with the Blizzard World of Warcraft API. The [Blizzard World of Warcraft API](http://blizzard.github.com/api-wow-docs) is an online API that interfaces with World of Warcraft.

(c)2008-2011 [Ronald M. Clifford](mailto:roncli@roncli.com)

Licensed under the [LGPL 3.0](http://www.gnu.org/licenses/lgpl.html).

## Usage
See the [Documentation](https://github.com/roncli/LibWowAPI/wiki/LibWowAPI) for more information on how to use LibWowAPI in your .NET application.

## Version History

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

### 1.0.1
* New:
 * Removed Json.NET dependancy.  LibWowAPI is now a standalone library, using System.Runtime.Serialization.Json to deserialize the JSON received from the Blizzard WoW API.
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
 * When retrieving an arena team, the list of member will be set to null if there are no members.
* Planned:
 * Better inheritance model for IfModifiedSince and Options properties.

## Classes

The following classes are provided:

* Auction.AuctionData
* Character.CharacterProfile
* Data.Battlegroups
* Data.CharacterAchievements
* Data.CharacterClasses
* Data.CharacterRaces
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

## Demo

The source code of LibWowAPI comes with the LibWowAPIDemo application. This console application is designed to provide potential developers with a working example of how to use LibWowAPI in their own applications. It's a great way to learn how to use the library.

## Special Thanks

* Lukan Schwigtenberg contributed the first working copy of the now-removed ItemTooltip class.