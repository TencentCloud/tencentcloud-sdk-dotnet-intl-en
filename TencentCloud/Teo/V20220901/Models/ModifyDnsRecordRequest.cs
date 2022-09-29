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

    public class ModifyDnsRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// The record ID.
        /// </summary>
        [JsonProperty("DnsRecordId")]
        public string DnsRecordId{ get; set; }

        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

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
        /// The record name, which consists of the host record and site name. Note that the original configuration will be used if this field is not specified.
        /// </summary>
        [JsonProperty("DnsRecordName")]
        public string DnsRecordName{ get; set; }

        /// <summary>
        /// The record content. Note that the original configuration will be used if this field is not specified.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// TTL (in seconds). The smaller the value, the faster the record changes take effect. Default value: 300. Note that the original configuration will be used if this field is not specified.
        /// </summary>
        [JsonProperty("TTL")]
        public long? TTL{ get; set; }

        /// <summary>
        /// Specifies a value in the range 1–50 when you make changes to the MX records. A smaller value indicates higher priority. Note that the default value 0 will be used if this field is not specified.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// The proxy mode. Values:
        /// <li>`dns_only`: Only DNS</li>
        /// <li>`proxied`: Proxied</li></li>The original configuration will apply if this field is not specified.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DnsRecordId", this.DnsRecordId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DnsRecordType", this.DnsRecordType);
            this.SetParamSimple(map, prefix + "DnsRecordName", this.DnsRecordName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

