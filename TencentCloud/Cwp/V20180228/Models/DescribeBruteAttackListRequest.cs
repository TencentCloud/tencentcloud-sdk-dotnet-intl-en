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

    public class DescribeBruteAttackListRequest : AbstractModel
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
        /// Filter criteria
        /// <li>IpOrAlias - String - required: no - filter by host IP or alias</li>
        /// <li>Uuid - String - Required: no - CWP unique UUID</li>
        /// <li>Quuid - String - required: no - CVM UUID</li>
        /// <li>Status - String - required: no - filter by status: failed - FAILED; succeeded - SUCCESS</li>
        /// <li>UserName - String - required: no - filter by UserName</li>
        /// <li>SrcIp - String - Required: No - Source ip filter criteria</li>
        /// <li>CreateBeginTime - String - required: no - filter by first attack time, start time</li>
        /// <li>CreateEndTime - String - Required: no - Filter by first attack time, end time</li>
        /// <li>ModifyBeginTime - String - required: no - filter by last attack time, start time</li>
        /// <li>ModifyEndTime - String - required: no - filter by last attack time, end time</li>
        /// <li>Banned - String - Required: No - Blocking status filtering, multiple values separated by ",": 0-unblocked (global ZK switch off), 82-unblocked (non-Pro Edition), 83-unblocked (added to allowlist), 1-Block Success (completed), 2-unblocked-abnormal program, 3-unblocked-internal network attack (blocking is not supported), 4-unblocked-Anping (blocking is not supported), 10-Block Success (active)</li>
        /// <li>DataFrom - Int - Matched rule: 0-login rule, 1-intelligence rule</li>
        /// <li>EventType - String - Required: No - Filter criteria for cracking status: 200-Cracking failure (incorrect password), 300-Successful cracking, 400-Cracking failure (account does not exist)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sorting method: sort by number of requests: asc - ascending order/desc - descending order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field: CreateTime - first attack time
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

