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

    public class DownloadCustomerGatewayConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the VPN gateway instance.
        /// </summary>
        [JsonProperty("VpnGatewayId")]
        public string VpnGatewayId{ get; set; }

        /// <summary>
        /// The ID of the VPN tunnel instance, such as `vpnx-f49l6u0z`.
        /// </summary>
        [JsonProperty("VpnConnectionId")]
        public string VpnConnectionId{ get; set; }

        /// <summary>
        /// Customer gateway vendor information object, which can be obtained through DescribeCustomerGatewayVendors.
        /// </summary>
        [JsonProperty("CustomerGatewayVendor")]
        public CustomerGatewayVendor CustomerGatewayVendor{ get; set; }

        /// <summary>
        /// Name of the physical API for tunnel access device.
        /// </summary>
        [JsonProperty("InterfaceName")]
        public string InterfaceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpnGatewayId", this.VpnGatewayId);
            this.SetParamSimple(map, prefix + "VpnConnectionId", this.VpnConnectionId);
            this.SetParamObj(map, prefix + "CustomerGatewayVendor.", this.CustomerGatewayVendor);
            this.SetParamSimple(map, prefix + "InterfaceName", this.InterfaceName);
        }
    }
}

