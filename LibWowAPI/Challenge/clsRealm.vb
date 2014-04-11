' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Challenge

    ''' <summary>
    ''' A class containing some of the information about a realm.
    ''' </summary>
    ''' <remarks>This class contains basic information about a realm.</remarks>
    Public Class Realm

        ''' <summary>
        ''' The name of the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the realm.</returns>
        ''' <remarks>This represents the localized name of the realm.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Blizzard's internal name for the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Slug field.</value>
        ''' <returns>Returns Blizzard's internal name for the realm.</returns>
        ''' <remarks>This represents Blizzard's internal name for the realm.</remarks>
        Public Property Slug As String

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

        Public Sub New(strName As String, strSlug As String, strBattlegroup As String, strLocale As String, strTimeZone As String)
            Name = strName
            Slug = strSlug
            Battlegroup = strBattlegroup
            Locale = strLocale
            TimeZone = strTimeZone
        End Sub

    End Class

End Namespace
