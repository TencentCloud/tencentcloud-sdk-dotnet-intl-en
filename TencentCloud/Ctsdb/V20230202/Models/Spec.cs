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

namespace TencentCloud.Ctsdb.V20230202.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Spec : AbstractModel
    {
        
        /// <summary>
        /// 1: yearly/monthly subscription; 2: bill by hour.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Request unit. 0 indicates following the resource configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestUnit")]
        public ulong? RequestUnit{ get; set; }

        /// <summary>
        /// Maximum number of CPU cores.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CpuLimit")]
        public float? CpuLimit{ get; set; }

        /// <summary>
        /// Maximum memory size (Gi).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemoryLimit")]
        public float? MemoryLimit{ get; set; }

        /// <summary>
        /// Maximum number of disks (Gi).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskLimit")]
        public ulong? DiskLimit{ get; set; }

        /// <summary>
        /// Number of business shards.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Shards")]
        public ulong? Shards{ get; set; }

        /// <summary>
        /// Number of business nodes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Replicas")]
        public ulong? Replicas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "RequestUnit", this.RequestUnit);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemoryLimit", this.MemoryLimit);
            this.SetParamSimple(map, prefix + "DiskLimit", this.DiskLimit);
            this.SetParamSimple(map, prefix + "Shards", this.Shards);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
        }
    }
}

