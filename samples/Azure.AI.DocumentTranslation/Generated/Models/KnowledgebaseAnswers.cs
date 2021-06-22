// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentTranslation.Models
{
    /// <summary> Represents List of Question Answers. </summary>
    public partial class KnowledgebaseAnswers
    {
        /// <summary> Initializes a new instance of KnowledgebaseAnswers. </summary>
        internal KnowledgebaseAnswers()
        {
            Answers = new ChangeTrackingList<KnowledgebaseAnswer>();
        }

        /// <summary> Initializes a new instance of KnowledgebaseAnswers. </summary>
        /// <param name="answers"> Represents Answer Result list. </param>
        internal KnowledgebaseAnswers(IReadOnlyList<KnowledgebaseAnswer> answers)
        {
            Answers = answers;
        }

        /// <summary> Represents Answer Result list. </summary>
        public IReadOnlyList<KnowledgebaseAnswer> Answers { get; }
    }
}
