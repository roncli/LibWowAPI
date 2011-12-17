' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports roncliProductions.LibWowAPI.Enums

Namespace roncliProductions.LibWowAPI.Item

    ''' <summary>
    ''' A class containing information about a gem's bonus stats.
    ''' </summary>
    ''' <remarks>This class contains some information about a gem's bonus stats, including any requirements to use the gem.</remarks>
    Public Class Bonus

        ''' <summary>
        ''' The name of the gem's bonus.
        ''' </summary>
        ''' <value>This property gets or sets the Name field.</value>
        ''' <returns>Returns the name of the gem's bonus.</returns>
        ''' <remarks>This is the localized name of the gem's bonus.</remarks>
        Public Property Name As String

        ''' <summary>
        ''' The item ID of the gem.
        ''' </summary>
        ''' <value>This property gets or sets the SourceItemID field.</value>
        ''' <returns>Returns the item ID of the gem.</returns>
        ''' <remarks>This represents the item ID of the gem.</remarks>
        Public Property SourceItemID As Integer

        ''' <summary>
        ''' The profession required to use the gem.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredSkill field.</value>
        ''' <returns>Returns the profession required to use the gem.</returns>
        ''' <remarks>This is a <see cref="Enums.Profession" /> enumeration that indicates what profession is required to use the gem.  A profession of <see cref="Enums.Profession.None" /> indicates that no profession is required.</remarks>
        Public Property RequiredSkill As Profession

        ''' <summary>
        ''' The required profession skill level to use the gem.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredSkillRank field.</value>
        ''' <returns>Returns the required profession skill level to use the gem.</returns>
        ''' <remarks>If the <see cref="RequiredSkill" /> property is not <see cref="Enums.Profession.None" />, then this represents the number of skill points a character must have in the specified profession in order to use the gem.</remarks>
        Public Property RequiredSkillRank As Integer

        ''' <summary>
        ''' The minimum level required to use the gem.
        ''' </summary>
        ''' <value>This property gets or sets the MinLevel field.</value>
        ''' <returns>Returns the minimum level required to use the gem.</returns>
        ''' <remarks>This is the minimum level the character must be in order to use the gem.</remarks>
        Public Property MinLevel As Integer

        ''' <summary>
        ''' The minimum item level required on the item the gem is to be used on.
        ''' </summary>
        ''' <value>This property gets or sets the RequiredItemLevel field.</value>
        ''' <returns>Returns the minimum item level required on the item the gem is to be used on.</returns>
        ''' <remarks>Gems can only be used on items of a certain <see cref="Item.ItemLevel" />.  This field represents the minimum item level required.</remarks>
        Public Property RequiredItemLevel As Integer

        Friend Sub New(strName As String, intSourceItemID As Integer, pRequiredSkill As Profession, intRequiredSkillRank As Integer, intMinLevel As Integer, intRequiredItemLevel As Integer)
            Name = strName
            SourceItemID = intSourceItemID
            RequiredSkill = pRequiredSkill
            RequiredSkillRank = intRequiredSkillRank
            MinLevel = intMinLevel
            RequiredItemLevel = intRequiredItemLevel
        End Sub

    End Class

End Namespace
