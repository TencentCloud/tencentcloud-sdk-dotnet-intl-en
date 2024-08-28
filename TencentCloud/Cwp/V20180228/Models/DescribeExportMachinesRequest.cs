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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeExportMachinesRequest : AbstractModel
    {
        
        /// <summary>
        /// CVM type
        /// <li>CVM: Represent a virtual machine</li>
        /// <li>BM: Represent a physical machine</li>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Machine region. Example: ap-guangzhou, ap-shanghai
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// Quantity of returns. It is 10 by default, and the maximum value is 100.
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
        /// <li>Keywords - String - required: no - keyword for query </li>
        /// <li>Status - String - required: no - client online status (OFFLINE: offline | ONLINE: online | UNINSTALLED: not installed)</li>
        /// <li>Version - String - required: no - current protection version (PRO_VERSION: Pro Edition | BASIC_VERSION: Basic Edition)</li>
        /// Only one value is allowed for each filter criterion. Multiple values with the OR relationship are not supported for queries.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// ID List of Businesses to which machines belong
        /// </summary>
        [JsonProperty("ProjectIds")]
        public ulong?[] ProjectIds{ get; set; }


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
        }
    }
}

