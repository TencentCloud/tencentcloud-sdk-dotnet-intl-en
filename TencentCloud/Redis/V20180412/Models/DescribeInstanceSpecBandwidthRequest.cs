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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceSpecBandwidthRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Specify the instance ID. Log in to the <a href="https://console.cloud.tencent.com/redis">Redis console</a> and copy the instance ID from the instance list. Meanwhile, InstanceId and specification parameters cannot be empty at the same time. Provide at least one.</p><ul><li>If only InstanceId is specified: Query the bandwidth of the current instance.</li><li>If InstanceId and at least one specification parameter (ShardSize, ShardNum, or ReplicateNum) are specified: Calculate the bandwidth after specification modification.</li><li>If partial or all specification parameters (ShardSize, ShardNum, ReplicateNum, and Type) are specified without InstanceId: Query the theoretical bandwidth based on the combined query of specifications.</li></ul>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Shard size. Unit: MB.</p>
        /// </summary>
        [JsonProperty("ShardSize")]
        public long? ShardSize{ get; set; }

        /// <summary>
        /// <p>Number of shards.</p>
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// <p>Number of replication groups.</p>
        /// </summary>
        [JsonProperty("ReplicateNum")]
        public long? ReplicateNum{ get; set; }

        /// <summary>
        /// <p>Read-only weight. - 100: Enable read-only slave. - 0: Disable read-only slave.</p>
        /// </summary>
        [JsonProperty("ReadOnlyWeight")]
        public long? ReadOnlyWeight{ get; set; }

        /// <summary>
        /// <p>Instance type, same as Type in <a href="https://www.tencentcloud.com/document/api/239/20026?from_cn_redirect=1">CreateInstances</a>.</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ShardSize", this.ShardSize);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "ReplicateNum", this.ReplicateNum);
            this.SetParamSimple(map, prefix + "ReadOnlyWeight", this.ReadOnlyWeight);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

