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

    public class AlarmEventInfo : AbstractModel
    {
        
        /// <summary>
        /// Alert ID
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// Alarm Time
        /// </summary>
        [JsonProperty("AlarmTime")]
        public string AlarmTime{ get; set; }

        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RegularName")]
        public string RegularName{ get; set; }

        /// <summary>
        /// Alert level, 0 for normal, 1 for important, 2 for urgent
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// Alert Method, separated by commas (1: email, 2: SMS, 3: WeChat, 4: voice call, 5: represents WeCom, 6: http)
        /// </summary>
        [JsonProperty("AlarmWay")]
        public ulong? AlarmWay{ get; set; }

        /// <summary>
        /// Alert Recipient ID, separated by commas
        /// </summary>
        [JsonProperty("AlarmRecipientId")]
        public string AlarmRecipientId{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Alert Metrics, 0 for task failure, 1 for task run timeout, 2 for task stop, 3 for task pause
        /// </summary>
        [JsonProperty("AlarmIndicator")]
        public ulong? AlarmIndicator{ get; set; }

        /// <summary>
        /// Alert Metric Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmIndicatorDesc")]
        public string AlarmIndicatorDesc{ get; set; }

        /// <summary>
        /// Metric threshold, 1 indicates the first run failure of the offline task, 2 indicates failure after all retries of the offline task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// Estimated timeout, minute level
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EstimatedTime")]
        public ulong? EstimatedTime{ get; set; }

        /// <summary>
        /// Instance IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Task NameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 0: Partial Success, 1: Complete Success, 2: Complete Failure
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IsSendSuccess")]
        public ulong? IsSendSuccess{ get; set; }

        /// <summary>
        /// During Do Not Disturb time, 0: No, 1: Yes
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InQuitePeriods")]
        public ulong? InQuitePeriods{ get; set; }

        /// <summary>
        /// Alert Record ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RecordId")]
        public ulong? RecordId{ get; set; }

        /// <summary>
        /// Message ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// Threshold Calculation Operator, 1: Greater than, 2: Less than
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Operator")]
        public long? Operator{ get; set; }

        /// <summary>
        /// Alert Rule ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RegularId")]
        public string RegularId{ get; set; }

        /// <summary>
        /// Alert Recipient Nickname
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmRecipientName")]
        public string AlarmRecipientName{ get; set; }

        /// <summary>
        /// Alert Task Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// Send Result
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SendResult")]
        public string SendResult{ get; set; }

        /// <summary>
        /// Monitoring Object ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MonitorObjectId")]
        public string MonitorObjectId{ get; set; }

        /// <summary>
        /// Monitoring Object Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MonitorObjectName")]
        public string MonitorObjectName{ get; set; }

        /// <summary>
        /// Metric Threshold
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Threshold")]
        public float? Threshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "AlarmTime", this.AlarmTime);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RegularName", this.RegularName);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "AlarmWay", this.AlarmWay);
            this.SetParamSimple(map, prefix + "AlarmRecipientId", this.AlarmRecipientId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AlarmIndicator", this.AlarmIndicator);
            this.SetParamSimple(map, prefix + "AlarmIndicatorDesc", this.AlarmIndicatorDesc);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "EstimatedTime", this.EstimatedTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "IsSendSuccess", this.IsSendSuccess);
            this.SetParamSimple(map, prefix + "InQuitePeriods", this.InQuitePeriods);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "RegularId", this.RegularId);
            this.SetParamSimple(map, prefix + "AlarmRecipientName", this.AlarmRecipientName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "SendResult", this.SendResult);
            this.SetParamSimple(map, prefix + "MonitorObjectId", this.MonitorObjectId);
            this.SetParamSimple(map, prefix + "MonitorObjectName", this.MonitorObjectName);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

