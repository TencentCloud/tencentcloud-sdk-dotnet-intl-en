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

    public class AlarmRuleDetail : AbstractModel
    {
        
        /// <summary>
        /// Failure Trigger Condition
        /// 
        /// 1: Trigger on the first failure
        /// 
        /// 2: Trigger after all retries are completed (default)
        /// </summary>
        [JsonProperty("Trigger")]
        public long? Trigger{ get; set; }

        /// <summary>
        /// Backfill/Rerun Trigger Condition
        /// 
        /// 1: Trigger on the first failure
        /// 
        /// 2: Trigger after all retries are completed
        /// </summary>
        [JsonProperty("DataBackfillOrRerunTrigger")]
        public long? DataBackfillOrRerunTrigger{ get; set; }

        /// <summary>
        /// Timeout configuration of the periodic instance.
        /// </summary>
        [JsonProperty("TimeOutExtInfo")]
        public TimeOutStrategyInfo[] TimeOutExtInfo{ get; set; }

        /// <summary>
        /// Specifies the timeout configuration details for rerunning a backfill instance.
        /// </summary>
        [JsonProperty("DataBackfillOrRerunTimeOutExtInfo")]
        public TimeOutStrategyInfo[] DataBackfillOrRerunTimeOutExtInfo{ get; set; }

        /// <summary>
        /// Specifies the detail of Alarm configuration for project fluctuation.
        /// </summary>
        [JsonProperty("ProjectInstanceStatisticsAlarmInfoList")]
        public ProjectInstanceStatisticsAlarmInfo[] ProjectInstanceStatisticsAlarmInfoList{ get; set; }

        /// <summary>
        /// Describes the Alarm configuration information for offline integration reconciliation.
        /// </summary>
        [JsonProperty("ReconciliationExtInfo")]
        public ReconciliationStrategyInfo[] ReconciliationExtInfo{ get; set; }

        /// <summary>
        /// Configure allowlist for monitored object.
        /// </summary>
        [JsonProperty("MonitorWhiteTasks")]
        public MonitorWhiteTask[] MonitorWhiteTasks{ get; set; }

        /// <summary>
        /// 3.0 Workflow completion time (period) Alarm policy.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkflowCompletionTimeCycleExtInfo")]
        public TimeOutStrategyInfo[] WorkflowCompletionTimeCycleExtInfo{ get; set; }

        /// <summary>
        /// Workflow execution triggers the Alarm condition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkflowExecutionTrigger")]
        public long? WorkflowExecutionTrigger{ get; set; }

        /// <summary>
        /// Workflow execution failure Alarm condition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkflowExecutionFailureTrigger")]
        public long? WorkflowExecutionFailureTrigger{ get; set; }

        /// <summary>
        /// Workflow execution successful Alarm condition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkflowExecutionSuccessTrigger")]
        public long? WorkflowExecutionSuccessTrigger{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Trigger", this.Trigger);
            this.SetParamSimple(map, prefix + "DataBackfillOrRerunTrigger", this.DataBackfillOrRerunTrigger);
            this.SetParamArrayObj(map, prefix + "TimeOutExtInfo.", this.TimeOutExtInfo);
            this.SetParamArrayObj(map, prefix + "DataBackfillOrRerunTimeOutExtInfo.", this.DataBackfillOrRerunTimeOutExtInfo);
            this.SetParamArrayObj(map, prefix + "ProjectInstanceStatisticsAlarmInfoList.", this.ProjectInstanceStatisticsAlarmInfoList);
            this.SetParamArrayObj(map, prefix + "ReconciliationExtInfo.", this.ReconciliationExtInfo);
            this.SetParamArrayObj(map, prefix + "MonitorWhiteTasks.", this.MonitorWhiteTasks);
            this.SetParamArrayObj(map, prefix + "WorkflowCompletionTimeCycleExtInfo.", this.WorkflowCompletionTimeCycleExtInfo);
            this.SetParamSimple(map, prefix + "WorkflowExecutionTrigger", this.WorkflowExecutionTrigger);
            this.SetParamSimple(map, prefix + "WorkflowExecutionFailureTrigger", this.WorkflowExecutionFailureTrigger);
            this.SetParamSimple(map, prefix + "WorkflowExecutionSuccessTrigger", this.WorkflowExecutionSuccessTrigger);
        }
    }
}

