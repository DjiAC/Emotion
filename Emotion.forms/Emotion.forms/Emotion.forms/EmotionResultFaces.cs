using System;
using System.Collections.Generic;
using System.Text;

namespace Emotion.Core
{
    /// <summary>
    /// Class for faceRectangles attributes
    /// </summary>
    public class EmotionResultFaces
    {
        /// <summary>
        /// Position from top
        /// </summary>
        public int top { get; set; }

        /// <summary>
        /// Position from Left
        /// </summary>
        public int left { get; set; }        

        /// <summary>
        /// Width of faceRectangles
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Height of faceRectangles
        /// </summary>
        public int height { get; set; }
    }
}
