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

    public class SparkJobInfo : AbstractModel
    {
        
        /// <summary>
        /// Spark job ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Spark job name
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// Spark job type. Valid values: `1` (batch job), `2` (streaming job).
        /// </summary>
        [JsonProperty("JobType")]
        public long? JobType{ get; set; }

        /// <summary>
        /// Engine name
        /// </summary>
        [JsonProperty("DataEngine")]
        public string DataEngine{ get; set; }

        /// <summary>
        /// This field has been disused. Use the `Datasource` field instead.
        /// </summary>
        [JsonProperty("Eni")]
        public string Eni{ get; set; }

        /// <summary>
        /// Whether the program package is uploaded locally. Valid values: `cos`, `lakefs`.
        /// </summary>
        [JsonProperty("IsLocal")]
        public string IsLocal{ get; set; }

        /// <summary>
        /// Program package path
        /// </summary>
        [JsonProperty("JobFile")]
        public string JobFile{ get; set; }

        /// <summary>
        /// Role ID
        /// </summary>
        [JsonProperty("RoleArn")]
        public long? RoleArn{ get; set; }

        /// <summary>
        /// Main class of Spark job execution
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// Command line parameters of the Spark job separated by space
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// Native Spark configurations separated by line break
        /// </summary>
        [JsonProperty("JobConf")]
        public string JobConf{ get; set; }

        /// <summary>
        /// Whether the dependency JAR packages are uploaded locally. Valid values: `cos`, `lakefs`.
        /// </summary>
        [JsonProperty("IsLocalJars")]
        public string IsLocalJars{ get; set; }

        /// <summary>
        /// Dependency JAR packages of the Spark job separated by comma
        /// </summary>
        [JsonProperty("JobJars")]
        public string JobJars{ get; set; }

        /// <summary>
        /// Whether the dependency file is uploaded locally. Valid values: `cos`, `lakefs`.
        /// </summary>
        [JsonProperty("IsLocalFiles")]
        public string IsLocalFiles{ get; set; }

        /// <summary>
        /// Dependency files of the Spark job separated by comma
        /// </summary>
        [JsonProperty("JobFiles")]
        public string JobFiles{ get; set; }

        /// <summary>
        /// Driver resource size of the Spark job
        /// </summary>
        [JsonProperty("JobDriverSize")]
        public string JobDriverSize{ get; set; }

        /// <summary>
        /// Executor resource size of the Spark job
        /// </summary>
        [JsonProperty("JobExecutorSize")]
        public string JobExecutorSize{ get; set; }

        /// <summary>
        /// Number of Spark job executors
        /// </summary>
        [JsonProperty("JobExecutorNums")]
        public long? JobExecutorNums{ get; set; }

        /// <summary>
        /// Maximum number of retries of the Spark flow task
        /// </summary>
        [JsonProperty("JobMaxAttempts")]
        public long? JobMaxAttempts{ get; set; }

        /// <summary>
        /// Spark job creator
        /// </summary>
        [JsonProperty("JobCreator")]
        public string JobCreator{ get; set; }

        /// <summary>
        /// Spark job creation time
        /// </summary>
        [JsonProperty("JobCreateTime")]
        public long? JobCreateTime{ get; set; }

        /// <summary>
        /// Spark job update time
        /// </summary>
        [JsonProperty("JobUpdateTime")]
        public ulong? JobUpdateTime{ get; set; }

        /// <summary>
        /// Last task ID of the Spark job
        /// </summary>
        [JsonProperty("CurrentTaskId")]
        public string CurrentTaskId{ get; set; }

        /// <summary>
        /// Last status of the Spark job
        /// </summary>
        [JsonProperty("JobStatus")]
        public long? JobStatus{ get; set; }

        /// <summary>
        /// Spark streaming job statistics
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StreamingStat")]
        public StreamingStatistics StreamingStat{ get; set; }

        /// <summary>
        /// Data source name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// PySpark: Dependency upload method. 1: cos; 2: lakefs (this method needs to be used in the console but cannot be called through APIs).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsLocalPythonFiles")]
        public string IsLocalPythonFiles{ get; set; }

        /// <summary>
        /// Note: This returned value has been disused.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppPythonFiles")]
        public string AppPythonFiles{ get; set; }

        /// <summary>
        /// Archives: Dependency upload method. 1: cos; 2: lakefs (this method needs to be used in the console but cannot be called through APIs).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsLocalArchives")]
        public string IsLocalArchives{ get; set; }

        /// <summary>
        /// Archives: Dependency resources
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JobArchives")]
        public string JobArchives{ get; set; }

        /// <summary>
        /// The Spark image version.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SparkImage")]
        public string SparkImage{ get; set; }

        /// <summary>
        /// PySpark: Python dependency, which can be in .py, .zip, or .egg format. Multiple files should be separated by comma.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JobPythonFiles")]
        public string JobPythonFiles{ get; set; }

        /// <summary>
        /// Number of tasks running or ready to run under the current job
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskNum")]
        public long? TaskNum{ get; set; }

        /// <summary>
        /// Engine status. -100 (default value): unknown; -2–11: normal.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataEngineStatus")]
        public long? DataEngineStatus{ get; set; }

        /// <summary>
        /// The specified executor count (max), which defaults to 1. This parameter applies if the "Dynamic" mode is selected. If the "Dynamic" mode is not selected, the executor count is equal to `JobExecutorNums`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JobExecutorMaxNumbers")]
        public long? JobExecutorMaxNumbers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "DataEngine", this.DataEngine);
            this.SetParamSimple(map, prefix + "Eni", this.Eni);
            this.SetParamSimple(map, prefix + "IsLocal", this.IsLocal);
            this.SetParamSimple(map, prefix + "JobFile", this.JobFile);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "MainClass", this.MainClass);
            this.SetParamSimple(map, prefix + "CmdArgs", this.CmdArgs);
            this.SetParamSimple(map, prefix + "JobConf", this.JobConf);
            this.SetParamSimple(map, prefix + "IsLocalJars", this.IsLocalJars);
            this.SetParamSimple(map, prefix + "JobJars", this.JobJars);
            this.SetParamSimple(map, prefix + "IsLocalFiles", this.IsLocalFiles);
            this.SetParamSimple(map, prefix + "JobFiles", this.JobFiles);
            this.SetParamSimple(map, prefix + "JobDriverSize", this.JobDriverSize);
            this.SetParamSimple(map, prefix + "JobExecutorSize", this.JobExecutorSize);
            this.SetParamSimple(map, prefix + "JobExecutorNums", this.JobExecutorNums);
            this.SetParamSimple(map, prefix + "JobMaxAttempts", this.JobMaxAttempts);
            this.SetParamSimple(map, prefix + "JobCreator", this.JobCreator);
            this.SetParamSimple(map, prefix + "JobCreateTime", this.JobCreateTime);
            this.SetParamSimple(map, prefix + "JobUpdateTime", this.JobUpdateTime);
            this.SetParamSimple(map, prefix + "CurrentTaskId", this.CurrentTaskId);
            this.SetParamSimple(map, prefix + "JobStatus", this.JobStatus);
            this.SetParamObj(map, prefix + "StreamingStat.", this.StreamingStat);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "IsLocalPythonFiles", this.IsLocalPythonFiles);
            this.SetParamSimple(map, prefix + "AppPythonFiles", this.AppPythonFiles);
            this.SetParamSimple(map, prefix + "IsLocalArchives", this.IsLocalArchives);
            this.SetParamSimple(map, prefix + "JobArchives", this.JobArchives);
            this.SetParamSimple(map, prefix + "SparkImage", this.SparkImage);
            this.SetParamSimple(map, prefix + "JobPythonFiles", this.JobPythonFiles);
            this.SetParamSimple(map, prefix + "TaskNum", this.TaskNum);
            this.SetParamSimple(map, prefix + "DataEngineStatus", this.DataEngineStatus);
            this.SetParamSimple(map, prefix + "JobExecutorMaxNumbers", this.JobExecutorMaxNumbers);
        }
    }
}

