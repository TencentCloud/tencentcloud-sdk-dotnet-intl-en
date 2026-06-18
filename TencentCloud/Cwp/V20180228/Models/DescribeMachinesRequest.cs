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

    public class DescribeMachinesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Machine zone type<br>CVM: Cloud Virtual Machine<br>BM: Blackstone<br>ECM: Edge Computing Machine<br>LH: Lighthouse<br>Other: Hybrid cloud zone</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// <p>Machine region, for example, ap-guangzhou or ap-shanghai. For non-Tencent Cloud hosts, use ap-others.</p>
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// <p>Number of returned results. The default number is 10, and the maximum value is 100.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Offset. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Filter criteria.</p><li>Ips - String - Required: No - Query by IP</li><li>Names - String - Required: No - Query by instance name</li><li>InstanceIds - String - Required: No - Query by instance id</li><li>Version - String - Required: No - Current protection edition (PRO_VERSION: Pro Edition | BASIC_VERSION: Basic Version | Flagship: Ultimate Edition | ProtectedMachines: Pro Edition + Ultimate Edition)</li><li>Risk - String - Required: No - Risk host (yes)</li><li>Os - String - Required: No - Operating system (DescribeMachineOsList API value). Each filter criterion only supports one value and does not support multiple values or relationship query.</li><li>Quuid - String - Required: No - Cloud server UUID. Maximum 100 entries.</li><li>AddedOnTheFifteen - String - Required: No - Query only hosts added within the last 15 days (1: yes)</li><li>TagId - String - Required: No - Query host list associated with the specified tag</li><li>AgentStatus - String - Required: No - ALL: All; ONLINE: Under protection; OFFLINE: Offline; UNINSTALLED: Not installed</li><li>MachineStatus - String - Required: No - ALL: All; RUNNING: Running; STOPPED: Shut down; EXPIRED: Pending recycling</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>List of business IDs to which the machines belong</p>
        /// </summary>
        [JsonProperty("ProjectIds")]
        public ulong?[] ProjectIds{ get; set; }

        /// <summary>
        /// <p>APPID of the machine</p>
        /// </summary>
        [JsonProperty("MachineAppId")]
        public ulong? MachineAppId{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamSimple(map, prefix + "MachineAppId", this.MachineAppId);
        }
    }
}

