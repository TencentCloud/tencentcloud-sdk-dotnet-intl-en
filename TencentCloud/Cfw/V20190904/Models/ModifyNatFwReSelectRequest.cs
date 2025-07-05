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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNatFwReSelectRequest : AbstractModel
    {
        
        /// <summary>
        /// Mode. 1: use existing; 0: create new
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// Firewall instance ID
        /// </summary>
        [JsonProperty("CfwInstance")]
        public string CfwInstance{ get; set; }

        /// <summary>
        /// List of NAT gateways reconnected for the Using Existing mode. Only one of NatGwList and VpcList can be passed.
        /// </summary>
        [JsonProperty("NatGwList")]
        public string[] NatGwList{ get; set; }

        /// <summary>
        /// List of VPCs reconnected for the Create New mode. Only one of NatGwList and VpcList can be passed.
        /// </summary>
        [JsonProperty("VpcList")]
        public string[] VpcList{ get; set; }

        /// <summary>
        /// IP range of the firewall
        /// </summary>
        [JsonProperty("FwCidrInfo")]
        public FwCidrInfo FwCidrInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "CfwInstance", this.CfwInstance);
            this.SetParamArraySimple(map, prefix + "NatGwList.", this.NatGwList);
            this.SetParamArraySimple(map, prefix + "VpcList.", this.VpcList);
            this.SetParamObj(map, prefix + "FwCidrInfo.", this.FwCidrInfo);
        }
    }
}

