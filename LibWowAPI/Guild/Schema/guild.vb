' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Runtime.Serialization
Imports roncliProductions.LibWowAPI.Achievement.Schema
Imports roncliProductions.LibWowAPI.Challenge.Schema

Namespace roncliProductions.LibWowAPI.Guild.Schema

    <DataContract()> Friend Class guild

        <DataMember()> Public Property lastModified As Long
        <DataMember()> Public Property name As String
        <DataMember()> Public Property realm As String
        <DataMember()> Public Property battlegroup As String
        <DataMember()> Public Property level As Integer
        <DataMember()> Public Property side As Integer
        <DataMember()> Public Property achievementPoints As Integer
        <DataMember()> Public Property achievements As completedAchievements
        <DataMember()> Public Property members As member()
        <DataMember()> Public Property emblem As emblem
        <DataMember()> Public Property news As news()
        <DataMember()> Public Property challenge As Challenge.Schema.challengeRealmMap()

    End Class

End Namespace
