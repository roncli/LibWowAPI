' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Character

    ''' <summary>
    ''' A class containing information about the character's appearance.
    ''' </summary>
    ''' <remarks>The data contained in this class represents information on how the character appears in the game.  Most of this data does not have any known translation as of yet.</remarks>
    Public Class Appearance

        ''' <summary>
        ''' A number representing the character's face variation.
        ''' </summary>
        ''' <value>This property gets or sets the FaceVariation field.</value>
        ''' <returns>Returns a number representing the character's face variation.</returns>
        ''' <remarks>Characters are able to change how their face looks, and this value represents an index of the face variation that was chosen.</remarks>
        Public Property FaceVariation As Integer

        ''' <summary>
        ''' A number representing the character's skin color.
        ''' </summary>
        ''' <value>This property gets or sets the SkinColor field.</value>
        ''' <returns>Returns a number representing the character's skin color.</returns>
        ''' <remarks>Characters are able to change what color their skin is, and this value represents an index of the skin color that was chosen.</remarks>
        Public Property SkinColor As Integer

        ''' <summary>
        ''' A number representing the character's hair variation.
        ''' </summary>
        ''' <value>This property gets or sets the HairVariation field.</value>
        ''' <returns>Returns a number representing the character's hair variation.</returns>
        ''' <remarks>Characters are able to change how their hair looks, and this value represents an index of the hair variation that was chosen.</remarks>
        Public Property HairVariation As Integer

        ''' <summary>
        ''' A number representing the character's hair color.
        ''' </summary>
        ''' <value>This property gets or sets the HairColor field.</value>
        ''' <returns>Returns a number representing the character's hair color.</returns>
        ''' <remarks>Characters are able to change what color their hair is, and this value represents an index of the hair color that was chosen.</remarks>
        Public Property HairColor As Integer

        ''' <summary>
        ''' A number representing the character's feature variation.
        ''' </summary>
        ''' <value>This property gets or sets the FeatureVariation field.</value>
        ''' <returns>Returns a number representing the character's feature variation.</returns>
        ''' <remarks>Characters are able to change some miscellaneous features, and this value represents an index of the feature variation that was chosen.</remarks>
        Public Property FeatureVariation As Integer

        ''' <summary>
        ''' A boolean to determine whether to show the character's helm.
        ''' </summary>
        ''' <value>This property gets or sets the ShowHelm field.</value>
        ''' <returns>Returns a boolean to determine whether to show the character's helm.</returns>
        ''' <remarks>Characters can choose whether or not to show their helm.</remarks>
        Public Property ShowHelm As Boolean

        ''' <summary>
        ''' A boolean to determine whether to show the character's cloak.
        ''' </summary>
        ''' <value>This property gets or sets the ShowCloak field.</value>
        ''' <returns>Returns a boolean to determine whether to show the character's cloak.</returns>
        ''' <remarks>Characters can choose whether or not to show their cloak.</remarks>
        Public Property ShowCloak As Boolean

        Friend Sub New(intFaceVariation As Integer, intSkinColor As Integer, intHairVariation As Integer, intHairColor As Integer, intFeatureVariation As Integer, blnShowHelm As Boolean, blnShowCloak As Boolean)
            FaceVariation = intFaceVariation
            SkinColor = intSkinColor
            HairVariation = intHairVariation
            HairColor = intHairColor
            FeatureVariation = intFeatureVariation
            ShowHelm = blnShowHelm
            ShowCloak = blnShowCloak
        End Sub

    End Class

End Namespace
