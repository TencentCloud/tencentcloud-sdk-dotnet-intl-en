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

    public class DescribeAccelerationDomainsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Zone ID of the acceleration domain name.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>The offset of paginated query. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Paginated query limit. Default value: 20, maximum value: 200.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Filter criteria. The maximum number of Filters.Values is 20. If this parameter is left empty, all domain information under the current zone-id is returned. The detailed filter criteria are as follows:</p><li>domain-name: Filter by acceleration domain name;</li><li>origin-type: Filter by origin server type;</li><li>origin: Filter by primary origin server address;</li><li>backup-origin: Filter by secondary origin server address;</li><li>domain-cname: Filter by CNAME;</li><li>share-cname: Filter by shared CNAME;</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>Sort returned results by this field. Valid values:</p><li>created_on: acceleration domain name creation time;</li><li>domain-name: acceleration domain name.</li>If left empty, returned results are sorted by domain-name by default.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting order. If the field value is a number, sort by its size. If the field value is text, sort by ASCII code size. Valid values:</p><li>asc: ascending order;</li><li>desc: descending order.</li>Use default value asc if not specified.
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// <p>Match mode. Valid values:</p><li>all: return acceleration domain names that match all query conditions;</li><li>any: return acceleration domain names that match any query condition.</li>If left empty, the default value is all.
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

