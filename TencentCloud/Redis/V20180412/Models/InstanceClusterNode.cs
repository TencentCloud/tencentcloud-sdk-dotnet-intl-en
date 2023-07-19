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

    public class InstanceClusterNode : AbstractModel
    {
        
        /// <summary>
        /// Node name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// ID of the runtime node of an instance
        /// </summary>
        [JsonProperty("RunId")]
        public string RunId{ get; set; }

        /// <summary>
        /// Cluster role. Valid values:  - `0` (master) - `1` (replica)
        /// </summary>
        [JsonProperty("Role")]
        public long? Role{ get; set; }

        /// <summary>
        /// Node status. Valid values:  - `0` (read/write) - `1` (read) - `2` (backup)
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Service status. Valid values: `0` (down), `1` (on).
        /// </summary>
        [JsonProperty("Connected")]
        public long? Connected{ get; set; }

        /// <summary>
        /// Node creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Node elimination time
        /// </summary>
        [JsonProperty("DownTime")]
        public string DownTime{ get; set; }

        /// <summary>
        /// Node slot distribution range
        /// </summary>
        [JsonProperty("Slots")]
        public string Slots{ get; set; }

        /// <summary>
        /// Distribution of node keys
        /// </summary>
        [JsonProperty("Keys")]
        public long? Keys{ get; set; }

        /// <summary>
        /// Node QPS Number of executions per second on sharded nodes Unit: Counts/sec
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// QPS slope of a node
        /// </summary>
        [JsonProperty("QpsSlope")]
        public float? QpsSlope{ get; set; }

        /// <summary>
        /// Node storage
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// Node storage slope
        /// </summary>
        [JsonProperty("StorageSlope")]
        public float? StorageSlope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RunId", this.RunId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Connected", this.Connected);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DownTime", this.DownTime);
            this.SetParamSimple(map, prefix + "Slots", this.Slots);
            this.SetParamSimple(map, prefix + "Keys", this.Keys);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "QpsSlope", this.QpsSlope);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "StorageSlope", this.StorageSlope);
        }
    }
}

