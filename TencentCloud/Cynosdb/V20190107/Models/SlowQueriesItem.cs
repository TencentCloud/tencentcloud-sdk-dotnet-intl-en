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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowQueriesItem : AbstractModel
    {
        
        /// <summary>
        /// Execution timestamp
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// Execution duration in seconds
        /// </summary>
        [JsonProperty("QueryTime")]
        public float? QueryTime{ get; set; }

        /// <summary>
        /// SQL statement
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// Client host
        /// </summary>
        [JsonProperty("UserHost")]
        public string UserHost{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// Lock duration in seconds
        /// </summary>
        [JsonProperty("LockTime")]
        public float? LockTime{ get; set; }

        /// <summary>
        /// Number of scanned rows
        /// </summary>
        [JsonProperty("RowsExamined")]
        public long? RowsExamined{ get; set; }

        /// <summary>
        /// Number of returned rows
        /// </summary>
        [JsonProperty("RowsSent")]
        public long? RowsSent{ get; set; }

        /// <summary>
        /// SQL template
        /// </summary>
        [JsonProperty("SqlTemplate")]
        public string SqlTemplate{ get; set; }

        /// <summary>
        /// MD5 value of the SQL statement
        /// </summary>
        [JsonProperty("SqlMd5")]
        public string SqlMd5{ get; set; }

        /// <summary>
        /// Remote reading count.
        /// Specifies that the database kernel version is larger than 3.1.12.
        /// </summary>
        [JsonProperty("SyncReadCountRemote")]
        public long? SyncReadCountRemote{ get; set; }

        /// <summary>
        /// Number of remote read bytes.
        /// Specifies that the database kernel version is larger than 3.1.12.
        /// </summary>
        [JsonProperty("SyncReadBytesRemote")]
        public long? SyncReadBytesRemote{ get; set; }

        /// <summary>
        /// Time spent on remote reads (µs).
        /// Specifies that the database kernel version is larger than 3.1.12.
        /// </summary>
        [JsonProperty("SyncReadTimeRemote")]
        public long? SyncReadTimeRemote{ get; set; }

        /// <summary>
        /// Remote write count.
        /// Specifies that the database kernel version is larger than 3.1.12.
        /// </summary>
        [JsonProperty("SyncWriteCountRemote")]
        public long? SyncWriteCountRemote{ get; set; }

        /// <summary>
        /// Specifies the number of remote written bytes.
        /// Specifies that the database kernel version is larger than 3.1.12.
        /// </summary>
        [JsonProperty("SyncWriteBytesRemote")]
        public long? SyncWriteBytesRemote{ get; set; }

        /// <summary>
        /// Time spent on remote writing (µs).
        /// Specifies that the database kernel version is larger than 3.1.12.
        /// </summary>
        [JsonProperty("SyncWriteTimeRemote")]
        public long? SyncWriteTimeRemote{ get; set; }

        /// <summary>
        /// Transaction submission delay (µs).
        /// Specifies that the database kernel version is larger than 3.1.12.
        /// </summary>
        [JsonProperty("TrxCommitDelay")]
        public long? TrxCommitDelay{ get; set; }


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
            this.SetParamSimple(map, prefix + "SqlTemplate", this.SqlTemplate);
            this.SetParamSimple(map, prefix + "SqlMd5", this.SqlMd5);
            this.SetParamSimple(map, prefix + "SyncReadCountRemote", this.SyncReadCountRemote);
            this.SetParamSimple(map, prefix + "SyncReadBytesRemote", this.SyncReadBytesRemote);
            this.SetParamSimple(map, prefix + "SyncReadTimeRemote", this.SyncReadTimeRemote);
            this.SetParamSimple(map, prefix + "SyncWriteCountRemote", this.SyncWriteCountRemote);
            this.SetParamSimple(map, prefix + "SyncWriteBytesRemote", this.SyncWriteBytesRemote);
            this.SetParamSimple(map, prefix + "SyncWriteTimeRemote", this.SyncWriteTimeRemote);
            this.SetParamSimple(map, prefix + "TrxCommitDelay", this.TrxCommitDelay);
        }
    }
}

