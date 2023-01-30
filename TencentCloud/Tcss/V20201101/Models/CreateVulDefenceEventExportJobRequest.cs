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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVulDefenceEventExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter
        /// <li>Status- String - Required: No - Plugin status. Valid values: `EVENT_UNDEAL` (pending); `EVENT_DEALED` (processed); `EVENT_IGNORE` (ignored); `EVENT_DEFENDED` (defended).</li>
        /// <li>ContainerStatus- String - Required: No - Container status. Valid values: `CREATED` (created); `RUNNING` (running); `PAUSED` (suspended); 	`STOPPED` (stopped); `RESTARTING` (restarting); `REMOVING` (removing); `DESTROYED` (terminated).</li>
        /// <li>ContainerNetStatus- String - Required: No - Container network status. Valid values: `NORMAL` (not isolated); `ISOLATED` (isolated); `ISOLATE_FAILED` (isolation failed); `RESTORE_FAILED` (recovery failed); `RESTORING` (recovering); `ISOLATING` (isolating).</li>
        /// <li>EventType - String - Required: No - Intrusion status. Valid values: `EVENT_DEFENDED` (defended successfully); `EVENT_ATTACK` (attack attempt).</li>
        /// <li>TimeRange- String - Required: No - Time range. The first value indicates the start time, and the second the end time.</li>
        /// <li>VulName- string - Required: No - Vulnerability name</li>
        /// <li>CVEID- string - Required: No - CVE No.</li>
        /// <li>SourceIP- string - Required: No - Attacker IP</li>
        /// <li>ContainerName- string - Required: No - Container name</li>
        /// <li>ContainerID- string - Required: No - Container ID</li>
        /// <li>ImageName- string - Required: No - Image name</li>
        /// <li>ImageID- string - Required: No - Image ID</li>
        /// <li>HostName- string - Required: No - Server name</li>
        /// <li>HostIP- string - Required: No - Private IP</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// Number of results to be returned. Maximum value: `100000`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: `0`.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: `asc`, `desc`.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field: `EventCount` (number of events).
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

