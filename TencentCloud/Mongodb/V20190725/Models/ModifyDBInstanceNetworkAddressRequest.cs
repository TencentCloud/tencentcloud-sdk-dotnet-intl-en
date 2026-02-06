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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceNetworkAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the ID of the instance for modifying the network. For example, cmgo-p8vn****. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/MongoDB) and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Retention period of the original IP address.
        ///  - Unit: minutes. 0 means that the IP address is immediately repossessed.
        ///  - The original IP address will be released after a scheduled period. Both the original and new IP addresses are accessible before release.
        /// </summary>
        [JsonProperty("OldIpExpiredTime")]
        public ulong? OldIpExpiredTime{ get; set; }

        /// <summary>
        /// VPC ID after the switch. If the instance is using a basic network, this field is not required. The [DescribeDBInstances](https://www.tencentcloud.com/document/product/240/38568?from_cn_redirect=1) API can be called to obtain the VPC ID.
        /// </summary>
        [JsonProperty("NewUniqVpcId")]
        public string NewUniqVpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID after the switch. If the instance is using a basic network, this field is not required. The [DescribeDBInstances](https://www.tencentcloud.com/document/product/240/38568?from_cn_redirect=1) API can be called to obtain the subnet ID of the VPC.
        /// </summary>
        [JsonProperty("NewUniqSubnetId")]
        public string NewUniqSubnetId{ get; set; }

        /// <summary>
        /// IP address information, including the new IP address and the original IP address.
        /// </summary>
        [JsonProperty("NetworkAddresses")]
        public ModifyNetworkAddress[] NetworkAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OldIpExpiredTime", this.OldIpExpiredTime);
            this.SetParamSimple(map, prefix + "NewUniqVpcId", this.NewUniqVpcId);
            this.SetParamSimple(map, prefix + "NewUniqSubnetId", this.NewUniqSubnetId);
            this.SetParamArrayObj(map, prefix + "NetworkAddresses.", this.NetworkAddresses);
        }
    }
}

