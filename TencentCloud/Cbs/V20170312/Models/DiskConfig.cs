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

    public class DiskConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether the configuration is available.
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// Payment mode. valid values: <br><li>PREPAID: PREPAID, i.e. monthly subscription</li><br><li>POSTPAID_BY_HOUR: POSTPAID, i.e. pay-as-you-go.</li>.
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// The [Availability Region](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#ZoneInfo) of the cloud drive.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Instance model series. For more information, please see [Instance Models](https://intl.cloud.tencent.com/document/product/213/11518?from_cn_redirect=1)
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// Cloud disk media type. valid values: <br>.
        /// CLOUD_BASIC: specifies the BASIC CLOUD disk.
        /// CLOUD_PREMIUM: indicates high-performance CLOUD block storage.
        /// CLOUD_BSSD: indicates a universal type SSD CLOUD disk.
        /// CLOUD_SSD: indicates SSD CLOUD disk.
        /// CLOUD_HSSD: indicates the enhanced SSD CLOUD disk.
        /// CLOUD_TSSD: indicates ultra-fast ssd cbs.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Specifies the minimum step size for disk size change in GiB.
        /// </summary>
        [JsonProperty("StepSize")]
        public ulong? StepSize{ get; set; }

        /// <summary>
        /// Additional performance range.
        /// Note: This field might return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtraPerformanceRange")]
        public long?[] ExtraPerformanceRange{ get; set; }

        /// <summary>
        /// Instance model.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DeviceClass")]
        public string DeviceClass{ get; set; }

        /// <summary>
        /// Cloud DISK type. valid values:<br><li>SYSTEM_DISK: SYSTEM DISK</li><br><li>DATA_DISK: DATA DISK.</li>.
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// Specifies the minimum configurable cloud disk size in GiB.
        /// </summary>
        [JsonProperty("MinDiskSize")]
        public ulong? MinDiskSize{ get; set; }

        /// <summary>
        /// Specifies the maximum configurable cloud disk size in GiB.
        /// </summary>
        [JsonProperty("MaxDiskSize")]
        public ulong? MaxDiskSize{ get; set; }

        /// <summary>
        /// Price of a prepaid or postpaid cloud disk.
        /// </summary>
        [JsonProperty("Price")]
        public Price Price{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "DiskChargeType", this.DiskChargeType);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "StepSize", this.StepSize);
            this.SetParamArraySimple(map, prefix + "ExtraPerformanceRange.", this.ExtraPerformanceRange);
            this.SetParamSimple(map, prefix + "DeviceClass", this.DeviceClass);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "MinDiskSize", this.MinDiskSize);
            this.SetParamSimple(map, prefix + "MaxDiskSize", this.MaxDiskSize);
            this.SetParamObj(map, prefix + "Price.", this.Price);
        }
    }
}

