// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TextTranslationSkillLanguage.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextTranslationSkillLanguage
    {
        [EnumMember(Value = "af")]
        Af,
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "bn")]
        Bn,
        [EnumMember(Value = "bs")]
        Bs,
        [EnumMember(Value = "bg")]
        Bg,
        [EnumMember(Value = "yue")]
        Yue,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh-Hans")]
        ZhHans,
        [EnumMember(Value = "zh-Hant")]
        ZhHant,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "cs")]
        Cs,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "et")]
        Et,
        [EnumMember(Value = "fj")]
        Fj,
        [EnumMember(Value = "fil")]
        Fil,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "el")]
        El,
        [EnumMember(Value = "ht")]
        Ht,
        [EnumMember(Value = "he")]
        He,
        [EnumMember(Value = "hi")]
        Hi,
        [EnumMember(Value = "mww")]
        Mww,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "sw")]
        Sw,
        [EnumMember(Value = "tlh")]
        Tlh,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "lv")]
        Lv,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "mg")]
        Mg,
        [EnumMember(Value = "ms")]
        Ms,
        [EnumMember(Value = "mt")]
        Mt,
        [EnumMember(Value = "nb")]
        Nb,
        [EnumMember(Value = "fa")]
        Fa,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "otq")]
        Otq,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sm")]
        Sm,
        [EnumMember(Value = "sr-Cyrl")]
        SrCyrl,
        [EnumMember(Value = "sr-Latn")]
        SrLatn,
        [EnumMember(Value = "sk")]
        Sk,
        [EnumMember(Value = "sl")]
        Sl,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "ty")]
        Ty,
        [EnumMember(Value = "ta")]
        Ta,
        [EnumMember(Value = "te")]
        Te,
        [EnumMember(Value = "th")]
        Th,
        [EnumMember(Value = "to")]
        To,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "ur")]
        Ur,
        [EnumMember(Value = "vi")]
        Vi,
        [EnumMember(Value = "cy")]
        Cy,
        [EnumMember(Value = "yua")]
        Yua
    }
    internal static class TextTranslationSkillLanguageEnumExtension
    {
        internal static string ToSerializedValue(this TextTranslationSkillLanguage? value)
        {
            return value == null ? null : ((TextTranslationSkillLanguage)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TextTranslationSkillLanguage value)
        {
            switch( value )
            {
                case TextTranslationSkillLanguage.Af:
                    return "af";
                case TextTranslationSkillLanguage.Ar:
                    return "ar";
                case TextTranslationSkillLanguage.Bn:
                    return "bn";
                case TextTranslationSkillLanguage.Bs:
                    return "bs";
                case TextTranslationSkillLanguage.Bg:
                    return "bg";
                case TextTranslationSkillLanguage.Yue:
                    return "yue";
                case TextTranslationSkillLanguage.Ca:
                    return "ca";
                case TextTranslationSkillLanguage.ZhHans:
                    return "zh-Hans";
                case TextTranslationSkillLanguage.ZhHant:
                    return "zh-Hant";
                case TextTranslationSkillLanguage.Hr:
                    return "hr";
                case TextTranslationSkillLanguage.Cs:
                    return "cs";
                case TextTranslationSkillLanguage.Da:
                    return "da";
                case TextTranslationSkillLanguage.Nl:
                    return "nl";
                case TextTranslationSkillLanguage.En:
                    return "en";
                case TextTranslationSkillLanguage.Et:
                    return "et";
                case TextTranslationSkillLanguage.Fj:
                    return "fj";
                case TextTranslationSkillLanguage.Fil:
                    return "fil";
                case TextTranslationSkillLanguage.Fi:
                    return "fi";
                case TextTranslationSkillLanguage.Fr:
                    return "fr";
                case TextTranslationSkillLanguage.De:
                    return "de";
                case TextTranslationSkillLanguage.El:
                    return "el";
                case TextTranslationSkillLanguage.Ht:
                    return "ht";
                case TextTranslationSkillLanguage.He:
                    return "he";
                case TextTranslationSkillLanguage.Hi:
                    return "hi";
                case TextTranslationSkillLanguage.Mww:
                    return "mww";
                case TextTranslationSkillLanguage.Hu:
                    return "hu";
                case TextTranslationSkillLanguage.Is:
                    return "is";
                case TextTranslationSkillLanguage.Id:
                    return "id";
                case TextTranslationSkillLanguage.It:
                    return "it";
                case TextTranslationSkillLanguage.Ja:
                    return "ja";
                case TextTranslationSkillLanguage.Sw:
                    return "sw";
                case TextTranslationSkillLanguage.Tlh:
                    return "tlh";
                case TextTranslationSkillLanguage.Ko:
                    return "ko";
                case TextTranslationSkillLanguage.Lv:
                    return "lv";
                case TextTranslationSkillLanguage.Lt:
                    return "lt";
                case TextTranslationSkillLanguage.Mg:
                    return "mg";
                case TextTranslationSkillLanguage.Ms:
                    return "ms";
                case TextTranslationSkillLanguage.Mt:
                    return "mt";
                case TextTranslationSkillLanguage.Nb:
                    return "nb";
                case TextTranslationSkillLanguage.Fa:
                    return "fa";
                case TextTranslationSkillLanguage.Pl:
                    return "pl";
                case TextTranslationSkillLanguage.Pt:
                    return "pt";
                case TextTranslationSkillLanguage.Otq:
                    return "otq";
                case TextTranslationSkillLanguage.Ro:
                    return "ro";
                case TextTranslationSkillLanguage.Ru:
                    return "ru";
                case TextTranslationSkillLanguage.Sm:
                    return "sm";
                case TextTranslationSkillLanguage.SrCyrl:
                    return "sr-Cyrl";
                case TextTranslationSkillLanguage.SrLatn:
                    return "sr-Latn";
                case TextTranslationSkillLanguage.Sk:
                    return "sk";
                case TextTranslationSkillLanguage.Sl:
                    return "sl";
                case TextTranslationSkillLanguage.Es:
                    return "es";
                case TextTranslationSkillLanguage.Sv:
                    return "sv";
                case TextTranslationSkillLanguage.Ty:
                    return "ty";
                case TextTranslationSkillLanguage.Ta:
                    return "ta";
                case TextTranslationSkillLanguage.Te:
                    return "te";
                case TextTranslationSkillLanguage.Th:
                    return "th";
                case TextTranslationSkillLanguage.To:
                    return "to";
                case TextTranslationSkillLanguage.Tr:
                    return "tr";
                case TextTranslationSkillLanguage.Uk:
                    return "uk";
                case TextTranslationSkillLanguage.Ur:
                    return "ur";
                case TextTranslationSkillLanguage.Vi:
                    return "vi";
                case TextTranslationSkillLanguage.Cy:
                    return "cy";
                case TextTranslationSkillLanguage.Yua:
                    return "yua";
            }
            return null;
        }

        internal static TextTranslationSkillLanguage? ParseTextTranslationSkillLanguage(this string value)
        {
            switch( value )
            {
                case "af":
                    return TextTranslationSkillLanguage.Af;
                case "ar":
                    return TextTranslationSkillLanguage.Ar;
                case "bn":
                    return TextTranslationSkillLanguage.Bn;
                case "bs":
                    return TextTranslationSkillLanguage.Bs;
                case "bg":
                    return TextTranslationSkillLanguage.Bg;
                case "yue":
                    return TextTranslationSkillLanguage.Yue;
                case "ca":
                    return TextTranslationSkillLanguage.Ca;
                case "zh-Hans":
                    return TextTranslationSkillLanguage.ZhHans;
                case "zh-Hant":
                    return TextTranslationSkillLanguage.ZhHant;
                case "hr":
                    return TextTranslationSkillLanguage.Hr;
                case "cs":
                    return TextTranslationSkillLanguage.Cs;
                case "da":
                    return TextTranslationSkillLanguage.Da;
                case "nl":
                    return TextTranslationSkillLanguage.Nl;
                case "en":
                    return TextTranslationSkillLanguage.En;
                case "et":
                    return TextTranslationSkillLanguage.Et;
                case "fj":
                    return TextTranslationSkillLanguage.Fj;
                case "fil":
                    return TextTranslationSkillLanguage.Fil;
                case "fi":
                    return TextTranslationSkillLanguage.Fi;
                case "fr":
                    return TextTranslationSkillLanguage.Fr;
                case "de":
                    return TextTranslationSkillLanguage.De;
                case "el":
                    return TextTranslationSkillLanguage.El;
                case "ht":
                    return TextTranslationSkillLanguage.Ht;
                case "he":
                    return TextTranslationSkillLanguage.He;
                case "hi":
                    return TextTranslationSkillLanguage.Hi;
                case "mww":
                    return TextTranslationSkillLanguage.Mww;
                case "hu":
                    return TextTranslationSkillLanguage.Hu;
                case "is":
                    return TextTranslationSkillLanguage.Is;
                case "id":
                    return TextTranslationSkillLanguage.Id;
                case "it":
                    return TextTranslationSkillLanguage.It;
                case "ja":
                    return TextTranslationSkillLanguage.Ja;
                case "sw":
                    return TextTranslationSkillLanguage.Sw;
                case "tlh":
                    return TextTranslationSkillLanguage.Tlh;
                case "ko":
                    return TextTranslationSkillLanguage.Ko;
                case "lv":
                    return TextTranslationSkillLanguage.Lv;
                case "lt":
                    return TextTranslationSkillLanguage.Lt;
                case "mg":
                    return TextTranslationSkillLanguage.Mg;
                case "ms":
                    return TextTranslationSkillLanguage.Ms;
                case "mt":
                    return TextTranslationSkillLanguage.Mt;
                case "nb":
                    return TextTranslationSkillLanguage.Nb;
                case "fa":
                    return TextTranslationSkillLanguage.Fa;
                case "pl":
                    return TextTranslationSkillLanguage.Pl;
                case "pt":
                    return TextTranslationSkillLanguage.Pt;
                case "otq":
                    return TextTranslationSkillLanguage.Otq;
                case "ro":
                    return TextTranslationSkillLanguage.Ro;
                case "ru":
                    return TextTranslationSkillLanguage.Ru;
                case "sm":
                    return TextTranslationSkillLanguage.Sm;
                case "sr-Cyrl":
                    return TextTranslationSkillLanguage.SrCyrl;
                case "sr-Latn":
                    return TextTranslationSkillLanguage.SrLatn;
                case "sk":
                    return TextTranslationSkillLanguage.Sk;
                case "sl":
                    return TextTranslationSkillLanguage.Sl;
                case "es":
                    return TextTranslationSkillLanguage.Es;
                case "sv":
                    return TextTranslationSkillLanguage.Sv;
                case "ty":
                    return TextTranslationSkillLanguage.Ty;
                case "ta":
                    return TextTranslationSkillLanguage.Ta;
                case "te":
                    return TextTranslationSkillLanguage.Te;
                case "th":
                    return TextTranslationSkillLanguage.Th;
                case "to":
                    return TextTranslationSkillLanguage.To;
                case "tr":
                    return TextTranslationSkillLanguage.Tr;
                case "uk":
                    return TextTranslationSkillLanguage.Uk;
                case "ur":
                    return TextTranslationSkillLanguage.Ur;
                case "vi":
                    return TextTranslationSkillLanguage.Vi;
                case "cy":
                    return TextTranslationSkillLanguage.Cy;
                case "yua":
                    return TextTranslationSkillLanguage.Yua;
            }
            return null;
        }
    }
}
