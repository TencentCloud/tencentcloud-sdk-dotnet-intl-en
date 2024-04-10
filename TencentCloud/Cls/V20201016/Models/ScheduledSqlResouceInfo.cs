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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduledSqlResouceInfo : AbstractModel
    {
        
        /// <summary>
        /// Target topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Region information for the topic
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Topic type: 0 for log topic, and 1 for metric topic
        /// </summary>
        [JsonProperty("BizType")]
        public long? BizType{ get; set; }

        /// <summary>
        /// Metric name. When BizType is 1, MetricName needs to be specified.
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Metric NameWhen BizType is 1, prioritize using the MetricNames field. Multiple metrics can only be filled in the MetricNames field, while it's recommended to fill a single metric in the MetricName field.
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// Metric dimension. Not accept time type.
        /// </summary>
        [JsonProperty("MetricLabels")]
        public string[] MetricLabels{ get; set; }

        /// <summary>
        /// Metric timestamp. The default value is the left time point of the SQL query time range, but you can also specify other fields (The type is uinx time, TimeStamp, and precision millisecond) as the metric timestamp.
        /// </summary>
        [JsonProperty("CustomTime")]
        public string CustomTime{ get; set; }

        /// <summary>
        /// In addition to MetricLabels, this parameter can be used to supplement static dimensions for the metric.
        /// Dimension names must start with a letter or underscore, followed by letters, digits, or underscores, with a length less than or equal to 1024 bytes.
        /// </summary>
        [JsonProperty("CustomMetricLabels")]
        public MetricLabel[] CustomMetricLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArraySimple(map, prefix + "MetricLabels.", this.MetricLabels);
            this.SetParamSimple(map, prefix + "CustomTime", this.CustomTime);
            this.SetParamArrayObj(map, prefix + "CustomMetricLabels.", this.CustomMetricLabels);
        }
    }
}

