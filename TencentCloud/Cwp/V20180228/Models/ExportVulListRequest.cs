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

    public class ExportVulListRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter criteria
        /// <li>VulCategory - int - required: no - filter by vulnerability category: 1 - web-cms vulnerabilities; 2 - application vulnerabilities; 4 - Linux software vulnerabilities; 5 - Windows system vulnerabilities</li>
        /// <li>IfEmergency - String - required: no - whether an emergency vulnerability; if you need to query an emergency vulnerability, please pass yes to this parameter.</li>
        /// <li>Status - String - required: yes - filter by vulnerability status: 0 - pending; 1 - ignored; 3 - fixed; 5 - detecting. The console only handles four statuses: 0, 1, 3, and 5.</li>
        /// <li>Level - String - required: no - filter by vulnerability level: 1 - low; 2 - medium; 3 - high; 4 - prompt</li>
        /// <li>VulName - String - required: no - search by vulnerability name</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Whether to export details: 1 - yes; 0 - no
        /// </summary>
        [JsonProperty("IfDetail")]
        public ulong? IfDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "IfDetail", this.IfDetail);
        }
    }
}

