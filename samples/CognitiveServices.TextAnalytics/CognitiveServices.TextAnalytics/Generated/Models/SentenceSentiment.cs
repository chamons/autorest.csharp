// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The SentenceSentiment. </summary>
    public partial class SentenceSentiment
    {
        /// <summary> The predicted Sentiment for the sentence. </summary>
        public SentenceSentimentValue Sentiment { get; set; }
        /// <summary> The sentiment confidence score between 0 and 1 for the sentence for all classes. </summary>
        public SentimentConfidenceScorePerLabel SentenceScores { get; set; } = new SentimentConfidenceScorePerLabel();
        /// <summary> The sentence offset from the start of the document. </summary>
        public int Offset { get; set; }
        /// <summary> The length of the sentence by Unicode standard. </summary>
        public int Length { get; set; }
        /// <summary> The warnings generated for the sentence. </summary>
        public ICollection<string> Warnings { get; set; }
    }
}
