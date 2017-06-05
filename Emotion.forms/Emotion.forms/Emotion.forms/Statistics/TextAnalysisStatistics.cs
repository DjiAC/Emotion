using System;
using System.Collections.Generic;
using System.Text;

namespace Emotion.Core
{ 
    /// <summary>
    /// Class for Text Analysis Statistics
    /// </summary>
    public class TextAnalysisStatistics
    {
        #region Variables & Properties

        /// <summary>
        /// Total number of Text Analysis Calls
        /// </summary>
        public int totalTextAnalysisCalls { get; set; }

        /// <summary>
        /// Total List of Text Analysis Calls Statistics
        /// </summary>
        public List<TextAnalysisCallStatistics> totalTextAnalysisCallsStatistics { get; set; }

        /// <summary>
        /// Mean of Text Analytics Calls per day
        /// </summary>
        public int textAnalyticsCallsPerDay { get; set; }

        /// <summary>
        /// Number of Detected phrases per Language
        /// </summary>
        public Tuple<String, int> detectionPerLanguage { get; set; }

        #endregion

        #region Calculs

        #endregion

    }
}
