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

    public class DirectConnectGateway : AbstractModel
    {
        
        /// <summary>
        /// The direct connect gateway ID.
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// The direct connect gateway name.
        /// </summary>
        [JsonProperty("DirectConnectGatewayName")]
        public string DirectConnectGatewayName{ get; set; }

        /// <summary>
        /// The ID of the VPC instance associated with the direct connect gateway.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The associated network type:
        /// <li>`VPC` - VPC</li>
        /// <li>`CCN` - CCN</li>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// The ID of the associated network instance:
        /// <li>When the `NetworkType` is `VPC`, this value is the VPC instance ID</li>
        /// <li>When the `NetworkType` is `CCN`, this value is the CCN instance ID</li>
        /// </summary>
        [JsonProperty("NetworkInstanceId")]
        public string NetworkInstanceId{ get; set; }

        /// <summary>
        /// The gateway type:
        /// <li>NORMAL - Standard type. Note: CCN only supports the standard type</li>
        /// <li>NAT type</li>
        /// The NAT type supports network address translation. The specified type cannot be modified. A VPC can create one NAT direct connect gateway and one non-NAT direct connect gateway
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The direct connect gateway IP.
        /// </summary>
        [JsonProperty("DirectConnectGatewayIp")]
        public string DirectConnectGatewayIp{ get; set; }

        /// <summary>
        /// The ID of the CCN instance associated with the direct connect gateway.
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// The route-learning type of the CCN:
        /// <li>`BGP` - Automatic learning.</li>
        /// <li>`STATIC` - Static, that is, user-configured.</li>
        /// </summary>
        [JsonProperty("CcnRouteType")]
        public string CcnRouteType{ get; set; }

        /// <summary>
        /// Whether the BGP is enabled.
        /// </summary>
        [JsonProperty("EnableBGP")]
        public bool? EnableBGP{ get; set; }

        /// <summary>
        /// Whether the `community` attribute of the BGP is enabled.
        /// </summary>
        [JsonProperty("EnableBGPCommunity")]
        public bool? EnableBGPCommunity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayName", this.DirectConnectGatewayName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "NetworkInstanceId", this.NetworkInstanceId);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayIp", this.DirectConnectGatewayIp);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CcnRouteType", this.CcnRouteType);
            this.SetParamSimple(map, prefix + "EnableBGP", this.EnableBGP);
            this.SetParamSimple(map, prefix + "EnableBGPCommunity", this.EnableBGPCommunity);
        }
    }
}
