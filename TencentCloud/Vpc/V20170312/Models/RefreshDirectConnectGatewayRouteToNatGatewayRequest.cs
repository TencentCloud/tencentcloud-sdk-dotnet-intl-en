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

    public class RefreshDirectConnectGatewayRouteToNatGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The NAT gateway ID.
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// Whether it is pre-refresh. Valid values: `True` (yes) and `False` (no)
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

