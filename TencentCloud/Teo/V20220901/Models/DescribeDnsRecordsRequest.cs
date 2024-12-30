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

    public class DescribeDnsRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// The site ID of the DNS record.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The page offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The paginated query limit. Default value: 20. Maximum value: 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// The upper limit of Filters.Values is 20. The detailed filtering conditions are as follows: <li>id: Filter by DNS record ID, supports fuzzy query;</li><li>name: Filter by DNS record name, supports fuzzy query;</li><li>content: Filter by DNS record content, supports fuzzy query;</li><li>type: Filter by DNS record type, does not support fuzzy query. Options:<br> A: Point the domain name to an external IPv4 address, such as 8.8.8.8;<br> AAAA: Point the domain name to an external IPv6 address;<br> CNAME: Point the domain name to another domain name, which then resolves to the final IP address;<br> TXT: Identify and describe the domain name, often used for domain verification and SPF records (anti-spam);<br> NS: If you need to delegate subdomain resolution to another DNS service provider, you need to add an NS record. Root domains cannot add NS records;<br> CAA: Specify the CA that can issue certificates for this site;<br> SRV: Identify a server using a specific service, commonly used in Microsoft's directory management;<br> MX: Specify the recipient's mail server.</li><li>ttl: Filter by the time-to-live (TTL) of the record, does not support fuzzy query.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// Sort criteria, with possible values:
        /// <li>content: DNS record content;</li>
        /// <li>created-on: DNS record creation time;</li>
        /// <li>name: DNS record name;</li>
        /// <li>ttl: Time-to-live (TTL);</li>
        /// <li>type: DNS record type.</li>
        /// The default sorting is based on a combination of type and name attributes.
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// List sorting order, with possible values:
        /// <li>asc: Ascending order;</li>
        /// <li>desc: Descending order.</li>
        /// The default value is asc.
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// The match mode. Values:
        /// <li>`all`: Return all records that match the specified filter.</li>
        /// <li>`any`: Return any record that matches the specified filter.</li>Default value: all.
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

