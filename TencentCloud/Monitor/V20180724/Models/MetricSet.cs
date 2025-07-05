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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricSet : AbstractModel
    {
        
        /// <summary>
        /// Namespace. Each Tencent Cloud product has a namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Metric Name
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Unit used by the metric
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Unit used by the metric
        /// </summary>
        [JsonProperty("UnitCname")]
        public string UnitCname{ get; set; }

        /// <summary>
        /// Statistical period in seconds supported by the metric, such as 60 and 300
        /// </summary>
        [JsonProperty("Period")]
        public long?[] Period{ get; set; }

        /// <summary>
        /// Metric method during the statistical period
        /// </summary>
        [JsonProperty("Periods")]
        public PeriodsSt[] Periods{ get; set; }

        /// <summary>
        /// Meaning of the statistical metric
        /// </summary>
        [JsonProperty("Meaning")]
        public MetricObjectMeaning Meaning{ get; set; }

        /// <summary>
        /// Dimension description
        /// </summary>
        [JsonProperty("Dimensions")]
        public DimensionsDesc[] Dimensions{ get; set; }

        /// <summary>
        /// Metric name (in Chinese).
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetricCName")]
        public string MetricCName{ get; set; }

        /// <summary>
        /// Metric name (in English).
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetricEName")]
        public string MetricEName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "UnitCname", this.UnitCname);
            this.SetParamArraySimple(map, prefix + "Period.", this.Period);
            this.SetParamArrayObj(map, prefix + "Periods.", this.Periods);
            this.SetParamObj(map, prefix + "Meaning.", this.Meaning);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamSimple(map, prefix + "MetricCName", this.MetricCName);
            this.SetParamSimple(map, prefix + "MetricEName", this.MetricEName);
        }
    }
}

