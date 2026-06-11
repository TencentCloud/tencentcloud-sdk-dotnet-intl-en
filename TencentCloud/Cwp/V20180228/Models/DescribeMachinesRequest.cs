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
        /// Type of the machine's zone
        /// CVM: Cloud Virtual Machine
        /// BM: BMECM: Edge Computing Machine
        /// LH: Lighthouse
        /// Other: Hybrid Cloud Zone
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Machine region. For example, ap-guangzhou, ap-shanghai. For non-Tencent Cloud hosts, use ap-others.
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// Number of returns. It is 10 by default, and the maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>Ips - String - Required: No - Query by ip</li>
        /// <li>Names - String - required: no - query by instance name</li>
        /// <li>InstanceIds - String - Required: No - Query by instance id</li>
        /// <li>Version - String required: no - current protection version ( PRO_VERSION: Pro Edition | BASIC_VERSION: Basic Edition | Flagship: Ultimate Edition | ProtectedMachines: Pro + Ultimate Editions)</li>
        /// <li>Risk - String - required: no - risky host (yes)</li>
        /// <li>Os - String - required: no - operating system (DescribeMachineOsList API value)</li>
        /// Each filtering criterion supports only one value; queries of multiple values with OR relationship are not supported.</li>
        /// <li>Quuid - String - Required: no - CVM instance UUID. Maximum value: 100.</li>
        /// <li>AddedOnTheFifteen - String required: no - whether to query only hosts added within the last 15 days (1: yes) </li>
        /// <li> TagId - String required: no - query the list of hosts associated with the specified tag </li>
        /// <li>AgentStatus - String - required: no - ALL total; ONLINE under protection; OFFLINE offline; UNINSTALLED not installed</li>
        /// <li>MachineStatus - String required: no - ALL all; RUNNING running; STOPPED is shut down; EXPIRED to be recycled</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// ID List of Businesses to which machines belong
        /// </summary>
        [JsonProperty("ProjectIds")]
        public ulong?[] ProjectIds{ get; set; }

        /// <summary>
        /// 
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

