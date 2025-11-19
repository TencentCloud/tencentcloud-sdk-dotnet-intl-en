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

    public class DescribeMetricRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// Metric list.
        /// </summary>
        [JsonProperty("Metrics")]
        public QueryMetricItem[] Metrics{ get; set; }

        /// <summary>
        /// Business system id.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Start time (unit: sec).
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// End time (unit: seconds).
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// Aggregation dimension.
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// Filter criteria.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Or filter criteria.
        /// </summary>
        [JsonProperty("OrFilters")]
        public Filter[] OrFilters{ get; set; }

        /// <summary>
        /// Sort
        /// .
        /// The currently supported keys are:.
        /// 
        /// -StartTime (start time).
        /// -EndTime (end time).
        /// -Duration (response time).
        /// 
        /// The currently supported values are:.
        /// 
        /// - desc: sort in descending order.
        /// -Asc - ascending order.
        /// </summary>
        [JsonProperty("OrderBy")]
        public OrderBy OrderBy{ get; set; }

        /// <summary>
        /// The service name of the business itself. console users should fill in taw.
        /// </summary>
        [JsonProperty("BusinessName")]
        public string BusinessName{ get; set; }

        /// <summary>
        /// Special handling of query results.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Size per page, defaults to 1,000, valid value range is 0 – 1,000.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Paging starting point.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Page number.
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// Page length.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrFilters.", this.OrFilters);
            this.SetParamObj(map, prefix + "OrderBy.", this.OrderBy);
            this.SetParamSimple(map, prefix + "BusinessName", this.BusinessName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

