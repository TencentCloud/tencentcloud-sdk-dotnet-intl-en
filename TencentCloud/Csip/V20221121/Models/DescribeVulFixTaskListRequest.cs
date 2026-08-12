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
        /// <p>Paging offset<br>Value ranges from 0 to +∞<br>Default value: 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of results per page<br>Value ranges from 1 to 100<br>Default value: 10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Filtering Conditions<br>Supported Filter.Name:<br>TaskId - Exact match, filter by task ID<br>JobId - Exact match, filter by task JobId, corresponding to the task ID of the background job system<br>FixStatus - Exact match, filter by remediation status: 0-Initialization 1-In remediation 2-Repair successful 3-Partially fix failed 4-All fix failed 5-Stop fix<br>StartTime - Range match, remediation startup time range, input two values to indicate start and end time<br>AppId - Exact match, filter by creator AppId<br>VulCategory - Exact match, filter by vulnerability type: LINUX-Linux software vulnerability WINDOWS-Windows system patch vulnerability WEB_CMS-Web-CMS vulnerability APPLICATION-Application vulnerability EMERGENCY-Emergency vulnerability<br>TaskName - Fuzzy matching, filter by vulnerability name/CVE ID/KB patch name, matching task associated vulnerability or KB patch</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Sorting field<br>Enumeration value:<br>StartTime: Sort by repair start time<br>EndTime: Sort by repair end time<br>CreateTime: Sort by creation time</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting method<br>Enumeration value:<br>asc: Ascending<br>desc: Descending order<br>Default value: desc</p>
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

