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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Metric : AbstractModel
    {
        
        /// <summary>
        /// Alarm policy type
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Metric name
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Metric display name
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Minimum value
        /// </summary>
        [JsonProperty("Min")]
        public float? Min{ get; set; }

        /// <summary>
        /// Maximum value
        /// </summary>
        [JsonProperty("Max")]
        public float? Max{ get; set; }

        /// <summary>
        /// Dimension list
        /// </summary>
        [JsonProperty("Dimensions")]
        public string[] Dimensions{ get; set; }

        /// <summary>
        /// Unit
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Metric configuration
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetricConfig")]
        public MetricConfig MetricConfig{ get; set; }

        /// <summary>
        /// Whether it is an advanced metric. 1: Yes; 0: No.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsAdvanced")]
        public long? IsAdvanced{ get; set; }

        /// <summary>
        /// Whether the advanced metric feature is enabled. 1: Yes; 0: No.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsOpen")]
        public long? IsOpen{ get; set; }

        /// <summary>
        /// Integration center product ID.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// Matching operator
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Operators")]
        public Operator[] Operators{ get; set; }

        /// <summary>
        /// Metric monitoring granularity
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Periods")]
        public long?[] Periods{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsLatenessMetric")]
        public long? IsLatenessMetric{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamArraySimple(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamObj(map, prefix + "MetricConfig.", this.MetricConfig);
            this.SetParamSimple(map, prefix + "IsAdvanced", this.IsAdvanced);
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamArrayObj(map, prefix + "Operators.", this.Operators);
            this.SetParamArraySimple(map, prefix + "Periods.", this.Periods);
            this.SetParamSimple(map, prefix + "IsLatenessMetric", this.IsLatenessMetric);
        }
    }
}

