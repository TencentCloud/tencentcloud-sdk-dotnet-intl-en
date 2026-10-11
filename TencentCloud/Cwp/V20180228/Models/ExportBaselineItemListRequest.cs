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

    public class ExportBaselineItemListRequest : AbstractModel
    {
        
        /// <summary>
        /// <li>PolicyId - int64 - required: no - policy ID</li>
        /// <li>RuleId - int64 - required: no - rule ID</li>
        /// <li>HostId - string - whether required: no - host ID</li>
        /// <li>HostName - string - required: no - host name</li>
        /// <li>HostIp - string - required: no - host IP</li>
        /// <li>ItemId - String - required: no - detection item ID</li>
        /// <li>ItemName - String - required: no - item name</li>
        /// <li>DetectStatus - int - required: no - detection status [0: not passed|3: passed|5: detecting]</li>
        /// <li>Level - int - Required: No - Risk level</li>
        /// <li>StartTime - string - required: no - start time</li>
        /// <li>EndTime - string - required: no - end time</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 0: Filtered Result Export; 1: Export All
        /// </summary>
        [JsonProperty("ExportAll")]
        public long? ExportAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "ExportAll", this.ExportAll);
        }
    }
}

