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

    public class DescribeVulFixTaskListRequest : AbstractModel
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
        /// <p>Filter criteria<br>Supported Filter.Name:<br>TaskId - Exact match, Filter by task ID<br>JobId - Exact match, Filter by task JobId, which corresponds to the task ID in the background job system<br>FixStatus - Exact match, Filter by remediation status: 0-initialization 1-in remediation 2-repair successful 3-partially failed to fix 4-all failed to fix 5-stop fix<br>StartTime - Range match, remediation start time range. Input two values to indicate the start and end time<br>AppId - Exact match, Filter by creator AppId<br>VulCategory - Exact match, Filter by vulnerability type: LINUX-LINUX software vulnerability WINDOWS-WINDOWS system patch vulnerability WEB_CMS-WEB-CMS vulnerability APPLICATION-APPLICATION vulnerability EMERGENCY-urgent vulnerability<br>TaskName - Fuzzy matching, Filter by vulnerability Name/CVE ID/KB patch Name, matching the vulnerability or KB patch associated with the task</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Sorting field<br>Enumeration values:<br>StartTime: sort by repair start time<br>EndTime: sort by repair end time<br>CreateTime: sort by creation time</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting method<br>Enumeration values:<br>asc: in ascending order<br>desc: in descending order<br>Default value: desc</p>
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

