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

    public class DescribeNatGatewaysRequest : AbstractModel
    {
        
        /// <summary>
        /// The unified ID of the NAT gateways, such as `nat-123xx454`.
        /// </summary>
        [JsonProperty("NatGatewayIds")]
        public string[] NatGatewayIds{ get; set; }

        /// <summary>
        /// Filters. `NatGatewayIds` and `Filters` cannot be specified at the same time.
        /// <li>nat-gateway-id - String - (Filter) The ID of the protocol port template instance, such as `nat-123xx454`.</li>
        /// <li>vpc-id - String - (Filter) The unique ID of the VPC, such as `vpc-123xx454`.</li>
        /// <li>nat-gateway-name - String - (Filter) The ID of the protocol port template instance, such as `test_nat`.</li>
        /// <li>tag-key - String - (Filter) The tag key, such as `test-key`.</li>
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

