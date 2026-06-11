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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHostLoginListRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of items to be returned. The maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset, which defaults to 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Filter criteria. <li>Quuid - String - Required: No - CVM uuid</li> <li>uuid - String - Required: No - Host security unique uuid</li> <li>MachineName - String - Required: No - Host alias</li> <li>Ip - String - Required: No - Host Ip address</li> <li>InstanceID - String - Required: No - Host instance ID</li> <li>SrcIp - String - Required: No - Source Ip filter</li> <li>UserName - String - Required: No - UserName filter</li> <li>Status - String - Required: No - Status filtering: 2: Pending; 5: Whitelisted; 14: Fixed; 15: Ignored</li> <li>LoginTimeBegin - String - Required: No - Filter by modification time range, start time</li> <li>LoginTimeEnd - String - Required: No - Filter by modification time range, end time</li> <li>RiskLevel - String - Required: No - Status filtering: 0: High risk; 1: Suspicious</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sorting method: sort by number of requests: asc - ascending order/desc - descending order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field: LoginTime - occurrence time
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

