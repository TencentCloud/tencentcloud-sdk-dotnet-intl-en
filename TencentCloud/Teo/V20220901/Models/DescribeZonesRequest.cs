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

    public class DescribeZonesRequest : AbstractModel
    {
        
        /// <summary>
        /// The page offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Limit on paginated queries. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter conditions. Up to 20 values for each filter. If this parameter is not filled in, the information of all sites under the current account is returned. Detailed filtering conditions are as follows:
        /// <li>`zone-name`: Site name </li><li>`zone-id`: Site ID, such as zone-2noz78a8ev6k</li><li>`status`: Site status </li><li>`tag-key`: Tag key </li><li>`tag-value`: Tag value </li>Only `zone-name` supports fuzzy query.
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// Sort the returned results according to this field. Values include:
        /// <li>`type`: Connection mode</li>
        /// <li>`area`: Acceleration region</li>
        /// <li>`create-time`: Creation time</li>
        /// <li>`zone-name`: Site name</li>
        /// <li>`use-time`: Last used time</li>
        /// <li>`active-status` Effective status</li> Default value: `create-time`
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sort direction. If the field value is a number, sort by the numeric value. If the field value is text, sort by the ascill code. Values include:
        /// <li>`asc`: From the smallest to largest</li>
        /// <li>`desc`: From the largest to smallest.</li>Default value: `desc`
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

