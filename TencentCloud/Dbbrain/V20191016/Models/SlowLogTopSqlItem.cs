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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowLogTopSqlItem : AbstractModel
    {
        
        /// <summary>
        /// Total SQL lock wait time
        /// </summary>
        [JsonProperty("LockTime")]
        public float? LockTime{ get; set; }

        /// <summary>
        /// Maximum lock wait time
        /// </summary>
        [JsonProperty("LockTimeMax")]
        public float? LockTimeMax{ get; set; }

        /// <summary>
        /// Minimum lock wait time
        /// </summary>
        [JsonProperty("LockTimeMin")]
        public float? LockTimeMin{ get; set; }

        /// <summary>
        /// Total number of scanned rows
        /// </summary>
        [JsonProperty("RowsExamined")]
        public long? RowsExamined{ get; set; }

        /// <summary>
        /// Maximum number of scanned rows
        /// </summary>
        [JsonProperty("RowsExaminedMax")]
        public long? RowsExaminedMax{ get; set; }

        /// <summary>
        /// Minimum number of scanned rows
        /// </summary>
        [JsonProperty("RowsExaminedMin")]
        public long? RowsExaminedMin{ get; set; }

        /// <summary>
        /// Total duration
        /// </summary>
        [JsonProperty("QueryTime")]
        public float? QueryTime{ get; set; }

        /// <summary>
        /// Maximum execution time
        /// </summary>
        [JsonProperty("QueryTimeMax")]
        public float? QueryTimeMax{ get; set; }

        /// <summary>
        /// Minimum execution time
        /// </summary>
        [JsonProperty("QueryTimeMin")]
        public float? QueryTimeMin{ get; set; }

        /// <summary>
        /// Total number of returned rows
        /// </summary>
        [JsonProperty("RowsSent")]
        public long? RowsSent{ get; set; }

        /// <summary>
        /// Maximum number of returned rows
        /// </summary>
        [JsonProperty("RowsSentMax")]
        public long? RowsSentMax{ get; set; }

        /// <summary>
        /// Minimum number of returned rows
        /// </summary>
        [JsonProperty("RowsSentMin")]
        public long? RowsSentMin{ get; set; }

        /// <summary>
        /// Number of executions
        /// </summary>
        [JsonProperty("ExecTimes")]
        public long? ExecTimes{ get; set; }

        /// <summary>
        /// SQL template
        /// </summary>
        [JsonProperty("SqlTemplate")]
        public string SqlTemplate{ get; set; }

        /// <summary>
        /// SQL with parameter (random)
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// Ratio of total duration
        /// </summary>
        [JsonProperty("QueryTimeRatio")]
        public float? QueryTimeRatio{ get; set; }

        /// <summary>
        /// Ratio of total SQL lock wait time
        /// </summary>
        [JsonProperty("LockTimeRatio")]
        public float? LockTimeRatio{ get; set; }

        /// <summary>
        /// Ratio of total number of scanned rows
        /// </summary>
        [JsonProperty("RowsExaminedRatio")]
        public float? RowsExaminedRatio{ get; set; }

        /// <summary>
        /// Ratio of total number of returned rows
        /// </summary>
        [JsonProperty("RowsSentRatio")]
        public float? RowsSentRatio{ get; set; }

        /// <summary>
        /// Average execution time
        /// </summary>
        [JsonProperty("QueryTimeAvg")]
        public float? QueryTimeAvg{ get; set; }

        /// <summary>
        /// Average number of rows returned
        /// </summary>
        [JsonProperty("RowsSentAvg")]
        public float? RowsSentAvg{ get; set; }

        /// <summary>
        /// Average lock wait time
        /// </summary>
        [JsonProperty("LockTimeAvg")]
        public float? LockTimeAvg{ get; set; }

        /// <summary>
        /// Average number of rows scanned
        /// </summary>
        [JsonProperty("RowsExaminedAvg")]
        public float? RowsExaminedAvg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LockTime", this.LockTime);
            this.SetParamSimple(map, prefix + "LockTimeMax", this.LockTimeMax);
            this.SetParamSimple(map, prefix + "LockTimeMin", this.LockTimeMin);
            this.SetParamSimple(map, prefix + "RowsExamined", this.RowsExamined);
            this.SetParamSimple(map, prefix + "RowsExaminedMax", this.RowsExaminedMax);
            this.SetParamSimple(map, prefix + "RowsExaminedMin", this.RowsExaminedMin);
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamSimple(map, prefix + "QueryTimeMax", this.QueryTimeMax);
            this.SetParamSimple(map, prefix + "QueryTimeMin", this.QueryTimeMin);
            this.SetParamSimple(map, prefix + "RowsSent", this.RowsSent);
            this.SetParamSimple(map, prefix + "RowsSentMax", this.RowsSentMax);
            this.SetParamSimple(map, prefix + "RowsSentMin", this.RowsSentMin);
            this.SetParamSimple(map, prefix + "ExecTimes", this.ExecTimes);
            this.SetParamSimple(map, prefix + "SqlTemplate", this.SqlTemplate);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "QueryTimeRatio", this.QueryTimeRatio);
            this.SetParamSimple(map, prefix + "LockTimeRatio", this.LockTimeRatio);
            this.SetParamSimple(map, prefix + "RowsExaminedRatio", this.RowsExaminedRatio);
            this.SetParamSimple(map, prefix + "RowsSentRatio", this.RowsSentRatio);
            this.SetParamSimple(map, prefix + "QueryTimeAvg", this.QueryTimeAvg);
            this.SetParamSimple(map, prefix + "RowsSentAvg", this.RowsSentAvg);
            this.SetParamSimple(map, prefix + "LockTimeAvg", this.LockTimeAvg);
            this.SetParamSimple(map, prefix + "RowsExaminedAvg", this.RowsExaminedAvg);
        }
    }
}

