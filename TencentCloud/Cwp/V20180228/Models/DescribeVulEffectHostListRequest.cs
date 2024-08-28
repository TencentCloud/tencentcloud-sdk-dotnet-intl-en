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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulEffectHostListRequest : AbstractModel
    {
        
        /// <summary>
        /// Pagination limit, with the maximum value being 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Pagination offset
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Vulnerability ID
        /// </summary>
        [JsonProperty("VulId")]
        public ulong? VulId{ get; set; }

        /// <summary>
        /// Filter criteria:
        /// <li>AliasName - String - host name for filtering</li>
        /// <li>TagIds - String - array of host tag IDs separated by commas</li>
        /// <li>Status - String - status: 0: pending; 1: ignored; 3: fixed; 5: detecting; 6: fixing; 8: fixing failed</li>
        /// <li>Uuid - String array - UUID array</li>
        /// <li>Version - String array - paid edition array: "Flagship": Ultimate Edition; "PRO_VERSION": Pro Edition; "BASIC_VERSION": Basic Edition</li>
        /// <li>InstanceState - String array - instance status array: "PENDING": creating; "LAUNCH_FAILED": creation failed; "RUNNING": running; "STOPPED": shut down; "STARTING": starting; "STOPPING": shutting down; "REBOOTING": restarting; "SHUTDOWN": to be terminated; "TERMINATING": terminating; "UNKNOWN": unknown (for non-Tencent Cloud machines and offline client) </li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "VulId", this.VulId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

