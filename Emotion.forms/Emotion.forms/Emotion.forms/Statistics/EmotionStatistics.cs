using System;
using System.Collections.Generic;
using System.Text;

namespace Emotion.Core
{
    /// <summary>
    /// Class for Emotion Statistics
    /// </summary>
    public class EmotionStatistics
    {
        #region Variables & Properties

        /// <summary>
        /// Total number of Emotion Calls
        /// </summary>
        public int totalEmotionCalls { get; set; }

        /// <summary>
        /// Total List of Emotion Calls Statistics
        /// </summary>
        public List<EmotionCallStatistics> totalEmotionCallsStatistics { get; set; }

        /// <summary>
        /// Mean of Emotion Calls per day
        /// </summary>
        public int emotionCallsPerDay { get; set; }

        /// <summary>
        /// Mean of Faces per Call
        /// </summary>
        public float facesPerCall { get; set; }

        /// <summary>
        /// Number of Detected Faces per Emotion
        /// </summary>
        public Tuple<String, int> detectionPerEmotion { get; set; }

        #endregion

        #region Calculs

        #endregion
    }
}
