' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports roncliProductions
Imports roncliProductions.LibWowAPI
Imports roncliProductions.LibWowAPI.Achievement
Imports roncliProductions.LibWowAPI.Auction
Imports roncliProductions.LibWowAPI.BattlePet
Imports roncliProductions.LibWowAPI.Challenge
Imports roncliProductions.LibWowAPI.Character
Imports roncliProductions.LibWowAPI.Data
Imports roncliProductions.LibWowAPI.Data.Battlegroups
Imports roncliProductions.LibWowAPI.Data.CharacterAchievements
Imports roncliProductions.LibWowAPI.Data.GuildAchievements
Imports roncliProductions.LibWowAPI.Data.GuildPerks
Imports roncliProductions.LibWowAPI.Data.GuildRewards
Imports roncliProductions.LibWowAPI.Guild
Imports roncliProductions.LibWowAPI.Internationalization
Imports roncliProductions.LibWowAPI.Item
Imports roncliProductions.LibWowAPI.PvP
Imports roncliProductions.LibWowAPI.Quest
Imports roncliProductions.LibWowAPI.Realm
Imports roncliProductions.LibWowAPI.Recipe

<Assembly: CLSCompliant(True)> 

Namespace roncliProductions.LibWowAPIDemo

    Public Module modMain

        Public Sub Main()
            ' Setup shared properties
            WowAPIData.Region = Region.NorthAmerica
            WowAPIData.Language = Language.EnglishUS
            WowAPIData.Application = "LibWowAPI Demo"
            WowAPIData.ApplicationURL = "http://libwowarmory.codeplex.com"

            ' There are a number of things to test here, so we will give the user the option of which test to perform.
            Do
                Console.WriteLine("Please choose a test to perform")
                Console.WriteLine("  Or press enter to quit.")
                Console.WriteLine("1 - Change Region")
                Console.WriteLine("2 - Change Language")
                Console.WriteLine("3 - Setup Authorization")
                Console.WriteLine("4 - Achievement Lookup")
                Console.WriteLine("5 - Arena Ladder")
                Console.WriteLine("6 - Arena Team")
                Console.WriteLine("7 - Auctions")
                Console.WriteLine("8 - Battlegroups")
                Console.WriteLine("9 - Battle Pet Abilities")
                Console.WriteLine("10 - Battle Pet Species")
                Console.WriteLine("11 - Battle Pet Stats")
                Console.WriteLine("12 - Challenge Mode for Realm")
                Console.WriteLine("13 - Challenge Mode for Region")
                Console.WriteLine("14 - Character Achievements")
                Console.WriteLine("15 - Character Classes")
                Console.WriteLine("16 - Character Profile")
                Console.WriteLine("17 - Character Races")
                Console.WriteLine("18 - Guild Achievements")
                Console.WriteLine("19 - Guild Perks")
                Console.WriteLine("20 - Guild Profile")
                Console.WriteLine("21 - Guild Rewards")
                Console.WriteLine("22 - Item Classes")
                Console.WriteLine("23 - Item Lookup")
                Console.WriteLine("24 - Quest Lookup")
                Console.WriteLine("25 - Rated Battlegroup Ladder")
                Console.WriteLine("26 - Realm Status")
                Console.WriteLine("27 - Recipe Lookup")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If String.IsNullOrWhiteSpace(strResponse) Then Exit Do
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 1
                            ChangeRegion()
                        Case 2
                            ChangeLanguage()
                        Case 3
                            SetupAuthorization()
                        Case 4
                            AchievementLookupDemo()
                        Case 5
                            ArenaLadderDemo()
                        Case 6
                            ArenaTeamDemo()
                        Case 7
                            AuctionsDemo()
                        Case 8
                            BattlegroupsDemo()
                        Case 9
                            BattlePetAbilitiesDemo()
                        Case 10
                            BattlePetSpeciesDemo()
                        Case 11
                            BattlePetStatsDemo()
                        Case 12
                            ChallengeRealmDemo()
                        Case 13
                            ChallengeRegionDemo()
                        Case 14
                            CharacterAchievementsDemo()
                        Case 15
                            CharacterClassesDemo()
                        Case 16
                            CharacterProfileDemo()
                        Case 17
                            CharacterRacesDemo()
                        Case 18
                            GuildAchievementsDemo()
                        Case 19
                            GuildPerksDemo()
                        Case 20
                            GuildProfileDemo()
                        Case 21
                            GuildRewardsDemo()
                        Case 22
                            ItemClassesDemo()
                        Case 23
                            ItemLookupDemo()
                        Case 24
                            QuestLookupDemo()
                        Case 25
                            RatedBattlegroundLadderDemo()
                        Case 26
                            RealmStatusDemo()
                        Case 27
                            RecipeLookupDemo()
                    End Select
                    Console.Clear()
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop
        End Sub

        Public Sub ChangeRegion()
            Console.Clear()
            Console.WriteLine("Change Region")
            Console.WriteLine()

            Do
                Console.WriteLine("Select the region to use the Armory with")
                Console.WriteLine("1 - North America")
                Console.WriteLine("2 - Europe")
                Console.WriteLine("3 - Korea")
                Console.WriteLine("4 - China")
                Console.WriteLine("5 - Taiwan")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 1
                            WowAPIData.Region = Region.NorthAmerica
                            Exit Do
                        Case 2
                            WowAPIData.Region = Region.Europe
                            Exit Do
                        Case 3
                            WowAPIData.Region = Region.Korea
                            Exit Do
                        Case 4
                            WowAPIData.Region = Region.China
                            Exit Do
                        Case 5
                            WowAPIData.Region = Region.Taiwan
                            Exit Do
                        Case Else
                            Console.WriteLine("Invalid response.")
                            Console.WriteLine()
                    End Select
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

        End Sub

        Public Sub ChangeLanguage()
            Console.Clear()
            Console.WriteLine("Change Language")
            Console.WriteLine()

            Do
                Console.WriteLine("Select the language to use the Armory with")
                Console.WriteLine("1 - German")
                Console.WriteLine("2 - English (UK)")
                Console.WriteLine("3 - English (US)")
                Console.WriteLine("4 - Spanish (Mexico)")
                Console.WriteLine("5 - Spanish (Spain)")
                Console.WriteLine("6 - French")
                Console.WriteLine("7 - Italian")
                Console.WriteLine("8 - Russian")
                Console.WriteLine("9 - Korean")
                Console.WriteLine("10 - Chinese (Simplified)")
                Console.WriteLine("11 - Chinese (Traditional)")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 1
                            WowAPIData.Language = Language.Deutsch
                            Exit Do
                        Case 2
                            WowAPIData.Language = Language.EnglishEU
                            Exit Do
                        Case 3
                            WowAPIData.Language = Language.EnglishUS
                            Exit Do
                        Case 4
                            WowAPIData.Language = Language.EspañolAL
                            Exit Do
                        Case 5
                            WowAPIData.Language = Language.EspañolEU
                            Exit Do
                        Case 6
                            WowAPIData.Language = Language.Français
                            Exit Do
                        Case 7
                            WowAPIData.Language = Language.Italiano
                            Exit Do
                        Case 8
                            WowAPIData.Language = Language.Русский
                            Exit Do
                        Case 9
                            WowAPIData.Language = Language.한국어
                            Exit Do
                        Case 10
                            WowAPIData.Language = Language.简体中文
                            Exit Do
                        Case 11
                            WowAPIData.Language = Language.繁體中文
                            Exit Do
                        Case Else
                            Console.WriteLine("Invalid response.")
                            Console.WriteLine()
                    End Select
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

        End Sub

        Public Sub SetupAuthorization()
            Console.Clear()
            Console.WriteLine("Setup Authorization")
            Console.WriteLine()

            ' First, get the public key
            Do
                Console.WriteLine("Please enter the public key.")
                Console.Write(">")
                WowAPIData.PublicKey = Console.ReadLine

                If String.IsNullOrWhiteSpace(WowAPIData.PublicKey) Then
                    WowAPIData.PublicKey = Nothing
                Else
                    Exit Do
                End If
            Loop

            ' Next, get the private key
            Do
                Console.WriteLine()
                Console.WriteLine("Please enter the private key.")
                Console.Write(">")
                WowAPIData.PrivateKey = Console.ReadLine

                If String.IsNullOrWhiteSpace(WowAPIData.PrivateKey) Then
                    WowAPIData.PrivateKey = Nothing
                Else
                    Exit Do
                End If
            Loop
        End Sub

        Public Sub AchievementLookupDemo()
            Console.Clear()
            Console.WriteLine("Achievement Lookup Demo")
            Console.WriteLine()

            ' First, setup some variables
            Dim intAchievementID As Integer

            ' Next, get the item ID.
            Do
                Console.WriteLine("Please enter the ID number of the achievement you wish to lookup.")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If Integer.TryParse(strResponse, intAchievementID) Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Get the Achievement.
            Dim aAchievement As New AchievementLookup(intAchievementID)

            ' Show the Achievement.
            Console.Clear()
            If aAchievement.CacheHit.HasValue AndAlso aAchievement.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0} - ID {1} - Points: {2}", aAchievement.Achievement.Title, aAchievement.Achievement.ID, aAchievement.Achievement.Points)
            If aAchievement.Achievement.AccountWide Then
                Console.WriteLine("  Account-wide Achievement")
            End If
            Console.WriteLine("  Icon: {0}", aAchievement.Achievement.Icon)
            Console.WriteLine("  {0}", aAchievement.Achievement.Description)
            If Not String.IsNullOrWhiteSpace(aAchievement.Achievement.Reward) Then
                Console.WriteLine("  {0}", aAchievement.Achievement.Reward)
            End If
            If aAchievement.Achievement.RewardItems IsNot Nothing Then
                For Each riItem In aAchievement.Achievement.RewardItems
                    Console.WriteLine("    {0} - ID: {1} - Quality: {2}", riItem.Name, riItem.ID, riItem.Quality)
                Next
            End If
            If aAchievement.Achievement.Criteria IsNot Nothing Then
                For Each cCriteria In aAchievement.Achievement.Criteria
                    Console.WriteLine("  - {0}) {1}", cCriteria.ID, cCriteria.Description)
                Next
            End If
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub ArenaLadderDemo()
            Console.Clear()
            Console.WriteLine("Arena Ladder Demo")
            Console.WriteLine()

            ' Declare some variabales.
            Dim strBattlegroup As String
            Dim intTeamSize As Integer
            Dim intTeams As Integer
            Dim intPage As Integer
            Dim blnAscending As New Boolean?

            ' Next, get the battlegroup.
            Do
                Console.WriteLine("Please enter the name of the battlegroup of the arena ladder you wish to retrieve.")
                Console.Write(">")
                strBattlegroup = Console.ReadLine

                If String.IsNullOrWhiteSpace(strBattlegroup) Then
                    Console.WriteLine("You must enter a realm name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' Next, get the team size.
            Do
                Console.WriteLine("Please enter an arena team size.")
                Console.WriteLine("2 - 2v2")
                Console.WriteLine("3 - 3v3")
                Console.WriteLine("5 - 5v5")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 2, 3, 5
                            intTeamSize = intResponse
                            Exit Do
                        Case Else
                            Console.WriteLine("Invalid response.")
                            Console.WriteLine()
                    End Select
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get the number of teams to return.
            Do
                Console.WriteLine("Please enter the number of teams to return.")
                Console.WriteLine("  Or press enter to default.")
                Console.Write(">")
                Dim strTeams = Console.ReadLine

                If String.IsNullOrWhiteSpace(strTeams) Then
                    Exit Do
                End If

                If Integer.TryParse(strTeams, intTeams) Then
                    Exit Do
                Else
                    Console.WriteLine("You must enter a valid number of teams to return.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get the page number to return.
            Do
                Console.WriteLine("Please enter the page number to return.")
                Console.WriteLine("  Or press enter to default.")
                Console.Write(">")
                Dim strPage = Console.ReadLine

                If String.IsNullOrWhiteSpace(strPage) Then
                    Exit Do
                End If

                If Integer.TryParse(strPage, intPage) Then
                    Exit Do
                Else
                    Console.WriteLine("You must enter a valid page number to return.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get whether to return results ascending or descending.
            Do
                Console.WriteLine("Select the sort order to use.")
                Console.WriteLine("0 - Default (Ascending)")
                Console.WriteLine("1 - Ascending")
                Console.WriteLine("2 - Descending")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 0
                            Exit Do
                        Case 1
                            blnAscending = True
                            Exit Do
                        Case 2
                            blnAscending = False
                            Exit Do
                        Case Else
                            Console.WriteLine("Invalid response.")
                            Console.WriteLine()
                    End Select
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Perform the arena ladder lookup.
            Dim alLadder As New ArenaLadder()
            alLadder.Options.Battlegroup = strBattlegroup
            alLadder.Options.TeamSize = intTeamSize
            alLadder.Options.Teams = intTeams
            alLadder.Options.Page = intPage
            alLadder.Options.Ascending = blnAscending
            alLadder.Load()

            ' Show the arena teams.
            Console.Clear()
            If alLadder.CacheHit.HasValue AndAlso alLadder.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each atTeam In alLadder.Teams
                Console.WriteLine("{0}) {1} - {2} - {3} - {4}v{4} - Created: {5:M/d/yyyy}", atTeam.Ranking, atTeam.Realm, atTeam.Faction, atTeam.Name, atTeam.TeamSize, atTeam.Created)
                Console.WriteLine("  Rating: {0}", atTeam.Rating)
                Console.WriteLine("  Record: {0}-{1} ({2} played) - Session record: {3}-{4} ({5} played)", atTeam.GamesWon, atTeam.GamesLost, atTeam.GamesPlayed, atTeam.SessionGamesWon, atTeam.SessionGamesLost, atTeam.SessionGamesPlayed)
                Console.WriteLine("  Current week ranking: {0} - Last session ranking: {1}", atTeam.CurrentWeekRanking, atTeam.LastSessionRanking)
                Console.WriteLine()

                Console.WriteLine("  Members:")
                For Each mMember In atTeam.Members
                    Console.WriteLine("    {0} - Level {1} {2} {3} {4} {5}", mMember.Character.Name, mMember.Character.Level, mMember.Character.Gender, mMember.Character.Race.Name, mMember.Character.Class.Name, If(mMember.Character.Spec Is Nothing, Nothing, mMember.Character.Spec.Name))
                    If mMember.Rank = 1 Then
                        Console.WriteLine("      Team Owner")
                    End If
                    Console.WriteLine("      Record: {0}-{1} ({2} played) - Session record: {3}-{4} ({5} played)", mMember.GamesWon, mMember.GamesLost, mMember.GamesPlayed, mMember.SessionGamesWon, mMember.SessionGamesLost, mMember.SessionGamesPlayed)
                    Console.WriteLine("      Personal rating: {0}", mMember.PersonalRating)
                    Console.WriteLine("      Achievement Points: {0}", mMember.Character.AchievementPoints)
                Next
                Console.WriteLine()
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub ArenaTeamDemo()
            Console.Clear()
            Console.WriteLine("Arena Team Demo")
            Console.WriteLine()

            ' Declare some variabales.
            Dim strRealm As String
            Dim intTeamSize As Integer
            Dim strName As String

            ' Next, get the realm.
            Do
                Console.WriteLine("Please enter the name of the realm of the arena team you wish to retrieve.")
                Console.Write(">")
                strRealm = Console.ReadLine

                If String.IsNullOrWhiteSpace(strRealm) Then
                    Console.WriteLine("You must enter a realm name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' Next, get the team size.
            Do
                Console.WriteLine("Please enter an arena team size.")
                Console.WriteLine("2 - 2v2")
                Console.WriteLine("3 - 3v3")
                Console.WriteLine("5 - 5v5")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 2, 3, 5
                            intTeamSize = intResponse
                            Exit Do
                        Case Else
                            Console.WriteLine("Invalid response.")
                            Console.WriteLine()
                    End Select
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get the character name.
            Do
                Console.WriteLine("Please enter the name of the arena team you wish to retrieve.")
                Console.Write(">")
                strName = Console.ReadLine

                If String.IsNullOrWhiteSpace(strName) Then
                    Console.WriteLine("You must enter an arena team name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' Perform the arena team lookup.
            Dim atTeam As New LibWowAPI.PvP.ArenaTeam(strRealm, intTeamSize, strName)

            ' Show the arena team.
            Console.Clear()
            If atTeam.CacheHit.HasValue AndAlso atTeam.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0} - {1} - {2} - {3}v{3} - Created: {4:M/d/yyyy}", atTeam.Team.Realm, atTeam.Team.Faction, atTeam.Team.Name, atTeam.Team.TeamSize, atTeam.Team.Created)
            Console.WriteLine("Rating: {0} - Ranking: {1}", atTeam.Team.Rating, atTeam.Team.Ranking)
            Console.WriteLine("Record: {0}-{1} ({2} played) - Session record: {3}-{4} ({5} played)", atTeam.Team.GamesWon, atTeam.Team.GamesLost, atTeam.Team.GamesPlayed, atTeam.Team.SessionGamesWon, atTeam.Team.SessionGamesLost, atTeam.Team.SessionGamesPlayed)
            Console.WriteLine("Current week ranking: {0} - Last session ranking: {1}", atTeam.Team.CurrentWeekRanking, atTeam.Team.LastSessionRanking)
            Console.WriteLine()

            Console.WriteLine("Members:")
            For Each mMember In atTeam.Team.Members
                Console.WriteLine("  {0} - Level {1} {2} {3} {4} {5}", mMember.Character.Name, mMember.Character.Level, mMember.Character.Gender, mMember.Character.Race.Name, mMember.Character.Class.Name, If(mMember.Character.Spec Is Nothing, Nothing, mMember.Character.Spec.Name))
                If mMember.Rank = 1 Then
                    Console.WriteLine("    Team Owner")
                End If
                Console.WriteLine("    Record: {0}-{1} ({2} played) - Session record: {3}-{4} ({5} played)", mMember.GamesWon, mMember.GamesLost, mMember.GamesPlayed, mMember.SessionGamesWon, mMember.SessionGamesLost, mMember.SessionGamesPlayed)
                Console.WriteLine("    Personal rating: {0}", mMember.PersonalRating)
                Console.WriteLine("    Achievement Points: {0}", mMember.Character.AchievementPoints)
            Next
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub AuctionsDemo()
            Console.Clear()
            Console.WriteLine("Auctions Demo")
            Console.WriteLine()

            ' Declare some variabales.
            Dim strRealm As String

            ' Next, get the realm.
            Do
                Console.WriteLine("Please enter the name of the realm of the auctions you wish to retrieve.")
                Console.Write(">")
                strRealm = Console.ReadLine

                If String.IsNullOrWhiteSpace(strRealm) Then
                    Console.WriteLine("You must enter a realm name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' Get the auctions.
            Dim adAuctions As New AuctionData(strRealm)
            adAuctions.Load()

            ' Show the auctions.
            Console.Clear()
            If adAuctions.CacheHit.HasValue AndAlso adAuctions.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each aAuctions In adAuctions.Auctions
                Console.WriteLine("Auctions for {0} - Slug {1}", aAuctions.Realm.Name, aAuctions.Realm.Slug)
                Console.WriteLine("Alliance:")
                For Each aAuction In aAuctions.Alliance.Auctions
                    Console.WriteLine("  {0}) Item {1} ({2}:{3}) x{4} - {5}", aAuction.ID, aAuction.ItemID, aAuction.SuffixID, aAuction.UniqueID, aAuction.Quantity, aAuction.TimeLeft)
                    Console.WriteLine("    Seller: {0}-{1} Bid: {2}g{3}s{4}c Buyout: {5}g{6}s{7}c", aAuction.Owner, aAuction.OwnerRealm, Math.Floor(aAuction.Bid / 10000), Math.Floor((aAuction.Bid / 100) Mod 100), aAuction.Bid Mod 100, Math.Floor(aAuction.Buyout / 10000), Math.Floor((aAuction.Buyout / 100) Mod 100), aAuction.Buyout Mod 100)
                    If aAuction.PetSpeciesID <> 0 Then
                        Console.WriteLine("    Pet Species: {0} - Level: {1} - Breed: {2} - Quality: {3}", aAuction.PetSpeciesID, aAuction.PetLevel, aAuction.PetBreed, aAuction.PetQuality)
                    End If
                Next
                Console.WriteLine("Horde:")
                For Each aAuction In aAuctions.Horde.Auctions
                    Console.WriteLine("  {0}) Item {1} ({2}:{3}) x{4} - {5}", aAuction.ID, aAuction.ItemID, aAuction.SuffixID, aAuction.UniqueID, aAuction.Quantity, aAuction.TimeLeft)
                    Console.WriteLine("    Seller: {0}-{1} Bid: {2}g{3}s{4}c Buyout: {5}g{6}s{7}c", aAuction.Owner, aAuction.OwnerRealm, Math.Floor(aAuction.Bid / 10000), Math.Floor((aAuction.Bid / 100) Mod 100), aAuction.Bid Mod 100, Math.Floor(aAuction.Buyout / 10000), Math.Floor((aAuction.Buyout / 100) Mod 100), aAuction.Buyout Mod 100)
                    If aAuction.PetSpeciesID <> 0 Then
                        Console.WriteLine("    Pet Species: {0} - Level: {1} - Breed: {2} - Quality: {3}", aAuction.PetSpeciesID, aAuction.PetLevel, aAuction.PetBreed, aAuction.PetQuality)
                    End If
                Next
                Console.WriteLine("Neutral:")
                For Each aAuction In aAuctions.Neutral.Auctions
                    Console.WriteLine("  {0}) Item {1} ({2}:{3}) x{4} - {5}", aAuction.ID, aAuction.ItemID, aAuction.SuffixID, aAuction.UniqueID, aAuction.Quantity, aAuction.TimeLeft)
                    Console.WriteLine("    Seller: {0}-{1} Bid: {2}g{3}s{4}c Buyout: {5}g{6}s{7}c", aAuction.Owner, aAuction.OwnerRealm, Math.Floor(aAuction.Bid / 10000), Math.Floor((aAuction.Bid / 100) Mod 100), aAuction.Bid Mod 100, Math.Floor(aAuction.Buyout / 10000), Math.Floor((aAuction.Buyout / 100) Mod 100), aAuction.Buyout Mod 100)
                    If aAuction.PetSpeciesID <> 0 Then
                        Console.WriteLine("    Pet Species: {0} - Level: {1} - Breed: {2} - Quality: {3}", aAuction.PetSpeciesID, aAuction.PetLevel, aAuction.PetBreed, aAuction.PetQuality)
                    End If
                Next
            Next
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub BattlegroupsDemo()
            Console.Clear()
            Console.WriteLine("Battlegroups Demo")
            Console.WriteLine()

            ' Get the battlegroups.
            Dim bBattlegroups As New Battlegroups()
            bBattlegroups.Load()

            ' Show the battlegroups.
            Console.Clear()
            If bBattlegroups.CacheHit.HasValue AndAlso bBattlegroups.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each bBattlegroup In bBattlegroups.Battlegroups
                Console.WriteLine("{0} - Slug: {1}", bBattlegroup.Name, bBattlegroup.Slug)
            Next
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub BattlePetAbilitiesDemo()
            Console.Clear()
            Console.WriteLine("Battle Pet Abilities Demo")
            Console.WriteLine()

            ' First, setup some variables
            Dim intAbilityID As Integer

            ' Next, get the ability ID.
            Do
                Console.WriteLine("Please enter the ID number of the battle pet ability you wish to lookup.")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If Integer.TryParse(strResponse, intAbilityID) Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Get the Ability.
            Dim aAbility As New BattlePetAbility(intAbilityID)

            ' Show the Achievement.
            Console.Clear()
            If aAbility.CacheHit.HasValue AndAlso aAbility.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0}) {1}", aAbility.Ability.ID, aAbility.Ability.Name)
            If aAbility.Ability.IsPassive Then
                Console.WriteLine("  Passive Ability")
            End If
            Console.WriteLine("  Rounds: {0} - Cooldown: {1}", aAbility.Ability.Rounds, aAbility.Ability.Cooldown)
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub BattlePetSpeciesDemo()
            Console.Clear()
            Console.WriteLine("Battle Pet Species Demo")
            Console.WriteLine()

            ' First, setup some variables
            Dim intSpeciesID As Integer

            ' Next, get the species ID.
            Do
                Console.WriteLine("Please enter the ID number of the battle pet species you wish to lookup.")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If Integer.TryParse(strResponse, intSpeciesID) Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Get the species.
            Dim sSpecies As New BattlePetSpecies(intSpeciesID)

            ' Show the Achievement.
            Console.Clear()
            If sSpecies.CacheHit.HasValue AndAlso sSpecies.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0}) {1}", sSpecies.Species.ID, sSpecies.Species.Name)
            Console.WriteLine("Source: {0}", sSpecies.Species.Source)
            Console.WriteLine()
            Console.WriteLine("Abilities:")
            For Each saAbility In sSpecies.Species.Abilities
                Console.WriteLine("  {0}) {1}", saAbility.ID, saAbility.Name)
                Console.WriteLine("    Required level: {0}", saAbility.RequiredLevel)
                If saAbility.IsPassive Then
                    Console.WriteLine("    Passive Ability")
                End If
                Console.WriteLine("    Rounds: {0} - Cooldown: {1}", saAbility.Rounds, saAbility.Cooldown)
                Console.WriteLine()
            Next
            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub BattlePetStatsDemo()
            Console.Clear()
            Console.WriteLine("Battle Pet Stats Demo")
            Console.WriteLine()

            ' First, setup some variables
            Dim intSpeciesID As Integer
            Dim intLevel As Integer
            Dim bpbBreed As Enums.BattlePetBreed
            Dim qQuality As Enums.Quality

            ' Next, get the species ID.
            Do
                Console.WriteLine("Please enter the ID number of the battle pet species you wish to lookup.")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If Integer.TryParse(strResponse, intSpeciesID) Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get the level.
            Do
                Console.WriteLine("Please enter the level of the pet.")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If Integer.TryParse(strResponse, intLevel) Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get the breed.
            Do
                Console.WriteLine("Select the breed of the pet")
                Console.WriteLine("3 - Male, Balanced")
                Console.WriteLine("4 - Male, Double Power")
                Console.WriteLine("5 - Male, Double Speed")
                Console.WriteLine("6 - Male, Double Health")
                Console.WriteLine("7 - Male, Health & Power")
                Console.WriteLine("8 - Male, Power & Speed")
                Console.WriteLine("9 - Male, Health & Speed")
                Console.WriteLine("10 - Male, Balanced Power")
                Console.WriteLine("11 - Male, Balance Speed")
                Console.WriteLine("12 - Male, Balanced Health")
                Console.WriteLine("13 - Female, Balanced")
                Console.WriteLine("14 - Female, Double Power")
                Console.WriteLine("15 - Female, Double Speed")
                Console.WriteLine("16 - Female, Double Health")
                Console.WriteLine("17 - Female, Health & Power")
                Console.WriteLine("18 - Female, Power & Speed")
                Console.WriteLine("19 - Female, Health & Speed")
                Console.WriteLine("20 - Female, Balanced Power")
                Console.WriteLine("21 - Female, Balance Speed")
                Console.WriteLine("22 - Female, Balanced Health")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    If intResponse >= 3 And intResponse <= 22 Then
                        bpbBreed = CType(intResponse, Enums.BattlePetBreed)
                        Exit Do
                    Else
                        Console.WriteLine("Invalid response.")
                        Console.WriteLine()
                    End If
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get the quality.
            Do
                Console.WriteLine("Select the quality of the pet")
                Console.WriteLine("0 - Poor")
                Console.WriteLine("1 - Common")
                Console.WriteLine("2 - Uncommon")
                Console.WriteLine("3 - Rare")
                Console.WriteLine("4 - Epic")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    If intResponse >= 0 And intResponse <= 4 Then
                        qQuality = CType(intResponse, Enums.Quality)
                        Exit Do
                    Else
                        Console.WriteLine("Invalid response.")
                        Console.WriteLine()
                    End If
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Get the stats.
            Dim sStats As New BattlePetStats(intSpeciesID, intLevel, bpbBreed, qQuality)

            ' Show the Achievement.
            Console.Clear()
            If sStats.CacheHit.HasValue AndAlso sStats.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("Species: {0} - Level: {1} - Breed: {2} - Quality: {3}", sStats.Stats.SpeciesID, sStats.Stats.Level, sStats.Stats.Breed, sStats.Stats.PetQuality)
            Console.WriteLine("  Health: {0}", sStats.Stats.Health)
            Console.WriteLine("  Power: {0}", sStats.Stats.Power)
            Console.WriteLine("  Speed: {0}", sStats.Stats.Speed)
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub ChallengeRealmDemo()
            Console.Clear()
            Console.WriteLine("Challenge Mode for Realm")
            Console.WriteLine()

            ' Declare some variabales.
            Dim strRealm As String

            ' Next, get the realm.
            Do
                Console.WriteLine("Please enter the name of the realm to get the leaderboards for.")
                Console.Write(">")
                strRealm = Console.ReadLine

                If String.IsNullOrWhiteSpace(strRealm) Then
                    Console.WriteLine("You must enter a realm name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' Get the leaderboards.
            Dim crChallenge = New ChallengeRealm(strRealm)

            ' Show the leaderboards
            Console.Clear()
            If crChallenge.CacheHit.HasValue AndAlso crChallenge.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each cChallenge In crChallenge.Challenge
                Console.WriteLine("{0}) {1}", cChallenge.Map.ID, cChallenge.Map.Name)
                Console.WriteLine("  Bronze Time: {0:g}", cChallenge.Map.BronzeCriteria)
                Console.WriteLine("  Silver Time: {0:g}", cChallenge.Map.SilverCriteria)
                Console.WriteLine("  Gold Time: {0:g}", cChallenge.Map.GoldCriteria)
                For Each gGroup In cChallenge.Groups
                    Console.WriteLine("  {0}) {1:g}", gGroup.Ranking, gGroup.Time)
                    Console.WriteLine(
                        "    {0}", String.Join(
                            ", ", (
                                From m In gGroup.Members
                                Where m.Character IsNot Nothing
                                Select String.Format(CultureInfo.InvariantCulture, "{0}-{1}", m.Character.Name, m.Character.Realm)
                                ).ToArray()
                            )
                        )
                Next
            Next
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub ChallengeRegionDemo()
            Console.Clear()
            Console.WriteLine("Challenge Mode for Region")
            Console.WriteLine()

            ' Get the leaderboards.
            Dim crChallenge = New ChallengeRegion()
            crChallenge.Load()

            ' Show the leaderboards
            If crChallenge.CacheHit.HasValue AndAlso crChallenge.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each cChallenge In crChallenge.Challenge
                Console.WriteLine("{0}) {1}", cChallenge.Map.ID, cChallenge.Map.Name)
                Console.WriteLine("  Bronze Time: {0:g}", cChallenge.Map.BronzeCriteria)
                Console.WriteLine("  Silver Time: {0:g}", cChallenge.Map.SilverCriteria)
                Console.WriteLine("  Gold Time: {0:g}", cChallenge.Map.GoldCriteria)
                For Each gGroup In cChallenge.Groups
                    Console.WriteLine("  {0}) {1:g}", gGroup.Ranking, gGroup.Time)
                    Console.WriteLine(
                        "    {0}", String.Join(
                            ", ", (
                                From m In gGroup.Members
                                Where m.Character IsNot Nothing
                                Select String.Format(CultureInfo.InvariantCulture, "{0}-{1}", m.Character.Name, m.Character.Realm)
                                ).ToArray()
                            )
                        )
                Next
            Next
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub CharacterAchievementsDemo()
            Console.Clear()
            Console.WriteLine("Character Achievements Demo")
            Console.WriteLine()

            ' Get the character achievements.
            Dim caAchievements As New CharacterAchievements()
            caAchievements.Load()

            ' Show the character achievements.
            Console.Clear()
            If caAchievements.CacheHit.HasValue AndAlso caAchievements.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each cCategory In caAchievements.Categories
                Console.WriteLine("{0} - Category ID {1}", cCategory.Name, cCategory.ID)
                For Each aAchievement In cCategory.Achievements
                    Console.WriteLine("  {0} - ID {1} - Points: {2}", aAchievement.Title, aAchievement.ID, aAchievement.Points)
                    If aAchievement.AccountWide Then
                        Console.WriteLine("    Account-wide Achievement")
                    End If
                    Console.WriteLine("    Icon: {0}", aAchievement.Icon)
                    Console.WriteLine("    {0}", aAchievement.Description)
                    If Not String.IsNullOrWhiteSpace(aAchievement.Reward) Then
                        Console.WriteLine("    {0}", aAchievement.Reward)
                    End If
                    If aAchievement.RewardItems IsNot Nothing Then
                        For Each riItem In aAchievement.RewardItems
                            Console.WriteLine("      {0} - ID: {1} - Quality: {2}", riItem.Name, riItem.ID, riItem.Quality)
                        Next
                    End If
                    If aAchievement.Criteria IsNot Nothing Then
                        For Each cCriteria In aAchievement.Criteria
                            Console.WriteLine("    - {0}) {1}", cCriteria.ID, cCriteria.Description)
                        Next
                    End If
                Next
                If cCategory.Categories IsNot Nothing Then
                    For Each cSubCategory In cCategory.Categories
                        Console.WriteLine("  {0} - Category ID {1}", cSubCategory.Name, cSubCategory.ID)
                        For Each aAchievement In cSubCategory.Achievements
                            Console.WriteLine("    {0} - ID {1} - Points: {2}", aAchievement.Title, aAchievement.ID, aAchievement.Points)
                            If aAchievement.AccountWide Then
                                Console.WriteLine("      Account-wide Achievement")
                            End If
                            Console.WriteLine("      Icon: {0}", aAchievement.Icon)
                            Console.WriteLine("      {0}", aAchievement.Description)
                            If Not String.IsNullOrWhiteSpace(aAchievement.Reward) Then
                                Console.WriteLine("      {0}", aAchievement.Reward)
                            End If
                            If aAchievement.RewardItems IsNot Nothing Then
                                For Each riItem In aAchievement.RewardItems
                                    Console.WriteLine("        {0} - ID: {1} - Quality: {2}", riItem.Name, riItem.ID, riItem.Quality)
                                Next
                            End If
                            If aAchievement.Criteria IsNot Nothing Then
                                For Each cCriteria In aAchievement.Criteria
                                    Console.WriteLine("      - {0}) {1}", cCriteria.ID, cCriteria.Description)
                                Next
                            End If
                        Next
                    Next
                End If
                Console.WriteLine()
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub CharacterClassesDemo()
            Console.Clear()
            Console.WriteLine("Character Classes Demo")
            Console.WriteLine()

            ' Get the character classes.
            Dim ccClasses As New CharacterClasses.CharacterClasses()
            ccClasses.Load()

            ' Show the character classes.
            Console.Clear()
            If ccClasses.CacheHit.HasValue AndAlso ccClasses.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each cClass In ccClasses.Classes
                Console.WriteLine("{0}) {1} - uses {2} - Mask: {3}", cClass.ID, cClass.Name, cClass.PowerType, cClass.Mask)
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Private Sub DisplayEquippedItem(strSlot As String, iItem As LibWowAPI.Character.Item)
            Console.WriteLine("  {0}: {1} - ID {2} - Quality: {3} - iLevel: {4}", strSlot, iItem.Name, iItem.ID, iItem.Quality, iItem.ItemLevel)
            If iItem.TooltipParams.Upgrade IsNot Nothing Then
                Console.WriteLine("    Upgraded: {0}/{1} for {2} iLevels", iItem.TooltipParams.Upgrade.Current, iItem.TooltipParams.Upgrade.Total, iItem.TooltipParams.Upgrade.ItemLevelIncrement)
            End If
            If iItem.Armor > 0 OrElse iItem.Stats.Count > 0 Then
                Console.WriteLine("    Stats:")
                If iItem.Armor > 0 Then
                    Console.WriteLine("      {0} Armor", iItem.Armor)
                End If
                For Each sStat In iItem.Stats
                    If sStat.Reforged Then
                        Console.WriteLine("      {0} {1} (+{0} reforged)", sStat.TotalAmount, sStat.Stat)
                    ElseIf sStat.ReforgedAmount <> 0 Then
                        Console.WriteLine("      {0} {1} ({2} reforged)", sStat.TotalAmount, sStat.Stat, sStat.ReforgedAmount)
                    Else
                        Console.WriteLine("      {0} {1}", sStat.TotalAmount, sStat.Stat)
                    End If
                Next
            End If
            If iItem.TooltipParams.Gems.Count > 0 Then
                Console.WriteLine("    Gems: {0}", String.Join(", ", iItem.TooltipParams.Gems.Select(Function(g) g.ToString(CultureInfo.InvariantCulture)).ToArray()))
            End If
            If iItem.TooltipParams.ExtraSocket Then
                Console.WriteLine("      Includes Extra Socket.")
            End If
            If iItem.TooltipParams.Suffix <> 0 Then
                Console.WriteLine("    Suffix: {0} (Seed: {1})", iItem.TooltipParams.Suffix, iItem.TooltipParams.Seed)
            End If
            If iItem.TooltipParams.Enchant <> 0 Then
                Console.WriteLine("    Enchant: {0}", iItem.TooltipParams.Enchant)
            End If
            If iItem.TooltipParams.Reforge <> 0 Then
                Console.WriteLine("    Reforge: {0}", iItem.TooltipParams.Reforge)
            End If
            If iItem.TooltipParams.TransmogItem <> 0 Then
                Console.WriteLine("    Transmogrified into: {0}", iItem.TooltipParams.TransmogItem)
            End If
            If iItem.TooltipParams.Set.Count > 0 Then
                Console.WriteLine("    Set items: {0}", String.Join(", ", iItem.TooltipParams.Set.Select(Function(s) s.ToString(CultureInfo.InvariantCulture)).ToArray()))
            End If
        End Sub

        Private Sub DisplayArenaBracket(abBracket As ArenaBracket)
            Console.WriteLine("  {0}) {1} rating - {2}-{3} season - {4}-{5} week", abBracket.Slug, abBracket.Rating, abBracket.SeasonWon, abBracket.SeasonLost, abBracket.WeeklyWon, abBracket.WeeklyLost)
        End Sub

        Public Sub CharacterProfileDemo()
            Console.Clear()
            Console.WriteLine("Character Profile Demo")
            Console.WriteLine()

            ' Declare some variabales.
            Dim strRealm As String
            Dim strName As String

            ' Next, get the realm.
            Do
                Console.WriteLine("Please enter the name of the realm of the character whose profile you wish to retrieve.")
                Console.Write(">")
                strRealm = Console.ReadLine

                If String.IsNullOrWhiteSpace(strRealm) Then
                    Console.WriteLine("You must enter a realm name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' Next, get the character name.
            Do
                Console.WriteLine("Please enter the name of the character whose profile you wish to retrieve.")
                Console.Write(">")
                strName = Console.ReadLine

                If String.IsNullOrWhiteSpace(strName) Then
                    Console.WriteLine("You must enter a character name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' We can start building the character profile object.
            Dim cpCharacter As New CharacterProfile()
            cpCharacter.Options.Realm = strRealm
            cpCharacter.Options.Name = strName

            ' Next, allow the user to set the options.
            Console.Clear()
            Do
                Console.WriteLine("Character Profile Options")
                Console.WriteLine()
                Console.WriteLine("Please set the options you wish for looking up the character profile.")
                Console.WriteLine("  Or press enter to perform the character lookup.")
                Console.WriteLine("1 - Include Guild - {0}", If(cpCharacter.Options.Guild, "Yes", "No"))
                Console.WriteLine("2 - Include Combat Stats - {0}", If(cpCharacter.Options.Stats, "Yes", "No"))
                Console.WriteLine("3 - Include Talents - {0}", If(cpCharacter.Options.Talents, "Yes", "No"))
                Console.WriteLine("4 - Include Items - {0}", If(cpCharacter.Options.Items, "Yes", "No"))
                Console.WriteLine("5 - Include Reputation - {0}", If(cpCharacter.Options.Reputation, "Yes", "No"))
                Console.WriteLine("6 - Include Titles - {0}", If(cpCharacter.Options.Titles, "Yes", "No"))
                Console.WriteLine("7 - Include Professions - {0}", If(cpCharacter.Options.Professions, "Yes", "No"))
                Console.WriteLine("8 - Include Appearance - {0}", If(cpCharacter.Options.Appearance, "Yes", "No"))
                ' TODO: Add pets and petSlots
                '                Console.WriteLine("9 - Include Companion Pets - {0}", If(cpCharacter.Options.Companions, "Yes", "No"))
                Console.WriteLine("9 - Include Mounts - {0}", If(cpCharacter.Options.Mounts, "Yes", "No"))
                Console.WriteLine("10 - Include Hunter Pets - {0}", If(cpCharacter.Options.HunterPets, "Yes", "No"))
                Console.WriteLine("11 - Include Achievements - {0}", If(cpCharacter.Options.Achievements, "Yes", "No"))
                Console.WriteLine("12 - Include Progression - {0}", If(cpCharacter.Options.Progression, "Yes", "No"))
                Console.WriteLine("13 - Include PvP - {0}", If(cpCharacter.Options.PvP, "Yes", "No"))
                Console.WriteLine("14 - Include Quests - {0}", If(cpCharacter.Options.Quests, "Yes", "No"))
                Console.WriteLine("15 - Include Feed - {0}", If(cpCharacter.Options.Feed, "Yes", "No"))
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If String.IsNullOrWhiteSpace(strResponse) Then Exit Do
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 1
                            cpCharacter.Options.Guild = Not cpCharacter.Options.Guild
                        Case 2
                            cpCharacter.Options.Stats = Not cpCharacter.Options.Stats
                        Case 3
                            cpCharacter.Options.Talents = Not cpCharacter.Options.Talents
                        Case 4
                            cpCharacter.Options.Items = Not cpCharacter.Options.Items
                        Case 5
                            cpCharacter.Options.Reputation = Not cpCharacter.Options.Reputation
                        Case 6
                            cpCharacter.Options.Titles = Not cpCharacter.Options.Titles
                        Case 7
                            cpCharacter.Options.Professions = Not cpCharacter.Options.Professions
                        Case 8
                            cpCharacter.Options.Appearance = Not cpCharacter.Options.Appearance
                            ' TODO: Add pets and petSlots
                            'Case 9
                            '    cpCharacter.Options.Companions = Not cpCharacter.Options.Companions
                        Case 9
                            cpCharacter.Options.Mounts = Not cpCharacter.Options.Mounts
                        Case 10
                            cpCharacter.Options.HunterPets = Not cpCharacter.Options.HunterPets
                        Case 11
                            cpCharacter.Options.Achievements = Not cpCharacter.Options.Achievements
                        Case 12
                            cpCharacter.Options.Progression = Not cpCharacter.Options.Progression
                        Case 13
                            cpCharacter.Options.PvP = Not cpCharacter.Options.PvP
                        Case 14
                            cpCharacter.Options.Quests = Not cpCharacter.Options.Quests
                        Case 15
                            cpCharacter.Options.Feed = Not cpCharacter.Options.Feed
                    End Select
                    Console.Clear()
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Perform the character profile lookup.
            cpCharacter.Load()

            ' Show the character profile.
            Console.Clear()
            If cpCharacter.CacheHit.HasValue AndAlso cpCharacter.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0} - {1} - Level {2} {3} {4} {5}", cpCharacter.Character.Realm, cpCharacter.Character.Name, cpCharacter.Character.Level, cpCharacter.Character.Gender, cpCharacter.Character.Race.Name, cpCharacter.Character.Class.Name)
            Console.WriteLine("Battlegroup: {0}", cpCharacter.Character.Battlegroup)
            Console.WriteLine("Last updated: {0:M/d/yyyy h:mm:ss tt}", cpCharacter.Character.LastModified.ToLocalTime())
            Console.WriteLine("Achievement points: {0} - Total Honorable Kills: {1}", cpCharacter.Character.AchievementPoints, cpCharacter.Character.TotalHonorableKills)
            Console.WriteLine("Thumbnail: {0}", cpCharacter.Character.Thumbnail)
            Console.WriteLine("Total Honorable Kills: {0}", cpCharacter.Character.TotalHonorableKills)
            Console.WriteLine()

            If cpCharacter.Character.Guild IsNot Nothing Then
                Console.WriteLine("Guild:")
                Console.WriteLine("  {0} - Level {1} - {2} members - {3} achievement points", cpCharacter.Character.Guild.Name, cpCharacter.Character.Guild.Level, cpCharacter.Character.Guild.Members, cpCharacter.Character.Guild.AchievementPoints)
                Console.WriteLine("  Guild Emblem:")
                Console.WriteLine("    Icon: {0}", cpCharacter.Character.Guild.Emblem.Icon)
                Console.WriteLine("    Icon Color: {0}", cpCharacter.Character.Guild.Emblem.IconColor.Name)
                Console.WriteLine("    Border: {0}", cpCharacter.Character.Guild.Emblem.Border)
                Console.WriteLine("    Border Color: {0}", cpCharacter.Character.Guild.Emblem.BorderColor.Name)
                Console.WriteLine("    Background Color: {0}", cpCharacter.Character.Guild.Emblem.BackgroundColor.Name)
                Console.WriteLine()
            End If

            If cpCharacter.Character.Stats IsNot Nothing Then
                Console.WriteLine("Stats:")
                Console.WriteLine("  Health: {0} - {1}: {2}", cpCharacter.Character.Stats.Health, cpCharacter.Character.Stats.PowerType, cpCharacter.Character.Stats.Power)
                Console.WriteLine("  Str {0} - Agi {1} - Sta {2} - Int {3} - Spr {4}", cpCharacter.Character.Stats.Str, cpCharacter.Character.Stats.Agi, cpCharacter.Character.Stats.Sta, cpCharacter.Character.Stats.Int, cpCharacter.Character.Stats.Spr)
                Console.WriteLine("  Attack Power: {0} (Ranged: {1})", cpCharacter.Character.Stats.AttackPower, cpCharacter.Character.Stats.RangedAttackPower)
                Console.WriteLine("  Mastery: {0:N2} (Rating: {1})", cpCharacter.Character.Stats.Mastery, cpCharacter.Character.Stats.MasteryRating)
                Console.WriteLine("  Crit: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.Crit, cpCharacter.Character.Stats.CritRating)
                Console.WriteLine("  Hit: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.HitPercent, cpCharacter.Character.Stats.HitRating)
                Console.WriteLine("  Haste Rating: {0}", cpCharacter.Character.Stats.HasteRating)
                Console.WriteLine("  Expertise Rating: {0}", cpCharacter.Character.Stats.ExpertiseRating)
                Console.WriteLine("  Spell Power: {0}", cpCharacter.Character.Stats.SpellPower)
                Console.WriteLine("  Spell Penetration: {0}", cpCharacter.Character.Stats.SpellPen)
                Console.WriteLine("  Spell Crit: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.SpellCrit, cpCharacter.Character.Stats.SpellCritRating)
                Console.WriteLine("  Spell Hit: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.SpellHitPercent, cpCharacter.Character.Stats.SpellHitRating)
                Console.WriteLine("  Mana Per 5: {0} (While In Combat: {1})", cpCharacter.Character.Stats.Mana5, cpCharacter.Character.Stats.Mana5Combat)
                Console.WriteLine("  Armor: {0}", cpCharacter.Character.Stats.Armor)
                Console.WriteLine("  Dodge: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.Dodge, cpCharacter.Character.Stats.DodgeRating)
                Console.WriteLine("  Parry: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.Parry, cpCharacter.Character.Stats.ParryRating)
                Console.WriteLine("  Block: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.Block, cpCharacter.Character.Stats.BlockRating)
                Console.WriteLine("  PvP Resilience: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.PvpResilience, cpCharacter.Character.Stats.PvpResilienceRating)
                Console.WriteLine("  Main Hand: {0:N1}-{1:N1} Damage, {2:N2} Speed, {3:N2} DPS, {4} Expertise", cpCharacter.Character.Stats.MainHandDmgMin, cpCharacter.Character.Stats.MainHandDmgMax, cpCharacter.Character.Stats.MainHandSpeed, cpCharacter.Character.Stats.MainHandDps, cpCharacter.Character.Stats.MainHandExpertise)
                Console.WriteLine("  Off Hand: {0:N1}-{1:N1} Damage, {2:N2} Speed, {3:N2} DPS, {4} Expertise", cpCharacter.Character.Stats.OffHandDmgMin, cpCharacter.Character.Stats.OffHandDmgMax, cpCharacter.Character.Stats.OffHandSpeed, cpCharacter.Character.Stats.OffHandDps, cpCharacter.Character.Stats.OffHandExpertise)
                Console.WriteLine("  Ranged: {0:N1}-{1:N1} Damage, {2:N2} Speed, {3:N2} DPS", cpCharacter.Character.Stats.RangedDmgMin, cpCharacter.Character.Stats.RangedDmgMax, cpCharacter.Character.Stats.RangedSpeed, cpCharacter.Character.Stats.RangedDps)
                Console.WriteLine("  Ranged Crit: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.RangedCrit, cpCharacter.Character.Stats.RangedCritRating)
                Console.WriteLine("  Ranged Hit: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.RangedHitPercent, cpCharacter.Character.Stats.RangedHitRating)
                Console.WriteLine("  PvP Power: {0:N2}% (Rating: {1})", cpCharacter.Character.Stats.PvpPower, cpCharacter.Character.Stats.PvpPowerRating)
                Console.WriteLine()
            End If

            If cpCharacter.Character.Talents IsNot Nothing Then
                Console.WriteLine("Talents:")
                For Each tsTalent In cpCharacter.Character.Talents
                    Console.WriteLine("  {0} - {1}", tsTalent.Spec.Name, tsTalent.Spec.Description)
                    For Each tTalent In tsTalent.Talents
                        Console.WriteLine("    {0} - Tier {1} - Column {2}", tTalent.Spell.Name, tTalent.Tier, tTalent.Column)
                    Next
                    Console.WriteLine("  Glyphs:")
                    Console.WriteLine("    Major:")
                    For Each gGlyph In tsTalent.Glyphs.Major
                        Console.WriteLine("      {0} - ID {1} - Item {2}", gGlyph.Name, gGlyph.Glyph, gGlyph.Item)
                    Next
                    Console.WriteLine("    Minor:")
                    For Each gGlyph In tsTalent.Glyphs.Minor
                        Console.WriteLine("      {0} - ID {1} - Item {2}", gGlyph.Name, gGlyph.Glyph, gGlyph.Item)
                    Next
                Next
                Console.WriteLine()
            End If

            If cpCharacter.Character.Items IsNot Nothing Then
                Console.WriteLine("Items:")
                Console.WriteLine("  Average Item Level: {0} (Equipped: {1})", cpCharacter.Character.Items.AverageItemLevel, cpCharacter.Character.Items.AverageItemLevelEquipped)
                If cpCharacter.Character.Items.Head IsNot Nothing Then
                    DisplayEquippedItem("Head", cpCharacter.Character.Items.Head)
                End If
                If cpCharacter.Character.Items.Neck IsNot Nothing Then
                    DisplayEquippedItem("Neck", cpCharacter.Character.Items.Neck)
                End If
                If cpCharacter.Character.Items.Shoulder IsNot Nothing Then
                    DisplayEquippedItem("Shoulder", cpCharacter.Character.Items.Shoulder)
                End If
                If cpCharacter.Character.Items.Back IsNot Nothing Then
                    DisplayEquippedItem("Back", cpCharacter.Character.Items.Back)
                End If
                If cpCharacter.Character.Items.Chest IsNot Nothing Then
                    DisplayEquippedItem("Chest", cpCharacter.Character.Items.Chest)
                End If
                If cpCharacter.Character.Items.Shirt IsNot Nothing Then
                    DisplayEquippedItem("Shirt", cpCharacter.Character.Items.Shirt)
                End If
                If cpCharacter.Character.Items.Tabard IsNot Nothing Then
                    DisplayEquippedItem("Tabard", cpCharacter.Character.Items.Tabard)
                End If
                If cpCharacter.Character.Items.Wrist IsNot Nothing Then
                    DisplayEquippedItem("Wrist", cpCharacter.Character.Items.Wrist)
                End If
                If cpCharacter.Character.Items.Hands IsNot Nothing Then
                    DisplayEquippedItem("Hands", cpCharacter.Character.Items.Hands)
                End If
                If cpCharacter.Character.Items.Waist IsNot Nothing Then
                    DisplayEquippedItem("Waist", cpCharacter.Character.Items.Waist)
                End If
                If cpCharacter.Character.Items.Legs IsNot Nothing Then
                    DisplayEquippedItem("Legs", cpCharacter.Character.Items.Legs)
                End If
                If cpCharacter.Character.Items.Feet IsNot Nothing Then
                    DisplayEquippedItem("Feet", cpCharacter.Character.Items.Feet)
                End If
                If cpCharacter.Character.Items.Finger1 IsNot Nothing Then
                    DisplayEquippedItem("Finger1", cpCharacter.Character.Items.Finger1)
                End If
                If cpCharacter.Character.Items.Finger2 IsNot Nothing Then
                    DisplayEquippedItem("Finger2", cpCharacter.Character.Items.Finger2)
                End If
                If cpCharacter.Character.Items.Trinket1 IsNot Nothing Then
                    DisplayEquippedItem("HeadTrinket1", cpCharacter.Character.Items.Trinket1)
                End If
                If cpCharacter.Character.Items.Trinket2 IsNot Nothing Then
                    DisplayEquippedItem("Trinket2", cpCharacter.Character.Items.Trinket2)
                End If
                If cpCharacter.Character.Items.MainHand IsNot Nothing Then
                    DisplayEquippedItem("MainHand", cpCharacter.Character.Items.MainHand)
                End If
                If cpCharacter.Character.Items.OffHand IsNot Nothing Then
                    DisplayEquippedItem("OffHand", cpCharacter.Character.Items.OffHand)
                End If
                Console.WriteLine()
            End If

            If cpCharacter.Character.Reputation IsNot Nothing Then
                Console.WriteLine("Reputation:")
                For Each rReputation In cpCharacter.Character.Reputation
                    Console.WriteLine("  {0} - ID: {1} - {2}/{3} {4}", rReputation.Name, rReputation.ID, rReputation.Value, rReputation.Max, rReputation.Standing)
                Next
                Console.WriteLine()
            End If

            If cpCharacter.Character.Titles IsNot Nothing Then
                Console.WriteLine("Titles:")
                For Each tTitle In cpCharacter.Character.Titles
                    Console.WriteLine("  {0} - ID: {1}{2}", tTitle.Name.Replace("%s", cpCharacter.Character.Name), tTitle.ID, If(tTitle.Selected, " - Selected", ""))
                Next
                Console.WriteLine()
            End If

            If cpCharacter.Character.Professions IsNot Nothing Then
                Console.WriteLine("Professions:")
                Console.WriteLine("  Primary:")
                For Each pProfession In cpCharacter.Character.Professions.Primary
                    Console.WriteLine("    {0} - {1}/{2}", pProfession.Name, pProfession.Rank, pProfession.Max)
                    If pProfession.Recipes.Count > 0 Then
                        Console.WriteLine("      Recipes: {0}", String.Join(", ", pProfession.Recipes.Select(Function(r) r.ToString(CultureInfo.InvariantCulture)).ToArray()))
                    End If
                Next
                Console.WriteLine("  Secondary:")
                For Each pProfession In cpCharacter.Character.Professions.Secondary
                    Console.WriteLine("    {0} - {1}/{2}", pProfession.Name, pProfession.Rank, pProfession.Max)
                    If pProfession.Recipes.Count > 0 Then
                        Console.WriteLine("      Recipes: {0}", String.Join(", ", pProfession.Recipes.Select(Function(r) r.ToString(CultureInfo.InvariantCulture)).ToArray()))
                    End If
                Next
                Console.WriteLine()
            End If

            If cpCharacter.Character.Appearance IsNot Nothing Then
                Console.WriteLine("Appearance:")
                Console.WriteLine("  Face variation: {0}", cpCharacter.Character.Appearance.FaceVariation)
                Console.WriteLine("  Skin color: {0}", cpCharacter.Character.Appearance.SkinColor)
                Console.WriteLine("  Hair variation: {0}", cpCharacter.Character.Appearance.HairVariation)
                Console.WriteLine("  Hair color: {0}", cpCharacter.Character.Appearance.HairColor)
                Console.WriteLine("  Feature variation: {0}", cpCharacter.Character.Appearance.FeatureVariation)
                Console.WriteLine("  Show helm: {0}", If(cpCharacter.Character.Appearance.ShowHelm, "Yes", "No"))
                Console.WriteLine("  Show cloak: {0}", If(cpCharacter.Character.Appearance.ShowCloak, "Yes", "No"))
                Console.WriteLine()
            End If

            ' TODO: Add pets and petSlots
            'If cpCharacter.Character.Companions IsNot Nothing Then
            '    Console.WriteLine("Companions:")
            '    Console.WriteLine("  {0}", String.Join(", ", cpCharacter.Character.Companions.Select(Function(c) c.ToString(CultureInfo.InvariantCulture)).ToArray()))
            '    Console.WriteLine()
            'End If

            If cpCharacter.Character.Mounts IsNot Nothing Then
                Console.WriteLine("Mounts:")
                Console.WriteLine("  Collected: {0}", cpCharacter.Character.Mounts.NumCollected)
                Console.WriteLine("  Not Collected: {0}", cpCharacter.Character.Mounts.NumNotCollected)
                Console.WriteLine("  Mounts:")
                For Each mMount In cpCharacter.Character.Mounts.Collected
                    Console.WriteLine("    {0} - {1} - Spell ID: {2} - Creature ID {3} - Item ID {4}", mMount.Name, mMount.Quality, mMount.SpellID, mMount.CreatureID, mMount.ItemID)
                    Console.WriteLine("      Ground: {0} - Flying: {1} - Aquatic: {2} - Jumping: {3}", mMount.IsGround, mMount.IsFlying, mMount.IsAquatic, mMount.IsJumping)
                Next
                Console.WriteLine()
            End If

            If cpCharacter.Character.HunterPets IsNot Nothing Then
                Console.WriteLine("Hunter Pets:")
                For Each hpHunterPet In cpCharacter.Character.HunterPets
                    Console.WriteLine("  {0} - Creature: {1} - Family: {2} - Slot: {3}", hpHunterPet.Name, hpHunterPet.Creature, hpHunterPet.FamilyName, hpHunterPet.Slot)
                    If hpHunterPet.Spec IsNot Nothing Then
                        Console.WriteLine("    Spec:")
                        Console.WriteLine("      {0} - {1}", hpHunterPet.Spec.Name, hpHunterPet.Spec.Role)
                    End If
                Next
                Console.WriteLine()
            End If

            If cpCharacter.Character.Achievements IsNot Nothing Then
                Console.WriteLine("Achievements:")
                For Each aAchievement In cpCharacter.Character.Achievements.Achievements
                    Console.WriteLine("  ID: {0} - Completed: {1:M/d/yyyy h:mm:ss tt}", aAchievement.ID, aAchievement.Timestamp.ToLocalTime())
                Next
                Console.WriteLine()
                Console.WriteLine("Guild Achievement Criteria:")
                For Each cCriteria In cpCharacter.Character.Achievements.Criteria
                    Console.WriteLine("  ID: {0} - Started: {1: M/d/yyyy h:mm:ss tt} - Completed: {2: M/d/yyyy h:mm:ss tt} - Quantity: {3}", cCriteria.ID, cCriteria.Timestamp.ToLocalTime(), cCriteria.Created.ToLocalTime(), cCriteria.Quantity)
                Next
                Console.WriteLine()
            End If

            If cpCharacter.Character.Progression IsNot Nothing Then
                Console.WriteLine("Progression:")
                Console.WriteLine("  Raids:")
                For Each rRaid In cpCharacter.Character.Progression.Raids
                    Console.WriteLine("    {0} - ID: {1} - Normal: {2} - Heroic: {3}", rRaid.Name, rRaid.ID, rRaid.Normal, rRaid.Heroic)
                    For Each bBoss In rRaid.Bosses
                        Console.WriteLine("      {0} - ID: {1}", bBoss.Name, bBoss.ID)
                        If bBoss.NormalKills > 0 Then
                            Console.WriteLine("        Normal: {0} kills - Last Kill: {1:M/d/yyyy}", bBoss.NormalKills, bBoss.NormalTimestamp)
                        Else
                            Console.WriteLine("        Normal: 0 kills")
                        End If
                        If bBoss.HeroicKills > 0 Then
                            Console.WriteLine("        Heroic: {0} kills - Last Kill: {1:M/d/yyyy}", bBoss.HeroicKills, bBoss.HeroicTimestamp)
                        Else
                            Console.WriteLine("        Heroic: 0 kills")
                        End If
                        If bBoss.LFRKills > 0 Then
                            Console.WriteLine("        LFR: {0} kills - Last Kill: {1:M/d/yyyy}", bBoss.LFRKills, bBoss.LFRTimestamp)
                        Else
                            Console.WriteLine("        LFR: 0 kills")
                        End If
                        If bBoss.FlexKills > 0 Then
                            Console.WriteLine("        Flex: {0} kills - Last Kill: {1:M/d/yyyy}", bBoss.FlexKills, bBoss.FlexTimestamp)
                        Else
                            Console.WriteLine("        Flex: 0 kills")
                        End If
                    Next
                Next
                Console.WriteLine()
            End If

            If cpCharacter.Character.PvP IsNot Nothing Then
                Console.WriteLine("PvP:")
                DisplayArenaBracket(cpCharacter.Character.PvP.Brackets.ArenaBracket2v2)
                DisplayArenaBracket(cpCharacter.Character.PvP.Brackets.ArenaBracket3v3)
                DisplayArenaBracket(cpCharacter.Character.PvP.Brackets.ArenaBracket5v5)
                DisplayArenaBracket(cpCharacter.Character.PvP.Brackets.ArenaBracketRBG)
                Console.WriteLine()
            End If

            If cpCharacter.Character.Quests IsNot Nothing Then
                Console.WriteLine("Quests:")
                Console.WriteLine("  {0}", String.Join(", ", cpCharacter.Character.Quests.Select(Function(q) q.ToString(CultureInfo.InvariantCulture)).ToArray()))
                Console.WriteLine()
            End If

            If cpCharacter.Character.Feed IsNot Nothing Then
                Console.WriteLine("Feed:")
                For Each fiItem In cpCharacter.Character.Feed
                    Dim afItem = TryCast(fiItem, AchievementFeed)
                    Dim bkfItem = TryCast(fiItem, BossKillFeed)
                    Dim cfItem = TryCast(fiItem, CriteriaFeed)
                    Dim lfItem = TryCast(fiItem, LootFeed)
                    If afItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Achievement: {1}", afItem.Date, afItem.Achievement.Title)
                    ElseIf bkfItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Boss Kill: {1}", bkfItem.Date, bkfItem.Name)
                    ElseIf cfItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Achievement Criteria: {1} for {2}", cfItem.Date, cfItem.Criteria.Description, cfItem.Achievement.Title)
                    ElseIf lfItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Loot: {1}", lfItem.Date, lfItem.ItemID)
                    End If
                Next
                Console.WriteLine()
            End If

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub CharacterRacesDemo()
            Console.Clear()
            Console.WriteLine("Character Races Demo")
            Console.WriteLine()

            ' Get the character races.
            Dim crRaces As New CharacterRaces.CharacterRaces()
            crRaces.Load()

            ' Show the character races.
            Console.Clear()
            If crRaces.CacheHit.HasValue AndAlso crRaces.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each rRace In crRaces.Races
                Console.WriteLine("{0}) {1} - {2} - Mask: {3}", rRace.ID, rRace.Name, rRace.Faction, rRace.Mask)
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub GuildAchievementsDemo()
            Console.Clear()
            Console.WriteLine("Guild Achievements Demo")
            Console.WriteLine()

            ' Get the guild achievements.
            Dim gaAchievements As New GuildAchievements()
            gaAchievements.Load()

            ' Show the guild achievements.
            Console.Clear()
            If gaAchievements.CacheHit.HasValue AndAlso gaAchievements.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each cCategory In gaAchievements.Categories
                Console.WriteLine("{0} - Category ID {1}", cCategory.Name, cCategory.ID)
                For Each aAchievement In cCategory.Achievements
                    Console.WriteLine("  {0} - ID {1} - Points: {2}", aAchievement.Title, aAchievement.ID, aAchievement.Points)
                    Console.WriteLine("    {0}", aAchievement.Description)
                    If aAchievement.AccountWide Then
                        Console.WriteLine("    Account-wide Achievement")
                    End If
                    If Not String.IsNullOrWhiteSpace(aAchievement.Reward) Then
                        Console.WriteLine("    {0}", aAchievement.Reward)
                    End If
                    If aAchievement.RewardItems IsNot Nothing Then
                        For Each riItem In aAchievement.RewardItems
                            Console.WriteLine("      {0} - ID: {1} - Quality: {2}", riItem.Name, riItem.ID, riItem.Quality)
                        Next
                    End If
                    If aAchievement.Criteria IsNot Nothing Then
                        For Each cCriteria In aAchievement.Criteria
                            Console.WriteLine("    - {0}) {1}", cCriteria.ID, cCriteria.Description)
                        Next
                    End If
                Next
                If cCategory.Categories IsNot Nothing Then
                    For Each cSubCategory In cCategory.Categories
                        Console.WriteLine("  {0} - Category ID {1}", cSubCategory.Name, cSubCategory.ID)
                        For Each aAchievement In cSubCategory.Achievements
                            Console.WriteLine("    {0} - ID {1} - Points: {2}", aAchievement.Title, aAchievement.ID, aAchievement.Points)
                            If aAchievement.AccountWide Then
                                Console.WriteLine("      Account-wide Achievement")
                            End If
                            Console.WriteLine("      {0}", aAchievement.Description)
                            If Not String.IsNullOrWhiteSpace(aAchievement.Reward) Then
                                Console.WriteLine("      {0}", aAchievement.Reward)
                            End If
                            If aAchievement.RewardItems IsNot Nothing Then
                                For Each riItem In aAchievement.RewardItems
                                    Console.WriteLine("        {0} - ID: {1} - Quality: {2}", riItem.Name, riItem.ID, riItem.Quality)
                                Next
                            End If
                            If aAchievement.Criteria IsNot Nothing Then
                                For Each cCriteria In aAchievement.Criteria
                                    Console.WriteLine("      - {0}) {1}", cCriteria.ID, cCriteria.Description)
                                Next
                            End If
                        Next
                    Next
                End If
                Console.WriteLine()
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub GuildPerksDemo()
            Console.Clear()
            Console.WriteLine("Guild Perks Demo")
            Console.WriteLine()

            ' Get the guild perks.
            Dim gpPerks As New GuildPerks()
            gpPerks.Load()

            ' Show the guild perks.
            Console.Clear()
            If gpPerks.CacheHit.HasValue AndAlso gpPerks.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each pPerk In gpPerks.Perks
                If String.IsNullOrWhiteSpace(pPerk.Spell.Rank) Then
                    Console.WriteLine("Level {0} - {1} - ID: {2}", pPerk.GuildLevel, pPerk.Spell.Name, pPerk.Spell.ID)
                Else
                    Console.WriteLine("Level {0} - {1} {2} - ID: {3}", pPerk.GuildLevel, pPerk.Spell.Name, pPerk.Spell.Rank, pPerk.Spell.ID)
                End If
                If Not String.IsNullOrWhiteSpace(pPerk.Spell.Range) Then
                    Console.WriteLine("Range: {0}", pPerk.Spell.Range)
                End If
                Console.WriteLine(pPerk.Spell.Description)
                If Not String.IsNullOrWhiteSpace(pPerk.Spell.CastTime) Then
                    Console.WriteLine("Cast Time: {0}", pPerk.Spell.CastTime)
                End If
                If Not String.IsNullOrWhiteSpace(pPerk.Spell.Cooldown) Then
                    Console.WriteLine("Cooldown: {0}", pPerk.Spell.Cooldown)
                End If
                Console.WriteLine()
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub GuildProfileDemo()
            Console.Clear()
            Console.WriteLine("Guild Profile Demo")
            Console.WriteLine()

            ' Declare some variabales.
            Dim strRealm As String
            Dim strName As String

            ' Next, get the realm.
            Do
                Console.WriteLine("Please enter the name of the realm of the guild whose profile you wish to retrieve.")
                Console.Write(">")
                strRealm = Console.ReadLine

                If String.IsNullOrWhiteSpace(strRealm) Then
                    Console.WriteLine("You must enter a realm name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' Next, get the guild name.
            Do
                Console.WriteLine("Please enter the name of the guild whose profile you wish to retrieve.")
                Console.Write(">")
                strName = Console.ReadLine

                If String.IsNullOrWhiteSpace(strName) Then
                    Console.WriteLine("You must enter a guild name.")
                    Console.WriteLine()
                Else
                    Exit Do
                End If
            Loop

            ' We can start building the guild profile object.
            Dim gpGuild As New GuildProfile()
            gpGuild.Options.Realm = strRealm
            gpGuild.Options.Name = strName

            ' Next, allow the user to set the options.
            Console.Clear()
            Do
                Console.WriteLine("Guild Profile Options")
                Console.WriteLine()
                Console.WriteLine("Please set the options you wish for looking up the guild profile.")
                Console.WriteLine("  Or press enter to perform the guild lookup.")
                Console.WriteLine("1 - Include Guild Achievements - {0}", If(gpGuild.Options.Achievements, "Yes", "No"))
                Console.WriteLine("2 - Include Members - {0}", If(gpGuild.Options.Members, "Yes", "No"))
                Console.WriteLine("3 - Include News - {0}", If(gpGuild.Options.News, "Yes", "No"))
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If String.IsNullOrWhiteSpace(strResponse) Then Exit Do
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 1
                            gpGuild.Options.Achievements = Not gpGuild.Options.Achievements
                        Case 2
                            gpGuild.Options.Members = Not gpGuild.Options.Members
                        Case 3
                            gpGuild.Options.News = Not gpGuild.Options.News
                    End Select
                    Console.Clear()
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Perform the guild profile lookup.
            gpGuild.Load()

            ' Show the guild profile.
            Console.Clear()
            If gpGuild.CacheHit.HasValue AndAlso gpGuild.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0} - {1} - {2} - Level {3}", gpGuild.Guild.Realm, gpGuild.Guild.Faction, gpGuild.Guild.Name, gpGuild.Guild.Level)
            Console.WriteLine("Battlegroup: {0}", gpGuild.Guild.Battlegroup)
            Console.WriteLine("Last updated: {0:M/d/yyyy h:mm:ss tt}", gpGuild.Guild.LastModified.ToLocalTime())
            Console.WriteLine("Guild Achievement Points: {0}", gpGuild.Guild.AchievementPoints)
            Console.WriteLine("Guild Emblem:")
            Console.WriteLine("  Icon: {0}", gpGuild.Guild.Emblem.Icon)
            Console.WriteLine("  Icon Color: {0}", gpGuild.Guild.Emblem.IconColor.Name)
            Console.WriteLine("  Border: {0}", gpGuild.Guild.Emblem.Border)
            Console.WriteLine("  Border Color: {0}", gpGuild.Guild.Emblem.BorderColor.Name)
            Console.WriteLine("  Background Color: {0}", gpGuild.Guild.Emblem.BackgroundColor.Name)
            Console.WriteLine()

            If gpGuild.Guild.Achievements IsNot Nothing Then
                Console.WriteLine("Guild Achievements:")
                For Each aAchievement In gpGuild.Guild.Achievements.Achievements
                    Console.WriteLine("  ID: {0} - Completed: {1:M/d/yyyy h:mm:ss tt}", aAchievement.ID, aAchievement.Timestamp.ToLocalTime())
                Next
                Console.WriteLine()
                Console.WriteLine("Guild Achievement Criteria:")
                For Each cCriteria In gpGuild.Guild.Achievements.Criteria
                    Console.WriteLine("  ID: {0} - Started: {1: M/d/yyyy h:mm:ss tt} - Completed: {2: M/d/yyyy h:mm:ss tt} - Quantity: {3}", cCriteria.ID, cCriteria.Timestamp.ToLocalTime(), cCriteria.Created.ToLocalTime(), cCriteria.Quantity)
                Next
                Console.WriteLine()
            End If

            If gpGuild.Guild.Members IsNot Nothing Then
                Console.WriteLine("Members:")
                For Each mMember In gpGuild.Guild.Members
                    Console.WriteLine("  {0} - Level {1} {2} {3} {4} {5}- Rank {6}", mMember.Character.Name, mMember.Character.Level, mMember.Character.Gender, mMember.Character.Race.Name, mMember.Character.Class.Name, If(mMember.Character.Spec Is Nothing, Nothing, mMember.Character.Spec.Name & " "), mMember.Rank)
                Next
                Console.WriteLine()
            End If

            If gpGuild.Guild.News IsNot Nothing Then
                Console.WriteLine("News:")
                For Each niItem In gpGuild.Guild.News
                    Dim ganItem = TryCast(niItem, GuildAchievementNews)
                    Dim gcnItem = TryCast(niItem, GuildCreatedNews)
                    Dim glnItem = TryCast(niItem, GuildLevelNews)
                    Dim ilnItem = TryCast(niItem, ItemLootNews)
                    Dim ipnItem = TryCast(niItem, ItemPurchaseNews)
                    Dim panItem = TryCast(niItem, PlayerAchievementNews)
                    If ganItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Guild Achievement: {1}", ganItem.Date, ganItem.Achievement.Title)
                    ElseIf gcnItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Guild Created", gcnItem.Date)
                    ElseIf glnItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Guild Level: {1}", glnItem.Date, glnItem.LevelUp)
                    ElseIf ilnItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Item Looted: {1} by {2}", ilnItem.Date, ilnItem.ItemID, ilnItem.Character)
                    ElseIf ipnItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Item Purchased: {1} by {2}", ipnItem.Date, ipnItem.ItemID, ipnItem.Character)
                    ElseIf panItem IsNot Nothing Then
                        Console.WriteLine("  {0:M/d/yyyy} - Player Achievement: {1} by {2}", panItem.Date, panItem.Achievement.Title, panItem.Character)
                    End If
                Next
                Console.WriteLine()
            End If

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub GuildRewardsDemo()
            Console.Clear()
            Console.WriteLine("Guild Rewards Demo")
            Console.WriteLine()

            ' Get the guild rewards.
            Dim grRewards As New GuildRewards()
            grRewards.Load()

            ' Show the guild rewards.
            Console.Clear()
            If grRewards.CacheHit.HasValue AndAlso grRewards.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each rReward In grRewards.Rewards
                Console.WriteLine("{0} - ID: {1} - Quality: {2} - iLevel: {3} - Armor: {4}", rReward.RewardItem.Name, rReward.RewardItem.ID, rReward.RewardItem.Quality, rReward.RewardItem.ItemLevel, rReward.RewardItem.Armor)
                If rReward.RequiredGuildLevel > 0 Then
                    Console.WriteLine("Required Guild Level: {0}", rReward.RequiredGuildLevel)
                End If
                Console.WriteLine("Required Guild Standing: {0}", rReward.RequiredGuildStanding)
                If rReward.Races IsNot Nothing Then
                    Console.WriteLine("Required races: {0}", String.Join(", ", rReward.Races.Select(Function(r) r.Name)))
                End If
                If rReward.Achievement IsNot Nothing Then
                    Console.WriteLine("Guild Achievement: {0} - ID: {1} - {2} Points", rReward.Achievement.Title, rReward.Achievement.ID, rReward.Achievement.Points)
                    Console.WriteLine("  {0}", rReward.Achievement.Description)
                    If rReward.Achievement.AccountWide Then
                        Console.WriteLine("    Account-wide Achievement")
                    End If
                    If Not String.IsNullOrWhiteSpace(rReward.Achievement.Reward) Then
                        Console.WriteLine("    {0}", rReward.Achievement.Reward)
                    End If
                    If rReward.Achievement.RewardItems IsNot Nothing Then
                        For Each riItem In rReward.Achievement.RewardItems
                            Console.WriteLine("      {0} - ID: {1} - Quality: {2} - iLevel: {3} - Armor: {4}", riItem.Name, riItem.ID, riItem.Quality, riItem.ItemLevel, riItem.Armor)
                        Next
                    End If
                    If rReward.Achievement.Criteria IsNot Nothing Then
                        For Each cCriteria In rReward.Achievement.Criteria
                            Console.WriteLine("    - {0}) {1}", cCriteria.ID, cCriteria.Description)
                        Next
                    End If
                End If
                Console.WriteLine()
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub ItemClassesDemo()
            Console.Clear()
            Console.WriteLine("Item Classes Demo")
            Console.WriteLine()

            ' Get the item classes.
            Dim icClasses As New ItemClasses.ItemClasses()
            icClasses.Load()

            ' Show the item classes.
            Console.Clear()
            If icClasses.CacheHit.HasValue AndAlso icClasses.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each cClass In icClasses.Classes
                Console.WriteLine("{0}) {1}", cClass.Class, cClass.Name)
                For Each sSubclass In cClass.Subclasses
                    Console.WriteLine("  {0}) {1}", sSubclass.Subclass, sSubclass.Name)
                Next
            Next
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub ItemLookupDemo()
            Console.Clear()
            Console.WriteLine("Item Lookup Demo")
            Console.WriteLine()

            ' First, setup some variables
            Dim intItemID As Integer

            ' Next, get the item ID.
            Do
                Console.WriteLine("Please enter the ID number of the item you wish to lookup.")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If Integer.TryParse(strResponse, intItemID) Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Get the Item.
            Dim iItem As New ItemLookup(intItemID)

            ' Show the item.
            Console.Clear()
            If iItem.CacheHit.HasValue AndAlso iItem.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0} - ID: {1} - Quality: {2}", iItem.Item.Name, iItem.Item.ID, iItem.Item.Quality)
            If iItem.Item.ItemBind <> Enums.Binding.NoBinding Then
                Console.WriteLine("Binding: {0}", iItem.Item.ItemBind)
            End If
            If Not String.IsNullOrWhiteSpace(iItem.Item.Description) Then
                Console.WriteLine("""{0}""", iItem.Item.Description)
            End If
            If iItem.Item.StackSize > 1 Then
                Console.WriteLine("Stacks in lots of {0}", iItem.Item.StackSize)
            End If
            If iItem.Item.AllowableClasses IsNot Nothing Then
                Console.WriteLine("Allowable Classes:")
                For Each cClass In iItem.Item.AllowableClasses
                    Console.WriteLine("  {0}", cClass.Name)
                Next
            End If
            If iItem.Item.AllowableRaces IsNot Nothing Then
                Console.WriteLine("Allowable Races:")
                For Each rRace In iItem.Item.AllowableRaces
                    Console.WriteLine("  {0}", rRace.Name)
                Next
            End If
            If iItem.Item.BoundZone IsNot Nothing Then
                Console.WriteLine("Bound to zone: {0} - ID: {1}", iItem.Item.BoundZone.Name, iItem.Item.BoundZone.ID)
            End If
            If iItem.Item.BaseArmor > 0 Then
                Console.WriteLine("Base Armor: {0}", iItem.Item.BaseArmor)
            End If
            If iItem.Item.BonusStats IsNot Nothing Then
                Console.WriteLine("Stats:")
                For Each sStat In iItem.Item.BonusStats
                    Console.WriteLine("  +{0} {1}", sStat.Amount, sStat.Stat)
                Next
            End If
            If iItem.Item.ItemSpells IsNot Nothing Then
                Console.WriteLine("Spells:")
                For Each isSpell In iItem.Item.ItemSpells
                    Console.WriteLine("  {0} - ID: {1} - Category ID: {2}", isSpell.Spell.Name, isSpell.SpellID, isSpell.CategoryID)
                    If Not String.IsNullOrWhiteSpace(isSpell.Spell.Rank) Then
                        Console.WriteLine("    {0}", isSpell.Spell.Rank)
                    End If
                    If Not String.IsNullOrWhiteSpace(isSpell.Spell.CastTime) Then
                        Console.WriteLine("    {0}", isSpell.Spell.CastTime)
                    End If
                    If Not String.IsNullOrWhiteSpace(isSpell.Spell.Range) Then
                        Console.WriteLine("    {0}", isSpell.Spell.Range)
                    End If
                    If Not String.IsNullOrWhiteSpace(isSpell.Spell.Description) Then
                        Console.WriteLine("    {0}", isSpell.Spell.Description)
                    End If
                    If Not String.IsNullOrWhiteSpace(isSpell.Spell.Cooldown) Then
                        Console.WriteLine("    {0}", isSpell.Spell.Cooldown)
                    End If
                    If isSpell.Consumable Then
                        Console.WriteLine("    Consumable")
                    End If
                    If isSpell.Charges > 0 Then
                        Console.WriteLine("    {0} Charges", isSpell.Charges)
                    End If
                    If isSpell.Trigger <> Enums.ItemSpellTrigger.Unknown Then
                        Console.WriteLine("    Proced {0}", isSpell.Trigger)
                    End If
                Next
            End If
            If iItem.Item.DisenchantingSkillRank > 0 Then
                Console.WriteLine("Disenchant Skill Needed: {0}", iItem.Item.DisenchantingSkillRank)
            End If
            If iItem.Item.BuyPrice > 0 Then
                Console.WriteLine("Buy Price: {0}g{1}s{2}c", Math.Floor(iItem.Item.BuyPrice / 10000), Math.Floor((iItem.Item.BuyPrice / 100) Mod 100), iItem.Item.BuyPrice Mod 100)
            End If
            If iItem.Item.SellPrice > 0 Then
                Console.WriteLine("Sell Price: {0}g{1}s{2}c", Math.Floor(iItem.Item.SellPrice / 10000), Math.Floor((iItem.Item.SellPrice / 100) Mod 100), iItem.Item.SellPrice Mod 100)
            End If
            Console.WriteLine("Item class: {0} - Subclass: {1}", iItem.Item.ItemClass.Name, iItem.Item.ItemSubClass.Name)
            If iItem.Item.ContainerSlots > 0 Then
                Console.WriteLine("Container slots: {0}", iItem.Item.ContainerSlots)
            End If
            If iItem.Item.WeaponInfo IsNot Nothing Then
                For Each dDamage In iItem.Item.WeaponInfo.Damage
                    Console.WriteLine("Damage: {0}-{1}", dDamage.MinDamage, dDamage.MaxDamage)
                Next
                Console.WriteLine("Weapon Speed: {0:N1}", iItem.Item.WeaponInfo.WeaponSpeed)
                Console.WriteLine("DPS: {0:N1}", iItem.Item.WeaponInfo.DPS)
            End If
            If iItem.Item.GemInfo IsNot Nothing Then
                Console.WriteLine("Gem Info: {0} socket", iItem.Item.GemInfo.Type)
                Console.WriteLine("  {0}", iItem.Item.GemInfo.Bonus.Name)
                If iItem.Item.GemInfo.Bonus.RequiredSkill <> Enums.Profession.None Then
                    Console.WriteLine("  Requires: {0} {1}", iItem.Item.GemInfo.Bonus.RequiredSkill, iItem.Item.GemInfo.Bonus.RequiredSkillRank)
                End If
                If iItem.Item.GemInfo.Bonus.MinLevel > 0 Then
                    Console.WriteLine("  Requires level: {0}", iItem.Item.GemInfo.Bonus.MinLevel)
                End If
                If iItem.Item.GemInfo.Bonus.RequiredItemLevel > 0 Then
                    Console.WriteLine("  Requires item level: {0}", iItem.Item.GemInfo.Bonus.RequiredItemLevel)
                End If
            End If
            If iItem.Item.Equippable Then
                Console.WriteLine("Equippable")
            End If
            If iItem.Item.InventoryType <> Enums.InventoryType.NonEquipType Then
                Console.WriteLine("Equip Slot: {0}", iItem.Item.InventoryType)
            End If
            If iItem.Item.ItemLevel > 0 Then
                Console.WriteLine("Item Level: {0}", iItem.Item.ItemLevel)
            End If
            If iItem.Item.ItemSet IsNot Nothing Then
                Console.WriteLine("Item Set: {0}", iItem.Item.ItemSet.Name)
                If iItem.Item.ItemSet.SetBonuses IsNot Nothing Then
                    For Each setBonus In iItem.Item.ItemSet.SetBonuses
                        Console.WriteLine("  ({0}) {1}", setBonus.Threshold, setBonus.Description)
                    Next
                End If
            End If
            If iItem.Item.MaxCount > 0 Then
                Console.WriteLine("Unique ({0})", iItem.Item.MaxCount)
            End If
            If iItem.Item.MaxDurability > 0 Then
                Console.WriteLine("Durability: {0}", iItem.Item.MaxDurability)
            End If
            If iItem.Item.RequiredFactionID > 0 Then
                Console.WriteLine("Required Faction ID: {0}", iItem.Item.RequiredFactionID)
            End If
            If iItem.Item.RequiredAbility IsNot Nothing Then
                Console.WriteLine("Required Ability: {0} - Spell ID: {1}", iItem.Item.RequiredAbility.Name, iItem.Item.RequiredAbility.SpellID)
                Console.WriteLine("  {0}", iItem.Item.RequiredAbility.Description)
            End If
            If iItem.Item.MinStanding > Enums.Standing.Hated Then
                Console.WriteLine("Required Faction Standing: {0}", iItem.Item.MinStanding)
            End If
            If iItem.Item.RequiredSkill <> Enums.Profession.None Then
                Console.WriteLine("Required Skill: {0} {1}", iItem.Item.RequiredSkill, iItem.Item.RequiredSkillRank)
            End If
            If iItem.Item.RequiredLevel > 0 Then
                Console.WriteLine("Required Level: {0}", iItem.Item.RequiredLevel)
            End If
            If iItem.Item.HasSockets AndAlso iItem.Item.Sockets.Count > 0 Then
                Console.WriteLine("Sockets:")
                For Each strSocket In iItem.Item.Sockets
                    Console.WriteLine("  {0}", strSocket)
                Next
                If iItem.Item.SocketBonus IsNot Nothing Then
                    Console.WriteLine("  Bonus: {0}", iItem.Item.SocketBonus)
                End If
            End If
            If iItem.Item.ItemSource IsNot Nothing Then
                Console.WriteLine("Source: {0} - ID: {1}", iItem.Item.ItemSource.SourceType, iItem.Item.ItemSource.SourceID)
            End If
            If iItem.Item.IsAuctionable Then
                Console.WriteLine("Is Auctionable")
            End If
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub QuestLookupDemo()
            Console.Clear()
            Console.WriteLine("Quest Lookup Demo")
            Console.WriteLine()

            ' First, setup some variables
            Dim intQuestID As Integer

            ' Next, get the quest ID.
            Do
                Console.WriteLine("Please enter the ID number of the quest you wish to lookup.")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If Integer.TryParse(strResponse, intQuestID) Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Get the Item.
            Dim qQuest As New QuestLookup(intQuestID)

            ' Show the item.
            Console.Clear()
            If qQuest.CacheHit.HasValue AndAlso qQuest.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0} - ID: {1} - Category: {2} - Level: {3}", qQuest.Quest.Title, qQuest.Quest.ID, qQuest.Quest.Category, qQuest.Quest.Level)
            Console.WriteLine("Required level: {0} - Suggested party members: {1}", qQuest.Quest.RequiredLevel, qQuest.Quest.SuggestedPartyMembers)
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub RatedBattlegroundLadderDemo()
            Console.Clear()
            Console.WriteLine("Rated Battlegroup Ladder Demo")
            Console.WriteLine()

            Dim intCharacters As Integer
            Dim intPage As Integer
            Dim blnAscending As New Boolean?

            ' First, get the number of characters to return.
            Do
                Console.WriteLine("Please enter the number of characters to return.")
                Console.WriteLine("  Or press enter to default.")
                Console.Write(">")
                Dim strTeams = Console.ReadLine

                If String.IsNullOrWhiteSpace(strTeams) Then
                    Exit Do
                End If

                If Integer.TryParse(strTeams, intCharacters) Then
                    Exit Do
                Else
                    Console.WriteLine("You must enter a valid number of characters to return.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get the page number to return.
            Do
                Console.WriteLine("Please enter the page number to return.")
                Console.WriteLine("  Or press enter to default.")
                Console.Write(">")
                Dim strPage = Console.ReadLine

                If String.IsNullOrWhiteSpace(strPage) Then
                    Exit Do
                End If

                If Integer.TryParse(strPage, intPage) Then
                    Exit Do
                Else
                    Console.WriteLine("You must enter a valid page number to return.")
                    Console.WriteLine()
                End If
            Loop

            ' Next, get whether to return results ascending or descending.
            Do
                Console.WriteLine("Select the sort order to use.")
                Console.WriteLine("0 - Default (Ascending)")
                Console.WriteLine("1 - Ascending")
                Console.WriteLine("2 - Descending")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                Dim intResponse As Integer
                If Integer.TryParse(strResponse, intResponse) Then
                    Select Case intResponse
                        Case 0
                            Exit Do
                        Case 1
                            blnAscending = True
                            Exit Do
                        Case 2
                            blnAscending = False
                            Exit Do
                        Case Else
                            Console.WriteLine("Invalid response.")
                            Console.WriteLine()
                    End Select
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Perform the rated battleground ladder lookup.
            Dim rblLadder As New RatedBattlegroundLadder()
            rblLadder.Options.Characters = intCharacters
            rblLadder.Options.Page = intPage
            rblLadder.Options.Ascending = blnAscending
            rblLadder.Load()

            ' Show the characters.
            Console.Clear()
            If rblLadder.CacheHit.HasValue AndAlso rblLadder.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each bgRecord In rblLadder.Characters
                Console.WriteLine("{0}) {1} - {2} - Battlegroup: {3}", bgRecord.Rank, bgRecord.Character.Name, bgRecord.Realm.Name, bgRecord.Battlegroup.Name)
                Console.WriteLine("  Level {0} {1} {2} {3} {4}", bgRecord.Character.Level, bgRecord.Character.Gender, bgRecord.Character.Race.Name, bgRecord.Character.Class.Name, If(bgRecord.Character.Spec Is Nothing, Nothing, bgRecord.Character.Spec.Name))
                Console.WriteLine("  Achievement Points: {0}", bgRecord.Character.AchievementPoints)
                Console.WriteLine("  Rating: {0}", bgRecord.Rating)
                Console.WriteLine("  Record: {0}-{1} ({2} played)", bgRecord.Wins, bgRecord.Losses, bgRecord.Played)
                Console.WriteLine()
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub RealmStatusDemo()
            Console.Clear()
            Console.WriteLine("Realm Status Demo")
            Console.WriteLine()

            ' Declare some variables.
            Dim strRealm As String
            Dim lstRealm As New List(Of String)

            ' Next, get the realm.
            Do
                Console.WriteLine("Please enter the name of the realm whose status you wish to retrieve.")
                Console.WriteLine("  Or press enter to continue.")
                Console.Write(">")
                strRealm = Console.ReadLine

                If String.IsNullOrWhiteSpace(strRealm) Then
                    Exit Do
                Else
                    lstRealm.Add(strRealm)
                    Console.WriteLine()
                End If
            Loop

            ' Get the realm status.
            Dim rsStatus As New RealmStatus(lstRealm)

            ' Show the realm status.
            Console.Clear()
            If rsStatus.CacheHit.HasValue AndAlso rsStatus.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            For Each rRealm In rsStatus.Realms
                Console.WriteLine("{0} - {1} - Battlegroup: {2}", rRealm.Name, rRealm.Type, rRealm.Battlegroup)
                Console.WriteLine("Population: {0} - Locale: {1} - Time Zone: {2}", rRealm.Population, rRealm.Locale, rRealm.TimeZone)
                Console.WriteLine("Status: {0} - Queue: {1}", If(rRealm.Status, "Online", "Offline"), If(rRealm.Queue, "Yes", "No"))
                Console.WriteLine("Wintergrasp: {0} controlled, next battle at {1:h:mm:ss tt} GMT, Status: {2}", rRealm.Wintergrasp.ControllingFaction, rRealm.Wintergrasp.Next, rRealm.Wintergrasp.Status)
                Console.WriteLine("Tol Barad: {0} controlled, next battle at {1:h:mm:ss tt} GMT, Status: {2}", rRealm.TolBarad.ControllingFaction, rRealm.TolBarad.Next, rRealm.TolBarad.Status)
                Console.WriteLine()
            Next

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub

        Public Sub RecipeLookupDemo()
            Console.Clear()
            Console.WriteLine("Recipe Lookup Demo")
            Console.WriteLine()

            ' First, setup some variables
            Dim intRecipeID As Integer

            ' Next, get the recipe ID.
            Do
                Console.WriteLine("Please enter the ID number of the recipe you wish to lookup.")
                Console.Write(">")
                Dim strResponse = Console.ReadLine
                If Integer.TryParse(strResponse, intRecipeID) Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid response.")
                    Console.WriteLine()
                End If
            Loop

            ' Get the Recipe.
            Dim rRecipe As New RecipeLookup(intRecipeID)

            ' Show the recipe.
            Console.Clear()
            If rRecipe.CacheHit.HasValue AndAlso rRecipe.CacheHit.Value Then
                Console.WriteLine("Cache hit!")
                Console.WriteLine()
            End If

            Console.WriteLine("{0} - ID: {1}", rRecipe.Recipe.Name, rRecipe.Recipe.RecipeID)
            Console.WriteLine("Profession: {0}", rRecipe.Recipe.Profession)
            Console.WriteLine()

            Console.WriteLine("Press any key to continue.")
            Console.ReadKey(True)
        End Sub
    End Module

End Namespace
