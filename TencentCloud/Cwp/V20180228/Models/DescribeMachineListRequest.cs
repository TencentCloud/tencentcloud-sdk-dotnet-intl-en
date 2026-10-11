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

    public class DescribeMachineListRequest : AbstractModel
    {
        
        /// <summary>
        /// CVM type.
        /// <li>CVM: Represent a virtual host</li>
        /// <li>BM: Represent a physical machine</li>
        /// <li>ECM: indicates Edge Computing Server</li>
        /// <li>LH: indicates Tencent Cloud Lighthouse</li>
        /// <li>Other: Indicates Hybrid cloud machines.</li>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Machine region. For example, ap-guangzhou and ap-shanghai.
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// Number of entries to be returned. Default value: 10. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Filter criteria.
        /// <li>Keywords - String - required: no - query by keywords</li>
        /// <li>Status - String - required: no - client online status (OFFLINE: offline | ONLINE: online | UNINSTALLED: not installed)</li>
        /// <li>Version - String - required: no - current protection version (PRO_VERSION: Professional edition | BASIC_VERSION: Basic edition)</li>
        /// Only one value is allowed for each filter criterion. Multiple values with the OR relationship are not supported for queries.
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MachineRegion", this.MachineRegion);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

