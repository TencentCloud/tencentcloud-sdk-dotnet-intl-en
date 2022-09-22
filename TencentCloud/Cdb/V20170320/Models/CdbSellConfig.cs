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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdbSellConfig : AbstractModel
    {
        
        /// <summary>
        /// Memory size in MB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// CPU core count
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Minimum disk size in GB
        /// </summary>
        [JsonProperty("VolumeMin")]
        public long? VolumeMin{ get; set; }

        /// <summary>
        /// Maximum disk size in GB
        /// </summary>
        [JsonProperty("VolumeMax")]
        public long? VolumeMax{ get; set; }

        /// <summary>
        /// Disk capacity increment in GB
        /// </summary>
        [JsonProperty("VolumeStep")]
        public long? VolumeStep{ get; set; }

        /// <summary>
        /// IO operations per second
        /// </summary>
        [JsonProperty("Iops")]
        public long? Iops{ get; set; }

        /// <summary>
        /// Application scenario description
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// Status. The value `0` indicates that this specification is available.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Instance type. Valid values: `UNIVERSAL` (general instance), `EXCLUSIVE` (dedicated instance), `BASIC` (basic instance).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// Engine type description. Valid values: `Innodb`, `RocksDB`.
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// Purchasable specifications ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "VolumeMin", this.VolumeMin);
            this.SetParamSimple(map, prefix + "VolumeMax", this.VolumeMax);
            this.SetParamSimple(map, prefix + "VolumeStep", this.VolumeStep);
            this.SetParamSimple(map, prefix + "Iops", this.Iops);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

