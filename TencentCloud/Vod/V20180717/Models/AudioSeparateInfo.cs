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

    public class AudioSeparateInfo : AbstractModel
    {
        
        /// <summary>
        /// Audio separation control switch. Available values:
        /// <li>ON: enable audio separation;</li>
        /// <li>OFF: Disable audio separation.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Scenario type. Valid values:
        /// <li>normal: Voice background sound scenario</li>
        /// <li>music: Singing accompaniment scenario</li>
        /// Default value: normal.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Output audio track. Available values:
        /// <li>vocal: output voice</li>
        /// <li>Background: Output background audio when the scenario is normal, and output accompaniment when the scenario is music.</li>
        /// Default value: vocal.
        /// </summary>
        [JsonProperty("Track")]
        public string Track{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Track", this.Track);
        }
    }
}

