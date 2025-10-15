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

    public class OpsWorkflowDetail : AbstractModel
    {
        
        /// <summary>
        /// Workflow ID.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Workflow description.
        /// </summary>
        [JsonProperty("WorkflowDesc")]
        public string WorkflowDesc{ get; set; }

        /// <summary>
        /// Specifies the workflow type.
        /// -cycle.
        /// -manual.
        /// </summary>
        [JsonProperty("WorkflowType")]
        public string WorkflowType{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Creator
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// Modification time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Delayed execution time. unit: minute.
        /// </summary>
        [JsonProperty("StartupTime")]
        public ulong? StartupTime{ get; set; }

        /// <summary>
        /// Effective date. specifies the start date.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Configure end date end date.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Task Cycle Type
        /// 
        /// * ONEOFF_CYCLE: One-time
        /// 
        /// * YEAR_CYCLE: Yearly
        /// 
        /// * MONTH_CYCLE: Monthly
        /// 
        /// * WEEK_CYCLE: Weekly
        /// 
        /// * DAY_CYCLE: Daily
        /// 
        /// * HOUR_CYCLE: Hourly
        /// 
        /// * MINUTE_CYCLE: Minute-level
        /// 
        /// * CRONTAB_CYCLE: Crontab expression-based
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// Folder ID
        /// 
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// Task instance initialization strategy.
        /// -T_PLUS_1 (t+1): initializes with a one-day delay.
        /// -T_PLUS_0 (t+0): initialize on the day.
        /// -T_MINUS_1 (t-1): initialize one day in advance.
        /// </summary>
        [JsonProperty("InstanceInitStrategy")]
        public string InstanceInitStrategy{ get; set; }

        /// <summary>
        /// Specifies the scheduling plan interpretation.
        /// </summary>
        [JsonProperty("SchedulerDesc")]
        public string SchedulerDesc{ get; set; }

        /// <summary>
        /// First submission time of workflow.
        /// </summary>
        [JsonProperty("FirstSubmitTime")]
        public string FirstSubmitTime{ get; set; }

        /// <summary>
        /// Latest submission time of workflow.
        /// </summary>
        [JsonProperty("LatestSubmitTime")]
        public string LatestSubmitTime{ get; set; }

        /// <summary>
        /// Workflow Status
        /// 
        /// * ALL_RUNNING: All running (all workflows are in scheduling state)
        /// 
        /// * ALL_FREEZED: All paused
        /// 
        /// * ALL_STOPPTED: All stopped
        /// 
        /// * PART_RUNNING: Partially running (some workflows are running, others not)
        /// 
        /// * ALL_NO_RUNNING: All not scheduled
        /// 
        /// * ALL_INVALID: All invalid
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Person in charge. multiple values are separated by a ";" separator.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Workflow name.
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowDesc", this.WorkflowDesc);
            this.SetParamSimple(map, prefix + "WorkflowType", this.WorkflowType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "InstanceInitStrategy", this.InstanceInitStrategy);
            this.SetParamSimple(map, prefix + "SchedulerDesc", this.SchedulerDesc);
            this.SetParamSimple(map, prefix + "FirstSubmitTime", this.FirstSubmitTime);
            this.SetParamSimple(map, prefix + "LatestSubmitTime", this.LatestSubmitTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
        }
    }
}

