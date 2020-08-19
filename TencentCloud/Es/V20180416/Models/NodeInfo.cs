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

    public class NodeInfo : AbstractModel
    {
        
        /// <summary>
        /// Number of nodes
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// Node specification <li>ES.S1.SMALL2: 1-core 2 GB </li><li>ES.S1.MEDIUM4: 2-core 4 GB </li><li>ES.S1.MEDIUM8: 2-core 8 GB </li><li>ES.S1.LARGE16: 4-core 16 GB </li><li>ES.S1.2XLARGE32: 8-core 32 GB </li><li>ES.S1.4XLARGE32: 16-core 32 GB </li><li>ES.S1.4XLARGE64: 16-core 64 GB </li>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Node type <li>hotData: hot data node</li>
        /// <li>warmData: warm data node</li>
        /// <li>dedicatedMaster: dedicated primary node</li>
        /// Default value: hotData
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Node disk type <li>CLOUD_SSD: SSD cloud storage </li><li>CLOUD_PREMIUM: Premium cloud disk </li>Default value: CLOUD_SSD
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Node disk size in GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Local disk information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LocalDiskInfo")]
        public LocalDiskInfo LocalDiskInfo{ get; set; }

        /// <summary>
        /// Number of node disks
        /// </summary>
        [JsonProperty("DiskCount")]
        public ulong? DiskCount{ get; set; }

        /// <summary>
        /// Whether to encrypt node disk. 0: no (default); 1: yes.
        /// </summary>
        [JsonProperty("DiskEncrypt")]
        public ulong? DiskEncrypt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamObj(map, prefix + "LocalDiskInfo.", this.LocalDiskInfo);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "DiskEncrypt", this.DiskEncrypt);
        }
    }
}

