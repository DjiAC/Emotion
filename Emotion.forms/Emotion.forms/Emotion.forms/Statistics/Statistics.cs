using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Emotion.Core
{ 
    /// <summary>
    /// 
    /// </summary>
    public static class Statistics
    {
        #region Variables 

        static List<EmotionStatistics> EmotionStats = new List<EmotionStatistics>();

        static List<TextAnalysisStatistics> TextAnalysisStats = new List<TextAnalysisStatistics>();

        #endregion

        #region Get Stats

        /// <summary>
        /// Get Emotion Call Statistics from local JSON File
        /// </summary>
        public static List<EmotionStatistics> GetEmotionStats()
        {
            EmotionStats = JsonConvert.DeserializeObject<List<EmotionStatistics>>(System.IO.File.ReadAllText(@"EmotionStats.json"));

            return EmotionStats;
        }

        /// <summary>
        /// Get TextAnalysis Call Statistics from local JSON File
        /// </summary>
        public static List<TextAnalysisStatistics> GetTextAnalysisStats()
        {
            TextAnalysisStats = JsonConvert.DeserializeObject<List<TextAnalysisStatistics>>(System.IO.File.ReadAllText(@"TextAnalysisStats.json"));

            return TextAnalysisStats;
        }

        #endregion

        #region Update Stats

        /// <summary>
        /// Update Emotion Call Statistics to local JSON File
        /// </summary>
        public static void UpdateEmotionStats(List<EmotionStatistics> emotionConnectStats)
        { 
            // TODO : Update Emotion Stats
        }

        /// <summary>
        /// Update TextAnalysis Call Statistics to local JSON File
        /// </summary>
        public static void UpdateTextAnalysisStats(List<TextAnalysisStatistics> textAnalysisConnectStats)
        {
            // TODO : Update Text Analysis Stats
        }

        /// <summary>
        /// Update Emotion Call JSON Statistics to local JSON File
        /// </summary>
        public static void UpdateEmotionJSONStats()
        {
            System.IO.File.WriteAllText(@"EmotionStats.json", JsonConvert.SerializeObject(EmotionStats));
        }        

        /// <summary>
        /// Update TextAnalysis Call JSON Statistics to local JSON File
        /// </summary>
        public static void UpdateTextAnalysisJSONStats()
        {
            System.IO.File.WriteAllText(@"TextAnalysisStats.json", JsonConvert.SerializeObject(TextAnalysisStats));
        }

        #endregion

        #region Calculs

        // TODO : Calls per Day - Mean Number of Faces per Call - Number of Faces per Emotion

        // TODO : Calls per day - Language repartition - Number of sentiment per stage ( 0-30 / 31-60 / 61-100)


        #endregion
    }
}
