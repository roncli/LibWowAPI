' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information a potential item bonus.
    ''' </summary>
    ''' <remarks>This class gives information about a potential item bonus.</remarks>
    Public Class BonusChance

        ''' <summary>
        ''' The type of enhancement for this bonus.
        ''' </summary>
        ''' <value>This property gets or sets the ChanceType field.</value>
        ''' <returns>Returns the type of enhancement for this bonus.</returns>
        ''' <remarks>This represents the type of enhancement for this bonus.</remarks>
        Public Property ChanceType As String

        ''' <summary>
        ''' The type of upgrade for this bonus.
        ''' </summary>
        ''' <value>This property gets or sets the Upgrade field.</value>
        ''' <returns>Returns the type of upgrade for this bonus.</returns>
        ''' <remarks>This is a <see cref="BonusChanceUpgrade" /> object that represents the type of upgrade for this bonus.</remarks>
        Public Property Upgrade As BonusChanceUpgrade

        Private Property colStats As Collection(Of BonusChanceStat)
        ''' <summary>
        ''' The bonus stats for this bonus.
        ''' </summary>
        ''' <value>This property gets the Stats field.</value>
        ''' <returns>Returns the bonus stats for this bonus.</returns>
        ''' <remarks>This is a <see cref="Collection(Of BonusChanceStat)" /> of <see cref="BonusChanceStat" /> objects that represents the bonus stats for this bonus.</remarks>
        Public ReadOnly Property Stats As Collection(Of BonusChanceStat)
            Get
                Return colStats
            End Get
        End Property

        Private Property colSockets As Collection(Of String)
        ''' <summary>
        ''' The sockets available with this bonus.
        ''' </summary>
        ''' <value>This property gets the Sockets field.</value>
        ''' <returns>Returns the sockets availble with this bonus.</returns>
        ''' <remarks>This is a <see cref="Collection(Of String)" /> representing the sockets available with this bonus.</remarks>
        Public ReadOnly Property Sockets As Collection(Of String)
            Get
                Return colSockets
            End Get
        End Property

        Friend Sub New(strChanceType As String, bcuUpgrade As BonusChanceUpgrade, bcsStats As Collection(Of BonusChanceStat), strSockets As Collection(Of String))
            ChanceType = strChanceType
            Upgrade = bcuUpgrade
            colStats = bcsStats
            colSockets = strSockets
        End Sub

    End Class

End Namespace
