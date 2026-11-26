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

    public class L4Proxy : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Layer 4 Proxy Instance ID.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Name of the L4 proxy instance.
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// Acceleration zone of the Layer 4 proxy instance. 
        /// <li>mainland: Chinese mainland availability zone;</li>
        /// <li>overseas: global availability zone (excluding the Chinese mainland);</li>
        ///  <li>global: global availability zone.</li>	
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Access via CNAME.
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// After fixed IP address is enabled, this value returns the corresponding access IP address. If not enabled, this value is empty.
        /// </summary>
        [JsonProperty("Ips")]
        public string[] Ips{ get; set; }

        /// <summary>
        /// Status of the Layer 4 proxy instance.
        /// <li>online: enabled;</li>
        /// <li>offline: Disabled;</li>
        /// <li>progress: deploying;</li>	
        /// <li>stopping: disabling;</li>
        /// <li>`banned`: The name server is banned.</li>
        /// <li>fail: deployment or disabling failed.</li>	
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Specifies whether to enable IPv6 access. 
        /// <li>`on`: Enable;</li> 
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("Ipv6")]
        public string Ipv6{ get; set; }

        /// <summary>
        /// Specifies whether to enable the fixed IP address.
        /// <li>`on`: Enable;</li> <li>`off`: Disable.</li>
        /// </summary>
        [JsonProperty("StaticIp")]
        public string StaticIp{ get; set; }

        /// <summary>
        /// Specifies whether to enable network optimization in the Chinese mainland.
        /// <li>on: Enable.</li> <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public string AccelerateMainland{ get; set; }

        /// <summary>
        /// Security protection configuration.
        /// This field is deprecated.
        /// </summary>
        [JsonProperty("DDosProtectionConfig")]
        [System.Obsolete]
        public DDosProtectionConfig DDosProtectionConfig{ get; set; }

        /// <summary>
        /// Number of forwarding rules under the layer 4 proxy instance.
        /// </summary>
        [JsonProperty("L4ProxyRuleCount")]
        public long? L4ProxyRuleCount{ get; set; }

        /// <summary>
        /// Latest modification time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamArraySimple(map, prefix + "Ips.", this.Ips);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Ipv6", this.Ipv6);
            this.SetParamSimple(map, prefix + "StaticIp", this.StaticIp);
            this.SetParamSimple(map, prefix + "AccelerateMainland", this.AccelerateMainland);
            this.SetParamObj(map, prefix + "DDosProtectionConfig.", this.DDosProtectionConfig);
            this.SetParamSimple(map, prefix + "L4ProxyRuleCount", this.L4ProxyRuleCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

