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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Line : AbstractModel
    {
        
        /// <summary>
        /// Metric name.
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Metric chinese name.
        /// </summary>
        [JsonProperty("MetricNameCN")]
        public string MetricNameCN{ get; set; }

        /// <summary>
        /// Time series.
        /// </summary>
        [JsonProperty("TimeSerial")]
        public long?[] TimeSerial{ get; set; }

        /// <summary>
        /// Data sequence.
        /// </summary>
        [JsonProperty("DataSerial")]
        public float?[] DataSerial{ get; set; }

        /// <summary>
        /// Dimension list.
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "MetricNameCN", this.MetricNameCN);
            this.SetParamArraySimple(map, prefix + "TimeSerial.", this.TimeSerial);
            this.SetParamArraySimple(map, prefix + "DataSerial.", this.DataSerial);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

