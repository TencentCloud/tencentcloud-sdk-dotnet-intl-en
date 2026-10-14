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

    public class NodeInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of nodes.</p>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// <p>Node specification<li>ES.S1.SMALL2: 1-core 2G</li><li>ES.S1.MEDIUM4: 2-core 4G</li><li>ES.S1.MEDIUM8: 2-core 8G</li><li>ES.S1.LARGE16: 4-core 16G</li><li>ES.S1.2XLARGE32: 8-core 32G</li><li>ES.S1.4XLARGE32: 16-core 32G</li><li>ES.S1.4XLARGE64: 16-core 64G</li></p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Node type</p><p>Enumeration values:</p><ul><li>hotData: hot data node</li><li>warmData: cold data node</li><li>dedicatedMaster: dedicated master node</li><li>dedicatedCoordinating: dedicated coordinator node</li><li>dedicatedMl: dedicated Machine Learning node</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Node disk type<li>CLOUD_SSD: ssd cloud disk</li><li>CLOUD_PREMIUM: high-performance cloud disk</li>Default value: CLOUD_SSD</p>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>Node disk capacity (GB)</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// <p>Node local disk information.</p>
        /// </summary>
        [JsonProperty("LocalDiskInfo")]
        public LocalDiskInfo LocalDiskInfo{ get; set; }

        /// <summary>
        /// <p>Number of node disk blocks</p>
        /// </summary>
        [JsonProperty("DiskCount")]
        public ulong? DiskCount{ get; set; }

        /// <summary>
        /// <p>Whether the node disk is encrypted. 0: no encryption; 1: encryption; not encrypted by default</p>
        /// </summary>
        [JsonProperty("DiskEncrypt")]
        public ulong? DiskEncrypt{ get; set; }

        /// <summary>
        /// <p>Custom encryption key id</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>Custom encryption key name</p>
        /// </summary>
        [JsonProperty("KmsKeyName")]
        public string KmsKeyName{ get; set; }

        /// <summary>
        /// <p>Number of CPUs</p>
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// <p>Memory size, in GB.</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// <p>Additional hard disk performance</p>
        /// </summary>
        [JsonProperty("DiskEnhance")]
        public long? DiskEnhance{ get; set; }

        /// <summary>
        /// <p>Gpu information of the node</p>
        /// </summary>
        [JsonProperty("GpuInfo")]
        public GpuInfo GpuInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamObj(map, prefix + "LocalDiskInfo.", this.LocalDiskInfo);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "DiskEncrypt", this.DiskEncrypt);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "KmsKeyName", this.KmsKeyName);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "DiskEnhance", this.DiskEnhance);
            this.SetParamObj(map, prefix + "GpuInfo.", this.GpuInfo);
        }
    }
}

