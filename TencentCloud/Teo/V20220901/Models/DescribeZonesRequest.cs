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

    public class DescribeZonesRequest : AbstractModel
    {
        
        /// <summary>
        /// The offset of paginated query. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Paginated query limit. Default value: 20, maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter criteria. The maximum number of Filters.Values is 20. If this parameter is left empty, all site information authorized under the current appid will be returned. The detailed filter criteria are as follows: <li>zone-name: Filter by site name.</li><li>zone-type: Filter by site type. Options:<br>        full: NS access type<br>        partial: CNAME access type<br>        partialComposite: domainless access<br>        dnsPodAccess: DNSPod managed access<br>        pages: Pages access type<br>        ai: edge reasoning access type.</li><li>zone-id: Filter by site ID in the format like zone-2noz78a8ev6k.</li><li>status: Filter by site status. Options:<br>        active: NS switched<br>        pending: NS to be switched<br>        deleted: deleted.</li><li>tag-key: Filter by tag key.</li><li>tag-value: Filter by tag value.</li><li>alias-zone-name: Filter by identical site identifier.</li>Fuzzy query supports filtering fields named zone-name or alias-zone-name.
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// Sort returned results based on this field. Valid values:
        /// <li> type: access type;</li>
        /// <li> area: acceleration region;</li>
        /// <li> create-time: creation time;</li>
        /// <li> zone-name: site name;</li>
        /// <li> use-time: last used time;</li>
        /// <li> active-status: effective status.</li>If left empty, the returned results are sorted by create-time by default.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting order. If the field value is a number, sort by number size. If the field value is text, sort by ASCII code size. Valid values:
        /// <li> asc: sort in ascending order;</li>
        /// <li> desc: in descending order.</li>Use default value desc if not specified.
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

