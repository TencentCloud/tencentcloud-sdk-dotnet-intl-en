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

namespace TencentCloud.Edgezone.V20260401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceTypeQuota : AbstractModel
    {
        
        /// <summary>
        /// Availability zone code.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Model specifications.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Model family.
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        [JsonProperty("CpuCores")]
        public long? CpuCores{ get; set; }

        /// <summary>
        /// CPU type.
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// Memory size (GB).
        /// </summary>
        [JsonProperty("MemoryGb")]
        public long? MemoryGb{ get; set; }

        /// <summary>
        /// System disk type.
        /// </summary>
        [JsonProperty("SystemDiskType")]
        public string SystemDiskType{ get; set; }

        /// <summary>
        /// System disk size (GB).
        /// </summary>
        [JsonProperty("SystemDiskSize")]
        public long? SystemDiskSize{ get; set; }

        /// <summary>
        /// Number of system disks.
        /// </summary>
        [JsonProperty("SystemDiskCount")]
        public ulong? SystemDiskCount{ get; set; }

        /// <summary>
        /// Data disk type.
        /// </summary>
        [JsonProperty("DataDiskType")]
        public string DataDiskType{ get; set; }

        /// <summary>
        /// Data disk size (GB).
        /// </summary>
        [JsonProperty("DataDiskSize")]
        public long? DataDiskSize{ get; set; }

        /// <summary>
        /// Number of data disks.
        /// </summary>
        [JsonProperty("DataDiskCount")]
        public ulong? DataDiskCount{ get; set; }

        /// <summary>
        /// Disk description string (backward compatibility).
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Network interface type.
        /// </summary>
        [JsonProperty("NetworkInterfaceType")]
        public string NetworkInterfaceType{ get; set; }

        /// <summary>
        /// GPU type. Empty string if no GPU is available.
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// Quota quantity. 0 indicates no restriction.
        /// </summary>
        [JsonProperty("Quota")]
        public ulong? Quota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "CpuCores", this.CpuCores);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "MemoryGb", this.MemoryGb);
            this.SetParamSimple(map, prefix + "SystemDiskType", this.SystemDiskType);
            this.SetParamSimple(map, prefix + "SystemDiskSize", this.SystemDiskSize);
            this.SetParamSimple(map, prefix + "SystemDiskCount", this.SystemDiskCount);
            this.SetParamSimple(map, prefix + "DataDiskType", this.DataDiskType);
            this.SetParamSimple(map, prefix + "DataDiskSize", this.DataDiskSize);
            this.SetParamSimple(map, prefix + "DataDiskCount", this.DataDiskCount);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "NetworkInterfaceType", this.NetworkInterfaceType);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "Quota", this.Quota);
        }
    }
}

