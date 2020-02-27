// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Text analytics positive-negative sentiment analysis, scored as a floating point value in a range of zero to 1. </summary>
    public partial class SentimentSkill : Skill
    {
        /// <summary> Initializes a new instance of SentimentSkill. </summary>
        public SentimentSkill()
        {
            OdataType = "#Microsoft.Skills.Text.SentimentSkill";
        }
        /// <summary> A value indicating which language code to use. Default is en. </summary>
        public SentimentSkillLanguage? DefaultLanguageCode { get; set; }
    }
}
