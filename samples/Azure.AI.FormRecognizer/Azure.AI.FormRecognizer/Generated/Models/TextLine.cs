// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> An object representing an extracted text line. </summary>
    public partial class TextLine
    {
        /// <summary> The text content of the line. </summary>
        public string Text { get; set; }
        /// <summary> Bounding box of an extracted line. </summary>
        public ICollection<float> BoundingBox { get; set; } = new List<float>();
        /// <summary> The detected language of this line, if different from the overall page language. </summary>
        public Language? Language { get; set; }
        /// <summary> List of words in the text line. </summary>
        public ICollection<TextWord> Words { get; set; } = new List<TextWord>();
    }
}