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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceAlarmEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Event query range start time, closed interval.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the event query range, closed interval.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Event name. Outofmemory - Memory OOM (status event); Switch - primary-secondary switch (status event); Roremove - read-only instance removal (status event); MemoryUsedHigh - high memory utilization (status event); CPUExpansion - CPU performance scale-out (stateless event); CPUExpansionFailed - CPU performance scale-out failed (stateless event); CPUContraction - CPU performance scale-in (stateless event); Restart - instance restart (status event); ServerFailureNodeMigration - ServerFailureNodeMigration (status event); PlannedSwitch - planned active/standby switch (stateless event); OverusedReadonlySet - instance will be locked (stateless event); OverusedReadWriteSet - instance unlock (stateless event).
        /// </summary>
        [JsonProperty("EventName")]
        public string[] EventName{ get; set; }

        /// <summary>
        /// Event status. "1" - Event; "0" - Recovery event; "-" - Stateless event.
        /// </summary>
        [JsonProperty("EventStatus")]
        public string EventStatus{ get; set; }

        /// <summary>
        /// Sorting method. Sort by event occurrence. "DESC" - inverted; "ASC" - in order. Default is inverted.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Number of displayed events. Default is 100, maximum is 200.
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "EventName.", this.EventName);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
        }
    }
}

