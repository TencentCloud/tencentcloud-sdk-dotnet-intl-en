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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowLogData : AbstractModel
    {
        
        /// <summary>
        /// <p>Sql execution time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// <p>Sql execution duration (seconds)</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QueryTime")]
        public float? QueryTime{ get; set; }

        /// <summary>
        /// <p>Sql statement</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// <p>Client IP address</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserHost")]
        public string UserHost{ get; set; }

        /// <summary>
        /// <p>Username.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Database name.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// <p>Lock duration (seconds)</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LockTime")]
        public float? LockTime{ get; set; }

        /// <summary>
        /// <p>Number of scanned rows</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RowsExamined")]
        public ulong? RowsExamined{ get; set; }

        /// <summary>
        /// <p>Result set row count</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RowsSent")]
        public ulong? RowsSent{ get; set; }

        /// <summary>
        /// <p>Transaction ID</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// <p>rpc duration</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RpcTime")]
        public float? RpcTime{ get; set; }

        /// <summary>
        /// <p>rpc duration for node interaction with storage</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageRpcTime")]
        public float? StorageRpcTime{ get; set; }

        /// <summary>
        /// <p>rpc retry latency</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RpcRetryDelayTime")]
        public float? RpcRetryDelayTime{ get; set; }

        /// <summary>
        /// <p>node Name</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>rpc link tracing</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RpcTrace")]
        public string RpcTrace{ get; set; }

        /// <summary>
        /// <p>TDStore lock duration</p><p>Unit: seconds</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TDStoreLockTime")]
        public float? TDStoreLockTime{ get; set; }

        /// <summary>
        /// <p>Global ID</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }

        /// <summary>
        /// <p>Execution plan</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Explain")]
        public Explain[] Explain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "UserHost", this.UserHost);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "LockTime", this.LockTime);
            this.SetParamSimple(map, prefix + "RowsExamined", this.RowsExamined);
            this.SetParamSimple(map, prefix + "RowsSent", this.RowsSent);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "RpcTime", this.RpcTime);
            this.SetParamSimple(map, prefix + "StorageRpcTime", this.StorageRpcTime);
            this.SetParamSimple(map, prefix + "RpcRetryDelayTime", this.RpcRetryDelayTime);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "RpcTrace", this.RpcTrace);
            this.SetParamSimple(map, prefix + "TDStoreLockTime", this.TDStoreLockTime);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
            this.SetParamArrayObj(map, prefix + "Explain.", this.Explain);
        }
    }
}

