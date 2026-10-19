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

    public class AuditLogQueryFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>SQL type list, with values such as SELECT, INSERT, UPDATE, and DELETE.</p>
        /// </summary>
        [JsonProperty("SqlType")]
        public string[] SqlType{ get; set; }

        /// <summary>
        /// <p>Execution duration range (ms), an array of length 2: [minimum value, maximum value].</p>
        /// </summary>
        [JsonProperty("ExecTime")]
        public long?[] ExecTime{ get; set; }

        /// <summary>
        /// <p>IO waiting duration range (ms), an array with a length of 2.</p>
        /// </summary>
        [JsonProperty("IoWaitTime")]
        public long?[] IoWaitTime{ get; set; }

        /// <summary>
        /// <p>CPU duration range (ms), an array of length 2.</p>
        /// </summary>
        [JsonProperty("CpuTime")]
        public long?[] CpuTime{ get; set; }

        /// <summary>
        /// <p>Lock wait time range (ms), an array with a length of 2.</p>
        /// </summary>
        [JsonProperty("LockWaitTime")]
        public long?[] LockWaitTime{ get; set; }

        /// <summary>
        /// <p>SQL execution error code. For example, 0 indicates success.</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>Error message.</p>
        /// </summary>
        [JsonProperty("ErrInfo")]
        public string ErrInfo{ get; set; }

        /// <summary>
        /// <p>Database name list.</p>
        /// </summary>
        [JsonProperty("DBName")]
        public string[] DBName{ get; set; }

        /// <summary>
        /// <p>Username list.</p>
        /// </summary>
        [JsonProperty("User")]
        public string[] User{ get; set; }

        /// <summary>
        /// <p>Source IP list.</p>
        /// </summary>
        [JsonProperty("Host")]
        public string[] Host{ get; set; }

        /// <summary>
        /// <p>List of thread IDs.</p>
        /// </summary>
        [JsonProperty("ThreadId")]
        public string[] ThreadId{ get; set; }

        /// <summary>
        /// <p>List of proxy node hosts.</p>
        /// </summary>
        [JsonProperty("ProxyHostList")]
        public string[] ProxyHostList{ get; set; }

        /// <summary>
        /// <p>Backend Set Host list.</p>
        /// </summary>
        [JsonProperty("SetHostList")]
        public string[] SetHostList{ get; set; }

        /// <summary>
        /// <p>Backend Set ID list.</p>
        /// </summary>
        [JsonProperty("SetIdList")]
        public string[] SetIdList{ get; set; }

        /// <summary>
        /// <p>Multiple SQL keyword conditions, JSON string, internally a two-dimensional array: level 1 is AND, the second level is OR. Note that the cloud API platform does not support two-dimensional arrays. Here, a string is used to carry it, and the server automatically parses it.</p>
        /// </summary>
        [JsonProperty("MultiSql")]
        public string MultiSql{ get; set; }

        /// <summary>
        /// <p>Excluded multiple SQL keyword conditions, JSON string, with the same structure as MultiSql.</p>
        /// </summary>
        [JsonProperty("ExcludeMultiSql")]
        public string ExcludeMultiSql{ get; set; }

        /// <summary>
        /// <p>SQL Template ID.</p>
        /// </summary>
        [JsonProperty("SqlTemplateId")]
        public string SqlTemplateId{ get; set; }

        /// <summary>
        /// <p>SQL start time, for example: 2026-10-10 11:05:06.002211</p><p>Parameter format: YYYY-MM-DD hh:mm:ss.SSSSSS</p>
        /// </summary>
        [JsonProperty("SqlStartTime")]
        public string SqlStartTime{ get; set; }

        /// <summary>
        /// <p>Query ID, used for join queries (required when LogType=All).</p>
        /// </summary>
        [JsonProperty("QueryId")]
        public string QueryId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SqlType.", this.SqlType);
            this.SetParamArraySimple(map, prefix + "ExecTime.", this.ExecTime);
            this.SetParamArraySimple(map, prefix + "IoWaitTime.", this.IoWaitTime);
            this.SetParamArraySimple(map, prefix + "CpuTime.", this.CpuTime);
            this.SetParamArraySimple(map, prefix + "LockWaitTime.", this.LockWaitTime);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrInfo", this.ErrInfo);
            this.SetParamArraySimple(map, prefix + "DBName.", this.DBName);
            this.SetParamArraySimple(map, prefix + "User.", this.User);
            this.SetParamArraySimple(map, prefix + "Host.", this.Host);
            this.SetParamArraySimple(map, prefix + "ThreadId.", this.ThreadId);
            this.SetParamArraySimple(map, prefix + "ProxyHostList.", this.ProxyHostList);
            this.SetParamArraySimple(map, prefix + "SetHostList.", this.SetHostList);
            this.SetParamArraySimple(map, prefix + "SetIdList.", this.SetIdList);
            this.SetParamSimple(map, prefix + "MultiSql", this.MultiSql);
            this.SetParamSimple(map, prefix + "ExcludeMultiSql", this.ExcludeMultiSql);
            this.SetParamSimple(map, prefix + "SqlTemplateId", this.SqlTemplateId);
            this.SetParamSimple(map, prefix + "SqlStartTime", this.SqlStartTime);
            this.SetParamSimple(map, prefix + "QueryId", this.QueryId);
        }
    }
}

