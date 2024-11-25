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

    public class DescribeReserveIpAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of unique IDs of reserved private IP addresses.
        /// </summary>
        [JsonProperty("ReserveIpIds")]
        public string[] ReserveIpIds{ get; set; }

        /// <summary>
        /// Filter criteria. ReserveIpIds and Filters cannot be specified at the same time.
        /// 
        /// reserve-ip-id - String - (Filter criteria) Unique ID of a reserved private IP address, for example, rsvip-pvqgv9vi.
        /// vpc-id - String - (Filter criteria) VPC instance ID, for example, vpc-f49l6u0z.
        /// subnet-id - String - (Filter criteria) Subnet instance ID, for example, subnet-f49l6u0z.
        /// address-ip - String - (Filter criteria) Reserved private IP address, for example, 192.168.0.10.
        /// ip-type - String - (Filter criteria) Business type (IpType), for example, 0.
        /// name - String - (Filter criteria) Name.
        /// state - String - (Filter criteria) Status. Valid values: Bind and UnBind.
        /// resource-id - String - (Filter criteria) Bound instance resource, for example, eni-059qmnif.
        /// tag-key - String - (Filter criteria) Tag key.
        /// tag:tag-key - String - (Filter criteria) Tag key-value pair. Replace tag-key with the specific tag key.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of request objects.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ReserveIpIds.", this.ReserveIpIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

