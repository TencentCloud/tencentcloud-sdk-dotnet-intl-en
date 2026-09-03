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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInterface : AbstractModel
    {
        
        /// <summary>
        /// <p>Network interface card type. This field is required in the request for each network interface.</p><p>Enumeration values:</p><ul><li>PRIMARY: Primary network interface</li><li>SECONDARY: Auxiliary network interface</li></ul><p>When configuring upper-level NetworkInterfaces, the array must explicitly contain and can only contain one PRIMARY. AS does not auto-complete the primary network interface.</p>
        /// </summary>
        [JsonProperty("InterfaceType")]
        public string InterfaceType{ get; set; }

        /// <summary>
        /// <p>Total number of private IPv4 addresses requested for the network interface card, including the primary IP.</p><p>Value range: [1, 40]</p><p>Required for SECONDARY network interface card requests; optional for PRIMARY network interface card requests. If left empty, it is processed as 1 only when constructing a CVM request copy during actual scaling, and is not written back to the launch configuration. The explicitly passed in value is passed through to CVM by AS, and finally validated by CVM/VPC.</p>
        /// </summary>
        [JsonProperty("PrivateIpv4AddressCount")]
        public long? PrivateIpv4AddressCount{ get; set; }

        /// <summary>
        /// <p>List of security group IDs bound to the ENI.</p><p>Input limit: up to 10.</p><p>For PRIMARY, a non-empty list explicitly configured in the network interface takes precedence over the SecurityGroupIds parameter in the launch configuration; if not configured in the network interface, the SecurityGroupIds parameter in the launch configuration is used. If neither is configured, AS does not specify security groups and proceeds with the CVM default rule. For SECONDARY, only the non-empty list explicitly configured in the network interface is passed through, and the SecurityGroupIds parameter in the launch configuration is not inherited.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>Whether to reserve the auxiliary network interface when instance is terminated. Only applicable to SECONDARY.</p><p>Enumeration values:</p><ul><li>false: Do not retain the auxiliary network interface. It will destroy with the instance.</li><li>true: Retain the auxiliary network interface.</li></ul><p>Default value: false</p><p>PRIMARY does not allow configuration of true.</p>
        /// </summary>
        [JsonProperty("IsKeepENI")]
        public bool? IsKeepENI{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InterfaceType", this.InterfaceType);
            this.SetParamSimple(map, prefix + "PrivateIpv4AddressCount", this.PrivateIpv4AddressCount);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "IsKeepENI", this.IsKeepENI);
        }
    }
}

