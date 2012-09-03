' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.PvP

    ''' <summary>
    ''' A class containing information about a character's realm.
    ''' </summary>
    ''' <remarks>This class contains basic information about a character's realm.</remarks>
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

        Friend Sub New(strName As String, strSlug As String, strBattlegroup As String, strLocale As String)
            Name = strName
            Slug = strSlug
            Battlegroup = strBattlegroup
            Locale = strLocale
        End Sub

    End Class

End Namespace
