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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListOpsAlarmRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Page number for pagination. defaults to 1.
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Number of items to display per page, defaults to 20, minimum value 1, maximum value 200.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Monitoring Object Type
        /// 
        /// Task-level Monitoring - Can be configured by Task / Workflow / Project:
        /// 1 = Task (default)
        /// 2 = Workflow
        /// 3 = Project
        /// 
        /// Project-level Monitoring - Monitors overall task fluctuations within a project:
        /// 7 = Project fluctuation monitoring alarm
        /// </summary>
        [JsonProperty("MonitorObjectType")]
        public long? MonitorObjectType{ get; set; }

        /// <summary>
        /// Based on task id, queries Alarm rules.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Alarm Rule Monitoring Types:
        /// 
        /// failure: Failure alarm
        /// 
        /// overtime: Timeout alarm
        /// 
        /// success: Success alarm
        /// 
        /// backTrackingOrRerunSuccess: Alarm when backfill/rerun succeeds
        /// 
        /// backTrackingOrRerunFailure: Alarm when backfill/rerun fails
        /// 
        /// projectFailureInstanceUpwardFluctuationAlarm: Alarm when the upward fluctuation rate of failed instances for the day exceeds the threshold
        /// 
        /// projectSuccessInstanceDownwardFluctuationAlarm: Alarm when the downward fluctuation rate of successful instances for the day exceeds the threshold
        /// 
        /// reconciliationFailure: Alarm when an offline reconciliation task fails
        /// 
        /// reconciliationOvertime: Alarm when an offline reconciliation task runs overtime
        /// 
        /// reconciliationMismatch: Alarm when the number of mismatched records in reconciliation exceeds the threshold
        /// </summary>
        [JsonProperty("AlarmType")]
        public string AlarmType{ get; set; }

        /// <summary>
        /// Queries Alarm rules configured with corresponding Alarm levels.
        /// Valid values: 1. ordinary, 2. important, 3. critical.
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public long? AlarmLevel{ get; set; }

        /// <summary>
        /// Query the alarm rules associated with the configured alarm recipients.
        /// </summary>
        [JsonProperty("AlarmRecipientId")]
        public string AlarmRecipientId{ get; set; }

        /// <summary>
        /// Queries the corresponding Alarm rule based on Alarm rule id or rule name.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// Specifies the creator filter for Alarm rule creation.
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// Start time of the Alarm rule create time range, in the format of 2025-08-17 00:00:00.
        /// </summary>
        [JsonProperty("CreateTimeFrom")]
        public string CreateTimeFrom{ get; set; }

        /// <summary>
        /// End time of the Alarm rule creation time range, in the format of "2025-08-26 23:59:59".
        /// </summary>
        [JsonProperty("CreateTimeTo")]
        public string CreateTimeTo{ get; set; }

        /// <summary>
        /// Filters Alarm rules by last update time, in the format of "2025-08-26 00:00:00".
        /// </summary>
        [JsonProperty("UpdateTimeFrom")]
        public string UpdateTimeFrom{ get; set; }

        /// <summary>
        /// Filters Alarm rules by last update time in the format of "2025-08-26 23:59:59".
        /// </summary>
        [JsonProperty("UpdateTimeTo")]
        public string UpdateTimeTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "MonitorObjectType", this.MonitorObjectType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "AlarmRecipientId", this.AlarmRecipientId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "CreateTimeFrom", this.CreateTimeFrom);
            this.SetParamSimple(map, prefix + "CreateTimeTo", this.CreateTimeTo);
            this.SetParamSimple(map, prefix + "UpdateTimeFrom", this.UpdateTimeFrom);
            this.SetParamSimple(map, prefix + "UpdateTimeTo", this.UpdateTimeTo);
        }
    }
}

