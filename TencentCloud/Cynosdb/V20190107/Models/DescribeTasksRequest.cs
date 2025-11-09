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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// Starting value of the task start time.
        /// </summary>
        [JsonProperty("StartTimeBegin")]
        public string StartTimeBegin{ get; set; }

        /// <summary>
        /// End value of the task start time.
        /// </summary>
        [JsonProperty("StartTimeEnd")]
        public string StartTimeEnd{ get; set; }

        /// <summary>
        /// Filtering conditions. Supported fields for searching: "ClusterId", "ClusterName", "InstanceId", "InstanceName", "Status", "TaskId", and "TaskType".
        /// </summary>
        [JsonProperty("Filters")]
        public QueryFilter[] Filters{ get; set; }

        /// <summary>
        /// Length of the list to be queried.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Offset of the list to be queried.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeBegin", this.StartTimeBegin);
            this.SetParamSimple(map, prefix + "StartTimeEnd", this.StartTimeEnd);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

