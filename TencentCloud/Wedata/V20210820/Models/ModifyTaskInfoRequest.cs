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

    public class ModifyTaskInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Execution time, in minutes, applicable to daily/weekly/monthly/yearly scheduling. For example, with daily scheduling, executing once at 02:00 AM every day, delayTime is 120 minutes
        /// </summary>
        [JsonProperty("DelayTime")]
        public long? DelayTime{ get; set; }

        /// <summary>
        /// Start Time
        /// </summary>
        [JsonProperty("StartupTime")]
        public long? StartupTime{ get; set; }

        /// <summary>
        /// Self-Dependency Type  1: Sequential serial, one at a time, queued, 2: Unordered serial, one at a time, not queued, 3: Parallel, multiple at once
        /// </summary>
        [JsonProperty("SelfDepend")]
        public long? SelfDepend{ get; set; }

        /// <summary>
        /// Effective Start Time, format yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Effective End Time, format yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Scheduling Configuration - Elastic Cycle Configuration, applicable to Hourly/Weekly/Monthly/Yearly schedules. For hourly tasks scheduled at 0, 3, 4 o'clock, it would be '0,3,4'.
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// "Cycle Type  0:crontab, 1:Minute,2:Hour,3:Day,4:Week,5:Month,6:One-time,7:User driven,10:Flexible cycle Week,11:Flexible cycle Month,12:Year,13:Immediate Trigger Instant type, isolated from normal cycle scheduling task logic
        /// </summary>
        [JsonProperty("CycleType")]
        public long? CycleType{ get; set; }

        /// <summary>
        /// Step Length, Interval Time, minimum of 1
        /// </summary>
        [JsonProperty("CycleStep")]
        public long? CycleStep{ get; set; }

        /// <summary>
        /// Cron Expression is required only for Cron Tab Scheduling
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// Execution Time Left Closed Interval, format: HH:mm. Applicable only to hourly scheduling. For example, for hourly tasks, it specifies the effective interval every day
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// Execution Time Right Closed Interval, format: HH:mm. Applicable only to hourly scheduling. For example, for hourly tasks, it specifies the effective interval every day
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// New Task Name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Failure Retry Interval, in minutes, a default value has already been provided during task creation
        /// </summary>
        [JsonProperty("RetryWait")]
        public long? RetryWait{ get; set; }

        /// <summary>
        /// Number of Retry Attempts on Failure, a default value has already been provided during task creation
        /// </summary>
        [JsonProperty("TryLimit")]
        public long? TryLimit{ get; set; }

        /// <summary>
        /// Whether to Retry, 1 for yes
        /// </summary>
        [JsonProperty("Retriable")]
        public long? Retriable{ get; set; }

        /// <summary>
        /// Running Priority, 4 for High, 5 for Medium, 6 for Low
        /// </summary>
        [JsonProperty("RunPriority")]
        public long? RunPriority{ get; set; }

        /// <summary>
        /// Extended Task Configuration
        /// </summary>
        [JsonProperty("TaskExt")]
        public TaskExtInfo[] TaskExt{ get; set; }

        /// <summary>
        /// Execution Resource Group ID, needs to be created on the Resource Management Service and bind to a CVM machine
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// Resource Pool Queue Name
        /// </summary>
        [JsonProperty("YarnQueue")]
        public string YarnQueue{ get; set; }

        /// <summary>
        /// Specific Execution Machine under Resource Group, 'any' means it can run on any machine.
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// Person in Charge
        /// </summary>
        [JsonProperty("InCharge")]
        [System.Obsolete]
        public string InCharge{ get; set; }

        /// <summary>
        /// Task notes
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }

        /// <summary>
        /// Task Parameters
        /// </summary>
        [JsonProperty("TaskParamInfos")]
        public ParamInfo[] TaskParamInfos{ get; set; }

        /// <summary>
        /// Source Data Source
        /// </summary>
        [JsonProperty("SourceServer")]
        public string SourceServer{ get; set; }

        /// <summary>
        /// Target Data Source
        /// </summary>
        [JsonProperty("TargetServer")]
        public string TargetServer{ get; set; }

        /// <summary>
        /// Supports Workflow Dependencies yes/no, default no
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// Dependency Configuration
        /// </summary>
        [JsonProperty("DependencyConfigDTOs")]
        public DependencyConfig[] DependencyConfigDTOs{ get; set; }

        /// <summary>
        /// Execution Duration
        /// </summary>
        [JsonProperty("ExecutionTTL")]
        public long? ExecutionTTL{ get; set; }

        /// <summary>
        /// Whether the Script has Changed
        /// </summary>
        [JsonProperty("ScriptChange")]
        public bool? ScriptChange{ get; set; }

        /// <summary>
        /// Responsible Person ID
        /// </summary>
        [JsonProperty("InChargeIds")]
        public string[] InChargeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "RetryWait", this.RetryWait);
            this.SetParamSimple(map, prefix + "TryLimit", this.TryLimit);
            this.SetParamSimple(map, prefix + "Retriable", this.Retriable);
            this.SetParamSimple(map, prefix + "RunPriority", this.RunPriority);
            this.SetParamArrayObj(map, prefix + "TaskExt.", this.TaskExt);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "YarnQueue", this.YarnQueue);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "Notes", this.Notes);
            this.SetParamArrayObj(map, prefix + "TaskParamInfos.", this.TaskParamInfos);
            this.SetParamSimple(map, prefix + "SourceServer", this.SourceServer);
            this.SetParamSimple(map, prefix + "TargetServer", this.TargetServer);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
            this.SetParamArrayObj(map, prefix + "DependencyConfigDTOs.", this.DependencyConfigDTOs);
            this.SetParamSimple(map, prefix + "ExecutionTTL", this.ExecutionTTL);
            this.SetParamSimple(map, prefix + "ScriptChange", this.ScriptChange);
            this.SetParamArraySimple(map, prefix + "InChargeIds.", this.InChargeIds);
        }
    }
}

