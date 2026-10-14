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

    public class DescribeInstanceLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Log type. Default value: 1.
        /// <li>1, master log</li>
        /// <li>2. Search slow logs</li>
        /// <li>3. Index slow log</li>
        /// <li>4. GC log</li>
        /// </summary>
        [JsonProperty("LogType")]
        public ulong? LogType{ get; set; }

        /// <summary>
        /// Search term. LUCENE grammar is supported, for example, level:WARN, ip:1.1.1.1, message:test-index
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Log start time in the format of YYYY-MM-DD HH:MM:SS, for example, 2019-01-22 20:15:53
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Log end time in the format of YYYY-MM-DD HH:MM:SS, for example, 2019-01-22 20:15:53
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Pagination starting value. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Pagination size. Default value: 100. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Time sort method. Default value: 0.
        /// <li>0: descending order</li>
        /// <li>1, ascending</li>
        /// </summary>
        [JsonProperty("OrderByType")]
        public ulong? OrderByType{ get; set; }

        /// <summary>
        /// Log level
        /// </summary>
        [JsonProperty("LogLevels")]
        public string[] LogLevels{ get; set; }

        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("NodeIds")]
        public string[] NodeIds{ get; set; }

        /// <summary>
        /// Slow log index name
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// Slow log index shards
        /// </summary>
        [JsonProperty("ShardId")]
        public string ShardId{ get; set; }

        /// <summary>
        /// Slow log query time
        /// </summary>
        [JsonProperty("QueryCost")]
        public ulong? QueryCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
            this.SetParamArraySimple(map, prefix + "LogLevels.", this.LogLevels);
            this.SetParamArraySimple(map, prefix + "NodeIds.", this.NodeIds);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "ShardId", this.ShardId);
            this.SetParamSimple(map, prefix + "QueryCost", this.QueryCost);
        }
    }
}

