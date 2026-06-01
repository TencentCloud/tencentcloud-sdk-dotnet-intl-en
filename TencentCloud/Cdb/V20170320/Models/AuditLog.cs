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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditLog : AbstractModel
    {
        
        /// <summary>
        /// Number of affected rows
        /// </summary>
        [JsonProperty("AffectRows")]
        public long? AffectRows{ get; set; }

        /// <summary>
        /// The error code
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// Audit policy name, which will be unavailable soon.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DBName")]
        public string DBName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// Client address
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Execution time (μs)
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// Time
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// Number of returned rows
        /// </summary>
        [JsonProperty("SentRows")]
        public long? SentRows{ get; set; }

        /// <summary>
        /// Thread ID
        /// </summary>
        [JsonProperty("ThreadId")]
        public long? ThreadId{ get; set; }

        /// <summary>
        /// Number of scanned rows.
        /// </summary>
        [JsonProperty("CheckRows")]
        public long? CheckRows{ get; set; }

        /// <summary>
        /// cpu execution time, µs.
        /// </summary>
        [JsonProperty("CpuTime")]
        public float? CpuTime{ get; set; }

        /// <summary>
        /// IO wait time, µs.
        /// </summary>
        [JsonProperty("IoWaitTime")]
        public ulong? IoWaitTime{ get; set; }

        /// <summary>
        /// Lock waiting time (unit: microsecond).
        /// </summary>
        [JsonProperty("LockWaitTime")]
        public ulong? LockWaitTime{ get; set; }

        /// <summary>
        /// Start time, which combines with timestamp to form a time accurate to nanoseconds.
        /// </summary>
        [JsonProperty("NsTime")]
        public ulong? NsTime{ get; set; }

        /// <summary>
        /// Transaction duration, µs.
        /// </summary>
        [JsonProperty("TrxLivingTime")]
        public ulong? TrxLivingTime{ get; set; }

        /// <summary>
        /// Basic info of the log hit rule template
        /// </summary>
        [JsonProperty("TemplateInfo")]
        public LogRuleTemplateInfo[] TemplateInfo{ get; set; }

        /// <summary>
        /// Transaction ID
        /// </summary>
        [JsonProperty("TrxId")]
        public long? TrxId{ get; set; }

        /// <summary>
        /// Port.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientPort")]
        public long? ClientPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AffectRows", this.AffectRows);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "DBName", this.DBName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "SentRows", this.SentRows);
            this.SetParamSimple(map, prefix + "ThreadId", this.ThreadId);
            this.SetParamSimple(map, prefix + "CheckRows", this.CheckRows);
            this.SetParamSimple(map, prefix + "CpuTime", this.CpuTime);
            this.SetParamSimple(map, prefix + "IoWaitTime", this.IoWaitTime);
            this.SetParamSimple(map, prefix + "LockWaitTime", this.LockWaitTime);
            this.SetParamSimple(map, prefix + "NsTime", this.NsTime);
            this.SetParamSimple(map, prefix + "TrxLivingTime", this.TrxLivingTime);
            this.SetParamArrayObj(map, prefix + "TemplateInfo.", this.TemplateInfo);
            this.SetParamSimple(map, prefix + "TrxId", this.TrxId);
            this.SetParamSimple(map, prefix + "ClientPort", this.ClientPort);
        }
    }
}

