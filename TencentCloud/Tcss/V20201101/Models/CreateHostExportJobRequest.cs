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

    public class CreateHostExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter conditions.<li>Status-String-Required: No-Filter by agent Status. "ALL": "ALL" (or leave this field blank), "UNINSTALL": "Not installed", "OFFLINE": "OFFLINE", "ONLINE": "Under protection"</li><li>HostName-String-Required: No-HostName Filtering</li><li>Group-String-Required: No-Host Group search</li><li>HostIP-String-Required: No-Search by host ip</li><li>HostID-String-Required: No-Search by host id</li><li>DockerVersion-String-Required: No-docker version search</li><li>MachineType-String-Required: No-Host origin MachineType search. "ALL": "ALL" (or leave this field blank). Host source: One of ["CVM", "ECM", "LH", "BM"] is a Tencent Cloud server; one of ["Other"] is a non-Tencent Cloud server.</li><li>DockerStatus-String-Required: No-docker installation Status. "ALL": "ALL" (or leave this field blank), "INSTALL": "Installed", "UNINSTALL": "Not installed"</li><li>ProjectID-String-Required: No-Project id search</li><li>Tag:(Tag: key)-String-Required: No-Tag key-value search. Example Filters":[{"Name":"Tag: tke-kind","Values":["service"]}]</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: `0`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// The number of results to return. Default value: 10. Maximum value: 10,000.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting field
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Valid values: `asc`, `desc`.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Export field
        /// </summary>
        [JsonProperty("ExportField")]
        public string[] ExportField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamArraySimple(map, prefix + "ExportField.", this.ExportField);
        }
    }
}

