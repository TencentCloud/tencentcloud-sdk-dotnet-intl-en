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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAvailabilityZonesRequest : AbstractModel
    {
        
        /// <summary>
        /// Specify the instance ID.
        ///  For example: crs-xjhsdj****, please log in to the [Redis Console] (https://console.cloud.tencent.com/redis#/) and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Switch time.
        /// - 1: Switch during the maintenance window.
        /// - 2: Switch immediately.
        /// </summary>
        [JsonProperty("SwitchOption")]
        public long? SwitchOption{ get; set; }

        /// <summary>
        /// Instance node information includes the node ID, node type, and node availability zone ID, and so on. For specific information, please see [RedisNodeInfo ](https://intl.cloud.tencent.com/document/product/239/20022?from_cn_redirect=1).
        /// For instances in a single availability zone, there is no need to configure the NodeId. For instances in multiple availability zones, the NodeId is required to configure.
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SwitchOption", this.SwitchOption);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
        }
    }
}

