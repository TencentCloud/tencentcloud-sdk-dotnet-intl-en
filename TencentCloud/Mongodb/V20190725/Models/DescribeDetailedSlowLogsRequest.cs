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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDetailedSlowLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the start time for querying slow logs. - Format: yyyy-mm-dd hh:mm:ss. For example, 2019-06-01 10:00:00. - The query start and end time interval cannot exceed 24 hours. Only slow logs within the last 7 days can be queried.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Specifies the end time for querying slow logs.
        /// - Format: yyyy-mm-dd hh:mm:ss. For example, 2019-06-02 12:00:00.
        /// - The query start and end time interval cannot exceed 24 hours. Only slow logs within the last 7 days can be queried.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Specifies the threshold for querying slow logs, in milliseconds. It indicates that the execution time of the slow log query exceeds this value. The default value is 100.
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// Specifies the command type for querying slow logs.
        /// </summary>
        [JsonProperty("Commands")]
        public string[] Commands{ get; set; }

        /// <summary>
        /// Full-text search keyword. The logical operator among multiple keywords is OR.
        /// </summary>
        [JsonProperty("Texts")]
        public string[] Texts{ get; set; }

        /// <summary>
        /// Specifies the node name for querying slow logs. The [DescribeDBInstanceNodeProperty](https://www.tencentcloud.com/document/product/240/82022?from_cn_redirect=1) API can be called to query the node name.
        /// </summary>
        [JsonProperty("NodeNames")]
        public string[] NodeNames{ get; set; }

        /// <summary>
        /// Specifies the queryHash value to be queried.
        /// </summary>
        [JsonProperty("QueryHash")]
        public string[] QueryHash{ get; set; }

        /// <summary>
        /// Pagination offset. The default value is 0, and the value range is [0, 100].
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned entries. The default value is 20, and the value range is [0, 10000].
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Specifies the sorting condition for slow logs.
        /// - StartTime: sort by the generation time of slow logs.
        /// - ExecTime: sort by the execution time of slow logs.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Specifies the sorting method.
        /// - desc: descending order.
        /// - asc: ascending order.
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamArraySimple(map, prefix + "Commands.", this.Commands);
            this.SetParamArraySimple(map, prefix + "Texts.", this.Texts);
            this.SetParamArraySimple(map, prefix + "NodeNames.", this.NodeNames);
            this.SetParamArraySimple(map, prefix + "QueryHash.", this.QueryHash);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

