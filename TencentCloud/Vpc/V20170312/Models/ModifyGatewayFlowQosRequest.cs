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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGatewayFlowQosRequest : AbstractModel
    {
        
        /// <summary>
        /// Gateway instance ID. Supported types:
        /// Direct connect gateway instance, such as `dcg-ltjahce6`;
        /// NAT gateway instance, such as `nat-ltjahce6`;
        /// VPN gateway instance, such as `vpn-ltjahce6`.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Bandwidth limit value in Mbps. Valid values: >0: Set the limit to the specified value. 0: Block all traffic. -1: No bandwidth limit.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// CVM private IP addresses with limited bandwidth.
        /// </summary>
        [JsonProperty("IpAddresses")]
        public string[] IpAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamArraySimple(map, prefix + "IpAddresses.", this.IpAddresses);
        }
    }
}

