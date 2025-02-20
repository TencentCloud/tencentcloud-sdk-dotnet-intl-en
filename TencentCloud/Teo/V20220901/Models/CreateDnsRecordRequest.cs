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
        /// Zone id.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// DNS record name. if the domain name is in chinese, korean, or japanese, it needs to be converted to punycode before input.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// DNS record type. valid values are: <li>a: points the domain name to an external ipv4 address, such as 8.8.8.8;</li><li>aaaa: points the domain name to an external ipv6 address;</li><li>mx: used for email servers. when there are multiple mx records, the lower the priority value, the higher the priority;</li><li>cname: points the domain name to another domain name, which then resolves to the final ip address;</li><li>txt: identifies and describes the domain name, commonly used for domain verification and spf records (anti-spam);</li><li>ns: if you need to delegate the subdomain to another dns service provider for resolution, you need to add an ns record. the root domain cannot add ns records;</li><li>caa: specifies the ca that can issue certificates for this site;</li><li>srv: identifies a server using a service, commonly used in microsoft's directory management.</li>.
        /// Different record types, such as srv and caa records, have different requirements for host record names and record value formats. for detailed descriptions and format examples of each record type, please refer to: [introduction to dns record types](https://intl.cloud.tencent.com/document/product/1552/90453?from_cn_redirect=1#2f681022-91ab-4a9e-ac3d-0a6c454d954e).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// DNS record content. fill in the corresponding content according to the type value. if the domain name is in chinese, korean, or japanese, it needs to be converted to punycode before input.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// DNS record resolution route. if not specified, the default is default, which means the default resolution route and is effective in all regions.
        /// 
        /// - resolution route configuration is only applicable when type (dns record type) is a, aaaa, or cname.
        /// - resolution route configuration is only applicable to standard version and enterprise edition packages. for valid values, please refer to: [resolution routes and corresponding code enumeration](https://intl.cloud.tencent.com/document/product/1552/112542?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// Cache time. users can specify a value range of 60-86400. the smaller the value, the faster the modification records will take effect in all regions. default value: 300. unit: seconds.
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// DNS record weight. users can specify a value range of -1 to 100. a value of 0 means no resolution. if not specified, the default is -1, which means no weight is set. weight configuration is only applicable when type (dns record type) is a, aaaa, or cname.<br>note: for the same subdomain, different dns records with the same resolution route should either all have weights set or none have weights set.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// MX record priority, which takes effect only when type (dns record type) is mx. the smaller the value, the higher the priority. users can specify a value range of 0–50. the default value is 0 if not specified.
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

