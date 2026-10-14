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

    public class NodeView : AbstractModel
    {
        
        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// Node IP
        /// </summary>
        [JsonProperty("NodeIp")]
        public string NodeIp{ get; set; }

        /// <summary>
        /// Whether the node is visible
        /// </summary>
        [JsonProperty("Visible")]
        public float? Visible{ get; set; }

        /// <summary>
        /// Whether to fuse
        /// </summary>
        [JsonProperty("Break")]
        public float? Break{ get; set; }

        /// <summary>
        /// Total node disk size
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Disk utilization rate
        /// </summary>
        [JsonProperty("DiskUsage")]
        public float? DiskUsage{ get; set; }

        /// <summary>
        /// Node memory size (unit: GB)
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// Memory usage rate
        /// </summary>
        [JsonProperty("MemUsage")]
        public float? MemUsage{ get; set; }

        /// <summary>
        /// Number of CPUs on the node
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// CPU utilization
        /// </summary>
        [JsonProperty("CpuUsage")]
        public float? CpuUsage{ get; set; }

        /// <summary>
        /// AZ.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Node role
        /// </summary>
        [JsonProperty("NodeRole")]
        public string NodeRole{ get; set; }

        /// <summary>
        /// Node HTTP IP
        /// </summary>
        [JsonProperty("NodeHttpIp")]
        public string NodeHttpIp{ get; set; }

        /// <summary>
        /// JVM memory usage rate
        /// </summary>
        [JsonProperty("JvmMemUsage")]
        public float? JvmMemUsage{ get; set; }

        /// <summary>
        /// Number of shards per node
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// Disk ID list on node
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// Whether it is a hidden AZ
        /// </summary>
        [JsonProperty("Hidden")]
        public bool? Hidden{ get; set; }

        /// <summary>
        /// Whether to act as the coordination node role
        /// </summary>
        [JsonProperty("IsCoordinationNode")]
        public bool? IsCoordinationNode{ get; set; }

        /// <summary>
        /// CVM running state
        /// </summary>
        [JsonProperty("CVMStatus")]
        public string CVMStatus{ get; set; }

        /// <summary>
        /// id of the placement group bound to the cvm
        /// </summary>
        [JsonProperty("CVMDisasterRecoverGroupId")]
        public string CVMDisasterRecoverGroupId{ get; set; }

        /// <summary>
        /// Status of the placement group bound to the cvm. 2: Bound; 1: Binding; 0: Not enabled
        /// </summary>
        [JsonProperty("CVMDisasterRecoverGroupStatus")]
        public long? CVMDisasterRecoverGroupStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeIp", this.NodeIp);
            this.SetParamSimple(map, prefix + "Visible", this.Visible);
            this.SetParamSimple(map, prefix + "Break", this.Break);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemUsage", this.MemUsage);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "CpuUsage", this.CpuUsage);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeRole", this.NodeRole);
            this.SetParamSimple(map, prefix + "NodeHttpIp", this.NodeHttpIp);
            this.SetParamSimple(map, prefix + "JvmMemUsage", this.JvmMemUsage);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "Hidden", this.Hidden);
            this.SetParamSimple(map, prefix + "IsCoordinationNode", this.IsCoordinationNode);
            this.SetParamSimple(map, prefix + "CVMStatus", this.CVMStatus);
            this.SetParamSimple(map, prefix + "CVMDisasterRecoverGroupId", this.CVMDisasterRecoverGroupId);
            this.SetParamSimple(map, prefix + "CVMDisasterRecoverGroupStatus", this.CVMDisasterRecoverGroupStatus);
        }
    }
}

