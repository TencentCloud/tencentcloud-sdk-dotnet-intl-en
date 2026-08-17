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

    public class RecognizeAudioRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// Identify the target language. If left empty, the default is auto for automatic language identification.
        /// Note: If the automatic language recognition performance is poor, you can specify the language to improve accuracy.
        /// 
        /// Currently supported languages:
        /// auto-identification
        /// Simplified Chinese
        /// en: English
        /// Japanese
        /// ko: Korean
        /// vi: Vietnamese
        /// ms: Malay
        /// id: Indonesian
        /// fil: Filipino
        /// th: Thai
        /// pt: Portuguese
        /// tr:
        /// ar: Arabic
        /// es: Spanish
        /// hi: Hindi
        /// French
        /// de: German
        /// Italian
        /// Cantonese
        /// ru: Russian
        /// af: Afrikaans
        /// sq: Albanian
        /// am: Amharic
        /// hy: Armenian
        /// az: Azerbaijani
        /// eu: Basque
        /// bn: Bengali
        /// bs: Bosnian
        /// bg: Bulgarian
        /// my: Burmese
        /// ca: Catalan
        /// hr: Croatian
        /// cs: Czech
        /// da: Danish
        /// nl: Dutch
        /// et: Estonian
        /// fi: Finnish
        /// gl: Galician
        /// ka: Georgian
        /// el: Greek
        /// gu: Gujarati
        /// iw: Hebrew
        /// hu: Hungarian
        /// is: Icelandic
        /// jv: Javanese
        /// kn: Kannada
        /// kk: Kazakh
        /// km: Khmer
        /// RPC
        /// lo: Lao
        /// lv: Latvian
        /// lt: Lithuanian
        /// mk: Macedonian
        /// ml: Malayalam
        /// mr: Marathi
        /// mn: Mongolian
        /// ne: Nepali
        /// Norwegian Bokmål
        /// fa: Persian
        /// pl: Polish
        /// ro: Romanian
        /// sr: Serbian
        /// si: Sinhalese
        /// sk: Slovak
        /// sl: Slovenian
        /// Southern Sotho
        /// su: Sundanese
        /// sw: Swahili
        /// sv: Swedish
        /// ta: Tamil
        /// te: Telugu
        /// `ts`: Tsonga.
        /// uk: Ukrainian
        /// ur: Urdu
        /// uz: Uzbek
        /// ve: Venda
        /// xh: isiXhosa
        /// zu: Zulu
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// Audio data format, default is pcm
        /// 
        /// Supported formats:
        /// pcm (mono 16-bit sampling pcm data with a 16000 sampling rate)
        /// ogg-opus (mono Opus-encoded Ogg data with sample rates of 16000, 24000, or 48000).
        /// </summary>
        [JsonProperty("AudioFormat")]
        public string AudioFormat{ get; set; }

        /// <summary>
        /// Audio sampling rate
        /// 
        /// Supported sampling rates:
        /// pcm 16000
        /// ogg-opus 16000 / 24000 / 48000
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// Extended parameter. This is left empty by default. Use this parameter for special requirements.
        /// </summary>
        [JsonProperty("UserExtPara")]
        public string UserExtPara{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "AudioFormat", this.AudioFormat);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "UserExtPara", this.UserExtPara);
        }
    }
}

