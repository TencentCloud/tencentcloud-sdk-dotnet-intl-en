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

    public class CreateAccelerationDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID of the acceleration domain name.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Acceleration domain name.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Origin server information.
        /// </summary>
        [JsonProperty("OriginInfo")]
        public OriginInfo OriginInfo{ get; set; }

        /// <summary>
        /// Origin-pull protocol. Valid values:
        /// <li>FOLLOW: follow protocol;</li>
        /// <li>HTTP: Origin-pull over HTTP protocol;</li>
        /// <li>HTTPS: origin-pull over the HTTPS protocol.</li>If not specified, the default is FOLLOW.
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP origin-pull port. Default value: 80. Value range: 1–65535.
        /// This parameter is valid only when OriginProtocol is FOLLOW or HTTP.
        /// </summary>
        [JsonProperty("HttpOriginPort")]
        public ulong? HttpOriginPort{ get; set; }

        /// <summary>
        /// HTTPS origin port. Default value: 443. Value range: 1–65535.
        /// This parameter is valid only when OriginProtocol is FOLLOW or HTTPS.
        /// </summary>
        [JsonProperty("HttpsOriginPort")]
        public ulong? HttpsOriginPort{ get; set; }

        /// <summary>
        /// IPv6 status. Valid values:
        /// <li>follow: follow the site IPv6 configuration;</li>
        /// <li>`on`: Enabled status;</li>
        /// <li>off: Disabled.</li>If not specified, the default is: follow.
        /// </summary>
        [JsonProperty("IPv6Status")]
        public string IPv6Status{ get; set; }

        /// <summary>
        /// Shared CNAME address bound to the specified domain. If not specified, the default CNAME is used.
        /// Binding a shared CNAME requires the scheduling policies of all domains to be consistent. The following configurations affect the scheduling policy. When they are inconsistent, binding a shared CNAME is processed as follows:
        /// - IPv6 access: not allowed to create a domain name. Modify IPv6Status to match the domain configuration of the rest bound to the shared CNAME.
        /// -DDoS protection: If DDoS protection is enabled for the selected shared CNAME, DDoS protection will be enabled for the domain by default when you create the domain.
        /// -Network optimization in the Chinese mainland (international acceleration): You are not allowed to create a domain name. Make sure the network optimization in the Chinese mainland (international acceleration) configuration of the current domain name is consistent with the rest of the domain names bound to the shared CNAME, and try again later.
        /// 
        /// Note: Shared CNAME is currently in beta test. To use it, contact us to enable it.
        /// </summary>
        [JsonProperty("SharedCNAME")]
        public string SharedCNAME{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamObj(map, prefix + "OriginInfo.", this.OriginInfo);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HttpOriginPort", this.HttpOriginPort);
            this.SetParamSimple(map, prefix + "HttpsOriginPort", this.HttpsOriginPort);
            this.SetParamSimple(map, prefix + "IPv6Status", this.IPv6Status);
            this.SetParamSimple(map, prefix + "SharedCNAME", this.SharedCNAME);
        }
    }
}

