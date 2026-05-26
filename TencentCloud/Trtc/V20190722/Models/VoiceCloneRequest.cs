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

    public class VoiceCloneRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the SdkAppId of TRTC.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Sound clone name. only digits, letters, and underscores are allowed with a maximum of 36 characters.
        /// </summary>
        [JsonProperty("VoiceName")]
        public string VoiceName{ get; set; }

        /// <summary>
        /// The reference audio for voice cloning must be a base64 string of a 16k mono wav file with length between 10–180 seconds.
        /// </summary>
        [JsonProperty("PromptAudio")]
        public string PromptAudio{ get; set; }

        /// <summary>
        /// API key for TTS.
        /// </summary>
        [JsonProperty("APIKey")]
        [System.Obsolete]
        public string APIKey{ get; set; }

        /// <summary>
        /// Reference text for voice cloning. specifies the text corresponding to the reference audio.
        /// </summary>
        [JsonProperty("PromptText")]
        public string PromptText{ get; set; }

        /// <summary>
        /// TTS model: flow_01_turbo, flow_01_ex.
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// Language parameter, empty by default. see: (ISO 639-1).
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "VoiceName", this.VoiceName);
            this.SetParamSimple(map, prefix + "PromptAudio", this.PromptAudio);
            this.SetParamSimple(map, prefix + "APIKey", this.APIKey);
            this.SetParamSimple(map, prefix + "PromptText", this.PromptText);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Language", this.Language);
        }
    }
}

