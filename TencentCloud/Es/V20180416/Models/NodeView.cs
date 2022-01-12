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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeView : AbstractModel
    {
        
        /// <summary>
        /// Node ID
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
        /// Whether the node encounters circuit breaking
        /// </summary>
        [JsonProperty("Break")]
        public float? Break{ get; set; }

        /// <summary>
        /// Node disk size
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Disk usage
        /// </summary>
        [JsonProperty("DiskUsage")]
        public float? DiskUsage{ get; set; }

        /// <summary>
        /// Node memory size (in GB)
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// Memory usage
        /// </summary>
        [JsonProperty("MemUsage")]
        public float? MemUsage{ get; set; }

        /// <summary>
        /// Number of node CPUs
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// CPU usage
        /// </summary>
        [JsonProperty("CpuUsage")]
        public float? CpuUsage{ get; set; }

        /// <summary>
        /// Availability zone
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
        /// JVM memory usage
        /// </summary>
        [JsonProperty("JvmMemUsage")]
        public float? JvmMemUsage{ get; set; }

        /// <summary>
        /// Number of node shards
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// ID list of node disks
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// Whether a hidden availability zone
        /// </summary>
        [JsonProperty("Hidden")]
        public bool? Hidden{ get; set; }


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
        }
    }
}

