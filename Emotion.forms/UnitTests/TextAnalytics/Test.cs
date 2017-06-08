﻿using NUnit.Framework;
using System;
namespace UnitTests
{
    [TestFixture()]
    public class TestTextAnalyticsConnect
    {
        [Test()]
        public void TestCallService()
        {
            // TODO Check if the right services list is returned 
            Emotion.Core.TextAnalyticsConnect connector = new Emotion.Core.TextAnalyticsConnect();
            Assert.IsTrue(true);
        }
        [Test()]
        public void TestCallTextAnalyticsAPI()
        {
            // TODO Check if a valid response is returned from the API
        }
        [Test()]
        public void TestCallLanguageAPI()
        {
            // TODO check if the API return an asynchrone task list 
        }
        [Test()]
        public void TestCallKeyPhraseAPI()
        {
            // TODO  check if the setting are updated on the PhraseAPI and if the method CallTextAnalyticsAPI() is called
        }
        [Test()]
        public void TestCallSentimentAPI()
        {
            // TODO check if the setting are updated on the SentimentAPI and if the method CallTextAnalyticsAPI() is called
        }
        [Test()]
        public void TestDetectLanguage()
        {
            // TODO check if the language is the right one
        }
        [Test()]
        public void TestDetectKeyPhrases()
        {
            // TODO check if the phrase is not empty, if the results are the same for the same text
        }
        [Test()]
        public void TestDetectSentiment()
        {
            // TODO check if the setiment is detected, if there is some network trouble 
        }
        [Test()]
        public void TestLanguageRequestFormat()
        {
            // TODO check if the data is converted in Json Format

        }
        [Test()]
        public void TestKeyPhrasesSentimentRequestFormat()
        {
            // TODO check if the Key Phrase & Sentiment request is converted to byte and Key Phrase & Sentiment request is converted to json format
        }
        [Test()]
        public void TestUpdateTextAnalysisResultsToStats()
        {
            // TODO check if stats are up to date after a the call of the function()
        }
    }
}
