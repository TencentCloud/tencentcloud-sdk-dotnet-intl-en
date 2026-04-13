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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSharedCNAMERequest : AbstractModel
    {
        
        /// <summary>
        /// Shared CNAME associated site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Filter criteria. The maximum value of Filters.Values is 20. The detailed filter criteria are as follows:
        /// <li>shared-cname<br>   Filter by [<strong>shared CNAME</strong>].<br>   Type: String<br>   Required: No</li>
        /// <li>type<br>   Filter by [<strong>shared CNAME type</strong>].<br>   type: String<br>   Required: No</li>
        /// <li>Description<br>   Filter by [<strong>description</strong>].<br>   Type: String<br>   Required: No</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// List sort method. Valid values:
        /// <li>asc: ascending order;</li>
        /// <li>desc: Sort in descending order.</li>The default value is `asc`.
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// Match mode. Valid values:
        /// <li>all: Returns the shared CNAME that matches all query conditions.</li>
        /// <li>any: Returns the shared CNAME that matches any query condition.</li> Default value is all.
        /// </summary>
        [JsonProperty("Match")]
        public string Match{ get; set; }

        /// <summary>
        /// Sorting basis. Valid values:
        /// <li>create-time: Creation time;</li>
        /// <li>shared-cname: Shared CNAME.</li> Default sorting order is based on the shared-cname attribute.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Offset of paginated query. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number limit of paginated query. Default value: 20. Upper limit: 200.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Match", this.Match);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

