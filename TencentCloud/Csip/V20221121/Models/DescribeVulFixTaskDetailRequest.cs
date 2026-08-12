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
        /// <p>Paging offset<br>Value ranges from 0 to +∞<br>Default value: 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of results per page<br>Value ranges from 1 to 100<br>Default value: 10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Filter criteria<br>Supported Filter.Name:<br>InstanceId - Exact match, filter by host instance ID<br>VulId - Exact match, filter by vulnerability ID, filter out hosts under a certain vulnerability<br>KBId - Exact match, filter by KB Patch ID, filter out hosts under a certain KB patch<br>Status - Exact match, filter by execution status: 0-Initial status 1-Issued 11-Client confirmed 2-Repair completed 3-Client offline 4-Timeout 5-Failure 6-No support 9-Waiting for snapshot creation to complete 10-Snapshot creation failed<br>FixStatus - Exact match, filter by repair result: 0-Initial status 1-Repair successful 2-Fix failure<br>SnapshotStatus - Exact match, filter by snapshot status: -1-No need to create snapshot 0-Not started 1-In progress 2-Completed 3-Creation failure</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Sorting field<br>Enumeration value:<br>StartTime: Sort by repair start time<br>EndTime: Sort by repair end time</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>Sorting method<br>Enumeration value:<br>asc: Ascending<br>desc: Descending<br>Default value: desc</p>
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

