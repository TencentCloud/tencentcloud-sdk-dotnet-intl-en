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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLoadBalancingRequest : AbstractModel
    {
        
        /// <summary>
        /// Offset for paginated queries. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Limit on paginated queries. Value range: 1-1000. Default value: 10.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filter criteria. Each filter criteria can have up to 20 entries.
        /// <li>`zone-id`:<br>   Filter by <strong>site ID</strong>, such as zone-1a8df68z<br>   Type: String<br>   Required: No<br>   Fuzzy query: Not supported
        /// <li>`load-balancing-id`<br>   Filter by <strong>load balancer ID</strong>, such as lb-d21bfaf7-8d72-11ec-841d-00ff977fb3c8<br>   Type: String<br>   Required: No<br>   Fuzzy query: Not supported
        /// <li>`host`:<br>   Filter by <strong>load balancing hostname</strong>, such as lb.tencent.com<br>   Type: String<br>   Required: No<br>   Fuzzy query: Supported (only one hostname allowed in a query)
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

