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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncDubbingRequest : AbstractModel
    {
        
        /// <summary>
        /// Text for the synthesis. This is required for text to speech. The text cannot exceed 2000 characters in length.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// Text language. This defaults to zh (Chinese) if left empty.
        /// Supported languages:
        /// zh: Chinese.
        /// en: English.
        /// ja: Japanese.
        /// de: German.
        /// fr: French.
        /// ko: Korean.
        /// ru: Russian.
        /// uk: Ukrainian.
        /// pt: Portuguese.
        /// it: Italian.
        /// es: Spanish.
        /// id: Indonesian.
        /// nl: Dutch.
        /// tr: Turkish.
        /// fil: Filipino.
        /// ms: Malay.
        /// el: Greek.
        /// fi: Finnish.
        /// hr: Croatian.
        /// sk: Slovak.
        /// pl: Polish.
        /// sv: Swedish.
        /// hi: Hindi.
        /// bg: Bulgarian.
        /// ro: Romanian.
        /// ar: Arabic.
        /// cs: Czech.
        /// da: Danish.
        /// ta: Tamil.
        /// hun: Hungarian.
        /// vi: Vietnamese.
        /// no: Norwegian.
        /// yue: Cantonese.
        /// th: Thai.
        /// he: Hebrew.
        /// ca: Catalan.
        /// nn: Nynorsk.
        /// af: Afrikaans.
        /// fa: Persian.
        /// sl: Slovenian.
        /// </summary>
        [JsonProperty("TextLang")]
        public string TextLang{ get; set; }

        /// <summary>
        /// Voice type ID. This is required for synthesis with a specific voice type. System voice types and voice type cloning are supported.
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// Base64-encoded audio for cloning.
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// Cloning audio language. The default language is Chinese.
        /// Supported languages are the same as those for TextLang.
        /// </summary>
        [JsonProperty("AudioLang")]
        public string AudioLang{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Output")]
        public SyncDubbingOutputOption Output{ get; set; }

        /// <summary>
        /// Extended parameters in the format of a JSON string.
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextLang", this.TextLang);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "AudioLang", this.AudioLang);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

