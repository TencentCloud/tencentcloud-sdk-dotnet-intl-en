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

    public class InquirePriceModifyDBInstanceSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. For example, cmgo-p8vn****. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance memory size after configuration changes, in GB. The [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1) API can be called to obtain the specific sales specifications for memory.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance disk size after configuration changes, in GB. The [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1) API can be called to obtain the maximum and minimum disk sizes corresponding to each CPU specification.
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// Number of instance nodes. The [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1) API can be called to obtain the number of instance nodes.
        /// - Replica set instance, which refers to the number of primary and secondary nodes for the instance after configuration changes.
        /// - Sharded cluster instance, which refers to the number of primary and secondary nodes per shard for the instance after configuration changes.
        /// **Note**: Do not initiate tasks of adjusting the number of nodes and shards and the node specifications simultaneously.
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// Sharded cluster instance, which refers to the number of shards for the instance after configuration changes. Value range: [2, 36].
        /// **Note**: The number of shards after changes cannot be less than the current number. Do not initiate tasks of adjusting the number of nodes and shards and the node specifications simultaneously.
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public long? ReplicateSetNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "ReplicateSetNum", this.ReplicateSetNum);
        }
    }
}

