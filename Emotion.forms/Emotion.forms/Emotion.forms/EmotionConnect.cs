using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;
using System.Net.Http.Headers;

namespace Emotion.Core
{
    /// <summary>
    /// Connection to Cognitive Services Microsoft API
    /// </summary>
    public class EmotionConnect
    {
        /// <summary>
        /// Differents Connection Response Status
        /// </summary>
        public enum ConnectionResults {
            success,
            networkTrouble,
            noFace,
            serviceTrouble
        }

        /// <summary>
        /// List of Emotions Response - EmotionResult format
        /// </summary>
        public List<EmotionResult> emotionResults { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public EmotionConnect()
        {
            emotionResults = new List<EmotionResult>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imagePath">Tested image path</param>
        /// <returns></returns>
        public byte[] GetImageAsByteArray(string imagePath)
        {
            FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }

        /// <summary>
        /// Cognitives Emotion Service call
        /// </summary>
        /// <param name="imagePath">Tested image path</param>
        /// <returns></returns>
        public async Task<ConnectionResults> CallService(string imagePath)
        {
            var webclient = new HttpClient();

            // Request Headers
            webclient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "b80ed666c80c493999bc69f957694206");

            string uri = "https://westus.api.cognitive.microsoft.com/emotion/v1.0/recognize?";
            HttpResponseMessage response;
            string responseContent = "";

            // Request body
            byte[] byteData = GetImageAsByteArray(imagePath);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                // Try HTTP Request
                try
                {
                    response = await webclient.PostAsync(uri, content);
                    responseContent = await response.Content.ReadAsStringAsync();
                }
                // Catch HTTP Request Exceptions
                catch (HttpRequestException)
                {
                    return ConnectionResults.networkTrouble;
                }
            }

            // Check deserializedResult to see if there is issues
            // Try Deserialize response
            try
            {
                var deserializedResult = JsonConvert.DeserializeObject<List<EmotionResult>>(responseContent);
            }
            // Catch Deserialize problem -> means the json returned a json is state an error
            catch (Exception)
            {
                return ConnectionResults.serviceTrouble;
            }

            // Check if Face Rectangle found
            if (emotionResults.Count != 0)
            {
                // Update the statistics and return a success
                // UpdateStatistics();
                return ConnectionResults.success;
            }
            else
            {
                // If no Face found on image
                return ConnectionResults.noFace;
            }            
        }
    }
}
