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

    public class DescribeVulFixedListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Paging offset<br>Value range: [0, +∞)<br>Default value: 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of results per page<br>Value range: [1, 100]<br>Default value: 10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Filter criteria<br>Supported Filter.Name:<br>Keyword - fuzzy matching, search by keyword (vulnerability name/CVE ID/host name/instance ID)<br>VulName - fuzzy matching, search by vulnerability name<br>Level - exact matching, filter by vulnerability level: LOW - low risk, MEDIUM - medium risk, HIGH - high risk, CRITICAL - critical<br>VprLevel - exact matching, filter by VPR rating: 1 - Low, 2 - Medium, 3 - High, 4 - Critical<br>VulCategory - exact matching, filter by vulnerability type: LINUX - Linux software vulnerability, WINDOWS - Windows system patch vulnerability, WEB_CMS - Web-CMS vulnerability, APPLICATION - application vulnerability, EMERGENCY - urgent vulnerability<br>MachineName - fuzzy matching, search by host name<br>InstanceId - fuzzy matching, search by instance ID<br>FixTime - range matching, repair time range. Input two values to indicate the start and end time</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Sorting field<br>Enumeration values:<br>FixTime: sort by fix time<br>VulName: sort by vulnerability name</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting method<br>Enumeration values:<br>asc: Ascending<br>desc: Descending<br>Default value: desc</p>
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

