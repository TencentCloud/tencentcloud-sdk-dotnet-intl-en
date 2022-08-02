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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskResultInfo : AbstractModel
    {
        
        /// <summary>
        /// Unique task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Name of the default selected data source when the current job is executed
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// Name of the default selected database when the current job is executed
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// The currently executed SQL statement. Each task contains one SQL statement.
        /// </summary>
        [JsonProperty("SQL")]
        public string SQL{ get; set; }

        /// <summary>
        /// Type of the executed task. Valid values: `DDL`, `DML`, `DQL`.
        /// </summary>
        [JsonProperty("SQLType")]
        public string SQLType{ get; set; }

        /// <summary>
        /// Current status of the task. `0`: initial; `1`: task running; `2`: task execution succeeded; `-1`: task execution failed; `-3`: task terminated manually by the user. The task execution result will be returned only if task execution succeeds.
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// Amount of the data scanned in bytes
        /// </summary>
        [JsonProperty("DataAmount")]
        public long? DataAmount{ get; set; }

        /// <summary>
        /// Task execution time in seconds
        /// </summary>
        [JsonProperty("UsedTime")]
        public long? UsedTime{ get; set; }

        /// <summary>
        /// Address of the COS bucket for storing the task result
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// Task creation timestamp
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Task execution information. `success` will be returned if the task succeeds; otherwise, the failure cause will be returned.
        /// </summary>
        [JsonProperty("OutputMessage")]
        public string OutputMessage{ get; set; }

        /// <summary>
        /// Number of affected rows
        /// </summary>
        [JsonProperty("RowAffectInfo")]
        public string RowAffectInfo{ get; set; }

        /// <summary>
        /// Schema information of the result
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResultSchema")]
        public Column[] ResultSchema{ get; set; }

        /// <summary>
        /// Result information. After it is unescaped, each element of the outer array is a data row.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResultSet")]
        public string ResultSet{ get; set; }

        /// <summary>
        /// Pagination information. If there is no more result data, `nextToken` will be empty.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// Task progress (%)
        /// </summary>
        [JsonProperty("Percentage")]
        public long? Percentage{ get; set; }

        /// <summary>
        /// Task progress details
        /// </summary>
        [JsonProperty("ProgressDetail")]
        public string ProgressDetail{ get; set; }

        /// <summary>
        /// Console display format. Valid values: `table`, `text`.
        /// </summary>
        [JsonProperty("DisplayFormat")]
        public string DisplayFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "SQL", this.SQL);
            this.SetParamSimple(map, prefix + "SQLType", this.SQLType);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "DataAmount", this.DataAmount);
            this.SetParamSimple(map, prefix + "UsedTime", this.UsedTime);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "OutputMessage", this.OutputMessage);
            this.SetParamSimple(map, prefix + "RowAffectInfo", this.RowAffectInfo);
            this.SetParamArrayObj(map, prefix + "ResultSchema.", this.ResultSchema);
            this.SetParamSimple(map, prefix + "ResultSet", this.ResultSet);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
            this.SetParamSimple(map, prefix + "ProgressDetail", this.ProgressDetail);
            this.SetParamSimple(map, prefix + "DisplayFormat", this.DisplayFormat);
        }
    }
}

