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

    public class WorkflowSchedulerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// Specifies the time zone.
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

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
        /// Self-Dependent. Valid values: parallel, serial, orderly. Default value: serial. 
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// Effective Start Time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Effective End Time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Workflow dependency. Valid values: yes or no.
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// Execution time. specifies the left-closed interval. example: 00:00.
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// Execution time right closed interval, for example: 23:59.
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// Cron expression
        /// 
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// Whether calendar scheduling is enabled. Valid values: 1 (enabled), 0 (disabled).
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "CalendarOpen", this.CalendarOpen);
            this.SetParamSimple(map, prefix + "CalendarName", this.CalendarName);
            this.SetParamSimple(map, prefix + "CalendarId", this.CalendarId);
        }
    }
}

