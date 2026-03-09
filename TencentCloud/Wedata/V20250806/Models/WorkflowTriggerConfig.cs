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

    public class WorkflowTriggerConfig : AbstractModel
    {
        
        /// <summary>
        /// Trigger mode.
        /// -Scheduled TRIGGER: TIME_TRIGGER.
        /// - CONTINUE_RUN: continuously RUN.
        /// -FILE_ARRIVAL.
        /// 
        /// Note:.
        /// -In TIME_TRIGGER and CONTINUE_RUN mode, SchedulerStatus, SchedulerTimeZone, StartTime, EndTime, ConfigMode, CycleType, and CrontabExpression are required.
        /// -In FILE_ARRIVAL mode, FileArrivalPath, TriggerMinimumIntervalSecond, and TriggerWaitTimeSecond are required.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TriggerMode")]
        public string TriggerMode{ get; set; }

        /// <summary>
        /// Convert WorkflowTriggerConfig into Json format for reconciliation usage.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// Scheduling time zone.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// Schedule effective time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Schedule end time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Setting method, general: COMMON, CRON EXPRESSION: CRON_EXPRESSION.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConfigMode")]
        public string ConfigMode{ get; set; }

        /// <summary>
        /// Period type: supported types are.
        /// ONEOFF_CYCLE: one-time.
        /// YEAR_CYCLE: year.
        /// MONTH_CYCLE: month.
        /// WEEK_CYCLE: week.
        /// DAY_CYCLE: day.
        /// HOUR_CYCLE: hr.
        /// MINUTE_CYCLE: minute.
        /// CRONTAB_CYCLE: crontab expression type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// Cron expression
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// triggerId, uuid
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// Listening path in the storage system under file arrival mode.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FileArrivalPath")]
        public string FileArrivalPath{ get; set; }

        /// <summary>
        /// File arrival mode triggers the shortest interval (unit: s).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TriggerMinimumIntervalSecond")]
        public ulong? TriggerMinimumIntervalSecond{ get; set; }

        /// <summary>
        /// File arrival in mode. trigger waiting time (unit: seconds).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TriggerWaitTimeSecond")]
        public ulong? TriggerWaitTimeSecond{ get; set; }

        /// <summary>
        /// Trigger status. valid values: ACTIVE (start), PAUSED (suspend).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SchedulerStatus")]
        public string SchedulerStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TriggerMode", this.TriggerMode);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ConfigMode", this.ConfigMode);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
            this.SetParamSimple(map, prefix + "FileArrivalPath", this.FileArrivalPath);
            this.SetParamSimple(map, prefix + "TriggerMinimumIntervalSecond", this.TriggerMinimumIntervalSecond);
            this.SetParamSimple(map, prefix + "TriggerWaitTimeSecond", this.TriggerWaitTimeSecond);
            this.SetParamSimple(map, prefix + "SchedulerStatus", this.SchedulerStatus);
        }
    }
}

