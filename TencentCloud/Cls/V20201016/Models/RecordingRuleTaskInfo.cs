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

    public class RecordingRuleTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Pre-aggregation task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Source Log Topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Pre-aggregation task name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Creation Time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Task Update Time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Task status: 1: Running 2: Stopped 3: Error - Source log topic not found 4: Error - Target topic not found
        /// 
        /// 5: Access permission issue 6: Internal failure 7: Other faults
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Task status: 1 Enabled, 2 Disabled
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// Schedule Start Time
        /// </summary>
        [JsonProperty("ProcessStartTime")]
        public ulong? ProcessStartTime{ get; set; }

        /// <summary>
        /// Scheduling Interval (Minutes)
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// Execution Delay (Seconds)
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// Whether to enable service log shipping. Valid values: 1: disable; 2: enable.
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// Pre-aggregation search statement.
        /// </summary>
        [JsonProperty("RecordingRuleContent")]
        public string RecordingRuleContent{ get; set; }

        /// <summary>
        /// Metric name
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Custom metric name.
        /// </summary>
        [JsonProperty("CustomMetricLabels")]
        public MetricLabel[] CustomMetricLabels{ get; set; }

        /// <summary>
        /// YAML configuration file ID.
        /// </summary>
        [JsonProperty("YamlId")]
        public string YamlId{ get; set; }

        /// <summary>
        /// YAML configuration file name.
        /// </summary>
        [JsonProperty("YamlConfigName")]
        public string YamlConfigName{ get; set; }

        /// <summary>
        /// Target log topic ID
        /// </summary>
        [JsonProperty("DstTopicId")]
        public string DstTopicId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "RecordingRuleContent", this.RecordingRuleContent);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArrayObj(map, prefix + "CustomMetricLabels.", this.CustomMetricLabels);
            this.SetParamSimple(map, prefix + "YamlId", this.YamlId);
            this.SetParamSimple(map, prefix + "YamlConfigName", this.YamlConfigName);
            this.SetParamSimple(map, prefix + "DstTopicId", this.DstTopicId);
        }
    }
}

