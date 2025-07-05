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

    public class ExportAssetMachineListRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria
        /// <li>IP - String - Required: No - Host IP</li>
        /// <li>MachineName - String - Required: No - hostname</li>
        /// <li>InstanceID - string - Required: No - Instance ID</li>
        /// <li>OsType - String - required: no - Windows or Linux</li>
        /// <li>CpuLoad - Int - required: no - 
        /// 0: 0% or unknown; 1: 0% to 20%
        /// 2: 20%～50%  3: 50%～80%
        /// 4: 80%～100%</li>
        /// <li>DiskLoad - Int - required: no - 
        /// 0: 0% or unknown; 1: 0% to 20%
        /// 2: 20%～50%  3: 50%～80%
        /// 4: 80%～100%</li>
        /// <li>MemLoad - Int - required: no - 
        /// 0: 0% or unknown; 1: 0% to 20%
        /// 2: 20%～50%  3: 50%～80%
        /// 4: 80%～100%</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sorting method: asc for ascending order or desc for descending order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Optional sorting method [FirstTime|PartitionCount]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

