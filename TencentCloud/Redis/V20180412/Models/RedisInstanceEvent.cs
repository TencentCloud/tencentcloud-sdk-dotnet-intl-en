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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RedisInstanceEvent : AbstractModel
    {
        
        /// <summary>
        /// Event ID.
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Event type. Currently, the type can only be related to instance migration, resource movement, and IDC deletion. This parameter can be set only to **InstanceMigration**.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Event level. The levels are divided into critical, important, medium, and general based on severity and urgency.
        ///  - Critical: critical.
        ///  - High: important.
        ///  - Middle: medium.
        ///  - Low.
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// Scheduled event execution date.
        /// </summary>
        [JsonProperty("ExecutionDate")]
        public string ExecutionDate{ get; set; }

        /// <summary>
        /// Start date of scheduled event execution.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End date of scheduled event execution.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Latest execution date of the Ops event. The event should be completed before this date. Otherwise, the business may be affected.
        /// </summary>
        [JsonProperty("LatestExecutionDate")]
        public string LatestExecutionDate{ get; set; }

        /// <summary>
        /// Current event status.
        ///  - Waiting: event not reached the execution date or not within the maintenance window.
        ///  - Running: event within the maintenance window and under maintenance execution.
        ///  - Finished: event with maintenance completed.
        /// - Canceled: Execution of the event is canceled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Completion time of the event execution task.
        /// </summary>
        [JsonProperty("TaskEndTime")]
        public string TaskEndTime{ get; set; }

        /// <summary>
        /// Event impact information.
        /// </summary>
        [JsonProperty("EffectInfo")]
        public string EffectInfo{ get; set; }

        /// <summary>
        /// Initial scheduled event execution date.
        /// </summary>
        [JsonProperty("InitialExecutionDate")]
        public string InitialExecutionDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "ExecutionDate", this.ExecutionDate);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LatestExecutionDate", this.LatestExecutionDate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskEndTime", this.TaskEndTime);
            this.SetParamSimple(map, prefix + "EffectInfo", this.EffectInfo);
            this.SetParamSimple(map, prefix + "InitialExecutionDate", this.InitialExecutionDate);
        }
    }
}

