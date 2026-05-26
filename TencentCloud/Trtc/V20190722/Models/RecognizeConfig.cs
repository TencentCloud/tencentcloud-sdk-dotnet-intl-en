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

    public class RecognizeConfig : AbstractModel
    {
        
        /// <summary>
        /// Convert speech to text supported languages, "zh" chinese is selected by default.
        /// 
        /// You can unlock different languages by purchasing the "AI intelligent recognition duration package" or claiming the trial version of the monthly subscription package. 
        /// 
        /// Supported languages for different speech to text package versions are as follows:.
        /// 
        /// Basic language engine:.
        /// -"zh": chinese (simplified).
        /// 
        /// **Standard language engine:**.
        /// -"8k_zh_large": engine (large model version) for telecommunication. the current model supports chinese and other language recognition, has a large number of parameters, and features language model performance enhancement. it greatly improves recognition accuracy for telephone audio in various scenarios and chinese dialects.
        /// -"16k_zh_large": large model engine for mandarin, chinese dialects, and english. the current model supports language recognition for chinese, english, and multiple chinese dialects. it has a large number of parameters and enhanced language model performance, targeting low-quality audio such as loud noise, strong echo, low voice volume, and voice from far away with greatly improved recognition accuracy.
        /// -"16k_zh_en": chinese-english large model engine. the current model simultaneously supports chinese and english recognition, has a large number of parameters, and features language model performance enhancement. it greatly improves recognition accuracy for low-quality audio such as loud noise, strong echo, low voice volume, and voice from far away.
        /// 
        /// **Advanced language engine:**.
        /// -"zh-dialect": chinese dialect.
        /// -"zh-yue": cantonese in china.
        /// -"Vi": "vietnamese.".
        /// -"Ja": "japanese.".
        /// -"Ko": "korean.".
        /// -"id": "indonesian".
        /// -"Th": thai.
        /// -"pt": portuguese.
        /// -"tr": "turkish.".
        /// -"Ar": "arabic".
        /// -"es": "spanish".
        /// -"Hi": "hindi".
        /// -"Fr": "french.".
        /// -"ms": malay.
        /// -"Fil": filipino.
        /// -"de": german.
        /// -`It`: italian.
        /// -"Ru": russian.
        /// -"sv": "swedish.".
        /// -"Da": "danish.".
        /// -"No": norwegian.
        /// 
        /// **Note**:.
        /// If the language you need is not available, contact our technical staff.
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// **Fuzzy recognition is an advanced edition capacity, charged as advanced edition by default, and only supports filling in basic version and advanced edition language.**.
        /// Note: does not support entering "zh-dialect".
        /// </summary>
        [JsonProperty("AlternativeLanguage")]
        public string[] AlternativeLanguage{ get; set; }

        /// <summary>
        /// Hot word list: this parameter is used for improving recognition accuracy. each hot word is limited to "term|weight", with no more than 30 characters (a maximum of 10 chinese characters) per term. weight ranges from 1 to 11 or 100, for example: "tencent cloud|5" or "ASR|11". hot word list limitation: multiple terms separated by commas, supports up to 300 hot words, for example: "tencent cloud|10, speech recognition|5, ASR|11".
        /// </summary>
        [JsonProperty("HotWordList")]
        public string HotWordList{ get; set; }

        /// <summary>
        /// Specifies the time when automatic speech recognition (asr) vad is active. value range: 240-2000. default: 1000. unit: ms. a smaller value enables faster speech recognition sentence segmentation.
        /// </summary>
        [JsonProperty("VadSilenceTime")]
        public ulong? VadSilenceTime{ get; set; }

        /// <summary>
        /// The vad far-field voice suppression capacity (does not impact asr recognition performance) ranges from 0 to 3, with a default value of 0. recommended setting is 2 for better far-field voice suppression.
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
            this.SetParamSimple(map, prefix + "HotWordList", this.HotWordList);
            this.SetParamSimple(map, prefix + "VadSilenceTime", this.VadSilenceTime);
            this.SetParamSimple(map, prefix + "VadLevel", this.VadLevel);
        }
    }
}

