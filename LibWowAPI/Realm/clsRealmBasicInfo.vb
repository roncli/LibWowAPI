' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Realm

    ''' <summary>
    ''' A class containing basic information about a realm's status.
    ''' </summary>
    ''' <remarks>This class contains detailed basic information about a realm.</remarks>
    Public Class RealmBasicInfo
        Inherits RealmName

        ''' <summary>
        ''' The name of the battlegroup the realm is in.
        ''' </summary>
        ''' <value>This property gets or sets the Battlegroup field.</value>
        ''' <returns>Returns the name of the battlegroup the realm is in.</returns>
        ''' <remarks>This represents the name of the battlegroup the realm is in.  This is not localized, and will always be in the realm's language.</remarks>
        Public Property Battlegroup As String

        ''' <summary>
        ''' The locale of the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Locale field.</value>
        ''' <returns>Returns the locale of the realm.</returns>
        ''' <remarks>This represents the locale of the realm.</remarks>
        Public Property Locale As String

        ''' <summary>
        ''' The Olson timezone of the realm.
        ''' </summary>
        ''' <value>This property gets or sets the TimeZone field.</value>
        ''' <returns>Returns the Olson timezone of the realm.</returns>
        ''' <remarks>This represents the Olson timeznoe of the realm.</remarks>
        Public Property TimeZone As String

        Friend Sub New(strName As String, strSlug As String, strBattlegroup As String, strLocale As String, strTimeZone As String)
            MyBase.New(strName, strSlug)
            Battlegroup = strBattlegroup
            Locale = strLocale
            TimeZone = strTimeZone
        End Sub

    End Class

End Namespace
