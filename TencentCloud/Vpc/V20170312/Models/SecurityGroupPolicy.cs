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

    public class SecurityGroupPolicy : AbstractModel
    {
        
        /// <summary>
        /// The index number of security group rules, which dynamically changes with the rules. This parameter can be obtained via the `DescribeSecurityGroupPolicies` API and used with the `Version` field in the returned value of the API.
        /// </summary>
        [JsonProperty("PolicyIndex")]
        public long? PolicyIndex{ get; set; }

        /// <summary>
        /// Protocol. Valid values: TCP, UDP, ICMP, ICMPv6, ALL.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Port (`all`, a single port, or a port range).
        /// Note: If the `Protocol` value is set to `ALL`, the `Port` value also needs to be set to `all`.
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Protocol port ID or protocol port group ID. ServiceTemplate and Protocol+Port are mutually exclusive.
        /// </summary>
        [JsonProperty("ServiceTemplate")]
        public ServiceTemplateSpecification ServiceTemplate{ get; set; }

        /// <summary>
        /// Either `CidrBlock` or `Ipv6CidrBlock can be specified. Note that if `0.0.0.0/n` is entered, it is mapped to 0.0.0.0/0.
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// The CIDR block or IPv6 (mutually exclusive).
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// The security group instance ID, such as `sg-ohuuioma`.
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// IP address ID or IP address group ID.
        /// </summary>
        [JsonProperty("AddressTemplate")]
        public AddressTemplateSpecification AddressTemplate{ get; set; }

        /// <summary>
        /// ACCEPT or DROP.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Security group policy description.
        /// </summary>
        [JsonProperty("PolicyDescription")]
        public string PolicyDescription{ get; set; }

        /// <summary>
        /// The last modification time of the security group.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyIndex", this.PolicyIndex);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamObj(map, prefix + "ServiceTemplate.", this.ServiceTemplate);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Ipv6CidrBlock", this.Ipv6CidrBlock);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamObj(map, prefix + "AddressTemplate.", this.AddressTemplate);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "PolicyDescription", this.PolicyDescription);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

