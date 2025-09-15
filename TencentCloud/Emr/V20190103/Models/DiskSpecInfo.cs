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

    public class DiskSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// Number of disks.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Valid values of the system disk type:
        /// <li>CLOUD_SSD: Cloud SSD.</li>
        /// <li>CLOUD_PREMIUM: Premium Cloud Disk.</li>
        /// <li>CLOUD_BASIC: Cloud Disk.</li>
        /// <li>LOCAL_BASIC: Local Disk.</li>
        /// <li>LOCAL_SSD: Local SSD.</li>
        /// 
        /// Valid values of the data disk type.
        /// <li>CLOUD_SSD: Cloud SSD.</li>
        /// <li>CLOUD_PREMIUM: Premium Cloud Disk.</li>
        /// <li>CLOUD_BASIC: Cloud Disk.</li>
        /// <li>LOCAL_BASIC: Local Disk.</li>
        /// <li>LOCAL_SSD: Local SSD.</li>
        /// <li>CLOUD_HSSD: Enhanced SSD.</li>
        /// <li>CLOUD_THROUGHPUT: Throughput HDD.</li>
        /// <li>CLOUD_TSSD: Tremendous SSD.</li>
        /// <li>CLOUD_BIGDATA: Big Data Cloud Disk.</li>
        /// <li>CLOUD_HIGHIO: High IO Cloud Disk.</li>
        /// <li>CLOUD_BSSD: Balanced SSD.</li>
        /// <li>REMOTE_SSD: Remote SSD.</li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Data capacity in GB.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Additional performance.
        /// </summary>
        [JsonProperty("ExtraPerformance")]
        public long? ExtraPerformance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "ExtraPerformance", this.ExtraPerformance);
        }
    }
}

