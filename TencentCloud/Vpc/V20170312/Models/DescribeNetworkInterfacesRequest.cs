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
        /// Filter. `NetworkInterfaceIds` and `Filters` cannot be specified at the same time.
        /// <li>`vpc-id` - String - VPC instance ID, such as `vpc-f49l6u0z`.</li>
        /// <li>`subnet-id` - String - Subnet instance ID, such as `subnet-f49l6u0z`.</li>
        /// <li>`network-interface-id` - String - ENI instance ID, such as `eni-5k56k7k7`.</li>
        /// <li>`attachment.instance-id` - String - ID of the bound CVM instance, such as `ins-3nqpdn3i`.</li>
        /// <li>`groups.security-group-id` - String - ID of the bound security group, such as `sg-f9ekbxeq`.</li>
        /// <li>`network-interface-name` - String - ENI instance name.</li>
        /// <li>`network-interface-description` - String - ENI instance description.</li>
        /// <li>`address-ip` - String - Private IPv4 address. A single IP will be fuzzily matched with the suffix, while multiple IPs will be exactly matched. It can be used with `ip-exact-match` to query and exactly match a single IP.</li>
        /// <li>`ip-exact-match` - Boolean - Exact match by private IPv4 address. The first value will be returned if multiple values are found.</li>
        /// <li>`tag-key` - String - Optional - Filter by tag key. See Example 2 for the detailed usage.</li>
        /// <li>`tag:tag-key` - String - Optional - Filter by tag key pair. Use a specific tag key to replace `tag-key`. See Example 3 for the detailed usage.</li>
        /// <li>`is-primary` - Boolean - Optional - Filter based on whether it is a primary ENI. If the value is `true`, filter only the primary ENI. If the value is `false`, filter only the secondary ENI. If this parameter is not specified, filter the both.</li>
        /// <li>`eni-type` - String - Optional - Filter by ENI type. "0" - secondary ENI, "1" - primary ENI, "2": relayed ENI</li>
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
            this.SetParamArraySimple(map, prefix + "NetworkInterfaceIds.", this.NetworkInterfaceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

