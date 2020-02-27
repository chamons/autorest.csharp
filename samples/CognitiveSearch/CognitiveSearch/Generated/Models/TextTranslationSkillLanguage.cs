// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace CognitiveSearch.Models
{
    /// <summary> The language codes supported for input text by TextTranslationSkill. </summary>
    public readonly partial struct TextTranslationSkillLanguage : IEquatable<TextTranslationSkillLanguage>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TextTranslationSkillLanguage"/> values are the same. </summary>
        public TextTranslationSkillLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AfValue = "af";
        private const string ArValue = "ar";
        private const string BnValue = "bn";
        private const string BsValue = "bs";
        private const string BgValue = "bg";
        private const string YueValue = "yue";
        private const string CaValue = "ca";
        private const string ZhHansValue = "zh-Hans";
        private const string ZhHantValue = "zh-Hant";
        private const string HrValue = "hr";
        private const string CsValue = "cs";
        private const string DaValue = "da";
        private const string NlValue = "nl";
        private const string EnValue = "en";
        private const string EtValue = "et";
        private const string FjValue = "fj";
        private const string FilValue = "fil";
        private const string FiValue = "fi";
        private const string FrValue = "fr";
        private const string DeValue = "de";
        private const string ElValue = "el";
        private const string HtValue = "ht";
        private const string HeValue = "he";
        private const string HiValue = "hi";
        private const string MwwValue = "mww";
        private const string HuValue = "hu";
        private const string IsValue = "is";
        private const string IdValue = "id";
        private const string ItValue = "it";
        private const string JaValue = "ja";
        private const string SwValue = "sw";
        private const string TlhValue = "tlh";
        private const string KoValue = "ko";
        private const string LvValue = "lv";
        private const string LtValue = "lt";
        private const string MgValue = "mg";
        private const string MsValue = "ms";
        private const string MtValue = "mt";
        private const string NbValue = "nb";
        private const string FaValue = "fa";
        private const string PlValue = "pl";
        private const string PtValue = "pt";
        private const string OtqValue = "otq";
        private const string RoValue = "ro";
        private const string RuValue = "ru";
        private const string SmValue = "sm";
        private const string SrCyrlValue = "sr-Cyrl";
        private const string SrLatnValue = "sr-Latn";
        private const string SkValue = "sk";
        private const string SlValue = "sl";
        private const string EsValue = "es";
        private const string SvValue = "sv";
        private const string TyValue = "ty";
        private const string TaValue = "ta";
        private const string TeValue = "te";
        private const string ThValue = "th";
        private const string ToValue = "to";
        private const string TrValue = "tr";
        private const string UkValue = "uk";
        private const string UrValue = "ur";
        private const string ViValue = "vi";
        private const string CyValue = "cy";
        private const string YuaValue = "yua";

        /// <summary> Afrikaans. </summary>
        public static TextTranslationSkillLanguage Af { get; } = new TextTranslationSkillLanguage(AfValue);
        /// <summary> Arabic. </summary>
        public static TextTranslationSkillLanguage Ar { get; } = new TextTranslationSkillLanguage(ArValue);
        /// <summary> Bangla. </summary>
        public static TextTranslationSkillLanguage Bn { get; } = new TextTranslationSkillLanguage(BnValue);
        /// <summary> Bosnian (Latin). </summary>
        public static TextTranslationSkillLanguage Bs { get; } = new TextTranslationSkillLanguage(BsValue);
        /// <summary> Bulgarian. </summary>
        public static TextTranslationSkillLanguage Bg { get; } = new TextTranslationSkillLanguage(BgValue);
        /// <summary> Cantonese (Traditional). </summary>
        public static TextTranslationSkillLanguage Yue { get; } = new TextTranslationSkillLanguage(YueValue);
        /// <summary> Catalan. </summary>
        public static TextTranslationSkillLanguage Ca { get; } = new TextTranslationSkillLanguage(CaValue);
        /// <summary> Chinese Simplified. </summary>
        public static TextTranslationSkillLanguage ZhHans { get; } = new TextTranslationSkillLanguage(ZhHansValue);
        /// <summary> Chinese Traditional. </summary>
        public static TextTranslationSkillLanguage ZhHant { get; } = new TextTranslationSkillLanguage(ZhHantValue);
        /// <summary> Croatian. </summary>
        public static TextTranslationSkillLanguage Hr { get; } = new TextTranslationSkillLanguage(HrValue);
        /// <summary> Czech. </summary>
        public static TextTranslationSkillLanguage Cs { get; } = new TextTranslationSkillLanguage(CsValue);
        /// <summary> Danish. </summary>
        public static TextTranslationSkillLanguage Da { get; } = new TextTranslationSkillLanguage(DaValue);
        /// <summary> Dutch. </summary>
        public static TextTranslationSkillLanguage Nl { get; } = new TextTranslationSkillLanguage(NlValue);
        /// <summary> English. </summary>
        public static TextTranslationSkillLanguage En { get; } = new TextTranslationSkillLanguage(EnValue);
        /// <summary> Estonian. </summary>
        public static TextTranslationSkillLanguage Et { get; } = new TextTranslationSkillLanguage(EtValue);
        /// <summary> Fijian. </summary>
        public static TextTranslationSkillLanguage Fj { get; } = new TextTranslationSkillLanguage(FjValue);
        /// <summary> Filipino. </summary>
        public static TextTranslationSkillLanguage Fil { get; } = new TextTranslationSkillLanguage(FilValue);
        /// <summary> Finnish. </summary>
        public static TextTranslationSkillLanguage Fi { get; } = new TextTranslationSkillLanguage(FiValue);
        /// <summary> French. </summary>
        public static TextTranslationSkillLanguage Fr { get; } = new TextTranslationSkillLanguage(FrValue);
        /// <summary> German. </summary>
        public static TextTranslationSkillLanguage De { get; } = new TextTranslationSkillLanguage(DeValue);
        /// <summary> Greek. </summary>
        public static TextTranslationSkillLanguage El { get; } = new TextTranslationSkillLanguage(ElValue);
        /// <summary> Haitian Creole. </summary>
        public static TextTranslationSkillLanguage Ht { get; } = new TextTranslationSkillLanguage(HtValue);
        /// <summary> Hebrew. </summary>
        public static TextTranslationSkillLanguage He { get; } = new TextTranslationSkillLanguage(HeValue);
        /// <summary> Hindi. </summary>
        public static TextTranslationSkillLanguage Hi { get; } = new TextTranslationSkillLanguage(HiValue);
        /// <summary> Hmong Daw. </summary>
        public static TextTranslationSkillLanguage Mww { get; } = new TextTranslationSkillLanguage(MwwValue);
        /// <summary> Hungarian. </summary>
        public static TextTranslationSkillLanguage Hu { get; } = new TextTranslationSkillLanguage(HuValue);
        /// <summary> Icelandic. </summary>
        public static TextTranslationSkillLanguage Is { get; } = new TextTranslationSkillLanguage(IsValue);
        /// <summary> Indonesian. </summary>
        public static TextTranslationSkillLanguage Id { get; } = new TextTranslationSkillLanguage(IdValue);
        /// <summary> Italian. </summary>
        public static TextTranslationSkillLanguage It { get; } = new TextTranslationSkillLanguage(ItValue);
        /// <summary> Japanese. </summary>
        public static TextTranslationSkillLanguage Ja { get; } = new TextTranslationSkillLanguage(JaValue);
        /// <summary> Kiswahili. </summary>
        public static TextTranslationSkillLanguage Sw { get; } = new TextTranslationSkillLanguage(SwValue);
        /// <summary> Klingon. </summary>
        public static TextTranslationSkillLanguage Tlh { get; } = new TextTranslationSkillLanguage(TlhValue);
        /// <summary> Korean. </summary>
        public static TextTranslationSkillLanguage Ko { get; } = new TextTranslationSkillLanguage(KoValue);
        /// <summary> Latvian. </summary>
        public static TextTranslationSkillLanguage Lv { get; } = new TextTranslationSkillLanguage(LvValue);
        /// <summary> Lithuanian. </summary>
        public static TextTranslationSkillLanguage Lt { get; } = new TextTranslationSkillLanguage(LtValue);
        /// <summary> Malagasy. </summary>
        public static TextTranslationSkillLanguage Mg { get; } = new TextTranslationSkillLanguage(MgValue);
        /// <summary> Malay. </summary>
        public static TextTranslationSkillLanguage Ms { get; } = new TextTranslationSkillLanguage(MsValue);
        /// <summary> Maltese. </summary>
        public static TextTranslationSkillLanguage Mt { get; } = new TextTranslationSkillLanguage(MtValue);
        /// <summary> Norwegian. </summary>
        public static TextTranslationSkillLanguage Nb { get; } = new TextTranslationSkillLanguage(NbValue);
        /// <summary> Persian. </summary>
        public static TextTranslationSkillLanguage Fa { get; } = new TextTranslationSkillLanguage(FaValue);
        /// <summary> Polish. </summary>
        public static TextTranslationSkillLanguage Pl { get; } = new TextTranslationSkillLanguage(PlValue);
        /// <summary> Portuguese. </summary>
        public static TextTranslationSkillLanguage Pt { get; } = new TextTranslationSkillLanguage(PtValue);
        /// <summary> Queretaro Otomi. </summary>
        public static TextTranslationSkillLanguage Otq { get; } = new TextTranslationSkillLanguage(OtqValue);
        /// <summary> Romanian. </summary>
        public static TextTranslationSkillLanguage Ro { get; } = new TextTranslationSkillLanguage(RoValue);
        /// <summary> Russian. </summary>
        public static TextTranslationSkillLanguage Ru { get; } = new TextTranslationSkillLanguage(RuValue);
        /// <summary> Samoan. </summary>
        public static TextTranslationSkillLanguage Sm { get; } = new TextTranslationSkillLanguage(SmValue);
        /// <summary> Serbian (Cyrillic). </summary>
        public static TextTranslationSkillLanguage SrCyrl { get; } = new TextTranslationSkillLanguage(SrCyrlValue);
        /// <summary> Serbian (Latin). </summary>
        public static TextTranslationSkillLanguage SrLatn { get; } = new TextTranslationSkillLanguage(SrLatnValue);
        /// <summary> Slovak. </summary>
        public static TextTranslationSkillLanguage Sk { get; } = new TextTranslationSkillLanguage(SkValue);
        /// <summary> Slovenian. </summary>
        public static TextTranslationSkillLanguage Sl { get; } = new TextTranslationSkillLanguage(SlValue);
        /// <summary> Spanish. </summary>
        public static TextTranslationSkillLanguage Es { get; } = new TextTranslationSkillLanguage(EsValue);
        /// <summary> Swedish. </summary>
        public static TextTranslationSkillLanguage Sv { get; } = new TextTranslationSkillLanguage(SvValue);
        /// <summary> Tahitian. </summary>
        public static TextTranslationSkillLanguage Ty { get; } = new TextTranslationSkillLanguage(TyValue);
        /// <summary> Tamil. </summary>
        public static TextTranslationSkillLanguage Ta { get; } = new TextTranslationSkillLanguage(TaValue);
        /// <summary> Telugu. </summary>
        public static TextTranslationSkillLanguage Te { get; } = new TextTranslationSkillLanguage(TeValue);
        /// <summary> Thai. </summary>
        public static TextTranslationSkillLanguage Th { get; } = new TextTranslationSkillLanguage(ThValue);
        /// <summary> Tongan. </summary>
        public static TextTranslationSkillLanguage To { get; } = new TextTranslationSkillLanguage(ToValue);
        /// <summary> Turkish. </summary>
        public static TextTranslationSkillLanguage Tr { get; } = new TextTranslationSkillLanguage(TrValue);
        /// <summary> Ukrainian. </summary>
        public static TextTranslationSkillLanguage Uk { get; } = new TextTranslationSkillLanguage(UkValue);
        /// <summary> Urdu. </summary>
        public static TextTranslationSkillLanguage Ur { get; } = new TextTranslationSkillLanguage(UrValue);
        /// <summary> Vietnamese. </summary>
        public static TextTranslationSkillLanguage Vi { get; } = new TextTranslationSkillLanguage(ViValue);
        /// <summary> Welsh. </summary>
        public static TextTranslationSkillLanguage Cy { get; } = new TextTranslationSkillLanguage(CyValue);
        /// <summary> Yucatec Maya. </summary>
        public static TextTranslationSkillLanguage Yua { get; } = new TextTranslationSkillLanguage(YuaValue);
        /// <summary> Determines if two <see cref="TextTranslationSkillLanguage"/> values are the same. </summary>
        public static bool operator ==(TextTranslationSkillLanguage left, TextTranslationSkillLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TextTranslationSkillLanguage"/> values are not the same. </summary>
        public static bool operator !=(TextTranslationSkillLanguage left, TextTranslationSkillLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TextTranslationSkillLanguage"/>. </summary>
        public static implicit operator TextTranslationSkillLanguage(string value) => new TextTranslationSkillLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TextTranslationSkillLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TextTranslationSkillLanguage other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
