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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceData : AbstractModel
    {
        
        /// <summary>
        /// CPU After Resizing
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Memory After Resizing
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Storage Limit After Resizing
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// CPU Before Resizing
        /// </summary>
        [JsonProperty("OldCpu")]
        public long? OldCpu{ get; set; }

        /// <summary>
        /// Memory Before Resizing
        /// </summary>
        [JsonProperty("OldMemory")]
        public long? OldMemory{ get; set; }

        /// <summary>
        /// Storage Limit Before Resizing
        /// </summary>
        [JsonProperty("OldStorageLimit")]
        public long? OldStorageLimit{ get; set; }

        /// <summary>
        /// Instance machine type before scaling.
        /// </summary>
        [JsonProperty("OldDeviceType")]
        public string OldDeviceType{ get; set; }

        /// <summary>
        /// Instance machine type after scaling.
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// Upgrade Method. Switchover is performed after upgrade completion or during maintenance windows
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// Specifies the quantity of libra nodes.
        /// </summary>
        [JsonProperty("LibraNodeCount")]
        public long? LibraNodeCount{ get; set; }

        /// <summary>
        /// Specifies the original quantity of libra nodes.
        /// </summary>
        [JsonProperty("OldLibraNodeCount")]
        public long? OldLibraNodeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "OldCpu", this.OldCpu);
            this.SetParamSimple(map, prefix + "OldMemory", this.OldMemory);
            this.SetParamSimple(map, prefix + "OldStorageLimit", this.OldStorageLimit);
            this.SetParamSimple(map, prefix + "OldDeviceType", this.OldDeviceType);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamSimple(map, prefix + "LibraNodeCount", this.LibraNodeCount);
            this.SetParamSimple(map, prefix + "OldLibraNodeCount", this.OldLibraNodeCount);
        }
    }
}

