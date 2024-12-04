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

    public class InquiryPriceUpgradeInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Shard size. Unit: MB.
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// Number of shards. This parameter is not required for Redis 2.8 Primary-Secondary Edition, CKV Primary-Secondary Edition, and Redis 2.8 Single-node Edition.
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public ulong? RedisShardNum{ get; set; }

        /// <summary>
        /// Number of replicas. This parameter is not required for Redis 2.8 Primary-Secondary Edition, CKV Primary-Secondary Edition, and Redis 2.8 Single-node Edition.
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public ulong? RedisReplicasNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
        }
    }
}

