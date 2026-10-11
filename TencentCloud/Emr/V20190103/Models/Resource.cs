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
        /// <p>Node specification description, such as CVM.SA2.</p>
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// <p>Valid values:<br>&quot;LOCAL_SSD&quot;   3     // Local SSD<br>&quot;CLOUD_SSD&quot;   4     // Cloud SSD<br>&quot;CLOUD_PREMIUM&quot;  5  // Premium Disk<br>&quot;CLOUD_HSSD&quot;   6    // Enhanced SSD<br>&quot;CLOUD_THROUGHPUT&quot; 11// Throughput-Optimized Cloud Disk<br>&quot;CLOUD_TSSD&quot;  12     // Tremendous SSD<br>&quot;CLOUD_BSSD&quot;    13   // Balanced SSD<br>&quot;CLOUD_BIGDATA&quot; 14   // Big Data Cloud Disk<br>&quot;CLOUD_HIGHIO&quot;  15   // High-IO Cloud Disk </p><p>This field is invalid. The actual system disk type is determined based on the data disk type and node type. If the node supports the selected data disk type, the system disk type is consistent with the data disk. It is recommended to use the CreateCluster API.</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// <p>Data disk type. Valid values:</p><p>CLOUD_SSD: Cloud SSD</p><p>CLOUD_PREMIUM: Premium Disk</p><p>CLOUD_BASIC: Cloud Basic Disk</p><p>LOCAL_BASIC: Local Basic Disk</p><p>LOCAL_SSD: Local SSD</p><p>CLOUD_HSSD: Enhanced SSD</p><p>CLOUD_THROUGHPUT: Throughput-Optimized Cloud Disk</p><p>CLOUD_TSSD: Tremendous SSD</p><p>CLOUD_BIGDATA: Big Data Cloud Disk</p><p>CLOUD_HIGHIO: High-IO Cloud Disk</p><p>CLOUD_BSSD: Balanced SSD</p><p>REMOTE_SSD: Remote SSD Disk</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>Memory capacity (MB).</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// <p>Number of CPU cores.</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Data disk capacity.</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <p>System disk capacity.</p>
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// <p>Cloud disk list. When the data disk is a single cloud disk, use the DiskType and DiskSize parameters directly. Use MultiDisks for extra disks.</p>
        /// </summary>
        [JsonProperty("MultiDisks")]
        public MultiDisk[] MultiDisks{ get; set; }

        /// <summary>
        /// <p>List of tags to be bound.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Specifications type, such as S2.MEDIUM8.</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Number of local disks. This field has been deprecated.</p>
        /// </summary>
        [JsonProperty("LocalDiskNum")]
        public ulong? LocalDiskNum{ get; set; }

        /// <summary>
        /// <p>Number of local disks, such as 2.</p>
        /// </summary>
        [JsonProperty("DiskNum")]
        public ulong? DiskNum{ get; set; }

        /// <summary>
        /// <p>GPU information.</p>
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }

        /// <summary>
        /// <p>Number of partitions in a placement group.</p>
        /// </summary>
        [JsonProperty("PartitionNumber")]
        public long? PartitionNumber{ get; set; }

        /// <summary>
        /// <p>High-performance cluster ID.</p>
        /// </summary>
        [JsonProperty("HCCHpcClusterId")]
        public string HCCHpcClusterId{ get; set; }

        /// <summary>
        /// <p>Custom hostname.</p>
        /// </summary>
        [JsonProperty("CustomNodeName")]
        public string CustomNodeName{ get; set; }

        /// <summary>
        /// <p>GPU image driver configuration.</p>
        /// </summary>
        [JsonProperty("GpuImageDriver")]
        public GpuImageDriverSpec GpuImageDriver{ get; set; }


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
            this.SetParamSimple(map, prefix + "PartitionNumber", this.PartitionNumber);
            this.SetParamSimple(map, prefix + "HCCHpcClusterId", this.HCCHpcClusterId);
            this.SetParamSimple(map, prefix + "CustomNodeName", this.CustomNodeName);
            this.SetParamObj(map, prefix + "GpuImageDriver.", this.GpuImageDriver);
        }
    }
}

