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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDDoSPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgpip`: Anti-DDoS Advanced; `bgp`: Anti-DDoS Pro (single IP); `bgp-multip`: Anti-DDoS Pro (multi-IP), `net`: Anti-DDoS Ultimate
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// Protocol disablement, which must be entered, and the array length must be 1
        /// </summary>
        [JsonProperty("DropOptions")]
        public DDoSPolicyDropOption[] DropOptions{ get; set; }

        /// <summary>
        /// Port disablement. If no ports are to be disabled, enter an empty array
        /// </summary>
        [JsonProperty("PortLimits")]
        public DDoSPolicyPortLimit[] PortLimits{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist. Enter an empty array if there is no IP blocklist/allowlist
        /// </summary>
        [JsonProperty("IpAllowDenys")]
        public IpBlackWhite[] IpAllowDenys{ get; set; }

        /// <summary>
        /// Packet filter. Enter an empty array if there are no packets to filter
        /// </summary>
        [JsonProperty("PacketFilters")]
        public DDoSPolicyPacketFilter[] PacketFilters{ get; set; }

        /// <summary>
        /// Watermarking policy parameter. Enter an empty array if the watermarking feature is not enabled. At most one watermarking policy can be passed in (that is, the size of the array cannot exceed 1)
        /// </summary>
        [JsonProperty("WaterPrint")]
        public WaterPrintPolicy[] WaterPrint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamArrayObj(map, prefix + "DropOptions.", this.DropOptions);
            this.SetParamArrayObj(map, prefix + "PortLimits.", this.PortLimits);
            this.SetParamArrayObj(map, prefix + "IpAllowDenys.", this.IpAllowDenys);
            this.SetParamArrayObj(map, prefix + "PacketFilters.", this.PacketFilters);
            this.SetParamArrayObj(map, prefix + "WaterPrint.", this.WaterPrint);
        }
    }
}

