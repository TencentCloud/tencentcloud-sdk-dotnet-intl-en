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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstancesVpcAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID(s). To obtain the instance IDs, you can call [`DescribeInstances`](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) and look for `InstanceId` in the response.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// VPC configurations. You can use this parameter to specify the VPC ID, subnet ID, VPC IP, etc. If the specified VPC ID and subnet ID (the subnet must be in the same availability zone as the instance) are different from the VPC where the specified instance resides, the instance will be migrated to a subnet of the specified VPC. You can use `PrivateIpAddresses` to specify the VPC subnet IP. If you want to specify the subnet IP, you will need to specify a subnet IP for each of the specified instances, and each `InstanceIds` will match a `PrivateIpAddresses`. If `PrivateIpAddresses` is not specified, the VPC subnet IP will be assigned randomly.
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// Whether to force shut down a running instances. Default value: TRUE.
        /// </summary>
        [JsonProperty("ForceStop")]
        public bool? ForceStop{ get; set; }

        /// <summary>
        /// Whether to keep the host name. Default value: FALSE.
        /// </summary>
        [JsonProperty("ReserveHostName")]
        public bool? ReserveHostName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "ForceStop", this.ForceStop);
            this.SetParamSimple(map, prefix + "ReserveHostName", this.ReserveHostName);
        }
    }
}

