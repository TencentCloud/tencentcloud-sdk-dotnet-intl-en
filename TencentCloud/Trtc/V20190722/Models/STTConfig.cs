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

    public class STTConfig : AbstractModel
    {
        
        /// <summary>
        /// Convert speech to text supported languages, "zh" chinese is selected by default.
        /// 
        /// You can unlock different languages by purchasing the "AI intelligent recognition duration package" or claiming the trial version of the monthly subscription package. 
        /// 
        /// Supported languages for different speech to text package versions are as follows:.
        /// 
        /// - "zh": chinese (simplified).
        /// - "zh-TW": chinese (traditional).
        /// - "en": english.
        /// - "zh-yue": cantonese in china.
        /// - "vi": "vietnamese.".
        /// - "ja": "japanese.".
        /// - "ko": "korean.".
        /// - "id": "indonesian".
        /// - "th": thai.
        /// - "pt": portuguese.
        /// - "tr": "turkish.".
        /// - "ar": "arabic".
        /// - "es": "spanish".
        /// - "hi": "hindi".
        /// - "ft": "french.".
        /// - "ms": malay.
        /// - "fil": filipino.
        /// - "de": german.
        /// -`it`: italian.
        /// - "ru": russian.
        /// - "sv": "swedish.".
        /// - "da": "danish.".
        /// - "no": norwegian.
        /// - "pl": polski.
        /// -"af-ZA": afrikaans.
        /// - "nl-NL": dutch.
        /// - "nl-BE": flemish.
        /// - "uz": uzbek.
        /// - "hu": hungarian.
        /// - "he": hebrew.
        /// - "ur": urdu.
        /// 
        /// **Note**:.
        /// If the language you need is not available, contact our technical staff.
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// **Fuzzy recognition is an advanced edition capacity, charged by default as the advanced edition.**.
        /// </summary>
        [JsonProperty("AlternativeLanguage")]
        public string[] AlternativeLanguage{ get; set; }

        /// <summary>
        /// Custom parameter. contact for background usage.
        /// </summary>
        [JsonProperty("CustomParam")]
        public string CustomParam{ get; set; }

        /// <summary>
        /// Specifies the time when automatic speech recognition (asr) vad is active. value range: 240-2000. default: 1000. unit: ms. a smaller value enables faster speech recognition sentence segmentation.
        /// </summary>
        [JsonProperty("VadSilenceTime")]
        public ulong? VadSilenceTime{ get; set; }

        /// <summary>
        /// The vad far-field voice suppression capacity (without impacting asr recognition performance) ranges from 0 to 5, with a default value of 0, indicating disabled far-field voice suppression. the recommended setting is 2 for better far-field voice suppression. in a noisy office environment, it can be set to 3, and in more noisy environments, 4 and 5 are available for use. note that a higher VadLevel may suppress single words as noise.
        /// </summary>
        [JsonProperty("VadLevel")]
        public ulong? VadLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamArraySimple(map, prefix + "AlternativeLanguage.", this.AlternativeLanguage);
            this.SetParamSimple(map, prefix + "CustomParam", this.CustomParam);
            this.SetParamSimple(map, prefix + "VadSilenceTime", this.VadSilenceTime);
            this.SetParamSimple(map, prefix + "VadLevel", this.VadLevel);
        }
    }
}

