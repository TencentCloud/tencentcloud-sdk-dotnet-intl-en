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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduledAction : AbstractModel
    {
        
        /// <summary>
        /// Scheduled task ID.
        /// </summary>
        [JsonProperty("ScheduledActionId")]
        public string ScheduledActionId{ get; set; }

        /// <summary>
        /// Scheduled task name.
        /// </summary>
        [JsonProperty("ScheduledActionName")]
        public string ScheduledActionName{ get; set; }

        /// <summary>
        /// ID of the auto scaling group where the scheduled task is located.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Start time of the scheduled task. The value is in `Beijing time` (UTC+8) in the format of `YYYY-MM-DDThh:mm:ss+08:00` according to the `ISO8601` standard.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Repeating mode of the scheduled task.
        /// </summary>
        [JsonProperty("Recurrence")]
        public string Recurrence{ get; set; }

        /// <summary>
        /// End time of the scheduled task. The value is in `Beijing time` (UTC+8) in the format of `YYYY-MM-DDThh:mm:ss+08:00` according to the `ISO8601` standard.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Maximum number of instances set by the scheduled task.
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// Desired number of instances set by the scheduled task.
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// Minimum number of instances set by the scheduled task.
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// Creation time of the scheduled task. The value is in `UTC time` in the format of `YYYY-MM-DDThh:mm:ssZ` according to the `ISO8601` standard.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Scheduled task execution type. Valid values:
        /// <li>CRONTAB: repeated execution.</li>
        /// <li>ONCE: single execution.</li>
        /// </summary>
        [JsonProperty("ScheduledType")]
        public string ScheduledType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduledActionId", this.ScheduledActionId);
            this.SetParamSimple(map, prefix + "ScheduledActionName", this.ScheduledActionName);
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Recurrence", this.Recurrence);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ScheduledType", this.ScheduledType);
        }
    }
}

