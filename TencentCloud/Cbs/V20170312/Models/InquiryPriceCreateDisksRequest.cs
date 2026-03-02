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

    public class InquiryPriceCreateDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// Cloud disk billing mode. <br>
        /// <li>PREPAID: Prepaid by month.</li>
        /// <li>POSTPAID_BY_HOUR: Hourly pay-as-you-go.</li>
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// Hard disk media type. valid values: <ul> <li>CLOUD_PREMIUM: high-performance CLOUD block storage</li> <li>CLOUD_SSD: SSD CLOUD disk</li> <li>CLOUD_HSSD: enhanced SSD CLOUD disk</li> <li>CLOUD_TSSD: ultra-fast SSD cbs</li> </ul>.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Specifies the disk capacity in GiB. for the cloud disk size range, please refer to the product type of cloud block storage (https://www.tencentcloud.com/document/product/362/2353?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// cloud disk project ID. obtain this parameter by calling the projectId field in the return value of [DescribeProject](https://www.tencentcloud.comom/document/api/651/78725?from_cn_redirect=1). default to the default project.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Specifies the number of cloud block storage (cbs) disks to purchase. defaults to 1 if left blank.
        /// </summary>
        [JsonProperty("DiskCount")]
        public ulong? DiskCount{ get; set; }

        /// <summary>
        /// Specifies the additional performance value of the CBS disk in MiB/s. extra performance is only supported for enhanced SSD (CLOUD_HSSD) and ultra-fast SSD (CLOUD_TSSD) CBS disks exceeding 460GiB in size.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// Prepaid mode, that is, the settings for the monthly subscription-related parameters. through this parameter, you can specify the purchase duration of the monthly subscribed cloud disk, whether to enable auto-renewal, and other attributes. this parameter is required for creating a prepaid cloud disk, but no need to specify it when creating an hourly postpaid cloud disk.
        /// </summary>
        [JsonProperty("DiskChargePrepaid")]
        public DiskChargePrepaid DiskChargePrepaid{ get; set; }

        /// <summary>
        /// Specifies the cloud disk backup point quota.
        /// </summary>
        [JsonProperty("DiskBackupQuota")]
        public ulong? DiskBackupQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskChargeType", this.DiskChargeType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
            this.SetParamObj(map, prefix + "DiskChargePrepaid.", this.DiskChargePrepaid);
            this.SetParamSimple(map, prefix + "DiskBackupQuota", this.DiskBackupQuota);
        }
    }
}

