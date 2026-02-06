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

    public class DescribeGeneralMetricDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Metric name to be queried, which cannot be customized. (for details, see <https://intl.cloud.tencent.com/document/product/248/101681?from_cn_redirect=1>.).
        /// </summary>
        [JsonProperty("Metrics")]
        public string[] Metrics{ get; set; }

        /// <summary>
        /// Business system id.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// View name. the input cannot be customized. [for details, see.](https://intl.cloud.tencent.com/document/product/248/101681?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// The dimension information to be filtered; different views have corresponding metric dimensions. (for details, see <https://intl.cloud.tencent.com/document/product/248/101681?from_cn_redirect=1>.).
        /// </summary>
        [JsonProperty("Filters")]
        public GeneralFilter[] Filters{ get; set; }

        /// <summary>
        /// Aggregated dimension; different views have corresponding metric dimensions. (for details, see <https://intl.cloud.tencent.com/document/product/248/101681?from_cn_redirect=1>.).
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// The timestamp of the start time, supporting the query of metric data within 30 days. (unit: seconds).
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// The timestamp of the end time, supporting the query of metric data within 30 days. (unit: seconds).
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Whether to aggregate by a fixed time span: enter 1 for values of 1 and greater, and 0 if not filled in.
        /// -If 0 is filled in, it calculates the metric data from the start time to the cutoff time.
        /// - if 1 is filled in, the aggregation granularity will be selected according to the time span from the start time to the deadline:.
        ///  -If the time span is (0,12) hours, it is aggregated by one-minute granularity.
        ///  -If the time span is [12,48] hours, it is aggregated at a five-minute granularity.
        ///  -If the time span is (48, +inf) hours, it is aggregated at an hourly granularity.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Sort query metrics.
        /// Key: enter the tencentcloud api metric name. [for details, see](https://intl.cloud.tencent.com/document/product/248/101681?from_cn_redirect=1) .
        /// Value: specify the sorting method:.     
        /// -Asc: sorts query metrics in ascending order.
        /// - desc: sort query metrics in descending order.
        /// </summary>
        [JsonProperty("OrderBy")]
        public OrderBy OrderBy{ get; set; }

        /// <summary>
        /// Maximum number of queried metrics. currently, up to 50 data entries can be displayed. the value range for pagesize is 1-50. submit pagesize to show the limited number based on the value of pagesize.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamObj(map, prefix + "OrderBy.", this.OrderBy);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

