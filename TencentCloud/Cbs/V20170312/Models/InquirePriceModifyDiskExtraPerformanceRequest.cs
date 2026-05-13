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

    public class InquirePriceModifyDiskExtraPerformanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the additional performance value of the CBS disk in MiB/s. extra performance is only supported for enhanced SSD (CLOUD_HSSD) and ultra-fast SSD (CLOUD_TSSD) CBS disks exceeding 460GiB in size.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// Cloud disk ID, which can be queried via the [DescribeDisks](https://intl.cloud.tencent.com/document/product/362/16315?from_cn_redirect=1) API.
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

