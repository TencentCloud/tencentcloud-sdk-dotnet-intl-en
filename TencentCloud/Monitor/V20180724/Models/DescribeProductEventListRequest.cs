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

    public class DescribeProductEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// API component name. It is fixed to monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Filter by product type. For example, "cvm" indicates Cloud Virtual Machine.
        /// </summary>
        [JsonProperty("ProductName")]
        public string[] ProductName{ get; set; }

        /// <summary>
        /// Filter by event name. For example, "guest_reboot" indicates instance restart.
        /// </summary>
        [JsonProperty("EventName")]
        public string[] EventName{ get; set; }

        /// <summary>
        /// Affected object, such as "ins-19708ino".
        /// </summary>
        [JsonProperty("InstanceId")]
        public string[] InstanceId{ get; set; }

        /// <summary>
        /// Filter by dimension, such as by public IP: 10.0.0.1.
        /// </summary>
        [JsonProperty("Dimensions")]
        public DescribeProductEventListDimensions[] Dimensions{ get; set; }

        /// <summary>
        /// Region filter parameter for service events.
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

        /// <summary>
        /// Filter by event type. Valid values: ["status_change","abnormal"], which indicate events whose statuses have changed and events with exceptions respectively.
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// Filter by event status. Valid values: ["recover","alarm","-"], which indicate that an event has been recovered, has not been recovered, and has no status respectively.
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// Filter by project ID.
        /// </summary>
        [JsonProperty("Project")]
        public string[] Project{ get; set; }

        /// <summary>
        /// Filter by alarm status configuration. The value 1 indicates that the alarm status has been configured. The value 0 indicates that the alarm status has not been configured.
        /// </summary>
        [JsonProperty("IsAlarmConfig")]
        public long? IsAlarmConfig{ get; set; }

        /// <summary>
        /// Sorting by update time. The value ASC indicates the ascending order. The value DESC indicates the descending order. The default value is DESC.
        /// </summary>
        [JsonProperty("TimeOrder")]
        public string TimeOrder{ get; set; }

        /// <summary>
        /// Start time, which is the timestamp one day prior by default.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time, which is the current timestamp by default.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Page offset. The default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The number of parameters that can be returned on each page. The default value is 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamArraySimple(map, prefix + "ProductName.", this.ProductName);
            this.SetParamArraySimple(map, prefix + "EventName.", this.EventName);
            this.SetParamArraySimple(map, prefix + "InstanceId.", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "Project.", this.Project);
            this.SetParamSimple(map, prefix + "IsAlarmConfig", this.IsAlarmConfig);
            this.SetParamSimple(map, prefix + "TimeOrder", this.TimeOrder);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

