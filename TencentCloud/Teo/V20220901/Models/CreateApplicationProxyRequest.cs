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

    public class CreateApplicationProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Domain name or subdomain name when `ProxyType=hostname`; 
        /// Instance name when `ProxyType=instance`.
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// The scheduling mode. Values:
        /// <li>`ip`: Schedule via Anycast IP.</li>
        /// <li>`domain`: Schedule via CNAME.</li>
        /// </summary>
        [JsonProperty("PlatType")]
        public string PlatType{ get; set; }

        /// <summary>
        /// Whether to enable security protection. Values:
        /// <li>`0`: Disable security protection.</li>
        /// <li>`1`: Enable security protection.</li>
        /// </summary>
        [JsonProperty("SecurityType")]
        public long? SecurityType{ get; set; }

        /// <summary>
        /// Whether to enable acceleration. Values:
        /// <li>`0`: Disable acceleration.</li>
        /// <li>`1`: Enable acceleration.</li>
        /// </summary>
        [JsonProperty("AccelerateType")]
        public long? AccelerateType{ get; set; }

        /// <summary>
        /// The proxy type. Values:
        /// <li>`hostname`: The proxy is created by subdomain name.</li>
        /// <li>`instance`: The proxy is created by instance.</li>If not specified, this field uses the default value `instance`.
        /// </summary>
        [JsonProperty("ProxyType")]
        public string ProxyType{ get; set; }

        /// <summary>
        /// The session persistence duration. Value range: 30-3600 (in seconds).
        /// If not specified, this field uses the default value 600.
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// Ipv6 access configuration. 
        /// IPv6 access is disabled if it is not specified.
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// The rule details.
        /// If this field is not specified, an application proxy rule will not be created.
        /// </summary>
        [JsonProperty("ApplicationProxyRules")]
        public ApplicationProxyRule[] ApplicationProxyRules{ get; set; }

        /// <summary>
        /// Cross-MLC-border acceleration. It is disabled if this parameter is not specified.
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

