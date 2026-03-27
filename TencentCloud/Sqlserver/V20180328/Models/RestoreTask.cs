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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreTask : AbstractModel
    {
        
        /// <summary>
        /// Target Instance ID
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }

        /// <summary>
        /// Target Instance Name
        /// </summary>
        [JsonProperty("TargetInstanceName")]
        public string TargetInstanceName{ get; set; }

        /// <summary>
        /// Target Instance Status. Valid values:
        /// 1: Creating
        /// 2: Running
        /// 3: Restricted Running (primary/secondary switching)
        /// 4: Isolated
        /// 5: Recycling
        /// 6: Recycled
        /// 7: Task Executing (instance backup, rollback, etc.)
        /// 8: Offline
        /// 9: Instance Scaling
        /// 10: Instance Migrating
        /// 11: Read-Only
        /// 12: Restarting
        /// </summary>
        [JsonProperty("TargetInstanceStatus")]
        public long? TargetInstanceStatus{ get; set; }

        /// <summary>
        /// Target Instance Region
        /// </summary>
        [JsonProperty("TargetRegion")]
        public string TargetRegion{ get; set; }

        /// <summary>
        /// Rollback Record ID
        /// </summary>
        [JsonProperty("RestoreId")]
        public long? RestoreId{ get; set; }

        /// <summary>
        /// Restoration target instance type: 0 - current instance, 1 - existing instance, 2 - new instance
        /// </summary>
        [JsonProperty("TargetType")]
        public long? TargetType{ get; set; }

        /// <summary>
        /// Rollback method: 0 - by point-in-time, 1 - by backup set
        /// </summary>
        [JsonProperty("RestoreType")]
        public long? RestoreType{ get; set; }

        /// <summary>
        /// Rollback Target Time
        /// </summary>
        [JsonProperty("RestoreTime")]
        public string RestoreTime{ get; set; }

        /// <summary>
        /// Start Time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End Time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Rollback status: 0 - Initialization, 1 - Running, 2 - Success, 3 - Failure
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Rollback Asynchronous Task ID
        /// </summary>
        [JsonProperty("FlowId")]
        public long? FlowId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
            this.SetParamSimple(map, prefix + "TargetInstanceName", this.TargetInstanceName);
            this.SetParamSimple(map, prefix + "TargetInstanceStatus", this.TargetInstanceStatus);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "RestoreId", this.RestoreId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "RestoreType", this.RestoreType);
            this.SetParamSimple(map, prefix + "RestoreTime", this.RestoreTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
        }
    }
}

