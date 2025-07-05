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

    public class ExportRiskProcessEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria
        /// <li>HostId - String - Required: No - Host ID</li>
        /// <li>IpOrName - String - whether required: no - host IP or host name</li>
        /// <li>VirusName - String - whether required: no - virus name</li>
        /// <li>ProcessId - String - whether required: no - process ID</li>
        /// <li>ProcessPath - String - whether required: no - process path</li>
        /// <li>BeginTime - String - whether required: no - process startup time - begin</li>
        /// <li>BeginTime - String - whether required: no - process startup time - end</li>
        /// <li>Status - String - whether required: no - filter by status: 0 - pending; 1 - under detection; 2 - detected; 3 - exited; 4 - trusted</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sorting method: [ASC: ascending order|DESC: descending order]
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// [StartTime: Process start time | DetectTime: Last detection time]
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

