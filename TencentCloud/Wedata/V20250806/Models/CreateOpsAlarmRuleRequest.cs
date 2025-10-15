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

    public class CreateOpsAlarmRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Specifies the Alarm rule name.
        /// </summary>
        [JsonProperty("AlarmRuleName")]
        public string AlarmRuleName{ get; set; }

        /// <summary>
        /// Monitoring Object Business ID List - Pass different business IDs depending on the value of MonitorType:
        /// 
        /// 1 (Task): MonitorObjectIds should contain a list of task IDs.
        /// 
        /// 2 (Workflow): MonitorObjectIds should contain a list of workflow IDs (workflow IDs can be obtained using the ListWorkflows API).
        /// 
        /// 3 (Project): MonitorObjectIds should contain a list of project IDs.
        /// </summary>
        [JsonProperty("MonitorObjectIds")]
        public string[] MonitorObjectIds{ get; set; }

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
        [JsonProperty("AlarmTypes")]
        public string[] AlarmTypes{ get; set; }

        /// <summary>
        /// Alarm recipient configuration.
        /// </summary>
        [JsonProperty("AlarmGroups")]
        public AlarmGroup[] AlarmGroups{ get; set; }

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
        public ulong? MonitorObjectType{ get; set; }

        /// <summary>
        /// Alarm Rule Configuration Information
        /// 
        /// Success Alarms - No configuration required;
        /// 
        /// Failure Alarms - Can be configured to trigger on the first failure or on all retry failures;
        /// 
        /// Timeout Alarms - Require configuration of the timeout type and timeout threshold;
        /// 
        /// Project Fluctuation Alarms - Require configuration of the fluctuation rate and the debounce cycle.
        /// </summary>
        [JsonProperty("AlarmRuleDetail")]
        public AlarmRuleDetail AlarmRuleDetail{ get; set; }

        /// <summary>
        /// Alarm level. 1. ordinary, 2. important, 3. critical (default: 1. ordinary).
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public long? AlarmLevel{ get; set; }

        /// <summary>
        /// Describes the Alarm rule.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AlarmRuleName", this.AlarmRuleName);
            this.SetParamArraySimple(map, prefix + "MonitorObjectIds.", this.MonitorObjectIds);
            this.SetParamArraySimple(map, prefix + "AlarmTypes.", this.AlarmTypes);
            this.SetParamArrayObj(map, prefix + "AlarmGroups.", this.AlarmGroups);
            this.SetParamSimple(map, prefix + "MonitorObjectType", this.MonitorObjectType);
            this.SetParamObj(map, prefix + "AlarmRuleDetail.", this.AlarmRuleDetail);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

