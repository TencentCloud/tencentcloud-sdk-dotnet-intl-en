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

    public class AssignPrivateIpAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the ENI instance, such as `eni-m6dyj72l`.
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// The information on private IP addresses, of which you can specify a maximum of 10 at a time. You should provide either this parameter or SecondaryPrivateIpAddressCount, or both.
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public PrivateIpAddressSpecification[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// The number of newly-applied private IP addresses. You should provide either this parameter or PrivateIpAddresses, or both. The total number of private IP addresses cannot exceed the quota. For more information, see<a href="/document/product/576/18527">ENI Use Limits</a>.
        /// </summary>
        [JsonProperty("SecondaryPrivateIpAddressCount")]
        public ulong? SecondaryPrivateIpAddressCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamArrayObj(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamSimple(map, prefix + "SecondaryPrivateIpAddressCount", this.SecondaryPrivateIpAddressCount);
        }
    }
}

