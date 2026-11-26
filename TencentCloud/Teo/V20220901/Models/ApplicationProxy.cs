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

    public class ApplicationProxy : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Proxy ID.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// When ProxyType=hostname, it indicates a domain name or subdomain.
        /// When ProxyType=instance, it indicates the proxy name.
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// L4 proxy mode. Valid values:
        /// <li>`hostname`: Create by subdomain name;</li>
        /// <li>`instance`: Create by instance.</li>
        /// </summary>
        [JsonProperty("ProxyType")]
        public string ProxyType{ get; set; }

        /// <summary>
        /// Scheduling mode. Valid values:
        /// <li>`ip`: Anycast IP;</li>
        /// <li>`domain`: CNAME.</li>
        /// </summary>
        [JsonProperty("PlatType")]
        public string PlatType{ get; set; }

        /// <summary>
        /// Acceleration region. Valid values:
        /// <li>mainland: within the Chinese mainland;</li>
        /// <li>overseas: global (excluding the Chinese mainland).</li>
        /// Default value: overseas
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Whether security is enabled. Valid values:
        /// <li>0: Disable security;</li>
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
        /// Session hold time, in seconds.
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// Status. Valid values:
        /// <li>`online`: Enable;</li>
        /// <li>`offline`: Disable;</li>
        /// <li>progress: deploying;</li>
        /// <li>stopping: disabling;</li>
        /// <li>fail: deployment or disabling failed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Blocking status. Valid values:
        /// <li>banned: blocked;</li>
        /// <li>banning: Being banned;</li>
        /// <li>recover: unblocked;</li>
        /// <li>`recovering`: The name server is being unblocked.</li>
        /// </summary>
        [JsonProperty("BanStatus")]
        public string BanStatus{ get; set; }

        /// <summary>
        /// Scheduling information.
        /// </summary>
        [JsonProperty("ScheduleValue")]
        public string[] ScheduleValue{ get; set; }

        /// <summary>
        /// When ProxyType=hostname:
        /// Indicates the unique ID of the proxy acceleration.
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// Ipv6 access configuration.
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Rule list.
        /// </summary>
        [JsonProperty("ApplicationProxyRules")]
        public ApplicationProxyRule[] ApplicationProxyRules{ get; set; }

        /// <summary>
        /// Acceleration optimization configuration for the Chinese mainland.
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainland AccelerateMainland{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
            this.SetParamSimple(map, prefix + "PlatType", this.PlatType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamSimple(map, prefix + "AccelerateType", this.AccelerateType);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BanStatus", this.BanStatus);
            this.SetParamArraySimple(map, prefix + "ScheduleValue.", this.ScheduleValue);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "ApplicationProxyRules.", this.ApplicationProxyRules);
            this.SetParamObj(map, prefix + "AccelerateMainland.", this.AccelerateMainland);
        }
    }
}

