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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsrParam : AbstractModel
    {
        
        /// <summary>
        /// The model type used for the transcription service. Example: <code>"zh"</code>.
        /// 
        /// Supported languages for speech-to-text:
        /// 
        /// - <code>"zh"</code>: Chinese (Simplified) - Powered by the latest 16k large model engine. Supports Mandarin, English, multiple Chinese regional accents, and code-switching between Chinese and English.
        /// - <code>"zh-TW"</code>: Chinese (Traditional)
        /// - <code>"en"</code>: English
        /// - <code>"vi"</code>: Vietnamese
        /// - <code>"ja"</code>: Japanese
        /// - <code>"ko"</code>: Korean
        /// - <code>"id"</code>: Indonesian
        /// - <code>"th"</code>: Thai
        /// - <code>"pt"</code>: Portuguese
        /// - <code>"tr"</code>: Turkish
        /// - <code>"ar"</code>: Arabic
        /// - <code>"es"</code>: Spanish
        /// - <code>"hi"</code>: Hindi
        /// - <code>"fr"</code>: French
        /// - <code>"ms"</code>: Malay
        /// - <code>"fil"</code>: Filipino
        /// - <code>"de"</code>: German
        /// - <code>"it"</code>: Italian
        /// - <code>"ru"</code>: Russian
        /// - <code>"sv"</code>: Swedish
        /// - <code>"da"</code>: Danish
        /// - <code>"no"</code>: Norwegian
        /// 
        /// > **Note:** If the language you need is not listed, please contact our support team.
        /// </summary>
        [JsonProperty("Lang")]
        public string Lang{ get; set; }

        /// <summary>
        /// The time for speech recognition vad ranges (ms) from 240 to 2000, with a default of 1000. A smaller value enables faster sentence segmentation in speech recognition.Example value: 1000.
        /// </summary>
        [JsonProperty("VadSilenceTime")]
        public ulong? VadSilenceTime{ get; set; }

        /// <summary>
        /// Temporary hotword list: This parameter is used for improving recognition accuracy.
        /// 
        /// - Hotword limit: "hotword|weight". Each hotword contains no more than 30 characters (10 Chinese characters max). Weight ranges from 1 to 11 or 100, for example: "Tencent Cloud|5" or "ASR|11".
        /// - Restrictions for the temporary term list: multiple terms separated by commas, supports up to 128 terms, for example: "Tencent Cloud|10,speech recognition|5,ASR|11".
        /// 
        /// > Note:
        /// - When the hotword weight is set to 11, the current hotword will be upgraded to a super term. It is advisable to only set important and must-effective hotwords to 11. Setting too many hotwords with weight 11 will affect overall accuracy.
        /// - When a hotword weight is set to 100, the hotword enhancement feature forces an exact match replacement: any recognized word that is a homophone of the configured hotword will be replaced with the hotword in the transcription output. 
        /// - For example, if the hotword Lyft|100 is configured, the word lift, which is phonetically identical, will always be transcribed as Lyft. 
        /// - Use this feature with caution. Only assign a weight of 100 to hotwords that are business-critical and must always appear verbatim in the output. Overuse of weight 100 hotwords may degrade overall transcription accuracy.
        /// - Hot words cannot contain spaces, for example: ASR Tencent Cloud
        /// - Example value: voice assistant|10
        /// </summary>
        [JsonProperty("HotWordList")]
        public string HotWordList{ get; set; }

        /// <summary>
        /// Fuzzy language detection is an advanced function, which is billed at the Advanced tier rate by default. Only Advanced tier languages are supported, excluding zh-dialect and zh-yue. Note: A maximum of 4 languages can be specified.
        /// </summary>
        [JsonProperty("AlternativeLanguage")]
        public string[] AlternativeLanguage{ get; set; }

        /// <summary>
        /// vad far-field voice suppression capacity (does not impact asr recognition accuracy), range [0, 3], default is 0. Recommended setting is 2 for better far-field voice suppression.
        /// </summary>
        [JsonProperty("VadLevel")]
        public ulong? VadLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
            this.SetParamSimple(map, prefix + "VadSilenceTime", this.VadSilenceTime);
            this.SetParamSimple(map, prefix + "HotWordList", this.HotWordList);
            this.SetParamArraySimple(map, prefix + "AlternativeLanguage.", this.AlternativeLanguage);
            this.SetParamSimple(map, prefix + "VadLevel", this.VadLevel);
        }
    }
}

