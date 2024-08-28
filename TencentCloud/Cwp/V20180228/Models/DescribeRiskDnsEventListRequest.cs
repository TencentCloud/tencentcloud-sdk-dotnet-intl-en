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

    public class DescribeRiskDnsEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// <li>IpOrName - String - required: no - filter by host IP or alias</li>
        /// <li>HostId - String - required: no - host ID</li>
        /// <li>AgentId - String - required: no - client ID</li>
        /// <li>PolicyType - String - required: no - policy type: 0 - system policy; 1 - user-defined policy</li>
        /// <li>Domain - String - required: no - domain name (First convert the domain name into the urlencode format, and then encode it using base64.)</li>
        /// <li>HandleStatus - String - required: no - filter by status: 0 - pending; 2 - trusted; 3 - untrusted</li>
        /// <li>BeginTime - String - required: no - start time of last access</li>
        /// <li>EndTime - String - required: no - end time of last access</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of items to be returned. It is 10 by default, and the maximum value is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Offset, which defaults to 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Sorting method: sort by number of requests [asc: ascending order|desc: descending order]
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field: [AccessCount: number of requests|LastTime: last request time]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

