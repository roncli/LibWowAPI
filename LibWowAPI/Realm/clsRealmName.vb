' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Realm

    ''' <summary>
    ''' A class containing a realm's name.
    ''' </summary>
    ''' <remarks>This class contains a realm's name.</remarks>
    Public Class RealmName

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

        Friend Sub New(strName As String, strSlug As String)
            Name = strName
            Slug = strSlug
        End Sub

    End Class

End Namespace
