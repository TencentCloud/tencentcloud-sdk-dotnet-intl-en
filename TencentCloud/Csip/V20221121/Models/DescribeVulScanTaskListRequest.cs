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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulScanTaskListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Filtering Conditions, support the following Name: <li>JobId - exact match of task ID</li><li>TaskType - exact match of task type</li></p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Page size</p><p>Value ranges from 1 to 100</p><p>Unit: entry</p><p>Default value: 10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Pagination offset</p><p>Value ranges from 0 to 99999</p><p>Unit: piece</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Filter orientation</p><p>Enumeration value:</p><ul><li>DESC: Descending order</li><li>ASC: Ascending order</li></ul>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting field</p><p>Default value: ScanTime</p>
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

