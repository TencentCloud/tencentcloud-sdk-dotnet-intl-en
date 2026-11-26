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

    public class CreateDnsRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// DNS record name. If it is a Chinese, Korean, or Japanese domain name, it needs to be converted to punycode before input.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// DNS record type. Valid values: <li>A: point the domain to an external IPv4 address, for example 8.8.8.8;</li><li>AAAA: point the domain to an external IPv6 address;</li><li>MX: for email servers. If multiple MX records exist, a lower priority value indicates a higher priority;</li><li>CNAME: point the domain to another domain, which is then resolved to the final IP address;</li><li>TXT: identify and describe the domain, commonly used for domain verification and SPF records (anti-spam);</li><li>NS: if you need to use another DNS service provider to resolve a subdomain, an NS record needs to be added. An NS record cannot be added for the root domain;</li><li>CAA: specify the CA that can issue certificates for this site;</li><li>SRV: identify that a server uses a service, commonly used for directory management in Microsoft systems.</li>
        /// Different record types, such as SRV and CAA records, have different requirements for the host record name and record value format. For detailed descriptions and format examples of each record type, see [DNS Record Type Introduction](https://www.tencentcloud.com/document/product/1552/90453?from_cn_redirect=1#2f681022-91ab-4a9e-ac3d-0a6c454d954e).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// DNS record content. Fill in the corresponding content based on the Type value. If it is a Chinese, Korean, or Japanese domain name, convert it to punycode before input.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// DNS record resolution route. If not specified, it defaults to Default, which means the default parsing route and takes effect in all regions.
        /// 
        /// -Resolution line configuration is applicable only when Type (DNS record type) is A, AAAA, or CNAME.
        /// - Route parsing line configuration is applicable only to the standard and enterprise plans. For values, see [Resolution Routes and Corresponding Code Enumeration](https://www.tencentcloud.com/document/product/1552/112542?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Cache time. You can specify a range of 60–86400. A smaller value means modification records take effect faster in each region. Default value: 300. Unit: seconds.
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// DNS record weight. Users can specify a value range of -1 to 100. When set to 0, it means no parsing. If not specified, it defaults to -1, indicating no weight is set. Weight configuration is applicable only when Type (DNS record type) is A, AAAA, or CNAME.<br>Note: For different DNS records under the same subdomain and resolution route, set weight for all of them simultaneously or leave all of them unset.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// MX record priority. This parameter is valid only when Type (DNS record type) is MX. A smaller value indicates higher priority. You can specify a value from 0 to 50. If not specified, the default is 0.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

