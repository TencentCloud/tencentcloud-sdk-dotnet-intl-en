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

    public class ModifyAccelerationDomainRequest : AbstractModel
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
        /// <li>HTTP: Origin-pull over HTTP;</li>
        /// <li>HTTPS: Origin-pull over HTTPS protocol.</li>
        /// <li>Leave blank to retain the original configuration.</li>
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP origin-pull port. Value range: 1–65535. This parameter is valid only when OriginProtocol is FOLLOW or HTTP. If not specified, the original configuration is retained.
        /// </summary>
        [JsonProperty("HttpOriginPort")]
        public ulong? HttpOriginPort{ get; set; }

        /// <summary>
        /// HTTPS origin-pull port. Value range: 1-65535. This parameter is valid only when OriginProtocol is FOLLOW or HTTPS. If not specified, the original configuration is retained.
        /// </summary>
        [JsonProperty("HttpsOriginPort")]
        public ulong? HttpsOriginPort{ get; set; }

        /// <summary>
        /// IPv6 status. Valid values:
        /// <li>follow: follow the site IPv6 configuration;</li>
        /// <li>on: enabled;</li>
        /// <li>off: Disabled.</li>
        /// <li>Leave blank to retain the original configuration.</li>
        /// </summary>
        [JsonProperty("IPv6Status")]
        public string IPv6Status{ get; set; }


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
        }
    }
}

