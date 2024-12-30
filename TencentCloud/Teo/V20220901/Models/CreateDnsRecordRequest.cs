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

    public class CreateDnsRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// The site ID of the DNS record.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The DNS record name.If the domain name is in Chinese, Korean, or Japanese, it needs to be converted to Punycode before being entered.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// DNS record types include:
        /// 
        /// - A:Points the domain to an external IPv4 address, such as 8.8.8.8.
        /// - AAAA: Points the domain to an external IPv6 address.
        /// - MX: Used for mail servers. When multiple MX records exist, the one with the lowest priority value is preferred.
        /// - CNAME: Points the domain to another domain, which then resolves to the final IP address.
        /// - TXT: Provides identification and description for the domain, commonly used for domain verification and SPF records (anti-spam).
        /// - NS: If you need to delegate a subdomain to another DNS service provider, you need to add an NS record. NS records cannot be added to the root domain.
        /// - CAA: Specifies which Certificate Authorities (CAs) are allowed to issue certificates for the site.
        /// - SRV: Indicates that a specific server is using a particular service, commonly used in Microsoft's directory management systems.
        /// 
        /// Different record types, such as SRV and CAA, have specific requirements for the host record name and record value format. For detailed descriptions and format examples of each record type, please refer to: [Introduction to DNS Record Types](https://www.tencentcloud.com/zh/document/product/1145/54764#2f681022-91ab-4a9e-ac3d-0a6c454d954e).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// DNS record content should be filled in according to the corresponding Type value. If the domain name is in Chinese, Korean, or Japanese, it needs to be converted to Punycode before being entered.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// DNS record resolution location, if not specified, default to "Default," which means the default resolution location and is effective for all regions.
        /// - Resolution location configuration is only applicable when the Type (DNS record type) is A, AAAA, or CNAME.
        /// - Resolution location configuration is only available for Standard and Enterprise packages.
        /// 
        /// For the values, please refer to: [Resolution Lines and Corresponding Codes Enumeration](https://www.tencentcloud.com/zh/document/product/1145/67229).
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// TTL (in seconds). The smaller the value, the faster the record changes take effect. Default value: 300
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// DNS record weight can be specified within the range of -1 to 100. Setting the weight to 0 means the record will not be resolved. If not specified, the default value is -1, indicating that no weight is set.
        /// 
        /// Weight configuration is only applicable when the Type (DNS record type) is A, AAAA, or CNAME.
        /// 
        /// Note: For the same subdomain, different DNS records on the same resolution line should either all have weights set or none should have weights set.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// The MX record priority parameter is only effective when the Type (DNS record type) is MX. The smaller the value, the higher the priority. Users can specify a value in the range of 0 to 50. If not specified, the default value is 0.
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

