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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestartNodesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Node name list
        /// </summary>
        [JsonProperty("NodeNames")]
        public string[] NodeNames{ get; set; }

        /// <summary>
        /// Whether to perform forced reboot.
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }

        /// <summary>
        /// Optional restart mode. `in-place`: restart; `blue-green`: blue-green restart. Default value: `in-place`.
        /// </summary>
        [JsonProperty("RestartMode")]
        public string RestartMode{ get; set; }

        /// <summary>
        /// Node status, for use in blue-green mode; offline node blue/green at risk
        /// </summary>
        [JsonProperty("IsOffline")]
        public bool? IsOffline{ get; set; }

        /// <summary>
        /// cvm delay listing time
        /// </summary>
        [JsonProperty("CvmDelayOnlineTime")]
        public ulong? CvmDelayOnlineTime{ get; set; }

        /// <summary>
        /// Number of concurrent shard migrations
        /// </summary>
        [JsonProperty("ShardAllocationConcurrents")]
        public ulong? ShardAllocationConcurrents{ get; set; }

        /// <summary>
        /// Shard migration concurrency speed
        /// </summary>
        [JsonProperty("ShardAllocationBytes")]
        public ulong? ShardAllocationBytes{ get; set; }

        /// <summary>
        /// Whether to enable the placement group asynchronous task
        /// </summary>
        [JsonProperty("EnableScheduleRecoverGroup")]
        public bool? EnableScheduleRecoverGroup{ get; set; }

        /// <summary>
        /// Time period of the async task for the placement group
        /// </summary>
        [JsonProperty("EnableScheduleOperationDuration")]
        public EnableScheduleOperationDuration EnableScheduleOperationDuration{ get; set; }

        /// <summary>
        /// Event ID list.
        /// </summary>
        [JsonProperty("EventTypeIds")]
        public string[] EventTypeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "NodeNames.", this.NodeNames);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
            this.SetParamSimple(map, prefix + "RestartMode", this.RestartMode);
            this.SetParamSimple(map, prefix + "IsOffline", this.IsOffline);
            this.SetParamSimple(map, prefix + "CvmDelayOnlineTime", this.CvmDelayOnlineTime);
            this.SetParamSimple(map, prefix + "ShardAllocationConcurrents", this.ShardAllocationConcurrents);
            this.SetParamSimple(map, prefix + "ShardAllocationBytes", this.ShardAllocationBytes);
            this.SetParamSimple(map, prefix + "EnableScheduleRecoverGroup", this.EnableScheduleRecoverGroup);
            this.SetParamObj(map, prefix + "EnableScheduleOperationDuration.", this.EnableScheduleOperationDuration);
            this.SetParamArraySimple(map, prefix + "EventTypeIds.", this.EventTypeIds);
        }
    }
}

