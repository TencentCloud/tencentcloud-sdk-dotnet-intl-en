/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class SlowPostConfig : AbstractModel
    {
        
        /// <summary>
        /// Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Detect slow attacks by the transfer period of the first 8 KB of requests
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FirstPartConfig")]
        public FirstPartConfig FirstPartConfig{ get; set; }

        /// <summary>
        /// Detect slow attacks by the data rate of the main body (excluding the first 8 KB) of requests
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SlowRateConfig")]
        public SlowRateConfig SlowRateConfig{ get; set; }

        /// <summary>
        /// The action to taken when a slow attack is detected. Values:
        /// <li>`monitor`: Observe</li>
        /// <li>`drop`: Block the request</li>
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// ID of the rule
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamObj(map, prefix + "FirstPartConfig.", this.FirstPartConfig);
            this.SetParamObj(map, prefix + "SlowRateConfig.", this.SlowRateConfig);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

