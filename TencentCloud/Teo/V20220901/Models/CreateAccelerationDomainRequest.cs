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
        /// ID of the site related with the acceleration domain name.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Acceleration domain name
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Details of the origin.
        /// </summary>
        [JsonProperty("OriginInfo")]
        public OriginInfo OriginInfo{ get; set; }

        /// <summary>
        /// Origin-Pull protocol. valid values:.
        /// <Li>FOLLOW: follow protocol;</li>.
        /// <Li>HTTP: http protocol for origin-pull;</li>.
        /// <li>HTTPS: the origin server uses the HTTPS protocol.</li>defaults to FOLLOW if left blank.
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP origin port. default value 80. value range: 1–65535.
        /// This parameter is valid only when OriginProtocol is FOLLOW or HTTP.
        /// </summary>
        [JsonProperty("HttpOriginPort")]
        public ulong? HttpOriginPort{ get; set; }

        /// <summary>
        /// HTTPS origin port. default value 443. value range: 1–65535.
        /// This parameter is valid only when OriginProtocol is FOLLOW or HTTPS.
        /// </summary>
        [JsonProperty("HttpsOriginPort")]
        public ulong? HttpsOriginPort{ get; set; }

        /// <summary>
        /// IPv6 status. valid values:.
        /// <li>follow: adhere to the site IPv6 configuration;</li>.
        /// <li>on: enabled status;</li>.
        /// <li>off: disabled.</li>if left empty, the default value is follow.
        /// </summary>
        [JsonProperty("IPv6Status")]
        public string IPv6Status{ get; set; }

        /// <summary>
        /// Specify the shared CNAME address for domain binding. use the default CNAME when not specified.
        /// Bind shared CNAME requires the scheduling policy of all domains to be consistent. the following configuration affects the scheduling policy. when inconsistent, bind shared CNAME will be processed as follows:.
        /// -IPv6 access: not allowed to create domain name. change IPv6Status to keep it configured the same as other domain names bound to the shared CNAME.
        /// -Anti-DDoS: if the selected shared CNAME has DDoS protection enabled, domain activation will enable DDoS protection by default.
        /// -Network optimization in the chinese mainland (international acceleration): not allowed to create a domain name. keep the network optimization in the chinese mainland (international acceleration) configuration of the current domain name consistent with the other domain names bound to the shared CNAME and try again after.
        /// 
        /// Note: shared CNAME is currently in beta test. if you need to use it, contact us to enable it.
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

