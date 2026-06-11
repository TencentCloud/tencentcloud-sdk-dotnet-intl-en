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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataTransformTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Data processing task name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Data processing task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task status. Valid values: 1 (enabled) and 2 (disabled).
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// Processing task type, 1: DSL (processing task using custom language), 2: SQL (processing task using SQL)
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Source log topic
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// Current task status. Valid values: 1 (preparing), 2 (in progress), 3 (being stopped), and 4 (stopped).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Creation time.
        /// Time format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modification time
        /// Time format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Last enabled time. Modify this time if the cluster needs to be rebuilt.
        /// Time format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("LastEnableTime")]
        public string LastEnableTime{ get; set; }

        /// <summary>
        /// Log topic name
        /// </summary>
        [JsonProperty("SrcTopicName")]
        public string SrcTopicName{ get; set; }

        /// <summary>
        /// Logset ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// Target topic ID and alias of the data processing task
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// Processing logic function.
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// Fallback Topic ID
        /// </summary>
        [JsonProperty("BackupTopicID")]
        public string BackupTopicID{ get; set; }

        /// <summary>
        /// Whether to discard log data after the limit is exceeded
        /// </summary>
        [JsonProperty("BackupGiveUpData")]
        public bool? BackupGiveUpData{ get; set; }

        /// <summary>
        /// Whether to enable service log shipping. Valid values: 1: disable; 2: enable.
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// Number of the target log topics of a task.
        /// </summary>
        [JsonProperty("TaskDstCount")]
        public ulong? TaskDstCount{ get; set; }

        /// <summary>
        /// Data processing type. Valid values: 0: standard processing task; 1: pre-processing task.
        /// </summary>
        [JsonProperty("DataTransformType")]
        public ulong? DataTransformType{ get; set; }

        /// <summary>
        /// Whether to keep the failure log status. Valid values: 1: no; 2: yes.
        /// </summary>
        [JsonProperty("KeepFailureLog")]
        public ulong? KeepFailureLog{ get; set; }

        /// <summary>
        /// Field name of a failed log.
        /// </summary>
        [JsonProperty("FailureLogKey")]
        public string FailureLogKey{ get; set; }

        /// <summary>
        /// Specify the start time of data processing (a second-level timestamp).
        /// -For any time range within the log topic lifecycle, if it exceeds the lifecycle, only process the part with data within the lifecycle.
        /// </summary>
        [JsonProperty("ProcessFromTimestamp")]
        public ulong? ProcessFromTimestamp{ get; set; }

        /// <summary>
        /// Specify the end time of data processing, a Unix second-level timestamp.
        /// 1. Cannot specify a future time
        /// 2. If left blank, it means that the task will run constantly.
        /// </summary>
        [JsonProperty("ProcessToTimestamp")]
        public ulong? ProcessToTimestamp{ get; set; }

        /// <summary>
        /// sql data source information
        /// </summary>
        [JsonProperty("DataTransformSqlDataSources")]
        public DataTransformSqlDataSource[] DataTransformSqlDataSources{ get; set; }

        /// <summary>
        /// Environment variable.
        /// </summary>
        [JsonProperty("EnvInfos")]
        public EnvInfo[] EnvInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastEnableTime", this.LastEnableTime);
            this.SetParamSimple(map, prefix + "SrcTopicName", this.SrcTopicName);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamSimple(map, prefix + "BackupTopicID", this.BackupTopicID);
            this.SetParamSimple(map, prefix + "BackupGiveUpData", this.BackupGiveUpData);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "TaskDstCount", this.TaskDstCount);
            this.SetParamSimple(map, prefix + "DataTransformType", this.DataTransformType);
            this.SetParamSimple(map, prefix + "KeepFailureLog", this.KeepFailureLog);
            this.SetParamSimple(map, prefix + "FailureLogKey", this.FailureLogKey);
            this.SetParamSimple(map, prefix + "ProcessFromTimestamp", this.ProcessFromTimestamp);
            this.SetParamSimple(map, prefix + "ProcessToTimestamp", this.ProcessToTimestamp);
            this.SetParamArrayObj(map, prefix + "DataTransformSqlDataSources.", this.DataTransformSqlDataSources);
            this.SetParamArrayObj(map, prefix + "EnvInfos.", this.EnvInfos);
        }
    }
}

