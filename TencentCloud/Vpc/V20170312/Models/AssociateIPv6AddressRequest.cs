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

    public class AssociateIPv6AddressRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the EIPv6, such as eipv6-11112222.
        /// </summary>
        [JsonProperty("IPv6AddressId")]
        public string IPv6AddressId{ get; set; }

        /// <summary>
        /// ID of the ENI to be bound, such as eni-11112222. NetworkInterfaceId and InstanceId cannot be specified at the same time. The ENI ID can be queried by logging in to the console or obtained from the networkInterfaceId field in the returned value of the DescribeNetworkInterfaces API.
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// Private IPv6 to be bound. If NetworkInterfaceId is specified, PrivateIPv6Address must also be specified, which indicates that the EIP will be bound to the specified private IPv6 of the specified ENI. At the same time, it shall be ensured that the specified PrivateIPv6Address is a private IPv6 on the specified NetworkInterfaceId. The specified ENI's private IPv6 can be queried by logging in to the console or obtained from the Ipv6AddressSet.Address field in the returned value of the DescribeNetworkInterfaces API.
        /// </summary>
        [JsonProperty("PrivateIPv6Address")]
        public string PrivateIPv6Address{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPv6AddressId", this.IPv6AddressId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateIPv6Address", this.PrivateIPv6Address);
        }
    }
}

