' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Spell

    ''' <summary>
    ''' A class that defines options for the spell lookup.
    ''' </summary>
    ''' <remarks>This class allows you to define the ID number to look up spell information for. There is no need to create an instance of this class, as the <see cref="SpellLookup.Options" /> property automatically does so for you.</remarks>
    Public Class SpellLookupOptions

        ''' <summary>
        ''' The spell ID to lookup.
        ''' </summary>
        ''' <value>This property gets or sets the SpellID field.</value>
        ''' <returns>Returns the spell ID to lookup.</returns>
        ''' <remarks>This represents the spell ID to lookup.</remarks>
        Public Property SpellID As Integer

        Friend Sub New()
        End Sub

    End Class

End Namespace
