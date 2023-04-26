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

    public class InstanceClusterShard : AbstractModel
    {
        
        /// <summary>
        /// The name of a shard node
        /// </summary>
        [JsonProperty("ShardName")]
        public string ShardName{ get; set; }

        /// <summary>
        /// The serial number of a shard node
        /// </summary>
        [JsonProperty("ShardId")]
        public string ShardId{ get; set; }

        /// <summary>
        /// The role of a shard node
        /// - `0`: Master node.
        /// - `1`: Replica node.
        /// </summary>
        [JsonProperty("Role")]
        public long? Role{ get; set; }

        /// <summary>
        /// Number of keys
        /// </summary>
        [JsonProperty("Keys")]
        public long? Keys{ get; set; }

        /// <summary>
        /// Slot information
        /// </summary>
        [JsonProperty("Slots")]
        public string Slots{ get; set; }

        /// <summary>
        /// Used Capacity
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// Capacity slope
        /// </summary>
        [JsonProperty("StorageSlope")]
        public float? StorageSlope{ get; set; }

        /// <summary>
        /// Instance runtime node ID
        /// </summary>
        [JsonProperty("Runid")]
        public string Runid{ get; set; }

        /// <summary>
        /// Service status
        /// - `0`: Down.
        /// - `1`: On.
        /// </summary>
        [JsonProperty("Connected")]
        public long? Connected{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShardName", this.ShardName);
            this.SetParamSimple(map, prefix + "ShardId", this.ShardId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Keys", this.Keys);
            this.SetParamSimple(map, prefix + "Slots", this.Slots);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "StorageSlope", this.StorageSlope);
            this.SetParamSimple(map, prefix + "Runid", this.Runid);
            this.SetParamSimple(map, prefix + "Connected", this.Connected);
        }
    }
}

