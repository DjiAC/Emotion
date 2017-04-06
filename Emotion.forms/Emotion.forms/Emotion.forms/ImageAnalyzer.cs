using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;

namespace Emotion.forms
{
    public class ImageAnalyzer
    {
        EmotionResultScores[] emotionResult;

        string subscriptionKey = "";

        EmotionServiceClient emotionServiceClient = new EmotionServiceClient(subscriptionKey);


    }
}
