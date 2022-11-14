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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcDnsInfo : AbstractModel
    {
        
        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// NAT firewall mode. 0: Create new; 1: Use existing
        /// </summary>
        [JsonProperty("FwMode")]
        public long? FwMode{ get; set; }

        /// <summary>
        /// VPC IPv4 CIDR block (Classless Inter-Domain Routing)
        /// </summary>
        [JsonProperty("VpcIpv4Cidr")]
        public string VpcIpv4Cidr{ get; set; }

        /// <summary>
        /// Public EIP, which is the firewall DNS resolution address
        /// </summary>
        [JsonProperty("DNSEip")]
        public string DNSEip{ get; set; }

        /// <summary>
        /// NAT gateway ID
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("NatInsId")]
        public string NatInsId{ get; set; }

        /// <summary>
        /// NAT gateway name
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("NatInsName")]
        public string NatInsName{ get; set; }

        /// <summary>
        /// 0: off; 1: on
        /// </summary>
        [JsonProperty("SwitchStatus")]
        public long? SwitchStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "FwMode", this.FwMode);
            this.SetParamSimple(map, prefix + "VpcIpv4Cidr", this.VpcIpv4Cidr);
            this.SetParamSimple(map, prefix + "DNSEip", this.DNSEip);
            this.SetParamSimple(map, prefix + "NatInsId", this.NatInsId);
            this.SetParamSimple(map, prefix + "NatInsName", this.NatInsName);
            this.SetParamSimple(map, prefix + "SwitchStatus", this.SwitchStatus);
        }
    }
}

