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

    public class CreateRecordingRuleYamlTaskRequest : AbstractModel
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
        /// <p>Scheduling period (minutes). Supported range (0,1440] minutes.</p><p>Measurement unit: minutes</p><p>Can also use interval: duration in YAML to set execution interval individually for each group.</p>
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// <p>Execution delay. Set it to 30 seconds to avoid inaccuracy in pre-aggregation task calculation results due to latency in metric reporting.</p><p>Unit: seconds</p>
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// <p>yaml configuration name</p>
        /// </summary>
        [JsonProperty("YamlConfigName")]
        public string YamlConfigName{ get; set; }

        /// <summary>
        /// <p>yaml configuration content</p><p>Compatible with Prometheus Recording Rules configuration files. Please note the line breaks and indent in the string during API calls.</p>
        /// </summary>
        [JsonProperty("YamlContent")]
        public string YamlContent{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "YamlConfigName", this.YamlConfigName);
            this.SetParamSimple(map, prefix + "YamlContent", this.YamlContent);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
        }
    }
}

