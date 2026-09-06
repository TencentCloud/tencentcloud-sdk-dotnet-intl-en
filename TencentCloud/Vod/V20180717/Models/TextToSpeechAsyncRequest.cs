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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextToSpeechAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Text to convert to speech.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Voice ID.</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>VOD application ID. For customers who activate on-demand services on or after December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications, whether in the default application or a newly created application.</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// <p>Language enhancement, such as "zh" "en" "auto", default "auto"</p>
        /// </summary>
        [JsonProperty("LanguageBoost")]
        public string LanguageBoost{ get; set; }

        /// <summary>
        /// <p>Extended parameters for text-to-speech (async). Fields supported by ExtParam:</p><ul><li>model (string): Synthesis model. Options: minimax-speech-2.8-hd, minimax-speech-2.8-turbo, minimax-speech-2.6-hd, minimax-speech-2.6-turbo, minimax-speech-02-hd, minimax-speech-02-turbo. Default: minimax-speech-2.8-hd.</li><li>text_lang (string): Text language, for example zh / en. Synonymous with the input parameter LanguageBoost. If both are passed, ExtParam takes precedence.</li><li>audio_setting (object): Audio output and voice type fine-tuning parameters. Note: For the async API, speaking rate, volume, pitch, and emotion are all under audio_setting, different from the voice_setting of the synchronous API. Optional fields:<ul><li>speed (float): Speaking rate, [0.5, 2.0]. Default: 1.0.</li><li>vol (float): Volume, (0, 10]. Default: 1.0.</li><li>pitch (int): Pitch, [-12, 12]. Default: 0.</li><li>emotion (string): Emotion. Options: happy, sad, angry, fearful, disgusted, surprised, calm, fluent, whisper.</li><li>sample_rate (int): Sampling rate. Options: 8000, 16000, 22050, 24000, 32000, 44100. Default: 16000.</li><li>format (string): Audio format. Options: mp3, wav. Default: wav.</li><li>duration (float): Target duration in seconds.</li><li>cut_silence (bool): Whether to trim silent segments.</li></ul></li></ul>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }

        /// <summary>
        /// <p>Output parameters.</p><p>Specifies the output format, etc. The default output audio url.</p>
        /// </summary>
        [JsonProperty("Output")]
        public TextToSpeechAsyncOutputOption Output{ get; set; }

        /// <summary>
        /// <p>Identifies the source context. This is used to pass user request information. The value of this field will be returned in callbacks and task flow status change callbacks. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Identification Code for Task Deduplication. If a request with the same identification code has been sent within the past 3 days, an error will be returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, it indicates no deduplication.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "LanguageBoost", this.LanguageBoost);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

