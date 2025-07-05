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

    public class DescribeTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// CVM type
        /// <li>CVM: indicates Cloud Virtual Machine</li>
        /// <li>BM: indicates Blackstone Physical Machine</li>
        /// <li>ECM: indicates Edge Computing Server</li>
        /// <li>LH: indicates Tencent Cloud Lighthouse</li>
        /// <li>Other: indicates hybrid CVMs</li>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Region where the machine is located, such as ap-guangzhou.
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>Keywords - String - required: no - query by keywords (machine name/machine IP)</li>
        /// <li>Status - String - required: no - client online status (OFFLINE: offline | ONLINE: online | UNINSTALLED: uninstalled | SHUTDOWN: shut down)</li>
        /// <li>Version - String - required: no - current protection version (PRO_VERSION: Professional edition | BASIC_VERSION: Basic edition)</li>
        /// <li>Risk - String - required: no - risky host (yes)</li>
        /// <li>Os - String - required: no - operating system (DescribeMachineOsList API value)</li>
        /// Each filtering criterion supports only one value; queries of multiple values with OR relationship are not supported.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MachineRegion", this.MachineRegion);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

