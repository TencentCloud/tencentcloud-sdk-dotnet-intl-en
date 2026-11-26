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

    public class CreateApplicationProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// When ProxyType=hostname, it indicates a domain name or subdomain.
        /// When ProxyType=instance, it indicates the proxy name.
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// Scheduling mode. Valid values:
        /// <li>`ip`: Anycast IP;</li>
        /// <li>`domain`: CNAME.</li>
        /// </summary>
        [JsonProperty("PlatType")]
        public string PlatType{ get; set; }

        /// <summary>
        /// Whether security is enabled. Valid values:
        /// <li>0: security off;</li>
        /// <li>1: Enable security.</li>
        /// </summary>
        [JsonProperty("SecurityType")]
        public long? SecurityType{ get; set; }

        /// <summary>
        /// Whether to enable acceleration. Valid values:
        /// <li>0: disable acceleration;</li>
        /// <li>1: Enable acceleration.</li>
        /// </summary>
        [JsonProperty("AccelerateType")]
        public long? AccelerateType{ get; set; }

        /// <summary>
        /// Layer 4 proxy mode. Valid values: <li>instance: instance mode.</li>Use default value instance if not specified.
        /// </summary>
        [JsonProperty("ProxyType")]
        public string ProxyType{ get; set; }

        /// <summary>
        /// Session persistence duration. Value range: 30-3600. Unit: second.
        /// If this field is not specified, the default value '600' will be used.
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// Ipv6 access configuration.
        /// Not specified means disabling Ipv6 access.
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// Rule details.
        /// If not specified, no rules are created.
        /// </summary>
        [JsonProperty("ApplicationProxyRules")]
        public ApplicationProxyRule[] ApplicationProxyRules{ get; set; }

        /// <summary>
        /// Acceleration optimization configuration for the Chinese mainland. Not specified means disabling acceleration optimization for the Chinese mainland.
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainland AccelerateMainland{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "PlatType", this.PlatType);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamSimple(map, prefix + "AccelerateType", this.AccelerateType);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamArrayObj(map, prefix + "ApplicationProxyRules.", this.ApplicationProxyRules);
            this.SetParamObj(map, prefix + "AccelerateMainland.", this.AccelerateMainland);
        }
    }
}

