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

    public class CreateL4ProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// L4 proxy instance name. Enter 1-50 characters. Allowed characters: a-z, 0-9, and -. The hyphen cannot be registered alone or used continuously, and cannot be placed at the beginning or the end. Modifications are not allowed after creation.
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// Acceleration zone of the L4 proxy instance.
        /// <li>mainland: Chinese mainland availability zone;</li>
        /// <li>overseas: global availability zone (excluding the Chinese mainland);</li>
        /// <li>global: global availability zone.</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Whether IPv6 access is enabled. If left empty, it is off by default. This configuration can only be enabled in certain acceleration zones and security protection configurations. For details, refer to Creating a New Layer 4 Proxy Instance (https://www.tencentcloud.com/document/product/1552/90025?from_cn_redirect=1). Value:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("Ipv6")]
        public string Ipv6{ get; set; }

        /// <summary>
        /// Whether to enable static IP. Default off if left empty. This configuration can only be enabled in certain acceleration zones and security protection configurations. For details, refer to Creating a New Layer 4 Proxy Instance (https://www.tencentcloud.com/document/product/1552/90025?from_cn_redirect=1). Value:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("StaticIp")]
        public string StaticIp{ get; set; }

        /// <summary>
        /// Whether to enable network optimization in the Chinese mainland. If left empty, it is off by default. This configuration can only be enabled in certain acceleration zones and security protection configurations. For details, refer to Creating a New Layer 4 Proxy Instance. Value:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public string AccelerateMainland{ get; set; }

        /// <summary>
        /// Configuration of L3/L4 DDoS protection. If this parameter is not input, the default platform protection option is used. For details, see [Exclusive DDoS Protection](https://www.tencentcloud.com/document/product/1552/95994?from_cn_redirect=1).
        /// This field is deprecated. Please use the DDosProtectionId field to specify the associated DDoS protection configuration.
        /// </summary>
        [JsonProperty("DDosProtectionConfig")]
        [System.Obsolete]
        public DDosProtectionConfig DDosProtectionConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Ipv6", this.Ipv6);
            this.SetParamSimple(map, prefix + "StaticIp", this.StaticIp);
            this.SetParamSimple(map, prefix + "AccelerateMainland", this.AccelerateMainland);
            this.SetParamObj(map, prefix + "DDosProtectionConfig.", this.DDosProtectionConfig);
        }
    }
}

