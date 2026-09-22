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

    public class AudioVolumeParam : AbstractModel
    {
        
        /// <summary>
        /// Whether to mute. Value range: 0 or 1.
        /// <li>0 means unmuted.</li>
        /// <li>1 means mute.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Mute")]
        public long? Mute{ get; set; }

        /// <summary>
        /// Audio gain. Value range: 0-10.
        /// <li>A value greater than 1 means volume increase.</li>
        /// <li>Less than 1 means low volume.</li>
        /// <li>0 and 1: means do not change.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Gain")]
        public float? Gain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mute", this.Mute);
            this.SetParamSimple(map, prefix + "Gain", this.Gain);
        }
    }
}

