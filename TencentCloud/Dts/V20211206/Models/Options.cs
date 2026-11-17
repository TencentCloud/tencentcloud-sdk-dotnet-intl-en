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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Options : AbstractModel
    {
        
        /// <summary>
        /// <p>Synchronization initialization options: Data (Full Data initialization), Structure (Structure initialization), Full (Full Data and Structure initialization, default), None (incremental only). The mongodb link supports only Full Data initialization or incremental only.</p>
        /// </summary>
        [JsonProperty("InitType")]
        public string InitType{ get; set; }

        /// <summary>
        /// <p>Handling of tables with the same name, ReportErrorAfterCheck (pre-validation and error reporting, default), ExecuteAfterIgnore (ignore and continue execution).</p>
        /// </summary>
        [JsonProperty("DealOfExistSameTable")]
        public string DealOfExistSameTable{ get; set; }

        /// <summary>
        /// <p>Conflict resolution options: ReportError (report error, default), Ignore, Cover, ConditionCover</p>
        /// </summary>
        [JsonProperty("ConflictHandleType")]
        public string ConflictHandleType{ get; set; }

        /// <summary>
        /// <p>Whether to add an additional column</p>
        /// </summary>
        [JsonProperty("AddAdditionalColumn")]
        public bool? AddAdditionalColumn{ get; set; }

        /// <summary>
        /// <p>Options for DML and DDL to be synchronized: Insert, Update, Delete, DDL (structure synchronization), PartialDDL (custom, can be used together with DdlOptions). Note that it must contain at least one DML option.</p>
        /// </summary>
        [JsonProperty("OpTypes")]
        public string[] OpTypes{ get; set; }

        /// <summary>
        /// <p>Detailed options for conflict resolution, such as condition row and conditional operation in condition coverage</p>
        /// </summary>
        [JsonProperty("ConflictHandleOption")]
        public ConflictHandleOption ConflictHandleOption{ get; set; }

        /// <summary>
        /// <p>DDL synchronization option. Description of which DDLs to synchronize.</p>
        /// </summary>
        [JsonProperty("DdlOptions")]
        public DdlOption[] DdlOptions{ get; set; }

        /// <summary>
        /// <p>kafka sync options</p>
        /// </summary>
        [JsonProperty("KafkaOption")]
        public KafkaOption KafkaOption{ get; set; }

        /// <summary>
        /// <p>Task speed limit information</p>
        /// </summary>
        [JsonProperty("RateLimitOption")]
        public RateLimitOption RateLimitOption{ get; set; }

        /// <summary>
        /// <p>Time window for automatic retry settings</p>
        /// </summary>
        [JsonProperty("AutoRetryTimeRangeMinutes")]
        public long? AutoRetryTimeRangeMinutes{ get; set; }

        /// <summary>
        /// <p>Synchronize to the specified checkpoint of the kafka link. Currently only support time format: 2023-12-20T19:24:23+08:00. If not specified, it is empty.</p>
        /// </summary>
        [JsonProperty("StartPosition")]
        public string StartPosition{ get; set; }

        /// <summary>
        /// <p>Whether to filter out begin and commit messages when synchronizing to kafka. Currently, only the mysql-to-kafka link supports this.</p>
        /// </summary>
        [JsonProperty("FilterBeginCommit")]
        public bool? FilterBeginCommit{ get; set; }

        /// <summary>
        /// <p>Whether to filter out checkpoint messages when synchronizing to kafka. Currently, only the mysql-to-kafka link supports this.</p>
        /// </summary>
        [JsonProperty("FilterCheckpoint")]
        public bool? FilterCheckpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InitType", this.InitType);
            this.SetParamSimple(map, prefix + "DealOfExistSameTable", this.DealOfExistSameTable);
            this.SetParamSimple(map, prefix + "ConflictHandleType", this.ConflictHandleType);
            this.SetParamSimple(map, prefix + "AddAdditionalColumn", this.AddAdditionalColumn);
            this.SetParamArraySimple(map, prefix + "OpTypes.", this.OpTypes);
            this.SetParamObj(map, prefix + "ConflictHandleOption.", this.ConflictHandleOption);
            this.SetParamArrayObj(map, prefix + "DdlOptions.", this.DdlOptions);
            this.SetParamObj(map, prefix + "KafkaOption.", this.KafkaOption);
            this.SetParamObj(map, prefix + "RateLimitOption.", this.RateLimitOption);
            this.SetParamSimple(map, prefix + "AutoRetryTimeRangeMinutes", this.AutoRetryTimeRangeMinutes);
            this.SetParamSimple(map, prefix + "StartPosition", this.StartPosition);
            this.SetParamSimple(map, prefix + "FilterBeginCommit", this.FilterBeginCommit);
            this.SetParamSimple(map, prefix + "FilterCheckpoint", this.FilterCheckpoint);
        }
    }
}

