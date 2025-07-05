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

    public class CreateEscapeWhiteListExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter
        /// <li>EventType- String - Required: No - Allowed event type. Valid values: `ESCAPE_CGROUPS` (cgroup escape); `ESCAPE_TAMPER_SENSITIVE_FILE` (file tamper escape); `ESCAPE_DOCKER_API` (Docker API access escape); `ESCAPE_VUL_OCCURRED` (vulnerability exploit); `MOUNT_SENSITIVE_PTAH` (sensitive path mount); `PRIVILEGE_CONTAINER_START` (privileged container); `PRIVILEGE` (program privilege escalation escape).</li>
        /// <li>ImageName- string - Required: No - Image name</li>
        /// <li>ImageID- string - Required: No - Image ID</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default value: `10000`. Maximum value: `10000`.
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
        /// Sorting field. Valid values: `HostCount` (number of servers); `ContainerCount` (number of containers); `UpdateTime` (update time).
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

