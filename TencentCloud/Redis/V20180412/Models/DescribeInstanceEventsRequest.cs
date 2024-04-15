/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// Configures the start date for querying the event execution schedule.
        /// </summary>
        [JsonProperty("ExecutionStartDate")]
        public string ExecutionStartDate{ get; set; }

        /// <summary>
        /// Configures the end date for querying the event execution schedule.
        /// </summary>
        [JsonProperty("ExecutionEndDate")]
        public string ExecutionEndDate{ get; set; }

        /// <summary>
        /// Specifies the instance ID. Example: crs-xjhsdj****. Log in to the [TencentDB for Redis console](https://console.cloud.tencent.com/redis) and copy the instance ID in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Outputs the number of events displayed per page. Default value: 10.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Configures the page number for querying events. You can query events on a certain page by specifying PageNo and PageSize. Default value: 1.
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// Current status of the event.- Waiting: The event is waiting for execution on the execution date or during the operations period.- Running: The event is being executed during the operations period.- Finished: Execution of the event is completed.- Canceled: Execution of the event is canceled.
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// Event type. Currently, the type can only be related to instance migration, resource movement, and IDC deletion. This parameter can be set only to **InstanceMigration**.
        /// </summary>
        [JsonProperty("EventTypes")]
        public string[] EventTypes{ get; set; }

        /// <summary>
        /// Configures the level of the queried event. Events are divided into Critical, High, Medium, and Low events according to the severity and urgency.- Critical- High- Medium- Low
        /// </summary>
        [JsonProperty("Grades")]
        public string[] Grades{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutionStartDate", this.ExecutionStartDate);
            this.SetParamSimple(map, prefix + "ExecutionEndDate", this.ExecutionEndDate);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "EventTypes.", this.EventTypes);
            this.SetParamArraySimple(map, prefix + "Grades.", this.Grades);
        }
    }
}

