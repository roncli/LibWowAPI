' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about weapon damage.
    ''' </summary>
    ''' <remarks>This class gives the minimum and maximum damage done by a weapon swing.</remarks>
    Public Class Damage

        ''' <summary>
        ''' The minimum damage done per swing by this weapon.
        ''' </summary>
        ''' <value>This property gets or sets the MinDamage field.</value>
        ''' <returns>Returns the minimum damage done per swing by this weapon.</returns>
        ''' <remarks>This represents the minimum damage done per swing by this weapon.</remarks>
        Public Property Min As Integer

        ''' <summary>
        ''' The maximum damage done per swing by this weapon.
        ''' </summary>
        ''' <value>This property gets or sets the MaxDamage field.</value>
        ''' <returns>Returns the maximum damage done per swing by this weapon.</returns>
        ''' <remarks>This represents the maximum damage done per swing by this weapon.</remarks>
        Public Property Max As Integer

        ''' <summary>
        ''' The exact minimum damage done per swing by this weapon.
        ''' </summary>
        ''' <value>This property gets or sets the ExactMinDamage field.</value>
        ''' <returns>Returns the exact minimum damage done per swing by this weapon.</returns>
        ''' <remarks>This represents the exact minimum damage done per swing by this weapon.</remarks>
        Public Property ExactMin As Double

        ''' <summary>
        ''' The exact maximum damage done per swing by this weapon.
        ''' </summary>
        ''' <value>This property gets or sets the ExactMaxDamage field.</value>
        ''' <returns>Returns the exact maximum damage done per swing by this weapon.</returns>
        ''' <remarks>This represents the exact maximum damage done per swing by this weapon.</remarks>
        Public Property ExactMax As Double

        Friend Sub New(intMin As Integer, intMax As Integer, dblExactMin As Double, dblExactMax As Double)
            Min = intMin
            Max = intMax
            ExactMin = dblExactMin
            ExactMax = dblExactMax
        End Sub

    End Class

End Namespace
