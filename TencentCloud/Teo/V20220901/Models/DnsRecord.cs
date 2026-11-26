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

    public class DnsRecord : AbstractModel
    {
        
        /// <summary>
        /// Site ID.<br>Note: ZoneId is for output usage only. It cannot be used as an input parameter in ModifyDnsRecords. If this parameter is input, it will be ignored.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// DNS record ID.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// DNS record name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// DNS record type. Valid values:
        /// <li>A: Point the domain name to a public IPv4 address, for example 8.8.8.8;</li>
        /// <li>AAAA: point the domain name to a public IPv6 address;</li>
        /// <li>MX: for email servers. When multiple MX records exist, lower priority means higher preference;</li>
        /// <li>CNAME: Point the domain to another domain, which then resolves the final IP;</li>
        /// <li>TXT: Identifies and describes a domain name, commonly used for domain name verification and SPF records (anti-spam);</li>
        /// <li>NS: If you need to delegate subdomain resolution to another DNS service provider, you need to add an NS record. NS records cannot be added for the root domain;</li>
        /// <li>CAA: specify the CA that can issue certificates for this site;</li>
        /// <li>SRV: identifies that a server used a service, commonly seen in directory management of Microsoft systems.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// DNS record resolution route. If not specified, it defaults to Default, which means the default resolution route and represents that it takes effect in all regions.<br>Route configuration is applicable only when Type (DNS record type) is A, AAAA, or CNAME.<br>For values, see [Resolution routes and corresponding code enumeration](https://www.tencentcloud.com/document/product/1552/112542?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// DNS record content. Fill in the corresponding content based on the Type value.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Cache time. Value range: 60–86400. A smaller value means the modification record takes effect faster in each region. Unit: seconds.
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// DNS record weight. Value range: -1 to 100. -1 means no weight is assigned, and 0 indicates no parsing. Weight configuration is applicable only when Type (DNS record type) is A, AAAA, or CNAME.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// MX record priority. Value range: 0–50. A smaller value indicates a higher priority.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// DNS record resolution status. Valid values: <li>enable: effective;</li><li>disable: disabled.</li>Note: Status is for output only. It cannot be used as an input parameter in ModifyDnsRecords and will be ignored if provided.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Creation time.<br>Note: CreatedOn is for output only and cannot be used as an input parameter in ModifyDnsRecords. If this parameter is input, it will be ignored.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// Last modified.<br>Note: ModifiedOn is for output only and cannot be used as an input parameter in ModifyDnsRecords. If this parameter is input, it will be ignored.
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
        }
    }
}

