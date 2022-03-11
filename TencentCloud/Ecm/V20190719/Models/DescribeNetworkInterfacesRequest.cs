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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNetworkInterfacesRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries the ID of the ENI instance, such as `eni-pxir56ns`. Each request supports a maximum of 100 instances. `NetworkInterfaceIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("NetworkInterfaceIds")]
        public string[] NetworkInterfaceIds{ get; set; }

        /// <summary>
        /// Filter. `NetworkInterfaceIds` and `Filters` cannot be specified at the same time.
        /// vpc-id - String - (Filter) VPC instance ID, such as `vpc-f49l6u0z`.
        /// subnet-id - String - (Filter) Subnet instance ID, such as `subnet-f49l6u0z`.
        /// network-interface-id - String - (Filter) ENI instance ID, such as `eni-5k56k7k7`.
        /// attachment.instance-id - String - (Filter) ID of the bound CVM instance, such as `ein-3nqpdn3i`.
        /// groups.security-group-id - String - (Filter) ID of the bound security group instance, such as `sg-f9ekbxeq`.
        /// network-interface-name - String - (Filter) ENI instance name.
        /// network-interface-description - String - (Filter) ENI instance description.
        /// address-ip - String - (Filter) Private IPv4 address.
        /// tag-key - String - Required: no - (Filter) Filter by tag key. For directions, see Sample 2.
        /// tag:tag-key - String - Required: no - (Filter) Filter by tag key-value pair. Replace `tag-key` with the specific tag key. For directions, see Sample 3.
        /// is-primary - Boolean - Required: no - (Filter) Filter by whether it is a primary ENI. true: filter only by primary ENI; false: filter only by secondary ENI. If this parameter is not specified, filtering by both primary and secondary ENIs will be used.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// ECM region, such as `ap-xian-ecm`.
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NetworkInterfaceIds.", this.NetworkInterfaceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
        }
    }
}

