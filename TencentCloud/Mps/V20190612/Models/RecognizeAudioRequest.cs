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
        /// Target language for recognition. If this is not specified, the language is automatically identified (auto).Note: If the automatic identification provides unsatisfactory results, you can specify the language to improve the accuracy.Supported languages:auto: automatic identification.zh: Simplified Chinese.en: English.ja: Japanese.ko: Korean.vi: Vietnamese.ms: Malay.id: Indonesian.fil: Filipino.th: Thai.pt: Portuguese.tr: Turkish.ar: Arabic.es: Spanish.hi: Hindi.fr: French.de: German.it: Italian.yue: Cantonese.ru: Russian.af: Afrikaans.sq: Albanian.am: Amharic.hy: Armenian.az: Azerbaijani.eu: Basque.bn: Bengali.bs: Bosnian.bg: Bulgarian.my: Burmese.ca: Catalan.hr: Croatian.cs: Czech.da: Danish.nl: Dutch.et: Estonian.fi: Finnish.gl: Galician.ka: Georgian.el: Greek.gu: Gujarati.iw: Hebrew.hu: Hungarian.is: Icelandic.jv: Javanese.kn: Kannada.kk: Kazakh.km: Khmer.rw: Kinyarwanda.lo: Lao.lv: Latvian.lt: Lithuanian.mk: Macedonian.ml: Malayalam.mr: Marathi.mn: Mongolian.ne: Nepali.no: Norwegian Bokmal.fa: Persian.pl: Polish.ro: Romanian.sr: Serbian.si: Sinhala.sk: Slovak.sl: Slovenian.st: Southern Sotho.su: Sundanese.sw: Swahili.sv: Swedish.ta: Tamil.te: Telugu.ts: Tsonga.uk: Ukrainian.ur: Urdu.uz: Uzbek.ve: Vendaxh: Xhosa.zu: Zulu.
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// Audio data format. Default value: pcm.Supported formats:pcm (mono 16-bit PCM data with a sample rate of 16000).ogg-opus (mono Opus-encoded Ogg data with sample rates of 16000, 24000, or 48000).
        /// </summary>
        [JsonProperty("AudioFormat")]
        public string AudioFormat{ get; set; }

        /// <summary>
        /// Audio sample rate.Supported sample rates:pcm 16000
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

