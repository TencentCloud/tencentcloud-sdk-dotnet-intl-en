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

    public class DescribeAssetHostListRequest : AbstractModel
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
        /// Filter criteria. <li>Status-String-Required: No-agent Status filtering, "ALL": "ALL" (or omit this field), "UNINSTALL": "not installed", "OFFLINE": "OFFLINE", "ONLINE": "under protection"</li> <li>HostName-String-Required: No-HostName filtering</li> <li>Group-String-Required: No-host Group search</li> <li>HostIP-String-Required: No-search by host ip</li> <li>HostID-String-Required: No-search by host id</li> <li>DockerVersion-String-Required: No-docker version search</li> <li>MachineType-String-Required: No-host origin MachineType search, "ALL": "ALL" (or omit this field), host source: one of ["CVM", "ECM", "LH", "BM"] for Tencent Cloud server; one of ["Other"] for non-Tencent Cloud server</li> <li>DockerStatus-String-Required: No-docker installation Status, "ALL": "ALL" (or omit this field), "INSTALL": "installed", "UNINSTALL": "not installed"</li> <li>ProjectID-String-Required: No-project id search</li> <li>Tag:(Tag: key)-String-Required: No-Tag key-value search example filter":[{"Name":"Tag: tke-kind","Values":["service"]}]</li> <li>NonClusterNode: whether to query non-cluster nodes (true: yes, false: no)</li>
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

