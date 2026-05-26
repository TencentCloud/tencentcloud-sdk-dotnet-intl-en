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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RawSlowQuery : AbstractModel
    {
        
        /// <summary>
        /// <p>Slow SQL statement</p>
        /// </summary>
        [JsonProperty("RawQuery")]
        public string RawQuery{ get; set; }

        /// <summary>
        /// <p>Database for slow SQL queries</p>
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// <p>Slow SQL execution duration</p>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// <p>Client that executes Slow SQL</p>
        /// </summary>
        [JsonProperty("ClientAddr")]
        public string ClientAddr{ get; set; }

        /// <summary>
        /// <p>userName that executes slow SQL</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Start time of Slow SQL execution</p>
        /// </summary>
        [JsonProperty("SessionStartTime")]
        public string SessionStartTime{ get; set; }

        /// <summary>
        /// <p>Process ID of the slow SQL being executed</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProcessId")]
        public long? ProcessId{ get; set; }

        /// <summary>
        /// <p>Session ID that executes slow SQL.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Transaction ID of the executed slow SQL</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VirtualTransactionId")]
        public string VirtualTransactionId{ get; set; }

        /// <summary>
        /// <p>Status code for executing slow SQL</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SqlStateCode")]
        public string SqlStateCode{ get; set; }

        /// <summary>
        /// <p>client name that executes slow SQL</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RawQuery", this.RawQuery);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ClientAddr", this.ClientAddr);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "SessionStartTime", this.SessionStartTime);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "VirtualTransactionId", this.VirtualTransactionId);
            this.SetParamSimple(map, prefix + "SqlStateCode", this.SqlStateCode);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
        }
    }
}

