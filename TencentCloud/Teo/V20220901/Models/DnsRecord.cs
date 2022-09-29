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

    public class DnsRecord : AbstractModel
    {
        
        /// <summary>
        /// The record ID.
        /// </summary>
        [JsonProperty("DnsRecordId")]
        public string DnsRecordId{ get; set; }

        /// <summary>
        /// The DNS record type. Values:
        /// <li>`A`: Point a domain name to an IPv4 address, such as 8.8.8.8.</li>
        /// <li>`AAAA`: Point a domain name to an IPv6 address.</li>
        /// <li>`MX`: It is used for email servers. The record value and priority parameters are provided by email service providers. If there are multiple MX records, the lower the priority value, the higher the priority.</li>
        /// <li>`CNAME`: Point a domain name to another domain name that can be resolved to an IP address.</li>
        /// <li>`TXT`: Identify and describe a domain name. It is usually used for domain verification and as SPF records (for anti-spam).</li>
        /// <li>`NS`: If you need to authorize a subdomain name to another DNS service provider for DNS resolution, you need to add an NS record. You cannot add an NS record for a root domain name.</li>
        /// <li>`CAA`: Specify CAs to issue certificates for sites.</li>
        /// <li>`SRV`: Identify a service used by a server. It is commonly used in Microsoft directory management.</li>
        /// </summary>
        [JsonProperty("DnsRecordType")]
        public string DnsRecordType{ get; set; }

        /// <summary>
        /// The record name.
        /// </summary>
        [JsonProperty("DnsRecordName")]
        public string DnsRecordName{ get; set; }

        /// <summary>
        /// The record value.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// The proxy mode. Values:
        /// <li>`dns_only`: Only DNS</li>
        /// <li>`proxied`: Proxied</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// TTL (in seconds). The smaller the value, the faster the record changes take effect.
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// The MX record priority. The smaller the value, the higher the priority.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// The modification time.
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// The lock status of the domain name.
        /// </summary>
        [JsonProperty("Locked")]
        public bool? Locked{ get; set; }

        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// The DNS record status. Values:
        /// <li>`active`: Activated</li>
        /// <li>`pending`: Deactivated</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The CNAME address.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// The service used by the domain name. Values:
        /// <li>`lb`: Load balancing</li>
        /// <li>`security`: Security protection</li>
        /// <li>`l4`: L4 proxy</li>
        /// </summary>
        [JsonProperty("DomainStatus")]
        public string[] DomainStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DnsRecordId", this.DnsRecordId);
            this.SetParamSimple(map, prefix + "DnsRecordType", this.DnsRecordType);
            this.SetParamSimple(map, prefix + "DnsRecordName", this.DnsRecordName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "Locked", this.Locked);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamArraySimple(map, prefix + "DomainStatus.", this.DomainStatus);
        }
    }
}

