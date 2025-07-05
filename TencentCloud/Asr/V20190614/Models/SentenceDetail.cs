/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SentenceDetail : AbstractModel
    {
        
        /// <summary>
        /// Final recognition result of a sentence.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FinalSentence")]
        public string FinalSentence{ get; set; }

        /// <summary>
        /// Intermediate recognition result of a sentence. The sentence is split into multiple phrases by spaces.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SliceSentence")]
        public string SliceSentence{ get; set; }

        /// <summary>
        /// Oral-to-written transcription result. This parameter has a value only if the corresponding feature is enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WrittenText")]
        public string WrittenText{ get; set; }

        /// <summary>
        /// Start time of a sentence (ms).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartMs")]
        public long? StartMs{ get; set; }

        /// <summary>
        /// End time of a sentence (ms).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndMs")]
        public long? EndMs{ get; set; }

        /// <summary>
        /// Number of words in a sentence.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WordsNum")]
        public long? WordsNum{ get; set; }

        /// <summary>
        /// Word details of a sentence.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Words")]
        public SentenceWords[] Words{ get; set; }

        /// <summary>
        /// Speech speed of a sentence. Unit: Number of words per second.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpeechSpeed")]
        public float? SpeechSpeed{ get; set; }

        /// <summary>
        /// Channel or speaker ID. (If speaker_diarization is specified or ChannelNum is set to 2 (stereo) in the request, speakers or channels can be distinguished.)
        /// Different values represent different speakers in mono mode. For the speakerId values, 0 represents the left channel, and 1 represents the right channel in stereo mode if an 8k engine is used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpeakerId")]
        public long? SpeakerId{ get; set; }

        /// <summary>
        /// Emotional energy value. This value is the result of dividing the sound volume in dB by 10. Value range: [1,10]. The higher the value, the stronger the emotion.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EmotionalEnergy")]
        public float? EmotionalEnergy{ get; set; }

        /// <summary>
        /// Silent duration between the current sentence and the last sentence.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SilenceTime")]
        public long? SilenceTime{ get; set; }

        /// <summary>
        /// Emotion type. (This parameter may be left blank in two scenarios: 1. No corresponding resource package exists; 2. The emotion is not recognized because it is not strong enough, which is related to the emotional energy.)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EmotionType")]
        public string[] EmotionType{ get; set; }

        /// <summary>
        /// List of recognized keywords.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyWordResults")]
        public KeyWordResult[] KeyWordResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FinalSentence", this.FinalSentence);
            this.SetParamSimple(map, prefix + "SliceSentence", this.SliceSentence);
            this.SetParamSimple(map, prefix + "WrittenText", this.WrittenText);
            this.SetParamSimple(map, prefix + "StartMs", this.StartMs);
            this.SetParamSimple(map, prefix + "EndMs", this.EndMs);
            this.SetParamSimple(map, prefix + "WordsNum", this.WordsNum);
            this.SetParamArrayObj(map, prefix + "Words.", this.Words);
            this.SetParamSimple(map, prefix + "SpeechSpeed", this.SpeechSpeed);
            this.SetParamSimple(map, prefix + "SpeakerId", this.SpeakerId);
            this.SetParamSimple(map, prefix + "EmotionalEnergy", this.EmotionalEnergy);
            this.SetParamSimple(map, prefix + "SilenceTime", this.SilenceTime);
            this.SetParamArraySimple(map, prefix + "EmotionType.", this.EmotionType);
            this.SetParamArrayObj(map, prefix + "KeyWordResults.", this.KeyWordResults);
        }
    }
}

