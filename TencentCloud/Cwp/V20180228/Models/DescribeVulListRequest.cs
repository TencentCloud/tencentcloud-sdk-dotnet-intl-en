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

    public class DescribeVulListRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of returns, with the maximum value being 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset, which defaults to 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>Status - String - required: no - processing status: 0: pending; 1: allowlisted; 2: deleted; 3: ignored</li>
        /// <li>ModifyTime - String - required: no - last occurrence time</li>
        /// <li>Uuid- String - required: no - query by host UUID</li>
        /// <li>VulName- string -</li>
        /// <li>VulCategory- string - required: no - vulnerability category: 1: web CMS vulnerability; 2: application vulnerability; 4: Linux software vulnerability; 5: Windows system vulnerability</li>
        /// <li>IsSupportDefense - int - required: no - support for defense: 0: not supported; 1: supported</li>
        /// <li>Labels - string - required: no - tag for search</li>
        /// <li>IsSupportAutoFix - string - required: no - whether automatic fixing is supported: 0: not supported; 1: supported</li>
        /// <li>CvssScore - string - required: no - lower limit of CVSS score</li>
        /// <li>AttackLevel - string - required: no - lower limit of attack level</li>
        /// 
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Sorting field: Level, LastTime, and HostCount
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Sorting order: desc and asc. Default value: asc.
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

