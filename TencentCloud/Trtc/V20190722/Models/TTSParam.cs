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

    public class TTSParam : AbstractModel
    {
        
        /// <summary>
        /// <p>TTS model</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>TTS language must be in the TargetLang list of TranslationParam.</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>The user requesting TTS playback. They must be on the subscription allowlist and not on the blocklist.</p>
        /// </summary>
        [JsonProperty("TargetUser")]
        public TranscriptionUserInfoParams TargetUser{ get; set; }

        /// <summary>
        /// <p>The robot user that pushes TTS audio back into the room.</p>
        /// </summary>
        [JsonProperty("TTSRobotUser")]
        public TranscriptionUserInfoParams TTSRobotUser{ get; set; }

        /// <summary>
        /// <p>TTS configuration parameters.</p>
        /// </summary>
        [JsonProperty("Voice")]
        public TTSVoice Voice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamObj(map, prefix + "TargetUser.", this.TargetUser);
            this.SetParamObj(map, prefix + "TTSRobotUser.", this.TTSRobotUser);
            this.SetParamObj(map, prefix + "Voice.", this.Voice);
        }
    }
}

