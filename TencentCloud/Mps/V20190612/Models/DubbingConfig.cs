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

    public class DubbingConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Dubbing type. Available values: FullAutoEmotionClone: fully automated high-emotion clone dubbing; RoleBasedSmartDubbing: intelligent dubbing by role; SingleVoice: specify a single voice type;</p>
        /// </summary>
        [JsonProperty("DubbingMode")]
        public string DubbingMode{ get; set; }

        /// <summary>
        /// <p>Background sound volume, range: 0-100</p><p>Default value: 80</p>
        /// </summary>
        [JsonProperty("BackgroundVolume")]
        public long? BackgroundVolume{ get; set; }

        /// <summary>
        /// <p>Secondary fine-tuning switch. Available values: <br>ON: enable secondary fine-tuning; <br>OFF: disable secondary fine-tuning;</p><p>Default value: OFF</p><p>It can be set to ON only for RoleBasedSmartDubbing.</p>
        /// </summary>
        [JsonProperty("SecondaryTuning")]
        public string SecondaryTuning{ get; set; }

        /// <summary>
        /// <p>Specify voice tone</p><p>Valid only for SingleVoice and required for Create</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>Dubbing version. Available values: v1, v2</p><p>Default value: v2</p><p>Only takes effect in FullAutoEmotionClone (fully automated high-emotion clone dubbing) mode</p>
        /// </summary>
        [JsonProperty("DubbingVersion")]
        public string DubbingVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DubbingMode", this.DubbingMode);
            this.SetParamSimple(map, prefix + "BackgroundVolume", this.BackgroundVolume);
            this.SetParamSimple(map, prefix + "SecondaryTuning", this.SecondaryTuning);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "DubbingVersion", this.DubbingVersion);
        }
    }
}

