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

    public class CreateRecordingRuleTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Source metric topic id</p><p>For reference:</p><ul><li><a href="https://www.tencentcloud.com/document/api/614/56454?from_cn_redirect=1">DescribeTopics</a></li><li><a href="https://console.cloud.tencent.com/cls/metric">metric topic</a></li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Target metric topic id, which can be the same as TopicId.</p>
        /// </summary>
        [JsonProperty("DstTopicId")]
        public string DstTopicId{ get; set; }

        /// <summary>
        /// <p>Pre-aggregation task name</p><p>Input parameter restrictions: Only letters, numbers, and underscores are allowed. Cannot begin with an underscore. Less than 256 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Task status. Valid values: 1: enabled; 2: disabled.</p>
        /// </summary>
        [JsonProperty("EnableFlag")]
        public ulong? EnableFlag{ get; set; }

        /// <summary>
        /// <p>Execution start time, Unix timestamp.</p><p>Unit: ms.</p>
        /// </summary>
        [JsonProperty("ProcessStartTime")]
        public ulong? ProcessStartTime{ get; set; }

        /// <summary>
        /// <p>Scheduling period (minutes). Supported range (0,1440] minutes.</p>
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// <p>Execution delay. Set it to 30 seconds to avoid inaccuracy in pre-aggregation task calculation results due to latency in metric reporting.</p><p>Unit: seconds</p>
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// <p>Execution statement (PromQL)</p>
        /// </summary>
        [JsonProperty("RecordingRuleContent")]
        public string RecordingRuleContent{ get; set; }

        /// <summary>
        /// <p>Metric name</p>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// <p>Metric custom dimension</p>
        /// </summary>
        [JsonProperty("CustomMetricLabels")]
        public MetricLabel[] CustomMetricLabels{ get; set; }

        /// <summary>
        /// <p>Whether to enable the delivery service log. 1: Disabled, 2: Enabled.</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "DstTopicId", this.DstTopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "RecordingRuleContent", this.RecordingRuleContent);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArrayObj(map, prefix + "CustomMetricLabels.", this.CustomMetricLabels);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
        }
    }
}

