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

    public class DescribeNetworkInterfacesRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries the ID of the ENI instance, such as `eni-pxir56ns`. Each request can have a maximum of 100 instances. `NetworkInterfaceIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("NetworkInterfaceIds")]
        public string[] NetworkInterfaceIds{ get; set; }

        /// <summary>
        /// Filter condition. `NetworkInterfaceIds` and `Filters` cannot be specified at the same time.
        /// <li>vpc-id - String - (Filter condition) VPC instance ID, such as `vpc-f49l6u0z`.</li>
        /// <li>subnet-id - String - (Filter condition) Subnet instance ID, such as `subnet-f49l6u0z`.</li>
        /// <li>network-interface-id - String - (Filter condition) ENI instance ID, such as `eni-5k56k7k7`.</li>
        /// <li>attachment.instance-id - String - (Filter condition) CVM instance ID, such as `ins-3nqpdn3i`.</li>
        /// <li>groups.security-group-id - String - (Filter condition) Instance ID of the security group, such as `sg-f9ekbxeq`.</li>
        /// <li>network-interface-name - String - (Filter condition) ENI instance name.</li>
        /// <li>network-interface-description - String - (Filter condition) ENI instance description.</li>
        /// <li>address-ip - String - (Filter condition) Private IPv4 address.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. The default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of values to be returned. The default value is 20. Maximum is 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NetworkInterfaceIds.", this.NetworkInterfaceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

