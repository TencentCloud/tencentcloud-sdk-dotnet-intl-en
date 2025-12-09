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

    public class CurrentOp : AbstractModel
    {
        
        /// <summary>
        /// Operation number.
        /// </summary>
        [JsonProperty("OpId")]
        public long? OpId{ get; set; }

        /// <summary>
        /// Namespace where the operation is located, in the format of db.collection.
        /// </summary>
        [JsonProperty("Ns")]
        public string Ns{ get; set; }

        /// <summary>
        /// Execution statement of the operation.
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Operation type.
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
        /// Name of the shard where the operation is performed.
        /// </summary>
        [JsonProperty("ReplicaSetName")]
        public string ReplicaSetName{ get; set; }

        /// <summary>
        /// Name of the node where the operation is performed.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Detailed information about the operation.
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// Node role.
        /// - primary: primary node.
        /// - secondary: secondary node.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Execution time of the operation, in ms.
        /// </summary>
        [JsonProperty("MicrosecsRunning")]
        public ulong? MicrosecsRunning{ get; set; }

        /// <summary>
        /// Information about the node where the current operation is performed.
        /// </summary>
        [JsonProperty("ExecNode")]
        public string ExecNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpId", this.OpId);
            this.SetParamSimple(map, prefix + "Ns", this.Ns);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Op", this.Op);
            this.SetParamSimple(map, prefix + "ReplicaSetName", this.ReplicaSetName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "MicrosecsRunning", this.MicrosecsRunning);
            this.SetParamSimple(map, prefix + "ExecNode", this.ExecNode);
        }
    }
}

