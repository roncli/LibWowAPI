﻿' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Imports System.Collections.ObjectModel
Imports roncliProductions.LibWowAPI.Data.CharacterClasses

Namespace roncliProductions.LibWowAPI.Data.Talents

    ''' <summary>
    ''' A class containing information about a class's talents.
    ''' </summary>
    ''' <remarks>This contains basic information about a class's talents.</remarks>
    Public Class Talents

        ''' <summary>
        ''' The class these talents are for.
        ''' </summary>
        ''' <value>This property gets or sets the Class field.</value>
        ''' <returns>Returns the class these talents are for.</returns>
        ''' <remarks>This represents the class these talents are for.</remarks>
        Public Property [Class] As CharacterClass

        Private colPetSpecs As Collection(Of Spec)
        ''' <summary>
        ''' The possible pet specializations for this class.
        ''' </summary>
        ''' <value>This property gets the PetSpecs field.</value>
        ''' <returns>Returns the possible pet specializations for this class.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Spec)" /> of <see cref="Spec" /> objects that represent the possible pet specializations for this class.</remarks>
        Public ReadOnly Property PetSpecs As Collection(Of Spec)
            Get
                Return colPetSpecs
            End Get
        End Property

        Private colGlyphs As Collection(Of Glyph)
        ''' <summary>
        ''' The possible glyphs for this class.
        ''' </summary>
        ''' <value>This property gets the Glyphs field.</value>
        ''' <returns>Returns the possible glyphs for this class.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Glyph)" /> of <see cref="Glyph" /> objects that represent the possible glyphs for this class.</remarks>
        Public ReadOnly Property Glyphs As Collection(Of Glyph)
            Get
                Return colGlyphs
            End Get
        End Property

        Private colTalentTiers As Collection(Of TalentTier)
        ''' <summary>
        ''' The possible talents for this class, divided into tiers.
        ''' </summary>
        ''' <value>This property gets the TalentTiers field.</value>
        ''' <returns>Returns the possible talents for this class, divided into tiers.</returns>
        ''' <remarks>This is a <see cref="Collection(Of TalentTier)" /> of <see cref="TalentTier" /> objects that represent the possible talents for this class, divided into tiers.</remarks>
        Public ReadOnly Property TalentTiers As Collection(Of TalentTier)
            Get
                Return colTalentTiers
            End Get
        End Property

        Private colSpecs As Collection(Of Spec)
        ''' <summary>
        ''' The possible specializations for this class.
        ''' </summary>
        ''' <value>This property gets the Specs field.</value>
        ''' <returns>Returns the possible specializations for this class.</returns>
        ''' <remarks>This is a <see cref="Collection(Of Spec)" /> of <see cref="Spec" /> objects that represent the possible specializations for this class.</remarks>
        Public ReadOnly Property Specs As Collection(Of Spec)
            Get
                Return colSpecs
            End Get
        End Property

        Friend Sub New(ccClass As CharacterClass, sPetSpecs As Collection(Of Spec), gGlyphs As Collection(Of Glyph), ttTalentTiers As Collection(Of TalentTier), sSpecs As Collection(Of Spec))
            [Class] = ccClass
            colPetSpecs = sPetSpecs
            colGlyphs = gGlyphs
            colTalentTiers = ttTalentTiers
            colSpecs = sSpecs
        End Sub

    End Class

End Namespace
