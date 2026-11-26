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
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Offset of paginated query. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number limit of paginated query. Default value: 20. Maximum value: 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter criteria. The maximum number of Filters.Values is 20. The detailed filter criteria are as follows: <li>id: Filter by DNS record ID. Fuzzy query is supported.</li><li>name: Filter by DNS record name. Fuzzy query is supported.</li><li>content: Filter by DNS record content. Fuzzy query is supported.</li><li>type: Filter by DNS record type. Fuzzy query is not supported. Options:<br>        A: Point the domain to an external IPv4 address, such as 8.8.8.8.<br>        AAAA: Point the domain to an external IPv6 address.<br>        CNAME: Point the domain to another domain, which then resolves to the final IP address.<br>        TXT: Identify and describe the domain. Commonly used for domain verification and SPF records (anti-spam).<br>        NS: If you need to delegate a subdomain to another DNS service provider for resolution, you need to add an NS record. NS records cannot be added for root domains.<br>        CAA: Specify the CA that can issue certificates for this site.<br>        SRV: Identify that a server uses a service. Commonly used for directory management in Microsoft systems.<br>        MX: Specify the recipient mail server.</li><li>ttl: Filter by resolution time. Fuzzy query is not supported.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// Sorting basis. Valid values: <li>content: DNS record content;</li><li>created-on: DNS record creation time;</li><li>name: DNS record name;</li><li>ttl: cache time;</li><li>type: DNS record type.</li>Default sorting order: by the combination of type and name attributes.
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// List sort method. Valid values: <li>asc: ascending sort;</li><li>desc: descending sort.</li> Default value: asc.
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// Match mode. Valid values: <li>all: return records that match all query conditions;</li><li>any: return records that match any query condition.</li> Default value: all.
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

