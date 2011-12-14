' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Auction

    ''' <summary>
    ''' A class containing information about a realm.
    ''' </summary>
    ''' <remarks>This class contains both the realm <see cref="Realm.Name" /> and Blizzard's internal name for the realm, called the <see cref="Realm.Slug" />, for the specified auction data.</remarks>
    Public Class Realm

        ''' <summary>
        ''' The name of the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the realm.</returns>
        ''' <remarks>This is the localized name of the realm.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' Blizzard's internal name for the realm.
        ''' </summary>
        ''' <value>This property gets or sets the Slug field.</value>
        ''' <returns>Returns Blizzard's internal name for the realm.</returns>
        ''' <remarks>Blizzard has an internal name for each realm that does not include capital letters or spaces.  The <see cref="Realm.Slug" /> can be used in place of the <see cref="Realm.Name" /> in most API operations.</remarks>
        Public Property Slug As String

        Friend Sub New(strName As String, strSlug As String)
            Name = strName
            Slug = strSlug
        End Sub

    End Class

End Namespace
