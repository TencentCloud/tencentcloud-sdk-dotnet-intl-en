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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulFixTaskDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Repair task ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// <p>Paging offset<br>Value range: [0, +∞)<br>Default value: 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of results per page<br>Value range: [1, 100]<br>Default value: 10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Filter criteria<br>Supported Filter.Name:<br>InstanceId - Exact match. Filter by host instance ID.<br>VulId - Exact match. Filter by vulnerability ID to filter out hosts under a vulnerability.<br>KBId - Exact match. Filter by KB Patch ID to filter out hosts under a KB patch.<br>Status - Exact match. Filter by execution status: 0-Initial status 1-Issued 11-Confirmed by client 2-Repair completed 3-Client offline 4-Timeout 5-Failed 6-Unsupported 9-Waiting for snapshot creation 10-Snapshot creation failed<br>FixStatus - Exact match. Filter by fix result: 0-Initial status 1-Repair successful 2-Failed to fix<br>SnapshotStatus - Exact match. Filter by snapshot status: -1-No need to create snapshot 0-Not started 1-In progress 2-Completed 3-Creation failed</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Sorting field<br>Enumeration values:<br>StartTime: sort by repair start time<br>EndTime: sort by repair end time</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting method<br>Enumeration values:<br>asc: in ascending order<br>desc: in descending order<br>Default value: desc</p>
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

