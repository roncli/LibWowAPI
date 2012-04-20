' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Realm

    ''' <summary>
    ''' A class containing information about a realm's status.
    ''' </summary>
    ''' <remarks>This class contains detailed information about a realm.</remarks>
    Public Class Realm

        ''' <summary>
        ''' The type of realm.
        ''' </summary>
        ''' <value>This property gets or sets the Type field.</value>
        ''' <returns>Returns the type of realm.</returns>
        ''' <remarks>This is a <see cref="Enums.RealmType" /> enumeration that describes the type of realm this is.</remarks>
        Public Property Type As RealmType

        ''' <summary>
        ''' The population of the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Population field.</value>
        ''' <returns>Returns the population of the realm.</returns>
        ''' <remarks>This represents the population of the realm.  This is one of "low", "medium", or "high", </remarks>
        Public Property Population As String

        ''' <summary>
        ''' Indicates if there is a queue to get into the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Queue field.</value>
        ''' <returns>Returns a boolean that indicates if there is a queue to get into the realm.</returns>
        ''' <remarks>This indicates if there is a queue to get into the realm.</remarks>
        Public Property Queue As Boolean

        ''' <summary>
        ''' Details about the current PvP status of Wintergrasp.
        ''' </summary>
        ''' <value>This property gets or sets the Wintergrasp field.</value>
        ''' <returns>Returns details about the current PvP status of Wintergrasp.</returns>
        ''' <remarks>This is a <see cref="PvpZone" /> object that contains details about the current PvP status of Wintergrasp.</remarks>
        Public Property Wintergrasp As PvpZone

        ''' <summary>
        ''' Details about the current PvP status of Tol Barad.
        ''' </summary>
        ''' <value>This property gets or sets the TolBarad field.</value>
        ''' <returns>Returns details about the current PvP status of Tol Barad.</returns>
        ''' <remarks>This is a <see cref="PvpZone" /> object that contains details about the current PvP status of Tol Barad.</remarks>
        Public Property TolBarad As PvpZone

        ''' <summary>
        ''' Indicates if the realm is online or not.
        ''' </summary>
        ''' <value>This property gets or sets the Status field.</value>
        ''' <returns>Returns a boolean that indicates if the realm is online or not.</returns>
        ''' <remarks>This indicates if the realm is online or not.</remarks>
        Public Property Status As Boolean

        ''' <summary>
        ''' The name of the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the realm.</returns>
        ''' <remarks>This represents the localized name of the realm.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The name of the battlegroup the realm is in.
        ''' </summary>
        ''' <value>This property gets or sets the Battlegroup field.</value>
        ''' <returns>Returns the name of the battlegroup the realm is in.</returns>
        ''' <remarks>This represents the name of the battlegroup the realm is in.  This is not localized, and will always be in the realm's language.</remarks>
        Public Property Battlegroup As String

        ''' <summary>
        ''' Blizzard's internal name for the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Slug field.</value>
        ''' <returns>Returns Blizzard's internal name for the realm.</returns>
        ''' <remarks>This represents Blizzard's internal name for the realm.</remarks>
        Public Property Slug As String

        Friend Sub New(rtType As RealmType, strPopulation As String, blnQueue As Boolean, pzWintergrasp As PvpZone, pzTolBarad As PvpZone, blnStatus As Boolean, strName As String, strBattlegroup As String, strSlug As String)
            Type = rtType
            Population = strPopulation
            Queue = blnQueue
            Wintergrasp = pzWintergrasp
            TolBarad = pzTolBarad
            Status = blnStatus
            Name = strName
            Battlegroup = strBattlegroup
            Slug = strSlug
        End Sub

    End Class

End Namespace
