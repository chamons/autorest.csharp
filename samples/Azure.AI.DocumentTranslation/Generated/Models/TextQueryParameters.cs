// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.DocumentTranslation.Models
{
    /// <summary> The question and text record parameters to answer. </summary>
    public partial class TextQueryParameters
    {
        /// <summary> Initializes a new instance of TextQueryParameters. </summary>
        /// <param name="question"> User question to query against the given text records. </param>
        /// <param name="records"> Text records to be searched for given question. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="question"/> or <paramref name="records"/> is null. </exception>
        public TextQueryParameters(string question, IEnumerable<TextInput> records)
        {
            if (question == null)
            {
                throw new ArgumentNullException(nameof(question));
            }
            if (records == null)
            {
                throw new ArgumentNullException(nameof(records));
            }

            Question = question;
            Records = records.ToList();
        }

        /// <summary> User question to query against the given text records. </summary>
        public string Question { get; }
        /// <summary> Text records to be searched for given question. </summary>
        public IList<TextInput> Records { get; }
        /// <summary> Language of the text records. This is BCP-47 representation of a language. For example, use &quot;en&quot; for English; &quot;es&quot; for Spanish etc. If not set, use &quot;en&quot; for English as default. </summary>
        public string Language { get; set; }
        /// <summary> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </summary>
        public StringIndexType? StringIndexType { get; set; }
    }
}
