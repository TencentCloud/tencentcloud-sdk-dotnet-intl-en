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

    public class UpdateOpsAlarmRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Specifies the unique id of the Alarm rule, obtained through the GetAlarmRule/ListAlarmRule api.
        /// </summary>
        [JsonProperty("AlarmRuleId")]
        public string AlarmRuleId{ get; set; }

        /// <summary>
        /// Specifies the new rule name of the Alarm rule.
        /// </summary>
        [JsonProperty("AlarmRuleName")]
        public string AlarmRuleName{ get; set; }

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
        /// Pass different business IDs based on the MonitorType setting:
        /// 
        /// 1 (Task): MonitorObjectIds should be a list of task IDs.
        /// 
        /// 2 (Workflow): MonitorObjectIds should be a list of workflow IDs (workflow IDs can be obtained via the ListWorkflows API).
        /// 
        /// 3 (Project): MonitorObjectIds should be a list of project IDs.
        /// </summary>
        [JsonProperty("MonitorObjectIds")]
        public string[] MonitorObjectIds{ get; set; }

        /// <summary>
        /// Alarm Rule Monitoring Types
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
        /// projectFailureInstanceUpwardVolatilityAlarm: Alarm when the upward fluctuation count of failed instances for the day exceeds the threshold
        /// 
        /// projectSuccessInstanceDownwardFluctuationAlarm: Alarm when the downward fluctuation rate of successful instances for the day exceeds the threshold
        /// 
        /// projectSuccessInstanceDownwardVolatilityAlarm: Alarm when the downward fluctuation count of successful instances for the day exceeds the threshold
        /// 
        /// projectFailureInstanceCountAlarm: Alarm when the number of failed instances for the day exceeds the threshold
        /// 
        /// projectFailureInstanceProportionAlarm: Alarm when the proportion of failed instances for the day exceeds the threshold
        /// 
        /// reconciliationFailure: Alarm when offline reconciliation task fails
        /// 
        /// reconciliationOvertime: Alarm when offline reconciliation task runs overtime
        /// 
        /// reconciliationMismatch: Alarm when the number of mismatched records in reconciliation exceeds the threshold
        /// </summary>
        [JsonProperty("AlarmTypes")]
        public string[] AlarmTypes{ get; set; }

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
        /// Enable status of the Alarm rule. valid values: 0 (disabled), 1 (enabled).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Alarm level. 1. ordinary, 2. important, 3. critical.
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public long? AlarmLevel{ get; set; }

        /// <summary>
        /// Describes the Alarm recipient configuration message.
        /// </summary>
        [JsonProperty("AlarmGroups")]
        public AlarmGroup[] AlarmGroups{ get; set; }

        /// <summary>
        /// Alarm description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AlarmRuleId", this.AlarmRuleId);
            this.SetParamSimple(map, prefix + "AlarmRuleName", this.AlarmRuleName);
            this.SetParamSimple(map, prefix + "MonitorObjectType", this.MonitorObjectType);
            this.SetParamArraySimple(map, prefix + "MonitorObjectIds.", this.MonitorObjectIds);
            this.SetParamArraySimple(map, prefix + "AlarmTypes.", this.AlarmTypes);
            this.SetParamObj(map, prefix + "AlarmRuleDetail.", this.AlarmRuleDetail);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamArrayObj(map, prefix + "AlarmGroups.", this.AlarmGroups);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

