using System;
using System.Collections.Generic;
using System.Text;

namespace Emotion.Core
{
    /// <summary>
    /// Class for Emotion analysis results
    /// </summary>
    public class EmotionResults
    {
        /// <summary>
        /// List of the face Rectangles
        /// </summary>
        List<EmotionResultsFaces> FaceRectangles { get; set; }

        /// <summary>
        /// List of the scores
        /// </summary>
        List<EmotionResultsScores> Scores { get; set; }
    }
}
