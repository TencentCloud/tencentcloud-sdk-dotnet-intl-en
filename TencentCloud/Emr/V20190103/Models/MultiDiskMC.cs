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

    public class MultiDiskMC : AbstractModel
    {
        
        /// <summary>
        /// Number of cloud disks of this type.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Disk type.
        /// 1: Local Disk.
        /// 2: Cloud Disk.
        /// 3: Local SSD.
        /// 4: Cloud SSD.
        /// 5: Premium Cloud Disk.
        /// 6: Enhanced SSD.
        /// 11: Throughput HDD.
        /// 12: Tremendous SSD.
        /// 13: Balanced SSD.
        /// 14: Big Data Cloud Disk.
        /// 15: High IO Cloud Disk.
        /// 16: Remote SSD.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Disk size.
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// Cloud disk size (bytes).
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
        }
    }
}

