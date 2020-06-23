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

    public class DescribeDirectConnectGatewaysRequest : AbstractModel
    {
        
        /// <summary>
        /// The unique `ID` of the Direct Connect gateway, such as `dcg-9o233uri`.
        /// </summary>
        [JsonProperty("DirectConnectGatewayIds")]
        public string[] DirectConnectGatewayIds{ get; set; }

        /// <summary>
        /// Filter condition. `DirectConnectGatewayIds` and `Filters` cannot be specified at the same time.
        /// <li>direct-connect-gateway-id - String - The unique `ID` of the Direct Connect gateway, such as `dcg-9o233uri`.</li>
        /// <li>direct-connect-gateway-name - String - The name of the Direct Connect gateway. The default is fuzzy query.</li>
        /// <li>direct-connect-gateway-ip - String - The `IP` of the Direct Connect gateway.</li>
        /// <li>gateway-type - String - The gateway type. Available values: `NORMAL` (Normal-type), `NAT` (NAT-type).</li>
        /// <li>network-type- String - The network type. Available values: `VPC` (VPC-type), `CCN` (CCN-type).</li>
        /// <li>ccn-id - String - The `ID` of the CCN where the Direct Connect gateway is located.</li>
        /// <li>vpc-id - String - The `ID` of the VPC where the Direct Connect gateway is located.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The returned quantity.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DirectConnectGatewayIds.", this.DirectConnectGatewayIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

