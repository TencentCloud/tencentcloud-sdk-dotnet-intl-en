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

    public class ModifyInstanceEventRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the instance ID. Example: crs-xjhsdj****. Log in to the [TencentDB for Redis console](https://console.cloud.tencent.com/redis#/) and copy the instance ID in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Event ID. Obtain the ID of the event to be modified using DescribeInstanceEvents.
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// Modifies the scheduled start time of event execution.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Modifies the scheduled end time of event execution. After the start time is configured, the end time can only be 30 minutes, 1 hour, 1.5 hours, 2 hours, or 3 hours later than the start time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Modifies the start date of the event execution schedule.
        /// </summary>
        [JsonProperty("ExecutionDate")]
        public string ExecutionDate{ get; set; }

        /// <summary>
        /// Modifies the running status of the event. Currently, this parameter can be set only to **Canceled**, indicating that the execution of the current event is canceled. You can query the running status and level of the current event using DescribeInstanceEvents.- Critical or High events cannot be canceled, which means that they must be executed.- Only events in the Waiting state (to be executed) can be canceled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecutionDate", this.ExecutionDate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

