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

    public class ModifyCCThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgpip`: Anti-DDoS Advanced, `bgp`: Anti-DDoS Pro (single IP), `bgp-multip`: Anti-DDoS Pro (multi-IP), `net`: Anti-DDoS Ultimate, `basic`: Anti-DDoS Basic
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// CC protection threshold. Valid values: (0 100 150 240 350 480 550 700 850 1000 1500 2000 3000 5000 10000 20000);
        /// If `Business` is Anti-DDoS Advanced or Anti-DDoS Ultimate, its maximum CC protection threshold is subject to the base protection bandwidth in the following way:
        ///   Base bandwidth: maximum CC protection threshold
        ///   10:  20000,
        ///   20:  40000,
        ///   30:  70000,
        ///   40:  100000,
        ///   50:  150000,
        ///   60:  200000,
        ///   80:  250000,
        ///   100: 300000,
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// Anti-DDoS instance ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// CC protection type, which is optional. Valid values: [http (HTTP CC protection), https (HTTPS CC protection)]; if this field is left empty, HTTPS CC protection will be used by default; if `https` is entered, the `RuleId` field is required;
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// HTTPS layer-7 forwarding rule ID (which is optional and can be obtained from the layer-7 forwarding rule API);
        /// Required if `Protocol` is `https`;
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Queried IP address (only provided by Anti-DDoS Basic), such as 1.1.1.1
        /// </summary>
        [JsonProperty("BasicIp")]
        public string BasicIp{ get; set; }

        /// <summary>
        /// IP region (only provided for Anti-DDoS Basic). Valid values: region abbreviations such as gz, bj, sh, and hk
        /// </summary>
        [JsonProperty("BasicRegion")]
        public string BasicRegion{ get; set; }

        /// <summary>
        /// Zone type (only provided for Anti-DDoS Basic). Valid values: public (public cloud zone), bm (BM zone), nat (NAT server zone), channel (internet channel).
        /// </summary>
        [JsonProperty("BasicBizType")]
        public string BasicBizType{ get; set; }

        /// <summary>
        /// Device type (only provided for Anti-DDoS Basic). Valid values: cvm (CVM), clb (public CLB), lb (BM CLB), nat (NAT server), channel (internet channel).
        /// </summary>
        [JsonProperty("BasicDeviceType")]
        public string BasicDeviceType{ get; set; }

        /// <summary>
        /// IPInstance Nat gateway (only provided for Anti-DDoS Basic), which is optional. (If the device type to be queried is a NAT server, this parameter is required, which can be obtained through the NAT resource query API)
        /// </summary>
        [JsonProperty("BasicIpInstance")]
        public string BasicIpInstance{ get; set; }

        /// <summary>
        /// ISP line (only provided for Anti-DDoS Basic), which is optional. (If the device type to be queried is a NAT server, this parameter should be 5)
        /// </summary>
        [JsonProperty("BasicIspCode")]
        public ulong? BasicIspCode{ get; set; }

        /// <summary>
        /// This optional field must be specified when HTTPS protocol is used.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "BasicIp", this.BasicIp);
            this.SetParamSimple(map, prefix + "BasicRegion", this.BasicRegion);
            this.SetParamSimple(map, prefix + "BasicBizType", this.BasicBizType);
            this.SetParamSimple(map, prefix + "BasicDeviceType", this.BasicDeviceType);
            this.SetParamSimple(map, prefix + "BasicIpInstance", this.BasicIpInstance);
            this.SetParamSimple(map, prefix + "BasicIspCode", this.BasicIspCode);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

