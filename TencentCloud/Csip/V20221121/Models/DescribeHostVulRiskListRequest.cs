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

    public class DescribeHostVulRiskListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Filter condition array. Multi-condition with each other is AND relationship<br>Supported Filter.Name:<br>CVSSLevel: CVSS level filter<br>Keyword: Keyword fuzzy search (multiple words use | to separate, fuzzy matching for vulnerability name/CVEID)<br>Category: Vulnerability category (LINUX/WEB_CMS/APPLICATION/EMERGENCY)<br>VPRLevel: VPR rating<br>RiskStatus: Remediation status<br>Label: VPR risk tag<br>InstanceID: Instance ID<br>CheckMethod: Detection method</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Number of results per page<br>Value ranges from 1 to 100<br>Default value: 10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Paging offset<br>Value ranges from 0 to +∞<br>Default value: 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Sorting order<br>Enumeration value:<br>ASC: Ascending<br>DESC: Descending order<br>Default value: DESC</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting field<br>Enumeration value:<br>LatestScanTime: latest scan time<br>Default value: LatestScanTime</p>
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

