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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBAuditLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Service product type. Currently, Cloud API only supports: dcdb, mariadb (cdb and cynosdb have been migrated to the central platform).</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>Start time, format yyyy-MM-dd HH:mm:ss.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time, format: yyyy-MM-dd HH:mm:ss.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Instance ID, required. In dcdb and mariadb scenarios, query audit logs by instance dimension.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Log type: Proxy log, DB database log, All.</p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>Sorting field. Default: Timestamp.</p>
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// <p>Sorting method: ASC for ascending order, DESC for descending order. Default: DESC.</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>Offset. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of returned results. Default: 20. Maximum: 100.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>SQL start time (millisecond-level timestamp), used when performing a join query by QueryId.</p>
        /// </summary>
        [JsonProperty("SqlStartTime")]
        public long? SqlStartTime{ get; set; }

        /// <summary>
        /// <p>A collection of query filter criteria for audit logs.</p>
        /// </summary>
        [JsonProperty("Filter")]
        public AuditLogQueryFilter Filter{ get; set; }

        /// <summary>
        /// <p>Cluster ID. Query audit logs for the dcdb product at the cluster level</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SqlStartTime", this.SqlStartTime);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
        }
    }
}

