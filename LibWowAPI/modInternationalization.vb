' LibWowAPI
' by Ronald M. Clifford (roncli@roncli.com)
'
' This source code is released under the GNU Lesser General Public License (LGPL) Version 3.0.

Namespace roncliProductions.LibWowAPI.Internationalization

    ''' <summary>
    ''' The region of the Armory, determines which base URL to hit.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Region
        ''' <summary>
        ''' North America, us.battle.net.
        ''' </summary>
        ''' <remarks></remarks>
        NorthAmerica

        ''' <summary>
        ''' Europe, eu.battle.net.
        ''' </summary>
        ''' <remarks></remarks>
        Europe

        ''' <summary>
        ''' Korea, kr.battle.net.
        ''' </summary>
        ''' <remarks></remarks>
        Korea

        ''' <summary>
        ''' China, www.battlenet.com.cn.
        ''' </summary>
        ''' <remarks></remarks>
        China

        ''' <summary>
        ''' Taiwan, tw.battle.net.
        ''' </summary>
        ''' <remarks></remarks>
        Taiwan
    End Enum

    ''' <summary>
    ''' The localization scheme to use on the Armory
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Language
        ''' <summary>
        ''' US English, en_us.
        ''' </summary>
        ''' <remarks></remarks>
        EnglishUS

        ''' <summary>
        ''' Mexican Spanish, es_mx.
        ''' </summary>
        ''' <remarks></remarks>
        EspañolAL

        ''' <summary>
        ''' Brazilian Portuguese, pt_br
        ''' </summary>
        ''' <remarks></remarks>
        PortuguêsAL

        ''' <summary>
        ''' German, de_de.
        ''' </summary>
        ''' <remarks></remarks>
        Deutsch

        ''' <summary>
        ''' Great Britain English, en_gb.
        ''' </summary>
        ''' <remarks></remarks>
        EnglishEU

        ''' <summary>
        ''' Spanish, es_es.
        ''' </summary>
        ''' <remarks></remarks>
        EspañolEU

        ''' <summary>
        ''' French, fr_fr.
        ''' </summary>
        ''' <remarks></remarks>
        Français

        ''' <summary>
        ''' Italian, it_it.
        ''' </summary>
        ''' <remarks></remarks>
        Italiano

        ''' <summary>
        ''' Portuguese, pt_pt.
        ''' </summary>
        ''' <remarks></remarks>
        PortuguêsEU

        ''' <summary>
        ''' Russian, ru_ru.
        ''' </summary>
        ''' <remarks></remarks>
        Русский

        ''' <summary>
        ''' Korean, ko_kr.
        ''' </summary>
        ''' <remarks></remarks>
        한국어

        ''' <summary>
        ''' Simplified Chinese, zh_cn.
        ''' </summary>
        ''' <remarks></remarks>
        简体中文

        ''' <summary>
        ''' Traditional Chinese, zh_tw.
        ''' </summary>
        ''' <remarks></remarks>
        繁體中文
    End Enum

End Namespace
