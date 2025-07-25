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

    public class DescribeAssetMachineListRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria
        /// <li>MachineName  Host name</li>
        /// <li>InstanceID  Instance ID  </li>
        /// <li>IP   Private or public IP address</li>
        /// <li>OsType - String - required: no - Windows or Linux</li>
        /// <li>CpuLoad - Int - required: no - 
        /// 	0: unknown; 1: low load;
        /// 	2: medium load; 3: high load</li>
        /// <li>DiskLoad - Int - required: no - 
        /// 	0: 0% or unknown; 1: 0%-20%;
        /// 	2: 20%～50%  3: 50%～80%
        /// 	4: 80%～100%</li>
        /// <li>MemLoad - Int - required: no - 
        /// 	0: 0% or unknown; 1: 0%-20%;
        /// 	2: 20%～50%  3: 50%～80%
        /// 	4: 80%～100%</li>
        /// <li>Quuid: Host QUUID</li>
        /// <li>Os - String required: no - operating system (value of DescribeMachineOsList)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default value: 10. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

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
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

