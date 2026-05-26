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

    public class CreateTaskSchedulerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <p>Period type: Defaults to DAY_CYCLE</p><p>Supported types are </p><ul><li>ONEOFF_CYCLE: One-time</li><li>YEAR_CYCLE: Year</li><li>MONTH_CYCLE: Month</li><li>WEEK_CYCLE: Week</li><li>DAY_CYCLE: Day</li><li>HOUR_CYCLE: Hour</li><li>MINUTE_CYCLE: Minute</li><li>CRONTAB_CYCLE: crontab expression</li></ul>
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>Time zone, defaults to UTC+8</p>
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>Cron expression, defaults to 0 0 0 * * ? *</p>
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// <p>Effective date, defaults to 00:00:00 of the current date</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End date, defaults to 2099-12-31 23:59:59</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Execution time left-closed interval, default 00:00</p>
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// <p>Execution time right closed interval, default 23:59</p>
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// <p>Calendar scheduling value is 0 and 1, where 1 is on and 0 is shutdown, with a default value of 0.</p>
        /// </summary>
        [JsonProperty("CalendarOpen")]
        public string CalendarOpen{ get; set; }

        /// <summary>
        /// <p>Calendar scheduling Calendar ID</p>
        /// </summary>
        [JsonProperty("CalendarId")]
        public string CalendarId{ get; set; }

        /// <summary>
        /// <p>Self-dependent, default value serial, value: parallel, serial, orderly</p>
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// <p>Upstream dependency array</p>
        /// </summary>
        [JsonProperty("UpstreamDependencyConfigList")]
        public DependencyTaskBrief[] UpstreamDependencyConfigList{ get; set; }

        /// <summary>
        /// <p>Event array</p>
        /// </summary>
        [JsonProperty("EventListenerList")]
        public EventListener[] EventListenerList{ get; set; }

        /// <summary>
        /// <p>Rerun & replenishment configuration, defaults to ALL; , ALL allows rerun or replenishment after successful or failed running, FAILURE cannot rerun or replenish after successful running but allows rerun or replenishment after running FAILURE, NONE does not allow rerun or replenishment after either successful or failed running;</p>
        /// </summary>
        [JsonProperty("AllowRedoType")]
        public string AllowRedoType{ get; set; }

        /// <summary>
        /// <p>Output parameter array</p>
        /// </summary>
        [JsonProperty("ParamTaskOutList")]
        public OutTaskParameter[] ParamTaskOutList{ get; set; }

        /// <summary>
        /// <p>Input parameter array</p>
        /// </summary>
        [JsonProperty("ParamTaskInList")]
        public InTaskParameter[] ParamTaskInList{ get; set; }

        /// <summary>
        /// <p>Output registration</p>
        /// </summary>
        [JsonProperty("TaskOutputRegistryList")]
        public TaskDataRegistry[] TaskOutputRegistryList{ get; set; }

        /// <summary>
        /// <p><strong>Instance Generation Policy</strong></p><ul><li>T_PLUS_0: T+0 generation, default policy</li><li>T_PLUS_1: T+1 generation</li></ul>
        /// </summary>
        [JsonProperty("InitStrategy")]
        public string InitStrategy{ get; set; }

        /// <summary>
        /// <p>Scheduling type: 0 normal scheduling 1 dry-run scheduling, default is 0</p>
        /// </summary>
        [JsonProperty("ScheduleRunType")]
        [System.Obsolete]
        public string ScheduleRunType{ get; set; }

        /// <summary>
        /// <p>Task scheduling priority Execution priority 4 High 5 Medium 6 Low, Default:6</p>
        /// </summary>
        [JsonProperty("RunPriority")]
        [System.Obsolete]
        public string RunPriority{ get; set; }

        /// <summary>
        /// <p>Retry policy Retry wait time, in minutes: Default: 5</p>
        /// </summary>
        [JsonProperty("RetryWait")]
        [System.Obsolete]
        public string RetryWait{ get; set; }

        /// <summary>
        /// <p>Retry policy Maximum attempts, Default: 4</p>
        /// </summary>
        [JsonProperty("MaxRetryAttempts")]
        [System.Obsolete]
        public string MaxRetryAttempts{ get; set; }

        /// <summary>
        /// <p>Timeout handling strategy Runtime timeout (unit: minutes) Default is -1</p>
        /// </summary>
        [JsonProperty("ExecutionTTL")]
        [System.Obsolete]
        public string ExecutionTTL{ get; set; }

        /// <summary>
        /// <p>Timeout handling strategy Wait duration timeout (unit: minutes) Default value is -1</p>
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTL")]
        [System.Obsolete]
        public string WaitExecutionTotalTTL{ get; set; }

        /// <summary>
        /// <p>Scheduling type: 0 normal scheduling 1 dry-run scheduling, default is 0</p>
        /// </summary>
        [JsonProperty("ScheduleType")]
        public long? ScheduleType{ get; set; }

        /// <summary>
        /// <p>Task scheduling priority Execution priority 4 High 5 Medium 6 Low, Default:6</p>
        /// </summary>
        [JsonProperty("RunPriorityType")]
        public long? RunPriorityType{ get; set; }

        /// <summary>
        /// <p>Retry policy Retry wait time, in minutes: Default: 5</p>
        /// </summary>
        [JsonProperty("RetryWaitMinute")]
        public long? RetryWaitMinute{ get; set; }

        /// <summary>
        /// <p>Retry policy Maximum attempts, Default: 4</p>
        /// </summary>
        [JsonProperty("MaxRetryNumber")]
        public long? MaxRetryNumber{ get; set; }

        /// <summary>
        /// <p>Timeout handling strategy Runtime timeout (unit: minutes) Default is -1</p>
        /// </summary>
        [JsonProperty("ExecutionTTLMinute")]
        public long? ExecutionTTLMinute{ get; set; }

        /// <summary>
        /// <p>Timeout handling strategy Wait duration timeout (unit: minutes) Default value is -1</p>
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTLMinute")]
        public long? WaitExecutionTotalTTLMinute{ get; set; }

        /// <summary>
        /// <ul><li>The task dependency run condition defaults to ALL_SUCCESS. Currently, only workflow scheduling under the project supports configuration.</li><li>ALL_SUCCESS: All successful: When all upstream dependency tasks reach the final state, perform a dependency check. If all upstream tasks are successful, the dependency check passes. Otherwise, if one upstream task skips running, it is marked as skipped. In other cases, it is marked as upstream failure.</li><li>ALL_FAILED: All failed: When all upstream dependency tasks reach the final state, perform a dependency check. If all upstream tasks are in a failed state or marked as upstream failure, the dependency check passes. Otherwise, it is marked as skipped.</li><li>ALL_DONE: All completed: When all upstream dependency tasks reach the final state, perform a dependency check, and the dependency check passes directly.</li><li>ALL_DONE_AT_LEAST_ONE_SUCCESS: All upstream tasks completed with at least one success: When all upstream dependency tasks reach the final state, perform a dependency check. If at least one is successful, the dependency check passes. Otherwise, it skips running.</li><li>ALL_SKIPPED: All upstream tasks skipped: When all upstream dependency tasks reach the final state, perform a dependency check. Only if all upstream tasks are in a skipped state does the dependency check pass. Otherwise, the current node skips running.</li><li>ONE_FAILED: At least one failed: If at least one upstream task fails, perform a dependency check, and the check passes. If all upstream tasks complete but none fail, it skips running.</li><li>ONE_SUCCESS: At least one success: If at least one upstream task succeeds, perform a dependency check, and the check passes. If all upstream tasks complete but none succeed, it skips running.</li><li>ONE_DONE: At least one completed: If at least one upstream task completes, perform a dependency check, and the check passes. Otherwise, it continues waiting for upstream.</li><li>NONE_FAILED: All upstream tasks completed with no failure: When all upstream dependency tasks reach the final state, perform a dependency check. If all upstream tasks are successful or skipped, the check passes. Otherwise, it is marked as upstream failure.</li><li>ALL_DONE_NONE_FAILED_AT_LEAST_ONE_SUCCESS: All upstream tasks completed with no failure and at least one success: When all upstream dependency tasks reach the final state, perform a dependency check. If no upstream task fails and at least one succeeds, the check passes. Otherwise, it skips running.</li><li>NONE_SKIPPED: All upstream tasks completed with no skipped runs: When all upstream dependency tasks reach the final state, perform a dependency check. If all upstream tasks are in a successful, failed, or upstream failure state, the check passes. Otherwise, it skips running.</li><li>ALL_DONE_AT_LEAST_ONE_FAILED: All upstream tasks completed with at least one failure: When all upstream dependency tasks reach the final state, perform a dependency check. If at least one fails, the check passes. Otherwise, it skips running.</li></ul>
        /// </summary>
        [JsonProperty("DependencyTriggerPolicy")]
        public string DependencyTriggerPolicy{ get; set; }

        /// <summary>
        /// <p>Whether to allow downstream dependency 1 Allow 0 Do not allow</p><p>Value ranges from 0 to 1</p><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("AllowDownstreamDependency")]
        [System.Obsolete]
        public long? AllowDownstreamDependency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "CalendarOpen", this.CalendarOpen);
            this.SetParamSimple(map, prefix + "CalendarId", this.CalendarId);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamArrayObj(map, prefix + "UpstreamDependencyConfigList.", this.UpstreamDependencyConfigList);
            this.SetParamArrayObj(map, prefix + "EventListenerList.", this.EventListenerList);
            this.SetParamSimple(map, prefix + "AllowRedoType", this.AllowRedoType);
            this.SetParamArrayObj(map, prefix + "ParamTaskOutList.", this.ParamTaskOutList);
            this.SetParamArrayObj(map, prefix + "ParamTaskInList.", this.ParamTaskInList);
            this.SetParamArrayObj(map, prefix + "TaskOutputRegistryList.", this.TaskOutputRegistryList);
            this.SetParamSimple(map, prefix + "InitStrategy", this.InitStrategy);
            this.SetParamSimple(map, prefix + "ScheduleRunType", this.ScheduleRunType);
            this.SetParamSimple(map, prefix + "RunPriority", this.RunPriority);
            this.SetParamSimple(map, prefix + "RetryWait", this.RetryWait);
            this.SetParamSimple(map, prefix + "MaxRetryAttempts", this.MaxRetryAttempts);
            this.SetParamSimple(map, prefix + "ExecutionTTL", this.ExecutionTTL);
            this.SetParamSimple(map, prefix + "WaitExecutionTotalTTL", this.WaitExecutionTotalTTL);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "RunPriorityType", this.RunPriorityType);
            this.SetParamSimple(map, prefix + "RetryWaitMinute", this.RetryWaitMinute);
            this.SetParamSimple(map, prefix + "MaxRetryNumber", this.MaxRetryNumber);
            this.SetParamSimple(map, prefix + "ExecutionTTLMinute", this.ExecutionTTLMinute);
            this.SetParamSimple(map, prefix + "WaitExecutionTotalTTLMinute", this.WaitExecutionTotalTTLMinute);
            this.SetParamSimple(map, prefix + "DependencyTriggerPolicy", this.DependencyTriggerPolicy);
            this.SetParamSimple(map, prefix + "AllowDownstreamDependency", this.AllowDownstreamDependency);
        }
    }
}

