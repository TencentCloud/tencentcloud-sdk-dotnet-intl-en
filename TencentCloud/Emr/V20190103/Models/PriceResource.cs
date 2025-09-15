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

    public class PriceResource : AbstractModel
    {
        
        /// <summary>
        /// Required specifications.
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// Hard disk type.
        /// </summary>
        [JsonProperty("StorageType")]
        public ulong? StorageType{ get; set; }

        /// <summary>
        /// Hard disk type.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// System disk size.
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// Memory size.
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// Number of cores.
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Hard disk size.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// List of cloud disks.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MultiDisks")]
        public MultiDisk[] MultiDisks{ get; set; }

        /// <summary>
        /// Number of disks.
        /// </summary>
        [JsonProperty("DiskCnt")]
        public long? DiskCnt{ get; set; }

        /// <summary>
        /// Specifications.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Tag
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Number of disks.
        /// </summary>
        [JsonProperty("DiskNum")]
        public long? DiskNum{ get; set; }

        /// <summary>
        /// Number of local disks.
        /// </summary>
        [JsonProperty("LocalDiskNum")]
        public long? LocalDiskNum{ get; set; }

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
            this.SetParamSimple(map, prefix + "RootSize", this.RootSize);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamArrayObj(map, prefix + "MultiDisks.", this.MultiDisks);
            this.SetParamSimple(map, prefix + "DiskCnt", this.DiskCnt);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DiskNum", this.DiskNum);
            this.SetParamSimple(map, prefix + "LocalDiskNum", this.LocalDiskNum);
            this.SetParamSimple(map, prefix + "GpuDesc", this.GpuDesc);
        }
    }
}

