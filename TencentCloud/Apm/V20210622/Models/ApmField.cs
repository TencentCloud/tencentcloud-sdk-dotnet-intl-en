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

    public class ApmField : AbstractModel
    {
        
        /// <summary>
        /// Metric name.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Indicator numerical value.
        /// </summary>
        [JsonProperty("Value")]
        public float? Value{ get; set; }

        /// <summary>
        /// Units corresponding to the metric.
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Year-Over-Year result array, recommended to use.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CompareVals")]
        public APMKVItem[] CompareVals{ get; set; }

        /// <summary>
        /// Indicator numerical value of the previous period in year-over-year comparison.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastPeriodValue")]
        public APMKV[] LastPeriodValue{ get; set; }

        /// <summary>
        /// Year-On-Year metric value. deprecated, not recommended for use.
        /// </summary>
        [JsonProperty("CompareVal")]
        public string CompareVal{ get; set; }

        /// <summary>
        /// Metric Chinese Name
        /// </summary>
        [JsonProperty("NameCN")]
        public string NameCN{ get; set; }

        /// <summary>
        /// Metric English name
        /// </summary>
        [JsonProperty("NameEN")]
        public string NameEN{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamArrayObj(map, prefix + "CompareVals.", this.CompareVals);
            this.SetParamArrayObj(map, prefix + "LastPeriodValue.", this.LastPeriodValue);
            this.SetParamSimple(map, prefix + "CompareVal", this.CompareVal);
            this.SetParamSimple(map, prefix + "NameCN", this.NameCN);
            this.SetParamSimple(map, prefix + "NameEN", this.NameEN);
        }
    }
}

