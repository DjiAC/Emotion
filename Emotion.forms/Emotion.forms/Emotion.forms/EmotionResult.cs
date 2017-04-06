using System;
using System.Collections.Generic;
using System.Text;

namespace Emotion.forms
{
    /// <summary>
    /// Class for Emotion analysis results
    /// </summary>
    public class EmotionResult
    {
        /// <summary>
        /// List of the face Rectangles
        /// </summary>
        List<EmotionResultFaces> FaceRectangles { get; set; }

        /// <summary>
        /// List of the scores
        /// </summary>
        List<EmotionResultScores> Scores { get; set; }

        public EmotionResult()
        {

        }
    }
}
