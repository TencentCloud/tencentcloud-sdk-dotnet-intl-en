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
        /// ID of the site related with the acceleration domain name.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Offset for paginated queries. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Limit on paginated queries. Default value: 20. Maximum value: 200.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter conditions. Up to 20 values for each filter. If it is not passed in, all domain names related with the specific zone-id are returned. 
        /// <li>`domain-name`: Acceleration domain name</li>
        /// <li>`origin-type`: Type of the origin</li>
        /// <li>`origin`: Primary origin address</li>
        /// <li>`backup-origin`: Secondary origin address</li>
        /// <li>`domain-cname`: CNAME</li>
        /// <li>`share-cname`: Shared CNAME</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// Sort the returned results according to this field. Values include:
        /// <li>`created_on`: Creation time of the acceleration domain name</li>
        /// <li>`domain-name`: (Default) Acceleration domain name.</li> 
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sort direction. If the field value is number, sort by the numeric value. If the field value is text, sort by the ascill code. Values include:
        /// <li>`asc`: Ascending order.</li>
        /// <li>`desc`: Descending order.</li> Default value: `asc`.
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Match", this.Match);
        }
    }
}

