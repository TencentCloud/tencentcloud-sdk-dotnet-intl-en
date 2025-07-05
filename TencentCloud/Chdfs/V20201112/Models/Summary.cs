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

namespace TencentCloud.Chdfs.V20201112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Summary : AbstractModel
    {
        
        /// <summary>
        /// Capacity usage in bytes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CapacityUsed")]
        public ulong? CapacityUsed{ get; set; }

        /// <summary>
        /// COS STANDARD storage usage in bytes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StandardCapacityUsed")]
        public ulong? StandardCapacityUsed{ get; set; }

        /// <summary>
        /// COS STANDARD_IA storage usage in bytes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DegradeCapacityUsed")]
        public ulong? DegradeCapacityUsed{ get; set; }

        /// <summary>
        /// COS ARCHIVE storage usage in bytes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ArchiveCapacityUsed")]
        public ulong? ArchiveCapacityUsed{ get; set; }

        /// <summary>
        /// COS DEEP ARCHIVE storage usage in bytes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeepArchiveCapacityUsed")]
        public ulong? DeepArchiveCapacityUsed{ get; set; }

        /// <summary>
        /// COS INTELLIGENT TIERING storage usage in bytes
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntelligentCapacityUsed")]
        public ulong? IntelligentCapacityUsed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CapacityUsed", this.CapacityUsed);
            this.SetParamSimple(map, prefix + "StandardCapacityUsed", this.StandardCapacityUsed);
            this.SetParamSimple(map, prefix + "DegradeCapacityUsed", this.DegradeCapacityUsed);
            this.SetParamSimple(map, prefix + "ArchiveCapacityUsed", this.ArchiveCapacityUsed);
            this.SetParamSimple(map, prefix + "DeepArchiveCapacityUsed", this.DeepArchiveCapacityUsed);
            this.SetParamSimple(map, prefix + "IntelligentCapacityUsed", this.IntelligentCapacityUsed);
        }
    }
}

