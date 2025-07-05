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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProductEventListEvents : AbstractModel
    {
        
        /// <summary>
        /// Event ID.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// Event name in Chinese.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventCName")]
        public string EventCName{ get; set; }

        /// <summary>
        /// Event name in English.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventEName")]
        public string EventEName{ get; set; }

        /// <summary>
        /// Event name abbreviation.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// Product name in Chinese.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ProductCName")]
        public string ProductCName{ get; set; }

        /// <summary>
        /// Product name in English.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ProductEName")]
        public string ProductEName{ get; set; }

        /// <summary>
        /// Product name abbreviation.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Instance ID.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Project ID.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Region.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Status.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Whether to support alarms.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SupportAlarm")]
        public long? SupportAlarm{ get; set; }

        /// <summary>
        /// Event type.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Start time.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// Update time.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// Instance object information.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Dimensions")]
        public DescribeProductEventListEventsDimensions[] Dimensions{ get; set; }

        /// <summary>
        /// Additional information of the instance object.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AdditionMsg")]
        public DescribeProductEventListEventsDimensions[] AdditionMsg{ get; set; }

        /// <summary>
        /// Whether to configure alarms.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IsAlarmConfig")]
        public long? IsAlarmConfig{ get; set; }

        /// <summary>
        /// Policy information.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("GroupInfo")]
        public DescribeProductEventListEventsGroupInfo[] GroupInfo{ get; set; }

        /// <summary>
        /// Display name
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "EventCName", this.EventCName);
            this.SetParamSimple(map, prefix + "EventEName", this.EventEName);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "ProductCName", this.ProductCName);
            this.SetParamSimple(map, prefix + "ProductEName", this.ProductEName);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SupportAlarm", this.SupportAlarm);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamArrayObj(map, prefix + "AdditionMsg.", this.AdditionMsg);
            this.SetParamSimple(map, prefix + "IsAlarmConfig", this.IsAlarmConfig);
            this.SetParamArrayObj(map, prefix + "GroupInfo.", this.GroupInfo);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
        }
    }
}

