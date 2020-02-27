// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace CognitiveSearch.Models
{
    /// <summary> The language codes supported for input text by KeyPhraseExtractionSkill. </summary>
    public readonly partial struct KeyPhraseExtractionSkillLanguage : IEquatable<KeyPhraseExtractionSkillLanguage>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="KeyPhraseExtractionSkillLanguage"/> values are the same. </summary>
        public KeyPhraseExtractionSkillLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DaValue = "da";
        private const string NlValue = "nl";
        private const string EnValue = "en";
        private const string FiValue = "fi";
        private const string FrValue = "fr";
        private const string DeValue = "de";
        private const string ItValue = "it";
        private const string JaValue = "ja";
        private const string KoValue = "ko";
        private const string NoValue = "no";
        private const string PlValue = "pl";
        private const string PtValue = "pt-PT";
        private const string PtBRValue = "pt-BR";
        private const string RuValue = "ru";
        private const string EsValue = "es";
        private const string SvValue = "sv";

        /// <summary> Danish. </summary>
        public static KeyPhraseExtractionSkillLanguage Da { get; } = new KeyPhraseExtractionSkillLanguage(DaValue);
        /// <summary> Dutch. </summary>
        public static KeyPhraseExtractionSkillLanguage Nl { get; } = new KeyPhraseExtractionSkillLanguage(NlValue);
        /// <summary> English. </summary>
        public static KeyPhraseExtractionSkillLanguage En { get; } = new KeyPhraseExtractionSkillLanguage(EnValue);
        /// <summary> Finnish. </summary>
        public static KeyPhraseExtractionSkillLanguage Fi { get; } = new KeyPhraseExtractionSkillLanguage(FiValue);
        /// <summary> French. </summary>
        public static KeyPhraseExtractionSkillLanguage Fr { get; } = new KeyPhraseExtractionSkillLanguage(FrValue);
        /// <summary> German. </summary>
        public static KeyPhraseExtractionSkillLanguage De { get; } = new KeyPhraseExtractionSkillLanguage(DeValue);
        /// <summary> Italian. </summary>
        public static KeyPhraseExtractionSkillLanguage It { get; } = new KeyPhraseExtractionSkillLanguage(ItValue);
        /// <summary> Japanese. </summary>
        public static KeyPhraseExtractionSkillLanguage Ja { get; } = new KeyPhraseExtractionSkillLanguage(JaValue);
        /// <summary> Korean. </summary>
        public static KeyPhraseExtractionSkillLanguage Ko { get; } = new KeyPhraseExtractionSkillLanguage(KoValue);
        /// <summary> Norwegian (Bokmaal). </summary>
        public static KeyPhraseExtractionSkillLanguage No { get; } = new KeyPhraseExtractionSkillLanguage(NoValue);
        /// <summary> Polish. </summary>
        public static KeyPhraseExtractionSkillLanguage Pl { get; } = new KeyPhraseExtractionSkillLanguage(PlValue);
        /// <summary> Portuguese (Portugal). </summary>
        public static KeyPhraseExtractionSkillLanguage Pt { get; } = new KeyPhraseExtractionSkillLanguage(PtValue);
        /// <summary> Portuguese (Brazil). </summary>
        public static KeyPhraseExtractionSkillLanguage PtBR { get; } = new KeyPhraseExtractionSkillLanguage(PtBRValue);
        /// <summary> Russian. </summary>
        public static KeyPhraseExtractionSkillLanguage Ru { get; } = new KeyPhraseExtractionSkillLanguage(RuValue);
        /// <summary> Spanish. </summary>
        public static KeyPhraseExtractionSkillLanguage Es { get; } = new KeyPhraseExtractionSkillLanguage(EsValue);
        /// <summary> Swedish. </summary>
        public static KeyPhraseExtractionSkillLanguage Sv { get; } = new KeyPhraseExtractionSkillLanguage(SvValue);
        /// <summary> Determines if two <see cref="KeyPhraseExtractionSkillLanguage"/> values are the same. </summary>
        public static bool operator ==(KeyPhraseExtractionSkillLanguage left, KeyPhraseExtractionSkillLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KeyPhraseExtractionSkillLanguage"/> values are not the same. </summary>
        public static bool operator !=(KeyPhraseExtractionSkillLanguage left, KeyPhraseExtractionSkillLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KeyPhraseExtractionSkillLanguage"/>. </summary>
        public static implicit operator KeyPhraseExtractionSkillLanguage(string value) => new KeyPhraseExtractionSkillLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KeyPhraseExtractionSkillLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KeyPhraseExtractionSkillLanguage other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
