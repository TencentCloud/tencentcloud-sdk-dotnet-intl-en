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

    public class CreateNetworkInterfaceRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the VPC instance. You can obtain the parameter value from the VpcId field in the returned result of DescribeVpcs API.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The name of the ENI. The maximum length is 60 characters.
        /// </summary>
        [JsonProperty("NetworkInterfaceName")]
        public string NetworkInterfaceName{ get; set; }

        /// <summary>
        /// The subnet instance ID of the ENI, such as `subnet-0ap8nwca`.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// ENI description can be named freely, but the maximum length is 60 characters.
        /// </summary>
        [JsonProperty("NetworkInterfaceDescription")]
        public string NetworkInterfaceDescription{ get; set; }

        /// <summary>
        /// The number of private IP addresses you apply for. The total number of private IP addresses cannot exceed the quota.
        /// </summary>
        [JsonProperty("SecondaryPrivateIpAddressCount")]
        public ulong? SecondaryPrivateIpAddressCount{ get; set; }

        /// <summary>
        /// IP service level. It’s used in combination with `SecondaryPrivateIpAddressCount`. Values: `PT` (Gold), `AU` (Silver), `AG` (Bronze) and `DEFAULT`
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// Specifies the security group to be bound with, such as ['sg-1dd51d'].
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// The information of the specified private IPs. You can specify a maximum of 10 each time.
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public PrivateIpAddressSpecification[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// Bound tags, such as [{"Key": "city", "Value": "shanghai"}].
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Configuration of the ENI trunking mode. Valid values: `Enable` and `Disable`. Default value: `Disable`.
        /// </summary>
        [JsonProperty("TrunkingFlag")]
        public string TrunkingFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceName", this.NetworkInterfaceName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceDescription", this.NetworkInterfaceDescription);
            this.SetParamSimple(map, prefix + "SecondaryPrivateIpAddressCount", this.SecondaryPrivateIpAddressCount);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArrayObj(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TrunkingFlag", this.TrunkingFlag);
        }
    }
}

