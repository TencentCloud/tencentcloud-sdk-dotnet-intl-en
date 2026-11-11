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

    public class DescribeHostVulRiskEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Pagination offset.<br>Value range: [0, +∞).<br>Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of returned items per page.<br>Value range: [1, 100].<br>Default value: 10.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Filter.Name supported by Filter criteria: VulName - fuzzy matching, search by vulnerability Name. Category - exact matching, Filter by vulnerability Category: LINUX-LINUX software vulnerability, WINDOWS-WINDOWS system patch vulnerability, WEB_CMS-WEB-CMS vulnerability, APPLICATION-APPLICATION vulnerability, EMERGENCY-URGENT vulnerability. RiskStatus - exact matching, Filter by risk status: PENDING-PENDING, HANDLED-processed, FIXED-FIXED, SCANNING-rechecking, IGNORED-IGNORED, NOT_REQUIRED-no action is REQUIRED, DELETED-DELETED, FIXING-in remediation, NEED_REBOOT-FIXED PENDING restart, FIX_FAILED-FIX failure. Level - exact matching, Filter by vulnerability severity Level: UNKNOWN-unavailable, LOW-LOW risk, MEDIUM-MEDIUM risk, HIGH-HIGH risk, CRITICAL-CRITICAL. CVSSLevel - exact matching, compatible field, equivalent to Level. VPRLevel - exact matching, Filter by VPR repair priority: DEFERRABLE-DEFERRABLE repair, PLANNED-PLANNED repair, SOON-repair as SOON as possible, URGENT-URGENT repair. - exact matching, Filter by vulnerability ID. InstanceID - exact matching, Filter by CVM instance ID. InstanceID - exact matching, compatible field, equivalent to InstanceID. UUID - exact matching, Filter by host security UUID. LatestScanTimeStart - range matching, latest scan time start, format: YYYY-MM-DD HH:MM:ss. LatestScanTimeEnd - range matching, latest scan time end, format: YYYY-MM-DD HH:MM:ss</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Sorting order.<br>Enumeration values:<br>asc: ascending<br>desc: descending<br>Default value: desc.</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting field<br>Enumeration values:<br>LatestScanTime: sort by latest scan time<br>Level: sort by threat level<br>VPRLevel: sort by VPR rating<br>RiskStatus: sort by risk status<br>VulID: sort by vulnerability ID<br>InstanceID: sort by instance ID<br>Default value: LatestScanTime</p>
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

