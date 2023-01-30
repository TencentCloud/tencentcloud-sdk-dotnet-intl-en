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

    public class DescribeSystemVulListRequest : AbstractModel
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
        /// Filter
        /// <li>OnlyAffectedContainer- string - Required: No - Show only vulnerabilities that affect containers. Valid values: `true`, `false`.</li>
        /// <li>OnlyAffectedNewestImage-string - Required: No - Show only vulnerabilities that affect the latest image tags. Valid values: `true`, `false`.</li>
        /// <li>Level- String - Required: No - Severity. Valid values: `CRITICAL` (critical); `HIGH` (high); `MIDDLE` (medium); `LOW` (low).</li>
        /// <li>Tags- string - Required: No - Vulnerability tag. Valid values: `POC`, `EXP`.</li>
        /// <li>CanBeFixed- string - Required: No - Whether the vulnerability can be fixed. Valid values: `true`, `false`.</li>
        /// <li>CVEID- string - Required: No - CVE No.</li>
        /// <li>ImageID- string - Required: No - Image ID</li>
        /// <li>ImageName- String - Required: No - Image name</li>
        /// <li>ContainerID- string - Required: No - Container ID</li>
        /// <li>ContainerName- string - Required: No - Container name</li>
        /// <li>ComponentName- string - Required: No - Component name</li>
        /// <li>ComponentVersion- string - Required: No - Component version</li>
        /// <li>Name- string - Required: No - Vulnerability name</li>
        /// <li>FocusOnType - string - Required: No - Urgency. Valid values: `ALL` (all); `SERIOUS_LEVEL (critical and high risks); `IS_SUGGEST` (high-priority); `POC_EXP` (POC/EXP); `NETWORK_EXP` (remote EXP).</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// Sorting order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field
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

