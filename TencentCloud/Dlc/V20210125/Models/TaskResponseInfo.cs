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

    public class TaskResponseInfo : AbstractModel
    {
        
        /// <summary>
        /// Database name of the task
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// Data volume of the task
        /// </summary>
        [JsonProperty("DataAmount")]
        public long? DataAmount{ get; set; }

        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// The compute time in ms.
        /// </summary>
        [JsonProperty("UsedTime")]
        public long? UsedTime{ get; set; }

        /// <summary>
        /// Task output path
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// Task creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The task status. Valid values: `0` (initializing), `1` (executing), `2` (executed), `3` (writing data), `4` (queuing), `-1` (failed), and `-3` (canceled).
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// SQL statement type of the task, such as DDL and DML.
        /// </summary>
        [JsonProperty("SQLType")]
        public string SQLType{ get; set; }

        /// <summary>
        /// SQL statement of the task
        /// </summary>
        [JsonProperty("SQL")]
        public string SQL{ get; set; }

        /// <summary>
        /// Whether the result has expired
        /// </summary>
        [JsonProperty("ResultExpired")]
        public bool? ResultExpired{ get; set; }

        /// <summary>
        /// Number of affected data rows
        /// </summary>
        [JsonProperty("RowAffectInfo")]
        public string RowAffectInfo{ get; set; }

        /// <summary>
        /// Dataset of task results
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataSet")]
        public string DataSet{ get; set; }

        /// <summary>
        /// Failure information, such as `errorMessage`. This field has been disused.
        /// </summary>
        [JsonProperty("Error")]
        public string Error{ get; set; }

        /// <summary>
        /// Task progress (%)
        /// </summary>
        [JsonProperty("Percentage")]
        public long? Percentage{ get; set; }

        /// <summary>
        /// Output information of task execution
        /// </summary>
        [JsonProperty("OutputMessage")]
        public string OutputMessage{ get; set; }

        /// <summary>
        /// Type of the engine executing the SQL statement
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Task progress details
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProgressDetail")]
        public string ProgressDetail{ get; set; }

        /// <summary>
        /// Task end time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Compute resource ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataEngineId")]
        public string DataEngineId{ get; set; }

        /// <summary>
        /// Sub-UIN that executes the SQL statement
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// Compute resource name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// Whether the import type is local import or COS
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// Import configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InputConf")]
        public string InputConf{ get; set; }

        /// <summary>
        /// Number of data entries
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataNumber")]
        public long? DataNumber{ get; set; }

        /// <summary>
        /// Whether the data can be downloaded
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CanDownload")]
        public bool? CanDownload{ get; set; }

        /// <summary>
        /// User alias
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// Spark application job name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SparkJobName")]
        public string SparkJobName{ get; set; }

        /// <summary>
        /// Spark application job ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SparkJobId")]
        public string SparkJobId{ get; set; }

        /// <summary>
        /// JAR file of the Spark application entry
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SparkJobFile")]
        public string SparkJobFile{ get; set; }

        /// <summary>
        /// Spark UI URL
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UiUrl")]
        public string UiUrl{ get; set; }

        /// <summary>
        /// The task time in ms.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalTime")]
        public long? TotalTime{ get; set; }

        /// <summary>
        /// The program entry parameter for running a task under a Spark job.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// The image version of the cluster.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }

        /// <summary>
        /// The driver size.
        /// Valid values for the standard resource type: `small`, `medium`, `large`, and `xlarge`.
        /// Valid values for the memory resource type: `m.small`, `m.medium`, `m.large`, and `m.xlarge`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DriverSize")]
        public string DriverSize{ get; set; }

        /// <summary>
        /// The executor size.
        /// Valid values for the standard resource type: `small`, `medium`, `large`, and `xlarge`.
        /// Valid values for the memory resource type: `m.small`, `m.medium`, `m.large`, and `m.xlarge`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecutorSize")]
        public string ExecutorSize{ get; set; }

        /// <summary>
        /// The executor count. The minimum value is 1 and the maximum value is less than the cluster specification.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecutorNums")]
        public ulong? ExecutorNums{ get; set; }

        /// <summary>
        /// The maximum executor count (in dynamic mode). The minimum value is 1 and the maximum value is less than the cluster specification. If you set `ExecutorMaxNumbers` to a value smaller than that of `ExecutorNums`, the value of `ExecutorMaxNumbers` is automatically changed to that of `ExecutorNums`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecutorMaxNumbers")]
        public ulong? ExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// Common task metrics
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CommonMetrics")]
        public CommonMetrics CommonMetrics{ get; set; }

        /// <summary>
        /// The Spark task metrics.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SparkMonitorMetrics")]
        public SparkMonitorMetrics SparkMonitorMetrics{ get; set; }

        /// <summary>
        /// The Presto task metrics.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrestoMonitorMetrics")]
        public PrestoMonitorMetrics PrestoMonitorMetrics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "DataAmount", this.DataAmount);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "UsedTime", this.UsedTime);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "SQLType", this.SQLType);
            this.SetParamSimple(map, prefix + "SQL", this.SQL);
            this.SetParamSimple(map, prefix + "ResultExpired", this.ResultExpired);
            this.SetParamSimple(map, prefix + "RowAffectInfo", this.RowAffectInfo);
            this.SetParamSimple(map, prefix + "DataSet", this.DataSet);
            this.SetParamSimple(map, prefix + "Error", this.Error);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
            this.SetParamSimple(map, prefix + "OutputMessage", this.OutputMessage);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ProgressDetail", this.ProgressDetail);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DataEngineId", this.DataEngineId);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "InputConf", this.InputConf);
            this.SetParamSimple(map, prefix + "DataNumber", this.DataNumber);
            this.SetParamSimple(map, prefix + "CanDownload", this.CanDownload);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamSimple(map, prefix + "SparkJobName", this.SparkJobName);
            this.SetParamSimple(map, prefix + "SparkJobId", this.SparkJobId);
            this.SetParamSimple(map, prefix + "SparkJobFile", this.SparkJobFile);
            this.SetParamSimple(map, prefix + "UiUrl", this.UiUrl);
            this.SetParamSimple(map, prefix + "TotalTime", this.TotalTime);
            this.SetParamSimple(map, prefix + "CmdArgs", this.CmdArgs);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
            this.SetParamSimple(map, prefix + "DriverSize", this.DriverSize);
            this.SetParamSimple(map, prefix + "ExecutorSize", this.ExecutorSize);
            this.SetParamSimple(map, prefix + "ExecutorNums", this.ExecutorNums);
            this.SetParamSimple(map, prefix + "ExecutorMaxNumbers", this.ExecutorMaxNumbers);
            this.SetParamObj(map, prefix + "CommonMetrics.", this.CommonMetrics);
            this.SetParamObj(map, prefix + "SparkMonitorMetrics.", this.SparkMonitorMetrics);
            this.SetParamObj(map, prefix + "PrestoMonitorMetrics.", this.PrestoMonitorMetrics);
        }
    }
}

