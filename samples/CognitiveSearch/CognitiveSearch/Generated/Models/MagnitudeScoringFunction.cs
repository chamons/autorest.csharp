// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Defines a function that boosts scores based on the magnitude of a numeric field. </summary>
    public partial class MagnitudeScoringFunction : ScoringFunction
    {
        /// <summary> Initializes a new instance of MagnitudeScoringFunction. </summary>
        public MagnitudeScoringFunction()
        {
            Type = "magnitude";
        }
        /// <summary> Parameter values for the magnitude scoring function. </summary>
        public MagnitudeScoringParameters Parameters { get; set; } = new MagnitudeScoringParameters();
    }
}
