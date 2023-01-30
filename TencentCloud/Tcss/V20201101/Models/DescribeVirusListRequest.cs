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

    public class DescribeVirusListRequest : AbstractModel
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
        /// <li>FileName - String - Required: No - Filename</li>
        /// <li>FilePath - String - Required: No - File path</li>
        /// <li>VirusName - String - Required: No - Virus name</li>
        /// <li>ContainerName- String - Required: Yes - Container name</li>
        /// <li>ContainerId- string - Required: No - Container ID</li>
        /// <li>ImageName- string - Required: No - Image name</li>
        /// <li>ImageId- string - Required: No - Image ID</li>
        /// <li>IsRealTime- int - Required: No - Whether it is real-time monitoring data</li>
        /// <li>TaskId- string - Required: No - Task ID</li>
        /// <li>ContainerNetStatus - String - Required: No - Container network status. Valid values: `NORMAL`, `ISOLATED`, `ISOLATING`, `RESTORING`, `RESTORE_FAILED`.</li>
        /// <li>TimeRange - string - Required: No - Time range ["2022-03-31 16:55:00", "2022-03-31 17:00:00"]</li>
        /// <li>ContainerStatus - string - Required: No - Container status. Valid values: `RUNNING`, `PAUSED`, `STOPPED`, `CREATED`, `DESTROYED`, `RESTARTING`, `REMOVING`.</li>
        /// <li>AutoIsolateMode - string - Required: No - Isolation method. Valid values: `MANUAL`, `AUTO`.</li>
        /// <li>MD5 - string - Required: No - MD5</li>
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

