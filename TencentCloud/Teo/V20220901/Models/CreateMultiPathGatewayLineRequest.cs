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

    public class CreateMultiPathGatewayLineRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Multi-Channel security gateway ID.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Line type. valid values:
        /// <li>direct: direct connection line, cannot be modified or deleted.</li>
        ///  <li>proxy: EdgeOne layer-4 proxy line, supports modifying instance ID and rule ID, but cannot be deleted.</li> <li>custom: custom line, supports modifying and deleting instance ID and rule ID.</li>
        /// </summary>
        [JsonProperty("LineType")]
        public string LineType{ get; set; }

        /// <summary>
        /// Line address format: ip:port.
        /// </summary>
        [JsonProperty("LineAddress")]
        public string LineAddress{ get; set; }

        /// <summary>
        /// The layer-4 proxy instance ID is required when the LineType value is proxy (EdgeOne layer-4 proxy) and can be obtained via the api [DescribeL4proxy](https://intl.cloud.tencent.com/document/api/1552/103413?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Forwarding rule ID, this field is required when the line type LineType value is proxy (EdgeOne layer-4 proxy). you can obtain it from the api [DescribeL4ProxyRules](https://intl.cloud.tencent.com/document/api/1552/103412?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "LineType", this.LineType);
            this.SetParamSimple(map, prefix + "LineAddress", this.LineAddress);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

