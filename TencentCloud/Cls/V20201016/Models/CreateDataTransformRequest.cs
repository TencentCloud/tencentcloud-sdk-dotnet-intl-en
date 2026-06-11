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

    public class CreateDataTransformRequest : AbstractModel
    {
        
        /// <summary>
        /// Task type. 1: Specify topic; 2: Dynamic creation. For details, please refer to Creating Processing Task Document (https://intl.cloud.tencent.com/document/product/614/63940?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("FuncType")]
        public long? FuncType{ get; set; }

        /// <summary>
        /// Log topic ID
        /// -Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// Processing task name
        /// Name limit
        /// -Cannot be an empty string
        /// -Cannot contain character '|'
        /// -Longest 128 characters
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Processing statement. When FuncType is 2, EtlContent must use [log_auto_output](https://www.tencentcloud.com/document/product/614/70733?from_cn_redirect=1#b3c58797-4825-4807-bef4-68106e25024f). 
        /// 
        /// Other reference documents
        /// 
        /// -[Create a processing task](https://www.tencentcloud.com/document/product/614/63940?from_cn_redirect=1) 
        /// -[Function overview](https://www.tencentcloud.com/document/product/614/70395?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// Processing type.
        /// 1: Process preview using random data from the source log topic; 2: Process preview using user-defined test data; 3: Create real processing tasks.
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// Target topic_id and alias of the processing task. This parameter is required when FuncType=1, and not required when FuncType=2.
        /// Target topic_id. Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// Alias limitation: 1. Cannot be an empty string. 2. Cannot contain the character '|'.
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// Task status. Valid values: 1 (enabled) and 2 (disabled).
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// Test data for preview processing results
        /// Obtain the target log topic ID through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("PreviewLogStatistics")]
        public PreviewLogStatistic[] PreviewLogStatistics{ get; set; }

        /// <summary>
        /// When FuncType is 2, whether to discard data if the count of dynamically created logsets and log topics exceeds product specification limits, default false.
        /// 
        /// false: Create a fallback logset and log topic and write to fallback topic.
        /// true: Discard log data.
        /// </summary>
        [JsonProperty("BackupGiveUpData")]
        public bool? BackupGiveUpData{ get; set; }

        /// <summary>
        /// Whether to enable service log shipping. Valid values: 1: disable; 2: enable.
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// Data processing type. Valid values: 0: standard processing task; 1: pre-processing task. A pre-processing task can process the collected logs and then write them into a log topic.
        /// </summary>
        [JsonProperty("DataTransformType")]
        public ulong? DataTransformType{ get; set; }

        /// <summary>
        /// Log status of failed jobs, 1: not retain (default), 2: retain.
        /// </summary>
        [JsonProperty("KeepFailureLog")]
        public ulong? KeepFailureLog{ get; set; }

        /// <summary>
        /// Field name of a failed log.
        /// </summary>
        [JsonProperty("FailureLogKey")]
        public string FailureLogKey{ get; set; }

        /// <summary>
        /// Specify the start time of data processing, a Unix second-level timestamp.
        /// -For any time range within the log topic lifecycle, if it exceeds the lifecycle, only process the part with data within the lifecycle.
        /// </summary>
        [JsonProperty("ProcessFromTimestamp")]
        public ulong? ProcessFromTimestamp{ get; set; }

        /// <summary>
        /// Specify the end time of data processing, a Unix second-level timestamp.
        /// 
        /// -Cannot specify a future time
        /// -Leave blank to run constantly
        /// </summary>
        [JsonProperty("ProcessToTimestamp")]
        public ulong? ProcessToTimestamp{ get; set; }

        /// <summary>
        /// Preview a task (TaskType is 1 or 2) that is already created and used the capacity to associate with external data. This parameter is required.
        /// Data processing task ID - Search the data processing task list basic information (https://www.tencentcloud.com/document/product/614/72182?from_cn_redirect=1) to get the data processing task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Associated data source information
        /// </summary>
        [JsonProperty("DataTransformSqlDataSources")]
        public DataTransformSqlDataSource[] DataTransformSqlDataSources{ get; set; }

        /// <summary>
        /// Set environment variable
        /// </summary>
        [JsonProperty("EnvInfos")]
        public EnvInfo[] EnvInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FuncType", this.FuncType);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamArrayObj(map, prefix + "PreviewLogStatistics.", this.PreviewLogStatistics);
            this.SetParamSimple(map, prefix + "BackupGiveUpData", this.BackupGiveUpData);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "DataTransformType", this.DataTransformType);
            this.SetParamSimple(map, prefix + "KeepFailureLog", this.KeepFailureLog);
            this.SetParamSimple(map, prefix + "FailureLogKey", this.FailureLogKey);
            this.SetParamSimple(map, prefix + "ProcessFromTimestamp", this.ProcessFromTimestamp);
            this.SetParamSimple(map, prefix + "ProcessToTimestamp", this.ProcessToTimestamp);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArrayObj(map, prefix + "DataTransformSqlDataSources.", this.DataTransformSqlDataSources);
            this.SetParamArrayObj(map, prefix + "EnvInfos.", this.EnvInfos);
        }
    }
}

