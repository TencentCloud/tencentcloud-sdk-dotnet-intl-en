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

    public class ModifyApplicationProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Proxy ID.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Domain name or subdomain name when `ProxyType=hostname`; 
        /// Instance name when `ProxyType=instance`.
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// The session persistence duration. Value range: 30-3600 (in seconds).
        /// The original configuration will apply if this field is not specified.
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// L4 proxy mode. Valid values: 
        /// <li>instance: Instance mode. </li>If it is not specified, instance is used by default.
        /// </summary>
        [JsonProperty("ProxyType")]
        public string ProxyType{ get; set; }

        /// <summary>
        /// IPv6 access configuration. The original configuration will apply if it is not specified.
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// Cross-MLC-border acceleration. The original configuration will apply if it is not specified.
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainland AccelerateMainland{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "AccelerateMainland.", this.AccelerateMainland);
        }
    }
}

