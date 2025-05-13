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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewWorkflowSchedulerInfoDsRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Workflow ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Delay Time
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// Start Time
        /// </summary>
        [JsonProperty("StartupTime")]
        public ulong? StartupTime{ get; set; }

        /// <summary>
        /// Task Dependency
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// Start Time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End Time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Specified Running Time
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// Scheduling Cycle Time Unit
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// Scheduling Cycle
        /// </summary>
        [JsonProperty("CycleStep")]
        public long? CycleStep{ get; set; }

        /// <summary>
        /// Execution Time Left Closed Interval
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// Execution Time Right Closed Interval
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// Task initialization strategy. valid values: T_PLUS_1, T_PLUS_0, T_MINUS_1
        /// </summary>
        [JsonProperty("InstanceInitStrategy")]
        public string InstanceInitStrategy{ get; set; }

        /// <summary>
        /// Workflow dependency. valid values: yes or no
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// CrontabExpression
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// 0: Do not modify 
        /// 1: Change the upstream dependency configuration of the task to the default value
        /// </summary>
        [JsonProperty("ModifyCycleValue")]
        public string ModifyCycleValue{ get; set; }

        /// <summary>
        /// Whether calendar scheduling is enabled. 1 means enabled, and 0 means disabled.
        /// </summary>
        [JsonProperty("CalendarOpen")]
        public string CalendarOpen{ get; set; }

        /// <summary>
        /// Calendar name.
        /// </summary>
        [JsonProperty("CalendarName")]
        public string CalendarName{ get; set; }

        /// <summary>
        /// Calendar id.
        /// </summary>
        [JsonProperty("CalendarId")]
        public string CalendarId{ get; set; }

        /// <summary>
        /// Specifies the time zone.
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// Whether to automatically clean up links to unsupported tasks.
        /// </summary>
        [JsonProperty("ClearLink")]
        public bool? ClearLink{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "InstanceInitStrategy", this.InstanceInitStrategy);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "ModifyCycleValue", this.ModifyCycleValue);
            this.SetParamSimple(map, prefix + "CalendarOpen", this.CalendarOpen);
            this.SetParamSimple(map, prefix + "CalendarName", this.CalendarName);
            this.SetParamSimple(map, prefix + "CalendarId", this.CalendarId);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "ClearLink", this.ClearLink);
        }
    }
}

