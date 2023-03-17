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

    public class DescribeAccelerationDomainsRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID of the accelerated domain name. If it’s not specified, all accelerated domain names under the site are returned.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Filter criteria. Each filter criteria can have up to 20 entries. Values:
        /// <li>`domain-name`:<br>   <strong>Accelerated domain name</strong><br>   Type: String<br>Required: No
        /// <li>`origin-type`:<br>   <strong>Type of the origin</strong><br>   Type: String<br>   Required: No
        /// <li>`origin`:<br>   <strong>Primary origin</strong><br>   Type: String<br>   Required: No
        /// <li>`backup-origin`<br>   <strong>Secondary origin</strong><br>   Type: String<br>   Required: No
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// The sorting order. Values:
        /// <li>`asc`: Ascending order.</li>
        /// <li>`desc`: Descending order.</li>Default value: `asc`.
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// The match mode. Values:
        /// <li>`all`: Return all matches.</li>
        /// <li>`any`: Return any match.</li>Default value: `all`.
        /// </summary>
        [JsonProperty("Match")]
        public string Match{ get; set; }

        /// <summary>
        /// Limit on paginated queries. Default value: 20. Maximum value: 200.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Offset for paginated queries. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The sorting criteria. Values:
        /// <li>`created_on`: Creation time of the accelerated domain name.</li>
        /// <li>`domain-name`: Acceleration domain name.</li>
        /// </li>Default value: `domain-name`.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Match", this.Match);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}
