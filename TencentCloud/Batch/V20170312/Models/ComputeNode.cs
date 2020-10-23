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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComputeNode : AbstractModel
    {
        
        /// <summary>
        /// Compute node ID
        /// </summary>
        [JsonProperty("ComputeNodeId")]
        public string ComputeNodeId{ get; set; }

        /// <summary>
        /// Compute node instance ID. In a CVM scenario, this parameter is the CVM InstanceId
        /// </summary>
        [JsonProperty("ComputeNodeInstanceId")]
        public string ComputeNodeInstanceId{ get; set; }

        /// <summary>
        /// Compute node state
        /// </summary>
        [JsonProperty("ComputeNodeState")]
        public string ComputeNodeState{ get; set; }

        /// <summary>
        /// Number of CPU cores
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Memory size in GiB
        /// </summary>
        [JsonProperty("Mem")]
        public ulong? Mem{ get; set; }

        /// <summary>
        /// Resource creation time
        /// </summary>
        [JsonProperty("ResourceCreatedTime")]
        public string ResourceCreatedTime{ get; set; }

        /// <summary>
        /// Available capacity of the compute node when running TaskInstance. 0 means that the compute node is busy.
        /// </summary>
        [JsonProperty("TaskInstanceNumAvailable")]
        public ulong? TaskInstanceNumAvailable{ get; set; }

        /// <summary>
        /// BatchCompute Agent version
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// Private IP of the instance
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// Public IP of the instance
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// Compute environment resource type. Valid values: `CVM`, `CPM` (Bare Metal)
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Source of compute environment resources. <br>BATCH_CREATED: instance resources created by BatchCompute.<br>
        /// USER_ATTACHED: instance resources added by users to the compute environment.
        /// </summary>
        [JsonProperty("ResourceOrigin")]
        public string ResourceOrigin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComputeNodeId", this.ComputeNodeId);
            this.SetParamSimple(map, prefix + "ComputeNodeInstanceId", this.ComputeNodeInstanceId);
            this.SetParamSimple(map, prefix + "ComputeNodeState", this.ComputeNodeState);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "ResourceCreatedTime", this.ResourceCreatedTime);
            this.SetParamSimple(map, prefix + "TaskInstanceNumAvailable", this.TaskInstanceNumAvailable);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceOrigin", this.ResourceOrigin);
        }
    }
}

