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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBasicAlarmListAlarms : AbstractModel
    {
        
        /// <summary>
        /// Alarm ID.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Project ID.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Project name.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Alarm status ID. Valid values: 0 (not resolved), 1 (resolved), 2/3/5 (insufficient data), 4 (expired)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Alarm status. Valid values: ALARM (not resolved), OK (resolved), NO_DATA (insufficient data), NO_CONF (expired)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlarmStatus")]
        public string AlarmStatus{ get; set; }

        /// <summary>
        /// Policy group ID.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// Policy group name.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Occurrence time.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FirstOccurTime")]
        public string FirstOccurTime{ get; set; }

        /// <summary>
        /// Duration in seconds.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// End time.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("LastOccurTime")]
        public string LastOccurTime{ get; set; }

        /// <summary>
        /// Alarm content.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Alarm object.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ObjName")]
        public string ObjName{ get; set; }

        /// <summary>
        /// Alarm object ID.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ObjId")]
        public string ObjId{ get; set; }

        /// <summary>
        /// Policy type.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// VPC, which is unique to CVM.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Vpc")]
        public string Vpc{ get; set; }

        /// <summary>
        /// Metric ID.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("MetricId")]
        public long? MetricId{ get; set; }

        /// <summary>
        /// Metric name.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Alarm type. The value 0 indicates metric alarms. The value 2 indicates product event alarms. The value 3 indicates platform event alarms.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AlarmType")]
        public long? AlarmType{ get; set; }

        /// <summary>
        /// Region.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Dimensions of an alarm object.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// Notification method.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("NotifyWay")]
        public string[] NotifyWay{ get; set; }

        /// <summary>
        /// Instance group information.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceGroup")]
        public InstanceGroup[] InstanceGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AlarmStatus", this.AlarmStatus);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "FirstOccurTime", this.FirstOccurTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "LastOccurTime", this.LastOccurTime);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ObjName", this.ObjName);
            this.SetParamSimple(map, prefix + "ObjId", this.ObjId);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "Vpc", this.Vpc);
            this.SetParamSimple(map, prefix + "MetricId", this.MetricId);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamArraySimple(map, prefix + "NotifyWay.", this.NotifyWay);
            this.SetParamArrayObj(map, prefix + "InstanceGroup.", this.InstanceGroup);
        }
    }
}

