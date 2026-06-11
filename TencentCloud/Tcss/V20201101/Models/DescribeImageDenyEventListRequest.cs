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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageDenyEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria
        /// <li>EventType - String - Required: No - Event type. EVENT_RISK: Risk event type. EVENT_PRIVILEGE: Privilege.</li>
        /// <li>DealBehavior - String - required: no - execution action, BEHAVIOR_ALERT: alert, BEHAVIOR_HOLDUP_SUCCESSED: block.</li>
        /// <li>RuleName - string - required: no - rule name.</li>
        /// <li>NodeName- string - required: no - node name.</li>
        /// <li>NodeIP - string - required: no - private and public IP.</li>
        /// <li>PublicIP - string - required: no - public IP address.</li>
        /// <li>ImageName- string - required: no - image name.</li>
        /// <li>ImageID - string - required: no - image ID.</li>
        /// <li>TimeRange - String - required: no - time range, the first value represents the start time, second value represents end time</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// Number of entries to be returned. Default value: 10. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sort Mode: DESC, ACS
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sort field. EventCount: Alarm quantity; LatestFoundTime: Most recent generation time
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

