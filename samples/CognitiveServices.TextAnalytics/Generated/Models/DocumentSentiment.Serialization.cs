// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class DocumentSentiment
    {
        internal static DocumentSentiment DeserializeDocumentSentiment(JsonElement element)
        {
            string id = default;
            DocumentSentimentValue sentiment = default;
            Optional<DocumentStatistics> statistics = default;
            SentimentConfidenceScorePerLabel confidenceScores = default;
            IReadOnlyList<SentenceSentiment> sentences = default;
            IReadOnlyList<TextAnalyticsWarning> warnings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentiment"))
                {
                    sentiment = property.Value.GetString().ToDocumentSentimentValue();
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = DocumentStatistics.DeserializeDocumentStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("confidenceScores"))
                {
                    confidenceScores = SentimentConfidenceScorePerLabel.DeserializeSentimentConfidenceScorePerLabel(property.Value);
                    continue;
                }
                if (property.NameEquals("sentences"))
                {
                    List<SentenceSentiment> array = new List<SentenceSentiment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceSentiment.DeserializeSentenceSentiment(item));
                    }
                    sentences = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<TextAnalyticsWarning> array = new List<TextAnalyticsWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsWarning.DeserializeTextAnalyticsWarning(item));
                    }
                    warnings = array;
                    continue;
                }
            }
            return new DocumentSentiment(id, sentiment, statistics.Value, confidenceScores, sentences, warnings);
        }
    }
}
