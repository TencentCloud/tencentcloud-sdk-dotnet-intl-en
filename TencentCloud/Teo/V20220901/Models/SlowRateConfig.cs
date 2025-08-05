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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowRateConfig : AbstractModel
    {
        
        /// <summary>
        /// Switch. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The statistics interval in seconds. after the first packet transfer, the data transmission axis is split by this parameter for separate computing of slow attacks on each shard.
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// Specifies the rate threshold applied during statistics in bps. if the transmission rate in this shard does not reach the parameter value, it is identified as a slow attack and the slow attack handling method is applied.
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

