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

    public class DescribeCurrentOpRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the instance ID to be queried. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Namespace where the operation belongs, in the format of db.collection.
        /// </summary>
        [JsonProperty("Ns")]
        public string Ns{ get; set; }

        /// <summary>
        /// Sets the query and filtering condition to the execution time of the operation task.
        /// - The default value is 0, and the value range is [0, 3600000], in milliseconds.
        /// - The result will return the operation whose execution time exceeds the set time.
        /// </summary>
        [JsonProperty("MillisecondRunning")]
        public ulong? MillisecondRunning{ get; set; }

        /// <summary>
        /// Sets the query and filtering condition to the type of the operation task. Valid values:
        /// - none: special status; idle connections or internal tasks.
        /// - update: update data.
        /// - insert: insertion operation.
        /// - query: query operation.
        /// - command: command operation.
        /// - getmore: obtain more data.
        /// - remove: deletion operation.
        /// - killcursors: operation of releasing the query cursor.
        /// </summary>
        [JsonProperty("Op")]
        public string Op{ get; set; }

        /// <summary>
        /// Filtering condition, such as the shard name.
        /// </summary>
        [JsonProperty("ReplicaSetName")]
        public string ReplicaSetName{ get; set; }

        /// <summary>
        /// Sets the query and filtering condition to the node role.
        /// - primary: primary node.
        /// - secondary: secondary node.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Number of entries returned per request. The default value is 100, and the value range is [0, 100].
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. The default value is 0, and the value range is [0, 10000].
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sorting field of the returned result set. Currently, sorting by MicrosecsRunning (execution time of the operation task) is supported.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Sorting method of the returned result set.
        /// - ASC: ascending order. The default value is ASC, which indicates sorting in ascending order.
        /// - DESC: descending order.
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Ns", this.Ns);
            this.SetParamSimple(map, prefix + "MillisecondRunning", this.MillisecondRunning);
            this.SetParamSimple(map, prefix + "Op", this.Op);
            this.SetParamSimple(map, prefix + "ReplicaSetName", this.ReplicaSetName);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

