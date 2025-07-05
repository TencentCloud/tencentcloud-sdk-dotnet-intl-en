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

    public class CreateRiskDnsEventExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Filters.
        /// <li>`EventStatus` - String - Optional - Event status. Values: `EVENT_UNDEAL` (Pending); `EVENT_DEALED` (Handled); `EVENT_IGNORE` (Ignored); `EVENT_ADD_WHITE` (Added to the allowlist)</li>
        /// <li>`ContainerStatus` - String - Optional - Container running status. `CREATED`, `RUNNING`, `PAUSED`, `STOPPED`, `RESTARTING`: `REMOVING`, `DESTROYED (Terminated)</li>
        /// <li>`ContainerNetStatus` - String - Optional - Container network status. Values: `NORMAL`, `ISOLATED`, `ISOLATE_FAILED` (Isolation failed`; `RESTORE_FAILED` (Failed to restore from isolation), `RESTORING` (Restoring); `ISOLATING`</li>
        /// <li>`EventType` - String - Optional - Event type. Values: `DOMAIN` (Malicious domain); `IP` (Malicious IP)</li>
        /// <li>`TimeRange` - String - Optional - Time range, where the first value represents the start time and the second value represents the end time</li>
        /// <li>`RiskDns` - String - Optional - Malicious domain. </li>
        /// <li>`RiskIP`- String - Optional - Malicious IP. </li>
        /// <li>`ContainerName` - String - Optional - Container name. </li>
        /// <li>`ContainerID` - String - Optional - Container ID. </li>
        /// <li>`ImageName` - String - Optional - Image name. </li>
        /// <li>`ImageID` - String - Optional - Image ID. </li>
        /// <li>`HostName` - String - Optional - Server name. </li>
        /// <li>`HostIP` - String - Optional - Private IP. </li>
        /// <li>`PublicIP` - String - Optional - Public IP. </li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// The number of results displayed per page. The maximum value is 100,000.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sort order: `asc`, `desc`
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field: Number of events: EventCount
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

