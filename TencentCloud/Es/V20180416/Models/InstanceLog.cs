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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceLog : AbstractModel
    {
        
        /// <summary>
        /// Log time
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Log level
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Cluster node IP address.
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Log content
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Cluster node ID.
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// Slow log index name
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// Slow log index shards
        /// </summary>
        [JsonProperty("Shard")]
        public string Shard{ get; set; }

        /// <summary>
        /// Slow log index query time
        /// </summary>
        [JsonProperty("QueryCost")]
        public string QueryCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "Shard", this.Shard);
            this.SetParamSimple(map, prefix + "QueryCost", this.QueryCost);
        }
    }
}

