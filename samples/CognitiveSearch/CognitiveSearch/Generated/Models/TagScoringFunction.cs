// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Defines a function that boosts scores of documents with string values matching a given list of tags. </summary>
    public partial class TagScoringFunction : ScoringFunction
    {
        /// <summary> Initializes a new instance of TagScoringFunction. </summary>
        public TagScoringFunction()
        {
            Type = "tag";
        }
        /// <summary> Parameter values for the tag scoring function. </summary>
        public TagScoringParameters Parameters { get; set; } = new TagScoringParameters();
    }
}
