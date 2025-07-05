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

    public class DescribeDnsRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone id.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Offset of paginated query. default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number limit of paginated query. default value: 20. maximum value: 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter conditions. up to 20 values for each filter. detailed filter conditions are as follows: <li>id: filter by dns record id, supports fuzzy search;</li><li>name: filter by dns record name, supports fuzzy search;</li><li>content: filter by dns record content, supports fuzzy search;</li><li>type: filter by dns record type, does not support fuzzy search. valid values:<br>   a: points the domain name to an external ipv4 address, such as 8.8.8.8;<br>   aaaa: points the domain name to an external ipv6 address;<br>   cname: points the domain name to another domain name, which then resolves to the final ip address;<br>   txt: identifies and describes the domain name, commonly used for domain verification and spf records (anti-spam);<br>   ns: if you need to delegate the subdomain to another dns service provider, you need to add an ns record. root domain cannot add ns records;<br>   caa: specifies the ca that can issue certificates for this site;<br>   srv: identifies a server using a specific service, commonly used in microsoft's directory management;<br>   mx: specifies the recipient's mail server.</li><li>ttl: filter by resolution effective time, does not support fuzzy search.</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// Sorting basis. values include: <li>`content`: dns record content</li><li>`created-on`: dns record creation time</li><li>`name`: dns record name</li><li>`ttl`: cache time</li><li>`type`: dns record type</li> default sorting is by the combination of `type`, `name`.
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// List sort method. values: <li>`asc`: ascending order</li><li>`desc`: sort in descending order</li> default value: `asc`.
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// Match method. values: <li>`all`: return records that match all query conditions</li><li>`any`: return records that match any query condition</li> default value: `all`.
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
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "Match", this.Match);
        }
    }
}

