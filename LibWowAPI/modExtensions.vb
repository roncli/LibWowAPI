' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.IO.Compression
Imports System.Linq
Imports System.Net
Imports System.Runtime.CompilerServices
Imports roncliProductions.LibWowAPI.Data
Imports roncliProductions.LibWowAPI.Data.CharacterClasses
Imports roncliProductions.LibWowAPI.Data.CharacterRaces
Imports roncliProductions.LibWowAPI.Data.ItemClasses
Imports roncliProductions.LibWowAPI.Data.PetTypes
Imports roncliProductions.LibWowAPI.Enums
Imports roncliProductions.LibWowAPI.Item.Schema

Namespace roncliProductions.LibWowAPI.Extensions

    Friend Module Extensions

        <Extension()> Friend Function ToCollection(Of T)(enumerable As IEnumerable(Of T)) As Collection(Of T)
            If enumerable Is Nothing Then
                Throw New ArgumentException("The enumeration is null.", "enumerable")
            End If

            Dim collection As New Collection(Of T)
            For Each obj As T In enumerable
                collection.Add(obj)
            Next
            Return collection
        End Function

        <Extension()> Friend Sub AddRange(Of T)(collection As Collection(Of T), enumerable As IEnumerable(Of T))
            If collection Is Nothing Then
                Throw New ArgumentException("The collection is null.", "collection")
            End If

            If enumerable Is Nothing Then
                Throw New ArgumentException("The enumeration is null.", "enumerable")
            End If

            For Each obj In enumerable
                collection.Add(obj)
            Next
        End Sub

        <Extension()> Friend Function BlizzardTimestampToUTC(lngTimestamp As Long) As Date
            Return New Date(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(lngTimestamp)
        End Function

        <Extension()> Friend Function ArgbHexToColor(strColor As String) As Color
            Return Color.FromArgb(Convert.ToInt32(strColor, 16))
        End Function

        <Extension()> Friend Function RgbHexToColor(strColor As String) As Color
            Return String.Format(CultureInfo.InvariantCulture, "00{0}", strColor).ArgbHexToColor()
        End Function

        <Extension()> Friend Function GetCharacterClass(intClassID As Integer) As CharacterClass
            Dim ccClasses As New CharacterClasses()
            ccClasses.Load()
            Dim varClass = ccClasses.Classes.Where(Function(c) c.ClassID = intClassID)
            If varClass.Count = 0 Then
                Return Nothing
            Else
                Return varClass.First()
            End If
        End Function

        <Extension()> Friend Function GetRace(intRaceID As Integer) As Race
            Dim crRaces As New CharacterRaces()
            crRaces.Load()
            Dim varRace = crRaces.Races.Where(Function(r) r.RaceID = intRaceID)
            If varRace.Count = 0 Then
                Return Nothing
            Else
                Return varRace.First()
            End If
        End Function

        <Extension()> Friend Function GetRealmType(strType As String) As RealmType
            Select Case strType
                Case "pve"
                    Return RealmType.PvE
                Case "pvp"
                    Return RealmType.PvP
                Case "rp"
                    Return RealmType.RP
                Case "rppvp"
                    Return RealmType.RPPvP
                Case Else
                    Return RealmType.Unknown
            End Select
        End Function

        <Extension()> Friend Function GetPowerType(strPowerType As String) As PowerType
            Select Case strPowerType
                Case "energy"
                    Return PowerType.Energy
                Case "focus"
                    Return PowerType.Focus
                Case "mana"
                    Return PowerType.Mana
                Case "rage"
                    Return PowerType.Rage
                Case "runic-power"
                    Return PowerType.RunicPower
                Case Else
                    Return PowerType.Unknown
            End Select
        End Function

        <Extension()> Friend Function GetFaction(strFaction As String) As Faction
            Select Case strFaction
                Case "alliance"
                    Return Faction.Alliance
                Case "horde"
                    Return Faction.Horde
                Case "neutral"
                    Return Faction.Neutral
                Case Else
                    Return Faction.Unknown
            End Select
        End Function

        <Extension()> Friend Function GetItemClass(intItemClassID As Integer) As ItemClass
            Dim icItemClasses = New ItemClasses()
            icItemClasses.Load()
            Dim varItemClass = icItemClasses.Classes.Where(Function(c) c.ClassID = intItemClassID)
            If varItemClass.Count = 0 Then
                Return Nothing
            Else
                Return varItemClass.First()
            End If
        End Function

        <Extension()> Friend Function GetItemSubclassForClass(intItemClassID As Integer, intItemSubclassID As Integer) As ItemSubclass
            Dim icItemClasses = New ItemClasses()
            icItemClasses.Load()
            Dim varItemClass = icItemClasses.Classes.Where(Function(c) c.ClassID = intItemClassID)
            If varItemClass.Count = 0 Then
                Return Nothing
            Else
                Dim varItemSubclass = varItemClass.First().Subclasses.Where(Function(s) s.SubclassID = intItemSubclassID)
                If varItemSubclass.Count = 0 Then
                    Return Nothing
                Else
                    Return varItemSubclass.First()
                End If
            End If
        End Function

        <Extension()> Friend Function GetAuctionTimeLeft(strTimeLeft As String) As AuctionTimeLeft
            Select Case strTimeLeft
                Case "SHORT"
                    Return AuctionTimeLeft.Short
                Case "MEDIUM"
                    Return AuctionTimeLeft.Medium
                Case "LONG"
                    Return AuctionTimeLeft.Long
                Case "VERY_LONG"
                    Return AuctionTimeLeft.VeryLong
                Case Else
                    Return AuctionTimeLeft.Unknown
            End Select
        End Function

        <Extension()> Friend Function GetRaces(intRaces As Integer()) As Collection(Of Race)
            If intRaces Is Nothing Then Return Nothing
            Dim crRaces As New CharacterRaces()
            crRaces.Load()
            Return (From r In crRaces.Races Where intRaces.Contains(r.RaceID)).ToCollection()
        End Function

        <Extension()> Friend Function GetClasses(intClasses As Integer()) As Collection(Of CharacterClass)
            If intClasses Is Nothing Then Return Nothing
            Dim ccClasses As New CharacterClasses()
            ccClasses.Load()
            Return (From c In ccClasses.Classes Where intClasses.Contains(c.ClassID)).ToCollection()
        End Function

        <Extension()> Friend Function GetResponse(wrResponse As WebResponse) As String
            If wrResponse.Headers("Content-Encoding") IsNot Nothing AndAlso wrResponse.Headers("Content-Encoding").Contains("gzip") Then
                Using gStream As New GZipStream(wrResponse.GetResponseStream, CompressionMode.Decompress)
                    Using mStream As New MemoryStream()
                        Dim intCount = 0
                        Dim bytBuffer(4095) As Byte
                        Do
                            intCount = gStream.Read(bytBuffer, 0, 4096)
                            If intCount > 0 Then
                                mStream.Write(bytBuffer, 0, intCount)
                            End If
                        Loop Until intCount = 0
                        mStream.Seek(0, SeekOrigin.Begin)
                        Return New StreamReader(mStream).ReadToEnd
                    End Using
                End Using
            Else
                Using srReader As New StreamReader(wrResponse.GetResponseStream)
                    Return srReader.ReadToEnd
                End Using
            End If
        End Function

        <Extension()> Friend Function GetItemSpellTrigger(strTrigger As String) As ItemSpellTrigger
            Select Case strTrigger.ToUpperInvariant()
                Case "ON_USE"
                    Return ItemSpellTrigger.OnUse
                Case "ON_EQUIP"
                    Return ItemSpellTrigger.OnEquip
                Case Else
                    Return ItemSpellTrigger.Unknown
            End Select
        End Function

        <Extension()> Friend Function GetGems(tpTooltipParams As tooltipParams) As Collection(Of Integer)
            Dim colGems As New Collection(Of Integer)
            If tpTooltipParams.gem0 <> 0 Then colGems.Add(tpTooltipParams.gem0)
            If tpTooltipParams.gem1 <> 0 Then colGems.Add(tpTooltipParams.gem1)
            If tpTooltipParams.gem2 <> 0 Then colGems.Add(tpTooltipParams.gem2)
            Return colGems
        End Function

        <Extension()> Friend Function GetPetType(intPetTypeID As Integer) As PetType
            Dim ptPetTypes = New PetTypes()
            ptPetTypes.Load()
            Dim varPetType = ptPetTypes.PetTypes.Where(Function(pt) pt.PetTypeID = intPetTypeID)
            If varPetType.Count = 0 Then
                Return Nothing
            Else
                Return varPetType.First()
            End If
        End Function

        <Extension()> Friend Function GetItemStatType(strStatId As String) As ItemStatType
            Dim intStatTypeID As Integer = 0
            If Integer.TryParse(strStatId, intStatTypeID) Then
                Return CType(intStatTypeID, ItemStatType)
            Else
                Select Case strStatId
                    Case "ilevel"
                        Return ItemStatType.ILevel
                End Select
            End If
        End Function

    End Module

End Namespace
