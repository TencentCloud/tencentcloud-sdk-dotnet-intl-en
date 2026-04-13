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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedCluster : AbstractModel
    {
        
        /// <summary>
        /// CDC ID.
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// Dedicated cluster name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Specifies the AZ of the exclusive cluster.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Disaster recovery cluster.
        /// </summary>
        [JsonProperty("StandbyDedicatedClusterSet")]
        public string[] StandbyDedicatedClusterSet{ get; set; }

        /// <summary>
        /// Specifies the instance count.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// Total number of cpus.
        /// </summary>
        [JsonProperty("CpuTotal")]
        public long? CpuTotal{ get; set; }

        /// <summary>
        /// Specifies the available amount of Cpu.
        /// </summary>
        [JsonProperty("CpuAvailable")]
        public long? CpuAvailable{ get; set; }

        /// <summary>
        /// Total memory capacity in GB.
        /// </summary>
        [JsonProperty("MemTotal")]
        public long? MemTotal{ get; set; }

        /// <summary>
        /// Available memory in GB.
        /// </summary>
        [JsonProperty("MemAvailable")]
        public long? MemAvailable{ get; set; }

        /// <summary>
        /// Total disk capacity (unit: GB).
        /// </summary>
        [JsonProperty("DiskTotal")]
        public long? DiskTotal{ get; set; }

        /// <summary>
        /// Disk availability (unit: GB).
        /// </summary>
        [JsonProperty("DiskAvailable")]
        public long? DiskAvailable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "StandbyDedicatedClusterSet.", this.StandbyDedicatedClusterSet);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "CpuTotal", this.CpuTotal);
            this.SetParamSimple(map, prefix + "CpuAvailable", this.CpuAvailable);
            this.SetParamSimple(map, prefix + "MemTotal", this.MemTotal);
            this.SetParamSimple(map, prefix + "MemAvailable", this.MemAvailable);
            this.SetParamSimple(map, prefix + "DiskTotal", this.DiskTotal);
            this.SetParamSimple(map, prefix + "DiskAvailable", this.DiskAvailable);
        }
    }
}

