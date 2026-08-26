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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInterfaces : AbstractModel
    {
        
        /// <summary>
        /// Specifies whether the network interface is primary or secondary. Valid values must be uppercase. The `NetworkInterfaces` array must contain exactly one `PRIMARY` network interface and can contain multiple `SECONDARY` network interfaces. Valid values:<li>`PRIMARY`: Primary network interface.</li><li>`SECONDARY`: Secondary network interface.</li>
        /// </summary>
        [JsonProperty("InterfaceType")]
        public string InterfaceType{ get; set; }

        /// <summary>
        /// VPC ID in the format of `vpc-xxx`. You can obtain a valid VPC ID from the [VPC console](https://console.tencentcloud.com/vpc/vpc?rid=1) or from the `VpcId` field returned by the [DescribeVpcs](https://www.tencentcloud.com/document/product/215/15778) API. If both `VpcId` and `SubnetId` are set to `DEFAULT` when creating an instance, the default VPC is used.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID in the format of `subnet-xxx`. You can obtain a valid subnet ID from the [subnet console](https://console.tencentcloud.com/vpc/subnet) or from the `SubnetId` field returned by the [DescribeSubnets](https://www.tencentcloud.com/document/product/215/15784) API. If both `SubnetId` and `VpcId` are set to `DEFAULT` when creating an instance, the default VPC is used.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Required. Specifies the number of private IPv4 addresses automatically assigned to each network interface. Manually specifying IP addresses and automatically assigning IP addresses at the same time is not supported. Valid range: [1, 50].
        /// </summary>
        [JsonProperty("PrivateIpv4AddressCount")]
        public long? PrivateIpv4AddressCount{ get; set; }

        /// <summary>
        /// ID of an existing elastic network interface (ENI) to be attached. This parameter applies only to secondary network interfaces. The primary network interface is created automatically through the existing process and cannot be specified using this parameter. When an existing ENI is specified, `InstanceCount` must be set to 1.
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// Security groups associated with the instance. You can obtain the security group IDs from the `SecurityGroupId` field returned by the [DescribeSecurityGroups](https://www.tencentcloud.com/document/api/215/15808) API. If this parameter is not specified, the default security group of the specified project is associated. If no default security group exists, one is automatically created. Each user can configure up to 50 security groups per project in each region.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Specifies whether the associated elastic network interface (ENI) is deleted when the CVM instance is terminated. This parameter applies only to secondary network interfaces. By default, secondary network interfaces are retained to preserve the existing behavior. This parameter does not apply to the primary network interface, which is always deleted when the instance is terminated. Default value: `false`.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InterfaceType", this.InterfaceType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "PrivateIpv4AddressCount", this.PrivateIpv4AddressCount);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
        }
    }
}

