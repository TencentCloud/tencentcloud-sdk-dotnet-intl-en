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

    public class DescribeEmergencyVulListRequest : AbstractModel
    {
        
        /// <summary>
        /// Quantity of returns. The maximum value is 100.
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
        /// <li>Status - String - required: Yes - vulnerability status filter: 0: not detected; 1: at risk; 2: no risk; 3: show progress while detecting</li>
        /// <li>Level - String - required: no - filter by vulnerability level: 1 - low; 2 - medium; 3 - high; 4 - prompt</li>
        /// <li>VulName - String - required: no - vulnerability name search</li>
        /// <li>Uuids- String - required: no - host uuid</li>
        /// <li>IsSupportDefense - int- required: no - whether to support defense: 0: no; 1: yes</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Sorting method: desc and asc
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field PublishDate  LastScanTime HostCount
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Whether hot spot vulnerabilities
        /// </summary>
        [JsonProperty("HotspotAttack")]
        public bool? HotspotAttack{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "HotspotAttack", this.HotspotAttack);
        }
    }
}

