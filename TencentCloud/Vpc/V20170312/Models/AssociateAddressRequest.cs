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

    public class AssociateAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// The unique ID of the EIP, such as `eip-11112222`.
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// The ID of the instance to be bound, such as `ins-11112222`. You can query the instance ID by logging into the [Console](https://console.cloud.tencent.com/cvm). You can also obtain the parameter value from the `InstanceId` field in the returned result of [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The ID of the ENI to be bonud, such as `eni-11112222`. `NetworkInterfaceId` and `InstanceId` cannot be specified at the same time. You can query the ENI ID by logging into the [Console](https://console.cloud.tencent.com/vpc/eni). You can also obtain the parameter value from the `networkInterfaceId` field in the returned result of [DescribeNetworkInterfaces](https://intl.cloud.tencent.com/document/api/215/15817?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// The private IP to be bound. If you specify `NetworkInterfaceId`, then you must also specify `PrivateIpAddress`, indicating the EIP is bound to the specified private IP of the specified ENI. At the same time, you must ensure the specified `PrivateIpAddress` is a private IP on the `NetworkInterfaceId`. You can query the private IP of the specified ENI by logging into the [Console](https://console.cloud.tencent.com/vpc/eni). You can also obtain the parameter value from the `privateIpAddress` field in the returned result of [DescribeNetworkInterfaces](https://intl.cloud.tencent.com/document/api/215/15817?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }

        /// <summary>
        /// Whether to enable direct access when binding a specified EIP. For more information, see [EIP Direct Access](https://intl.cloud.tencent.com/document/product/1199/41709?from_cn_redirect=1). Valid values: `True` and `False`; default value: `False`. You can set this parameter to `True` when binding an EIP to a CVM instance or an EKS elastic cluster. This parameter is currently in beta. To use it, please [submit a ticket](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20CLB&level3_id=1071&queue=96&scene_code=34639&step=2).
        /// </summary>
        [JsonProperty("EipDirectConnection")]
        public bool? EipDirectConnection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
            this.SetParamSimple(map, prefix + "EipDirectConnection", this.EipDirectConnection);
        }
    }
}

