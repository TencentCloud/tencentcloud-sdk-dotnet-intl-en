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
        /// Zone id.<br>note: zoneid is for output parameter use only and cannot be used as an input parameter in modifydnsrecords. if this parameter is passed, it will be ignored.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// DNS record id.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// DNS record name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// DNS record type. valid values are:.
        /// <Li>A: point the domain to a public network ipv4 address, such as 8.8.8.8;</li>.
        /// <Li>AAAA: point the domain to a public network ipv6 address;</li>.
        /// <Li>MX: used for email servers. when there are multiple mx records, the lower the priority, the higher the precedence;</li>.
        /// <Li>CNAME: point the domain to another domain name, which will resolve to the final ip address;</li>.
        /// <Li>TXT: identify and describe the domain, commonly used for domain verification and spf records (anti-spam);</li>.
        /// <Li>NS: if you need to delegate the resolution of a subdomain to another dns service provider, you need to add an ns record. ns records cannot be added to the root domain name;</li>.
        /// <Li>CAA: specifies the ca that can issue certificates for this site;</li>.
        /// <Li>SRV: indicates that a server is using a service, commonly seen in microsoft system directory management.</li>.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// DNS record resolution route, if not specified, defaults to default, indicating the default resolution route, effective in all regions.<br>resolution route configuration only applies when type (dns record type) is a, aaaa, or cname.<br>for valid values, refer to: [resolution routes and corresponding code enumeration](https://intl.cloud.tencent.com/document/product/1552/112542?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// DNS record content. fill in the corresponding content based on the type value.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Cache time. value range: 60–86400. the smaller the value, the faster the record modification will take effect globally. unit: seconds.
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// DNS record weight. value range: -1–100. a value of -1 means no weight is assigned, and 0 means no parsing. weight configuration is only applicable when type (dns record type) is a, aaaa, or cname.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// MX record priority. value range: 0–50. the smaller the value, the higher the priority.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// DNS record parsing status. valid values are: <li>enable: takes effect;</li><li>disable: disabled.</li> note: status is only used as an output parameter and cannot be used as an input parameter in modifydnsrecords. if this parameter is passed, it will be ignored.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Creation time.<br>note: createdon is only used as an output parameter and cannot be used as an input parameter in modifydnsrecords. if this parameter is passed, it will be ignored.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// Modification time.<br>note: modifiedon is for output parameter only and cannot be used as an input parameter in modifydnsrecords. if this parameter is passed, it will be ignored.
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

