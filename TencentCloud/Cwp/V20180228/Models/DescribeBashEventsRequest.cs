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

    public class DescribeBashEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of items to be returned. It is 10 by default, and the maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>HostName - String - required: no - host name</li>
        /// <li>Hostip - String - required: no - host's private IP address</li>
        /// <li>RuleCategory - Int - required: no - policy type (all types or a single type): 0: system; 1: user</li>
        /// <li>RuleName - String - required: no - policy name</li>
        /// <li>RuleLevel - Int - required: no - threat Level (multiple levels supported)</li>
        /// <li>Status - Int - required: no - processing status (multiple statuses supported): 0: pending; 1: processed; 2: added to allowlist; 3: ignored; 4: deleted; 5: blocked</li>
        /// <li>DetectBy - Int - required: no - data source (multiple sources supported): 0: bash logs; 1: real-time monitoring</li>
        /// <li>StartTime - String - required: no - start time</li>
        /// <li>EndTime - String - required: no - end time</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset, which defaults to 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting method: sort by number of requests. asc: ascending order; desc: descending order.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field. CreateTime: occurrence time; ModifyTime: processing time.
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

