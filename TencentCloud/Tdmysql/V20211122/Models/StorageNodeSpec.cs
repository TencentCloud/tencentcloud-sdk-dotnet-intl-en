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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageNodeSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>Specification code</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// <p>CPU cores of the storage node</p>
        /// </summary>
        [JsonProperty("StorageNodeCpu")]
        public long? StorageNodeCpu{ get; set; }

        /// <summary>
        /// <p>Storage node memory size</p>
        /// </summary>
        [JsonProperty("StorageNodeMem")]
        public long? StorageNodeMem{ get; set; }

        /// <summary>
        /// <p>Maximum quantity of storage nodes</p>
        /// </summary>
        [JsonProperty("StorageNodeMaxNum")]
        public long? StorageNodeMaxNum{ get; set; }

        /// <summary>
        /// <p>Node disk size capacity limit</p>
        /// </summary>
        [JsonProperty("StorageNodeMaxDisk")]
        public long? StorageNodeMaxDisk{ get; set; }

        /// <summary>
        /// <p>Minimum number of storage nodes</p>
        /// </summary>
        [JsonProperty("StorageNodeMinNum")]
        public long? StorageNodeMinNum{ get; set; }

        /// <summary>
        /// <p>Node disk size minimum</p>
        /// </summary>
        [JsonProperty("StorageNodeMinDisk")]
        public long? StorageNodeMinDisk{ get; set; }

        /// <summary>
        /// <p>Disk Type, CLOUD_HSSD enhanced SSD, CLOUD_TCS local SSD disk</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>Default disk size of storage node for frontend display</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StorageNodeDefaultDisk")]
        public long? StorageNodeDefaultDisk{ get; set; }

        /// <summary>
        /// <p>Specification support billing mode list</p>
        /// </summary>
        [JsonProperty("InstanceMode")]
        public string[] InstanceMode{ get; set; }

        /// <summary>
        /// <p>Disk Type CLOUD_DISK: cloud disk LOCAL_DISK: local disk</p>
        /// </summary>
        [JsonProperty("DiskTypeCategory")]
        public string DiskTypeCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "StorageNodeCpu", this.StorageNodeCpu);
            this.SetParamSimple(map, prefix + "StorageNodeMem", this.StorageNodeMem);
            this.SetParamSimple(map, prefix + "StorageNodeMaxNum", this.StorageNodeMaxNum);
            this.SetParamSimple(map, prefix + "StorageNodeMaxDisk", this.StorageNodeMaxDisk);
            this.SetParamSimple(map, prefix + "StorageNodeMinNum", this.StorageNodeMinNum);
            this.SetParamSimple(map, prefix + "StorageNodeMinDisk", this.StorageNodeMinDisk);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "StorageNodeDefaultDisk", this.StorageNodeDefaultDisk);
            this.SetParamArraySimple(map, prefix + "InstanceMode.", this.InstanceMode);
            this.SetParamSimple(map, prefix + "DiskTypeCategory", this.DiskTypeCategory);
        }
    }
}

