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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAuditLogFileRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.comom/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Start time. We recommend that the interval between start and end time does not exceed 7 days.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time. We recommend that the interval between start and end time does not exceed 7 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Sort order. Valid values: "ASC" - Ascending order, "DESC" - Descending order. Default value: "DESC".
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Field to sort by. Valid values: "timestamp" - Timestamp; "affectRows" - Number of affected rows; "execTime" - Execution time. Default value: "timestamp".
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Deprecated.
        /// </summary>
        [JsonProperty("Filter")]
        [System.Obsolete]
        public AuditLogFilter Filter{ get; set; }

        /// <summary>
        /// Filter conditions. You can filter logs based on these conditions.
        /// </summary>
        [JsonProperty("LogFilter")]
        public InstanceAuditLogFilters[] LogFilter{ get; set; }

        /// <summary>
        /// Columns to include in the download.
        /// </summary>
        [JsonProperty("ColumnFilter")]
        public string[] ColumnFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArrayObj(map, prefix + "LogFilter.", this.LogFilter);
            this.SetParamArraySimple(map, prefix + "ColumnFilter.", this.ColumnFilter);
        }
    }
}

