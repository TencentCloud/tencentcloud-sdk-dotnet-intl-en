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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StorageStatData : AbstractModel
    {
        
        /// <summary>
        /// VOD storage billing region. Valid values:
        /// <li>Chinese Mainland</li>
        /// <li>Outside Chinese Mainland</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Current total storage capacity in bytes.
        /// </summary>
        [JsonProperty("TotalStorage")]
        public ulong? TotalStorage{ get; set; }

        /// <summary>
        /// Current STANDARD_IA storage capacity in bytes.
        /// </summary>
        [JsonProperty("InfrequentStorage")]
        public ulong? InfrequentStorage{ get; set; }

        /// <summary>
        /// Current STANDARD storage capacity in bytes.
        /// </summary>
        [JsonProperty("StandardStorage")]
        public ulong? StandardStorage{ get; set; }

        /// <summary>
        /// Current ARCHIVE storage usage in bytes
        /// </summary>
        [JsonProperty("ArchiveStorage")]
        public ulong? ArchiveStorage{ get; set; }

        /// <summary>
        /// Current DEEP ARCHIVE storage usage in bytes
        /// </summary>
        [JsonProperty("DeepArchiveStorage")]
        public ulong? DeepArchiveStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "TotalStorage", this.TotalStorage);
            this.SetParamSimple(map, prefix + "InfrequentStorage", this.InfrequentStorage);
            this.SetParamSimple(map, prefix + "StandardStorage", this.StandardStorage);
            this.SetParamSimple(map, prefix + "ArchiveStorage", this.ArchiveStorage);
            this.SetParamSimple(map, prefix + "DeepArchiveStorage", this.DeepArchiveStorage);
        }
    }
}

