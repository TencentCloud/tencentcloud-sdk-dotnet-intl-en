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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Resource : AbstractModel
    {
        
        /// <summary>
        /// Node specifications description, such as CVM.SA2.
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// Storage type.
        /// Valid values:
        /// <li>4: Cloud SSD.</li>
        /// <li>5: Premium Cloud Disk.</li>
        /// <li>6: Enhanced SSD.</li>
        /// <li>11: Throughput HDD.</li>
        /// <li>12: Tremendous SSD.</li>: this type is invalid upon creation, and automatic judgment will be conducted based on data disk type and node type.
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// Disk type.
        /// Valid values.
        /// <li>CLOUD_SSD: Cloud SSD.</li>
        /// <li>CLOUD_PREMIUM: Premium Cloud Disk.</li>
        /// <li>CLOUD_BASIC: Cloud Disk.</li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Memory capacity, in MB.
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Data disk capacity.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// System disk capacity.
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// List of cloud disks. When the data disk is a cloud disk, `DiskType` and `DiskSize` are used directly; `MultiDisks` will be used for the excessive part
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MultiDisks")]
        public MultiDisk[] MultiDisks{ get; set; }

        /// <summary>
        /// List of tags to be bound
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Specifications type, such as S2.MEDIUM8.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Number of local disks. This field is deprecated.
        /// </summary>
        [JsonProperty("LocalDiskNum")]
        public ulong? LocalDiskNum{ get; set; }

        /// <summary>
        /// Number of local disks, such as 2.
        /// </summary>
        [JsonProperty("DiskNum")]
        public ulong? DiskNum{ get; set; }

        /// <summary>
        /// GPU information.
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "RootSize", this.RootSize);
            this.SetParamArrayObj(map, prefix + "MultiDisks.", this.MultiDisks);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "LocalDiskNum", this.LocalDiskNum);
            this.SetParamSimple(map, prefix + "DiskNum", this.DiskNum);
            this.SetParamSimple(map, prefix + "GpuDesc", this.GpuDesc);
        }
    }
}

