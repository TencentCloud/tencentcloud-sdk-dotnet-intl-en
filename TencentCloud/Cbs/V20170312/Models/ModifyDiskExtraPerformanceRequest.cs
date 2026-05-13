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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDiskExtraPerformanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the hard disk performance of the additional CBS purchase in MiB/s.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// The CLOUD disk ID for which extra performance needs to be purchased. it can be queried via the [DescribeDisks](https://www.tencentcloud.com/document/product/362/16315?from_cn_redirect=1) api. extra performance is only supported for enhanced SSD (CLOUD_HSSD) and ultra-fast SSD (CLOUD_TSSD) CBS disks exceeding 460GiB in size.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
        }
    }
}

