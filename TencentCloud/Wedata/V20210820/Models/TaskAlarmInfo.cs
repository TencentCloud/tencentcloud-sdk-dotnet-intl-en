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

    public class TaskAlarmInfo : AbstractModel
    {
        
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
        /// Rule Status (0 for off, 1 for on)
        /// </summary>
        [JsonProperty("RegularStatus")]
        public ulong? RegularStatus{ get; set; }

        /// <summary>
        /// Alert Level (0 for general, 1 for critical, 2 for urgent)
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// Alert Method, separated by commas (1: email, 2: SMS, 3: WeChat, 4: voice call, 5: represents WeCom, 6: http)
        /// </summary>
        [JsonProperty("AlarmWay")]
        public string AlarmWay{ get; set; }

        /// <summary>
        /// Task Type (201 for real-time, 202 for offline)
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }

        /// <summary>
        /// ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RegularId")]
        public string RegularId{ get; set; }

        /// <summary>
        /// Alert Metrics, 0 for task failure, 1 for task run timeout, 2 for task stop, 3 for task pause,4 Write Speed, 5 Read Speed, 6 Read Throughput, 7 Write Throughput, 8 Dirty Data Byte Count, 9 Number of Dirty Data Entries
        /// </summary>
        [JsonProperty("AlarmIndicator")]
        public ulong? AlarmIndicator{ get; set; }

        /// <summary>
        /// Metric Threshold (1 for the first run failure of an offline task, 2 for all retries failed of an offline task)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// Estimated Timeout Duration (Minute Level)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EstimatedTime")]
        public ulong? EstimatedTime{ get; set; }

        /// <summary>
        /// Alert Recipient ID, separated by commas
        /// </summary>
        [JsonProperty("AlarmRecipientId")]
        public string AlarmRecipientId{ get; set; }

        /// <summary>
        /// Project IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// CreatorNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Creater")]
        public string Creater{ get; set; }

        /// <summary>
        /// Alert Recipient Nickname, separated by commas
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmRecipientName")]
        public string AlarmRecipientName{ get; set; }

        /// <summary>
        /// Alert Metric Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmIndicatorDesc")]
        public string AlarmIndicatorDesc{ get; set; }

        /// <summary>
        /// Parameters needed for real-time task alerts, 1 is greater than, 2 is less than
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Operator")]
        public ulong? Operator{ get; set; }

        /// <summary>
        /// Node ID, separated by commas
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// Node name, separated by commas
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Metric List
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmIndicatorInfos")]
        public AlarmIndicatorInfo[] AlarmIndicatorInfos{ get; set; }

        /// <summary>
        /// Alert Recipient Type, 0 is designated person; 1 is task responsible person
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmRecipientType")]
        public ulong? AlarmRecipientType{ get; set; }

        /// <summary>
        /// Do not disturb time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QuietPeriods")]
        public QuietPeriod[] QuietPeriods{ get; set; }

        /// <summary>
        /// Enterprise WeChat Group Hook Address, multiple hook addresses separated by commas
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WeComHook")]
        public string WeComHook{ get; set; }

        /// <summary>
        /// Last Operation Time
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Last Operator Uin
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OperatorUin")]
        public string OperatorUin{ get; set; }

        /// <summary>
        /// Associated Task Count
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TaskCount")]
        public long? TaskCount{ get; set; }

        /// <summary>
        /// Monitored Object Type, 1: all tasks, 2: specified tasks, 3: specified responsible person
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MonitorType")]
        public long? MonitorType{ get; set; }

        /// <summary>
        /// Monitoring Object List
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MonitorObjectIds")]
        public string[] MonitorObjectIds{ get; set; }

        /// <summary>
        /// Instance ID of the Last Alert
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LatestAlarmInstanceId")]
        public string LatestAlarmInstanceId{ get; set; }

        /// <summary>
        /// Time of the Last Alert
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LatestAlarmTime")]
        public string LatestAlarmTime{ get; set; }

        /// <summary>
        /// Alert Rule Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// FeiShu Group Hook Address, multiple hook addresses separated by commas
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LarkWebHooks")]
        public string LarkWebHooks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RegularName", this.RegularName);
            this.SetParamSimple(map, prefix + "RegularStatus", this.RegularStatus);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "AlarmWay", this.AlarmWay);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RegularId", this.RegularId);
            this.SetParamSimple(map, prefix + "AlarmIndicator", this.AlarmIndicator);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "EstimatedTime", this.EstimatedTime);
            this.SetParamSimple(map, prefix + "AlarmRecipientId", this.AlarmRecipientId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Creater", this.Creater);
            this.SetParamSimple(map, prefix + "AlarmRecipientName", this.AlarmRecipientName);
            this.SetParamSimple(map, prefix + "AlarmIndicatorDesc", this.AlarmIndicatorDesc);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamArrayObj(map, prefix + "AlarmIndicatorInfos.", this.AlarmIndicatorInfos);
            this.SetParamSimple(map, prefix + "AlarmRecipientType", this.AlarmRecipientType);
            this.SetParamArrayObj(map, prefix + "QuietPeriods.", this.QuietPeriods);
            this.SetParamSimple(map, prefix + "WeComHook", this.WeComHook);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OperatorUin", this.OperatorUin);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamArraySimple(map, prefix + "MonitorObjectIds.", this.MonitorObjectIds);
            this.SetParamSimple(map, prefix + "LatestAlarmInstanceId", this.LatestAlarmInstanceId);
            this.SetParamSimple(map, prefix + "LatestAlarmTime", this.LatestAlarmTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "LarkWebHooks", this.LarkWebHooks);
        }
    }
}

