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

    public class DescribeAssetContainerListRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of results to be returned. Default value: `10`. Maximum value: `100`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: `0`.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Filter condition
        /// <li>`ContainerName`: String - Required: No - Container name</li>
        /// <li>`Status` - String - Required: No - Container status. Values: `0` (created); `1` (running); `2` (paused); `3` (restarting); `4` (removing); `5` (exited); `6` (dead).</li>
        /// <li>`Runas`: String - Required: No - Operator</li>
        /// <li>`ImageName`: String - Required: No - Image name</li>
        /// <li>`HostIP`: String - Required: No - Server IP</li>
        /// <li>`OrderBy` - String - Required: No - Sorting field, which supports dynamic sorting by `cpu_usage` or `mem_usage` such as ["cpu_usage","+"]. '+' indicates ascending, and '-' indicates descending.</li>
        /// <li>`NetStatus`: String - Required: No - Container network status. Values: `normal`, `isolated`, `isolating`, `isolate_failed`, `restoring`, `restore_failed`.</li>
        /// <li>`PodID`: String - Required: No- Pod ID </li>
        /// <li>`NodeUniqueID`: String - Required: No - Super Node</li>
        /// <li>`PodUid`: String - Required: No - Pod</li>
        /// <li>`PodIP`: String - Required: No - Pod IP</li>
        /// <li>`NodeType`: String - Required: No - Values: `NORMAL` (general nodes), `SUPER` (super nodes)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// Sorting field
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: `asc`, `desc`.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

