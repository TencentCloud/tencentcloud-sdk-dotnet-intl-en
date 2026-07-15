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

    public class ScheduledSqlTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>ScheduledSql task id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>ScheduledSql task name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Source log topic id.</p>
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// <p>source log topic name</p>
        /// </summary>
        [JsonProperty("SrcTopicName")]
        public string SrcTopicName{ get; set; }

        /// <summary>
        /// <p>Scheduled SQL analysis target topic</p>
        /// </summary>
        [JsonProperty("DstResource")]
        public ScheduledSqlResouceInfo DstResource{ get; set; }

        /// <summary>
        /// <p>Task creation time. Format: yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Task update time. Format: yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Task status, 1: Running 2: Stopped 3: Exception - Source log topic not found 4: Exception - Target topic not found</p><p>5: Access permission issue 6: Internal fault 7: Other faults</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Task status: 1 Enabled, 2 Disabled</p>
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// <p>Query statement</p>
        /// </summary>
        [JsonProperty("ScheduledSqlContent")]
        public string ScheduledSqlContent{ get; set; }

        /// <summary>
        /// <p>Schedule start time. Format: yyyy-MM-dd HH:mm:ss</p>
        /// </summary>
        [JsonProperty("ProcessStartTime")]
        public string ProcessStartTime{ get; set; }

        /// <summary>
        /// <p>Schedule Type: 1 Continuous Running 2 Specified Time Range</p>
        /// </summary>
        [JsonProperty("ProcessType")]
        public long? ProcessType{ get; set; }

        /// <summary>
        /// <p>Schedule End Time, format: yyyy-MM-dd HH:mm:ss, required when process_type=2</p>
        /// </summary>
        [JsonProperty("ProcessEndTime")]
        public string ProcessEndTime{ get; set; }

        /// <summary>
        /// <p>Scheduling Interval (Minutes), 1-1440 minutes</p>
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// <p>Query Time Window. @m-15m, @m, meaning the last 15 minutes</p>
        /// </summary>
        [JsonProperty("ProcessTimeWindow")]
        public string ProcessTimeWindow{ get; set; }

        /// <summary>
        /// <p>Execution delay (seconds), 0-120 seconds, default 60 seconds</p>
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// <p>Regional information of the source topicId. For supported regions, see the <a href="https://www.tencentcloud.com/document/api/614/56474?from_cn_redirect=1#.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8">region list</a> document.</p>
        /// </summary>
        [JsonProperty("SrcTopicRegion")]
        public string SrcTopicRegion{ get; set; }

        /// <summary>
        /// <p>Syntax rules. 0: Lucene syntax, 1: CQL syntax</p>
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }

        /// <summary>
        /// <p>Whether the delivery service log is enabled. 1: Turn off, 2: Turn on.</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// <p>Full-text search tag. 1: Off, 2: On.</p>
        /// </summary>
        [JsonProperty("FullQuery")]
        public ulong? FullQuery{ get; set; }

        /// <summary>
        /// <p>Scheduling cycle time unit</p><p>Value ranges from 1 to 2</p><p>Default value: 1</p><p>Default value 1 (minute), other value 2 (second)</p>
        /// </summary>
        [JsonProperty("ProcessPeriodUnit")]
        public long? ProcessPeriodUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "SrcTopicName", this.SrcTopicName);
            this.SetParamObj(map, prefix + "DstResource.", this.DstResource);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "ScheduledSqlContent", this.ScheduledSqlContent);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "ProcessEndTime", this.ProcessEndTime);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessTimeWindow", this.ProcessTimeWindow);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "SrcTopicRegion", this.SrcTopicRegion);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "FullQuery", this.FullQuery);
            this.SetParamSimple(map, prefix + "ProcessPeriodUnit", this.ProcessPeriodUnit);
        }
    }
}

