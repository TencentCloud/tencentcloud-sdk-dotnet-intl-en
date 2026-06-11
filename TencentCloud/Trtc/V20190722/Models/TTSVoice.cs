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

    public class TTSVoice : AbstractModel
    {
        
        /// <summary>
        /// <p>Voice ID.</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>Speech speed. 0.5 for half speed, 2.0 for 2x speed, 1.0 for normal speed. Value range: [0.5, 2.0]. Default: 1.0.</p>
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// <p>Audio volume. 0 is mute, 10 is maximum volume. It is recommended to keep the default value to 1.0. Value range: [0, 10]. Default: 1.0.</p>
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// <p>Pitch. Negative value makes the sound low and deep, positive value makes it sharper. 0 indicates the original pitch. Value range: [-12, 12]. Default 0.</p>
        /// </summary>
        [JsonProperty("Pitch")]
        public long? Pitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Pitch", this.Pitch);
        }
    }
}

