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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVpnConnectionsRequest : AbstractModel
    {
        
        /// <summary>
        /// The instance ID of the VPN tunnel, such as `vpnx-f49l6u0z`. Each request can have a maximum of 100 instances. `VpnConnectionIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("VpnConnectionIds")]
        public string[] VpnConnectionIds{ get; set; }

        /// <summary>
        /// The filter condition. For details, see the Instance Filter Conditions Table. The upper limit for `Filters` in each request is 10 and 5 for `Filter.Values`. `VpnConnectionIds` and `Filters` cannot be specified at the same time.
        /// <li>vpc-id - String - The VPC instance ID, such as `vpc-0a36uwkr`.</li>
        /// <li>vpn-gateway-id - String - The VPN gateway instance ID, such as `vpngw-p4lmqawn`.</li>
        /// <li>customer-gateway-id - String - The customer gateway instance ID, such as `cgw-l4rblw63`.</li>
        /// <li>vpn-connection-name - String - The connection name, such as `test-vpn`.</li>
        /// <li>vpn-connection-id - String - The connection instance ID, such as `vpnx-5p7vkch8"`.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The Offset. The default value is 0. For more information about Offset, see the relevant section in the API Introduction.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of values to be returned. The default value is 20. Maximum is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "VpnConnectionIds.", this.VpnConnectionIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

