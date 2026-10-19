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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditDBLogItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Time point of SQL execution (format string, yyyy-MM-dd HH:mm:ss).</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Number of affected rows.</p>
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// <p>Number of scanned rows.</p>
        /// </summary>
        [JsonProperty("CheckRows")]
        public long? CheckRows{ get; set; }

        /// <summary>
        /// <p>CPU time (µs).</p>
        /// </summary>
        [JsonProperty("CpuTime")]
        public long? CpuTime{ get; set; }

        /// <summary>
        /// <p>Backend Set Host (source field dbHost).</p>
        /// </summary>
        [JsonProperty("SetHost")]
        public string SetHost{ get; set; }

        /// <summary>
        /// <p>Database name where the SQL is executed.</p>
        /// </summary>
        [JsonProperty("DBName")]
        public string DBName{ get; set; }

        /// <summary>
        /// <p>Error code returned by SQL execution. 0 indicates success.</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>SQL execution time (µs).</p>
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// <p>Client source IP.</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>Set Name (source field instanceId).</p>
        /// </summary>
        [JsonProperty("SetName")]
        public string SetName{ get; set; }

        /// <summary>
        /// <p>IO wait time (µs).</p>
        /// </summary>
        [JsonProperty("IoWaitTime")]
        public long? IoWaitTime{ get; set; }

        /// <summary>
        /// <p>Lock waiting time (µs).</p>
        /// </summary>
        [JsonProperty("LockWaitTime")]
        public long? LockWaitTime{ get; set; }

        /// <summary>
        /// <p>SQL start time (nanosecond timestamp).</p>
        /// </summary>
        [JsonProperty("SqlStartTimeNs")]
        public long? SqlStartTimeNs{ get; set; }

        /// <summary>
        /// <p>Query ID (used for join queries).</p>
        /// </summary>
        [JsonProperty("QueryId")]
        public string QueryId{ get; set; }

        /// <summary>
        /// <p>Serial number for queries (serial number of SQL in the same transaction).</p>
        /// </summary>
        [JsonProperty("QueryNo")]
        public long? QueryNo{ get; set; }

        /// <summary>
        /// <p>Number of rows returned (rows in the scanning result set).</p>
        /// </summary>
        [JsonProperty("SentRows")]
        public long? SentRows{ get; set; }

        /// <summary>
        /// <p>Original executed SQL statement.</p>
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// <p>SQL Template ID.</p>
        /// </summary>
        [JsonProperty("SqlTemplateId")]
        public string SqlTemplateId{ get; set; }

        /// <summary>
        /// <p>SQL type (for example, Select, Insert, Update, Delete).</p>
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// <p>Tables involved.</p>
        /// </summary>
        [JsonProperty("Tables")]
        public string Tables{ get; set; }

        /// <summary>
        /// <p>Thread ID.</p>
        /// </summary>
        [JsonProperty("ThreadId")]
        public string ThreadId{ get; set; }

        /// <summary>
        /// <p>SQL start time (millisecond-level timestamp).</p>
        /// </summary>
        [JsonProperty("SqlStartTime")]
        public long? SqlStartTime{ get; set; }

        /// <summary>
        /// <p>Transaction time to live (µs).</p>
        /// </summary>
        [JsonProperty("TrxLivingTime")]
        public long? TrxLivingTime{ get; set; }

        /// <summary>
        /// <p>Database username that executes the SQL.</p>
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// <p>Transaction ID.</p>
        /// </summary>
        [JsonProperty("TrxId")]
        public string TrxId{ get; set; }

        /// <summary>
        /// <p>Internal XID.</p>
        /// </summary>
        [JsonProperty("InternalXId")]
        public string InternalXId{ get; set; }

        /// <summary>
        /// <p>Business code (extracted from i/o/p and other KV in business-side SQL annotations).</p>
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// <p>Gateway circulation duration (ms). It is returned only when LogType=All after gateway log association. When LogType=DB, this field is not delivered.</p>
        /// </summary>
        [JsonProperty("FlowTime")]
        public long? FlowTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamSimple(map, prefix + "CheckRows", this.CheckRows);
            this.SetParamSimple(map, prefix + "CpuTime", this.CpuTime);
            this.SetParamSimple(map, prefix + "SetHost", this.SetHost);
            this.SetParamSimple(map, prefix + "DBName", this.DBName);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "SetName", this.SetName);
            this.SetParamSimple(map, prefix + "IoWaitTime", this.IoWaitTime);
            this.SetParamSimple(map, prefix + "LockWaitTime", this.LockWaitTime);
            this.SetParamSimple(map, prefix + "SqlStartTimeNs", this.SqlStartTimeNs);
            this.SetParamSimple(map, prefix + "QueryId", this.QueryId);
            this.SetParamSimple(map, prefix + "QueryNo", this.QueryNo);
            this.SetParamSimple(map, prefix + "SentRows", this.SentRows);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "SqlTemplateId", this.SqlTemplateId);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "Tables", this.Tables);
            this.SetParamSimple(map, prefix + "ThreadId", this.ThreadId);
            this.SetParamSimple(map, prefix + "SqlStartTime", this.SqlStartTime);
            this.SetParamSimple(map, prefix + "TrxLivingTime", this.TrxLivingTime);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "TrxId", this.TrxId);
            this.SetParamSimple(map, prefix + "InternalXId", this.InternalXId);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "FlowTime", this.FlowTime);
        }
    }
}

