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

    public class TaskSchedulerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// Period type. Supported types:
        /// 
        /// ONEOFF_CYCLE: specifies a one-time cycle.
        /// YEAR_CYCLE: specifies the year cycle.
        /// MONTH_CYCLE: specifies the monthly cycle.
        /// WEEK_CYCLE: specifies the week cycle.
        /// DAY_CYCLE: specifies the day cycle.
        /// HOUR_CYCLE: specifies the hour cycle.
        /// MINUTE_CYCLE: specifies the minute cycle.
        /// CRONTAB_CYCLE: specifies the crontab expression type
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// Time zone.
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// 0 2 3 1,L,2 * ?	
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// Effective date.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Execution time. the left-closed interval.
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// Execution time. right closed interval.
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// Whether calendar scheduling is enabled. Valid values: 1 (enabled), 0 (disabled).
        /// </summary>
        [JsonProperty("CalendarOpen")]
        public string CalendarOpen{ get; set; }

        /// <summary>
        /// Calendar id.
        /// </summary>
        [JsonProperty("CalendarId")]
        public string CalendarId{ get; set; }

        /// <summary>
        /// Calendar name, which needs to be obtained from DescribeScheduleCalendarPageList API.
        /// </summary>
        [JsonProperty("CalendarName")]
        public string CalendarName{ get; set; }

        /// <summary>
        /// Self-Dependent. Valid values: parallel, serial, orderly. Default value: serial. 
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// Specifies the upstream dependency array.
        /// </summary>
        [JsonProperty("UpstreamDependencyConfigList")]
        public DependencyTaskBrief[] UpstreamDependencyConfigList{ get; set; }

        /// <summary>
        /// Downstream dependency array.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DownstreamDependencyConfigList")]
        public DependencyTaskBrief[] DownstreamDependencyConfigList{ get; set; }

        /// <summary>
        /// Array of Events
        /// </summary>
        [JsonProperty("EventListenerList")]
        public EventListener[] EventListenerList{ get; set; }

        /// <summary>
        /// Rerun & Refill Configuration: Default: ALL;
        /// 
        /// * ALL: Rerun or refill is allowed regardless of whether the task succeeds or fails.
        /// 
        /// * FAILURE: Rerun or refill is allowed only if the task fails; not allowed if the task succeeds.
        /// 
        /// * NONE: Rerun or refill is not allowed regardless of success or failure.
        /// </summary>
        [JsonProperty("AllowRedoType")]
        public string AllowRedoType{ get; set; }

        /// <summary>
        /// Output parameter list.
        /// </summary>
        [JsonProperty("ParamTaskOutList")]
        public OutTaskParameter[] ParamTaskOutList{ get; set; }

        /// <summary>
        /// Input parameter list.
        /// </summary>
        [JsonProperty("ParamTaskInList")]
        public InTaskParameter[] ParamTaskInList{ get; set; }

        /// <summary>
        /// Output registration.
        /// </summary>
        [JsonProperty("TaskOutputRegistryList")]
        public TaskDataRegistry[] TaskOutputRegistryList{ get; set; }

        /// <summary>
        /// **Instance generation policy**.
        /// T_PLUS_0: specifies t+0 generation. default policy.
        /// T_PLUS_1: specifies t+1 generation.
        /// </summary>
        [JsonProperty("InitStrategy")]
        public string InitStrategy{ get; set; }

        /// <summary>
        /// Scheduling type: 0 normal scheduling 1 dry-run scheduling, defaults to 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScheduleRunType")]
        [System.Obsolete]
        public long? ScheduleRunType{ get; set; }

        /// <summary>
        /// (Deprecated, recommend using DownstreamDependencyConfigList) downstream dependency array.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DownStreamDependencyConfigList")]
        [System.Obsolete]
        public DependencyTaskBrief[] DownStreamDependencyConfigList{ get; set; }

        /// <summary>
        /// Task scheduling priority. valid values: 4 (high), 5 (medium), 6 (low). default: 6.
        /// </summary>
        [JsonProperty("RunPriority")]
        [System.Obsolete]
        public ulong? RunPriority{ get; set; }

        /// <summary>
        /// Retry policy. retry wait time in minutes. default: 5.
        /// </summary>
        [JsonProperty("RetryWait")]
        [System.Obsolete]
        public long? RetryWait{ get; set; }

        /// <summary>
        /// Specifies the maximum attempts of the retry policy. default: 4.
        /// </summary>
        [JsonProperty("MaxRetryAttempts")]
        [System.Obsolete]
        public long? MaxRetryAttempts{ get; set; }

        /// <summary>
        /// Timeout Handling Policy: Execution Timeout (in minutes), default: -1
        /// </summary>
        [JsonProperty("ExecutionTTL")]
        [System.Obsolete]
        public long? ExecutionTTL{ get; set; }

        /// <summary>
        /// Timeout Handling Policy: Wait Duration Timeout  (in minutes), default: -1
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTL")]
        [System.Obsolete]
        public string WaitExecutionTotalTTL{ get; set; }

        /// <summary>
        /// Scheduling type: 0 normal scheduling 1 dry-run scheduling, defaults to 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScheduleType")]
        public long? ScheduleType{ get; set; }

        /// <summary>
        /// Task scheduling priority execution priority 4 high 5 medium 6 low, default: 6.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RunPriorityType")]
        public long? RunPriorityType{ get; set; }

        /// <summary>
        /// Retry policy retry wait time, in minutes: default: 5.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RetryWaitMinute")]
        public long? RetryWaitMinute{ get; set; }

        /// <summary>
        /// Retry policy maximum attempts. default: 4.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxRetryNumber")]
        public long? MaxRetryNumber{ get; set; }

        /// <summary>
        /// Timeout handling strategy runtime timeout (unit: minutes) defaults to -1.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecutionTTLMinute")]
        public long? ExecutionTTLMinute{ get; set; }

        /// <summary>
        /// Timeout handling strategy wait for the total duration timeout (measurement unit: minutes) defaults to -1.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTLMinute")]
        public long? WaitExecutionTotalTTLMinute{ get; set; }


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
            this.SetParamSimple(map, prefix + "CalendarName", this.CalendarName);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamArrayObj(map, prefix + "UpstreamDependencyConfigList.", this.UpstreamDependencyConfigList);
            this.SetParamArrayObj(map, prefix + "DownstreamDependencyConfigList.", this.DownstreamDependencyConfigList);
            this.SetParamArrayObj(map, prefix + "EventListenerList.", this.EventListenerList);
            this.SetParamSimple(map, prefix + "AllowRedoType", this.AllowRedoType);
            this.SetParamArrayObj(map, prefix + "ParamTaskOutList.", this.ParamTaskOutList);
            this.SetParamArrayObj(map, prefix + "ParamTaskInList.", this.ParamTaskInList);
            this.SetParamArrayObj(map, prefix + "TaskOutputRegistryList.", this.TaskOutputRegistryList);
            this.SetParamSimple(map, prefix + "InitStrategy", this.InitStrategy);
            this.SetParamSimple(map, prefix + "ScheduleRunType", this.ScheduleRunType);
            this.SetParamArrayObj(map, prefix + "DownStreamDependencyConfigList.", this.DownStreamDependencyConfigList);
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
        }
    }
}

