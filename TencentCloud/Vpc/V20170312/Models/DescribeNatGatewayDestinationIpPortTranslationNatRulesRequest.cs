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

    public class DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT gateway ID.
        /// </summary>
        [JsonProperty("NatGatewayIds")]
        public string[] NatGatewayIds{ get; set; }

        /// <summary>
        /// Filters:
        /// `NatGatewayIds` and `Filters` cannot be specified at the same time.
        /// <li> `nat-gateway-id`: The NAT gateway ID, such as `nat-0yi4hekt`.</li>
        /// <li> `vpc-id`: The VPC ID, such as `vpc-0yi4hekt`.</li>
        /// <li> `public-ip-address`: The EIP, such as `139.199.232.238`.</li>
        /// <li>`public-port`: The public network port.</li>
        /// <li>`private-ip-address`: The private IP, such as `10.0.0.1`.</li>
        /// <li>`private-port`. The private network port.</li>
        /// <li>`description`. The rule description.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NatGatewayIds.", this.NatGatewayIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

